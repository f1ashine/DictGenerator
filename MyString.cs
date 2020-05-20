using System;
using System.Collections.Generic;

namespace DictGenerator
{
    class MyString
    {
        private string _Id = "1";
        public String value = "";
        public int index = 0;
        public List<Int32> indexList = new List<Int32>();
        public MyString(String v)
        {
            this.value = v;
        }

        public MyString(String v, int index)
        {
            this.value = v;
            this.index = index;
            this.indexList.Add(index);
        }

        public void setIndex(int index)
        {
            this.index = index;
            this.indexList.Add(index);
        }

        public void addIndex(int index)
        {
            this.indexList.Add(index);
        }

        public static MyString operator +(MyString a, MyString b)
        {
            if (!a.indexList.Contains(b.index))
            {
                MyString obj = new MyString(a.value + b.value);
                obj.indexList.Add(a.index);
                obj.indexList.Add(b.index);
                return obj;
            }
            else
            {
                return null;
            }
        }
        public override bool Equals(object o)
        {
            if (ReferenceEquals(null, o)) return false;
            if (ReferenceEquals(this, o)) return true;
            if (o.GetType() != this.GetType()) return false;
            else
                return this.Equals((MyString)o);
        }

        public bool Equals(MyString m)
        {
            return this.index == m.index && this.value == m.value;
        }
        public static bool operator ==(MyString a, MyString b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            else 
                return ReferenceEquals(a, null) || ReferenceEquals(b, null) ? false : a.Equals(b);
        }

        public static bool operator !=(MyString a, MyString b)
        {
            return !(a==b);
        }

        public override int GetHashCode()
        {
            return (_Id != null ? StringComparer.InvariantCulture.GetHashCode(_Id) : 0);
        }

        public override String ToString()
        {
            return this.value;
        }

        /// <summary>
        /// 获取从list中取出元素与res中的元素组合，且该组合无重复元素的集合
        /// </summary>
        /// <param name="list"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public static List<MyString> getResult(List<MyString> list, List<MyString> res)
        {
            List<MyString> result = new List<MyString>();
            foreach (MyString i in list)
            {
                foreach (MyString j in res)
                {
                    MyString k = j + i;
                    if (k != null)
                    {
                        result.Add(k);
                    }
                }
            }
            return result;
        }
    }
}
