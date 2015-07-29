using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bind.Structures
{
    #region class Struct

    class Struct
    {
        string _name;
        bool _isUnion;

        public Struct(bool isUnion)
        {
            _isUnion = isUnion;
        }

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public bool IsUnion
        {
            get { return _isUnion; }
        }

        ParameterCollection _members_collection = new ParameterCollection();

        public ParameterCollection Members
        {
            get { return _members_collection; }
        }

        // Use only for debugging, not for code generation.
        public override string ToString()
        {
            return String.Format("struct {0}", Name);
        }

        public void Add(Parameter member)
        {
            Members.Add(member);
        }

        public bool CLSCompliant
        {
            get
            {
                return Members.All(p => p.Type.CLSCompliant);
            }
        }
    }

    #endregion

    #region class StructCollection

    class StructCollection : IDictionary<string, Struct>
    {
        SortedDictionary<string, Struct> Structs = new SortedDictionary<string, Struct>();

        #region Public Members

        public void Add(Struct e)
        {
            Add(e.Name, e);
        }

        public void AddRange(StructCollection structs)
        {
            foreach (Struct e in structs.Values)
            {
                Add(e);
            }
        }

        #endregion

        #region IDictionary<string, Struct> Members

        public void Add(string key, Struct value)
        {
            Structs.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return Structs.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return Structs.Keys; }
        }

        public bool Remove(string key)
        {
            return Structs.Remove(key);
        }

        public bool TryGetValue(string key, out Struct value)
        {
            return Structs.TryGetValue(key, out value);
        }

        public ICollection<Struct> Values
        {
            get { return Structs.Values; }
        }

        public Struct this[string key]
        {
            get
            {
                return Structs[key];
            }
            set
            {
                Structs[key] = value;
            }
        }

        public void Add(KeyValuePair<string, Struct> item)
        {
            Structs.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            Structs.Clear();
        }

        public bool Contains(KeyValuePair<string, Struct> item)
        {
            return Structs.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, Struct>[] array, int arrayIndex)
        {
            Structs.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Structs.Count; }
        }

        public bool IsReadOnly
        {
            get { return (Structs as IDictionary<string, Struct>).IsReadOnly; }
        }

        public bool Remove(KeyValuePair<string, Struct> item)
        {
            return Structs.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<string, Struct>> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        #endregion
    }

    #endregion
}
