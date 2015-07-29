using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bind.Structures
{
    #region class Member

    class Member : IComparable<Member>, IEquatable<Member>
    {
        readonly string _name;
        readonly Type _type;

        public Member(string name, Type type)
        {
            _name = name;
            _type = type;
        }

        public Member(Member m)
        {
            _name = m.Name;
            _type = new Type(m.Type);
        }

        public string Name { get { return _name; } }
        public Type Type { get { return _type; } }

        public int CompareTo(Member other)
        {
            int result = Type.CompareTo(other.Type);
            if (result == 0)
                result = Name.CompareTo(other.Name);
            return result;
        }

        public bool Equals(Member other)
        {
            bool result =
                Type.Equals(other.Type) &&
                Name.Equals(other.Name);

            return result;
        }
    }

    #endregion

    #region class MemberCollection

    class MemberCollection : IList<Member>, IComparable<MemberCollection>, IEquatable<MemberCollection>
    {
        readonly List<Member> _list = new List<Member>();

        public MemberCollection()
        {
        }

        public MemberCollection(MemberCollection pc)
        {
            foreach (Member m in pc)
            {
                Add(new Member(m));
            }
        }

        public MemberCollection(IEnumerable<Member> parameters)
        {
            foreach (Member m in parameters)
                Add(new Member(m));
        }

        #region IList<Member> Members

        public int IndexOf(Member item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Member item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public Member this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        public void Add(Member item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Member item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Member[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Member item)
        {
            return _list.Remove(item);
        }

        public IEnumerator<Member> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (_list as System.Collections.IEnumerable).GetEnumerator();
        }

        #endregion 

        #region IComparable<MemberCollection> Members

        public int CompareTo(MemberCollection other)
        {
            if (Count < other.Count)
            {
                return -1;
            }
            else if (Count > other.Count)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    int result = this[i].CompareTo(other[i]);
                    if (result != 0)
                        return result;
                }
                return 0;
            }
        }

        #endregion

        #region IEquatable<MemberCollection> Members

        public bool Equals(MemberCollection other)
        {
            if (Count != other.Count)
                return false;

            bool result = true;
            for (int i = 0; i < Count && result; i++)
            {
                result &= this[i].Equals(other[i]);
            }
            return result;
        }

        #endregion
    }

    #endregion
}
