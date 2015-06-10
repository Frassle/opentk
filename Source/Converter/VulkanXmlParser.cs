using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace OpenTK.Convert
{
    class VulkanXmlParser : Parser
    {
        public override IEnumerable<XElement> Parse(string[] lines)
        {
            var input = XDocument.Parse(String.Join(" ", lines), LoadOptions.PreserveWhitespace);

            var vulkan = new XElement("api",
                new XAttribute("name", "vulkan"),
                String.IsNullOrEmpty(Version) ? null : new XAttribute("version", Version));

            foreach (var e in ParseEnums(input).Concat(
                ParseTypes(input)).Concat(
                ParseCommands(input)))
            {
                vulkan.Add(e);
            }

            yield return vulkan;
        }

        private IEnumerable<XElement> ParseEnums(XDocument input)
        {
            var enumerations = input.Root.Elements("enums");
            foreach (var enumeration in enumerations)
            {
                var enums = enumeration.Elements("enum");
                var name = enumeration.Attribute("name");
                if(name != null)
                {
                    var flags = enumeration.Attribute("type").Value == "bitmask";

                    var tkenum = new XElement(
                        "enum",
                        new XAttribute("name", TrimName(name.Value)),
                        new XAttribute("flags", flags));

                    foreach(var @enum in enums)
                    {
                        string value;
                        if (@enum.Attribute("value") != null)
                        {
                            value = @enum.Attribute("value").Value;
                        }
                        else if (@enum.Attribute("bitpos") != null)
                        {
                            var bitpos = @enum.Attribute("bitpos").Value;
                            value = "0x" + (1 << int.Parse(bitpos)).ToString("X");
                        }
                        else
                        {
                            throw new NotImplementedException(string.Format("Unrecognized attribute type {0}", @enum));
                        }

                        tkenum.Add(new XElement("token",
                            new XAttribute("name", TrimName(@enum.Attribute("name").Value)),
                            new XAttribute("value", value)));
                    }

                    yield return tkenum;
                }
            }
        }

        private string ParseType(XElement type, out string name)
        {
            // Vulkan members are of the following general C format:
            // <member>CODE[<type>TYPENAME</type>]CODE <name>NAME</name>CODE</member>
            // Examples:
            // <member>const <type>char</type>* <name>values</name></member>
            // <member><type>char</type> <name>values[4]</name></member>
            // <member><type>char</type> <name>values</name>[<enum>VK_MAX_EXTENSION_NAME</enum>]</member>
            //
            // We want to translate this to an OpenTK suitable type declaration
            // TODO: For now we just copy the complete C declaration

            var nameNode = type.Element("name");
            name = null;

            var nameRegex = new System.Text.RegularExpressions.Regex(@"(?<name>[^\[\]]+)(?<array>\[[^\[\]]+\])?");

            string code = "";
            foreach (var node in type.Nodes())
            {
                if (node == nameNode)
                {
                    var match = nameRegex.Match(nameNode.Value);
                    name = TrimName(match.Groups["name"].Value);

                    code += match.Groups["array"].Value;
                }
                else if (node.NodeType == System.Xml.XmlNodeType.Whitespace ||
                        node.NodeType == System.Xml.XmlNodeType.SignificantWhitespace)
                {
                    code += " ";
                }
                else if (node.NodeType == System.Xml.XmlNodeType.Text)
                {
                    code += (node as XText).Value;
                }
                else if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    code += (node as XElement).Value;
                }
            }

            if (name == null)
            {
                throw new Exception("name should not be null");
            }

            code = code.Trim();
            code = code.Replace('\t', ' ');
            while (code.Contains("  "))
            {
                code = code.Replace("  ", " ");
            }
            return code;
        }

        private XElement ParseStruct(XElement structType)
        {
            var name = structType.Attribute("name");
            var union = structType.Attribute("category").Value == "union";

            var xstruct = new XElement("struct",
                new XAttribute("name", TrimName(name.Value)),
                new XAttribute("union", union));

            foreach (var member in structType.Elements("member"))
            {
                string memberName;
                var memberType = ParseType(member, out memberName);                

                xstruct.Add(new XElement("member",
                    new XAttribute("name", memberName),
                    new XAttribute("type", memberType)));
            }

            return xstruct;
        }

        private IEnumerable<XElement> ParseTypes(XDocument input)
        {
            var types = input.Root.Elements("types").Elements("type");
            foreach (var type in types)
            {
                var category = type.Attribute("category");

                if (category != null)
                {
                    if (category.Value == "struct" || category.Value == "union")
                    {
                        yield return ParseStruct(type);
                    }
                }
            }
        }

        private IEnumerable<XElement> ParseCommands(XDocument input)
        {
            var commands = input.Root.Elements("commands").Elements("command");

            foreach (var command in commands)
            {
                var proto = command.Element("proto");
                string protoName;
                var protoType = ParseType(proto, out protoName);

                var function = new XElement("function",
                    new XAttribute("name", protoName),
                    new XAttribute("extension", "vulkan"), // TODO: Should be worked out from feature element
                    new XElement("returns", new XAttribute("type", protoType)));

                foreach (var param in command.Elements("param"))
                {
                    string paramName;
                    var paramType = ParseType(param, out paramName);
                    function.Add(new XElement("param",
                        new XAttribute("name", paramName),
                        new XAttribute("type", paramType)));
                }

                yield return function;
            }
        }
    }
}
