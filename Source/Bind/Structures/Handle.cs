using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bind.Structures
{
    #region class Handle

    class Handle
    {
        readonly string _name;
        readonly string _method;

        public Handle(string name, string method)
        {
            _name = name;
            _method = method;
        }

        public string Name
        {
            get { return _name ?? ""; }
        }

        public string Method
        {
            get { return _method; }
        }
    }

    #endregion

    #region class HandleCollection

    class HandleCollection : IDictionary<string, Handle>
    {
        SortedDictionary<string, Handle> Handles = new SortedDictionary<string, Handle>();

        #region Public Members

        public void Add(Handle e)
        {
            Add(e.Name, e);
        }

        public void AddRange(HandleCollection structs)
        {
            foreach (Handle e in structs.Values)
            {
                Add(e);
            }
        }

        #endregion

        #region IDictionary<string, Handle> Members

        public void Add(string key, Handle value)
        {
            Handles.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return Handles.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return Handles.Keys; }
        }

        public bool Remove(string key)
        {
            return Handles.Remove(key);
        }

        public bool TryGetValue(string key, out Handle value)
        {
            return Handles.TryGetValue(key, out value);
        }

        public ICollection<Handle> Values
        {
            get { return Handles.Values; }
        }

        public Handle this[string key]
        {
            get
            {
                return Handles[key];
            }
            set
            {
                Handles[key] = value;
            }
        }

        public void Add(KeyValuePair<string, Handle> item)
        {
            Handles.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            Handles.Clear();
        }

        public bool Contains(KeyValuePair<string, Handle> item)
        {
            return Handles.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, Handle>[] array, int arrayIndex)
        {
            Handles.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Handles.Count; }
        }

        public bool IsReadOnly
        {
            get { return (Handles as IDictionary<string, Handle>).IsReadOnly; }
        }

        public bool Remove(KeyValuePair<string, Handle> item)
        {
            return Handles.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<string, Handle>> GetEnumerator()
        {
            return Handles.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Handles.GetEnumerator();
        }

        #endregion
    }

    #endregion
}
