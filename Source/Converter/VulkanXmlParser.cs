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
            var input = XDocument.Parse(String.Join(" ", lines));

            var vulkan = new XElement("api",
                new XAttribute("name", "vulkan"),
                String.IsNullOrEmpty(Version) ? null : new XAttribute("version", Version));

            foreach (var e in ParseEnums(input).Concat(
                ParseTypes(input)).Concat(
                ParseStructs(input)).Concat(
                ParseFunctions(input)))
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

        private IEnumerable<XElement> ParseTypes(XDocument input)
        {
            if (false)
            {
                yield return null;
            }
        }

        private IEnumerable<XElement> ParseStructs(XDocument input)
        {
            if (false)
            {
                yield return null;
            }
        }

        private IEnumerable<XElement> ParseFunctions(XDocument input)
        {
            if (false)
            {
                yield return null;
            }
        }
    }
}
