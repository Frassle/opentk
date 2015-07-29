#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Bind.Structures;
using Delegate = Bind.Structures.Delegate;

namespace Bind
{
    using Enum = Bind.Structures.Enum;
    using Type = Bind.Structures.Type;

    class StructProcessor
    {
        readonly IEnumerable<string> Overrides;

        IBind Generator { get; set; }
        Settings Settings { get { return Generator.Settings; } }

        public StructProcessor(IBind generator, IEnumerable<string> overrides)
        {
            if (generator == null)
                throw new ArgumentNullException("generator");
            if (overrides == null)
                throw new ArgumentNullException("overrides");

            Generator = generator;
            Overrides = overrides;
        }

        public StructCollection Process(EnumProcessor enum_processor, DocProcessor doc_processor,
            StructCollection structs, EnumCollection enums, string apiname, string apiversion)
        {
            // Translate each delegate:
            // 1st using the <replace> elements in overrides.xml
            // 2nd using the hardcoded rules in FuncProcessor (e.g. char* -> string)
            foreach (var s in structs.Values)
            {
                TranslateMembers(s, enum_processor, enums, apiname);
            }

            return structs;
        }

        private void TranslateMembers(Struct s, EnumProcessor enum_processor, EnumCollection enums, string apiname)
        {
            foreach (var member in s.Members)
            {
                TranslateType(member.Type, enum_processor, enums, apiname);
            }
        }

        private void TranslateType(Type type, EnumProcessor enum_processor, EnumCollection enums, string apiname)
        {
            // Remove const
            var constRegex = new Regex(@"\bconst\b");
            type.CurrentType = constRegex.Replace(type.CurrentType, "");

            type.CurrentType =
                Generator.CSTypes.ContainsKey(type.CurrentType) ?
                Generator.CSTypes[type.CurrentType] : type.CurrentType;
        }
    }
}
