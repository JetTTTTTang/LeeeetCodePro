using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashSet hashSet = new MyHashSet();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Contains(1);    // 返回 true
            hashSet.Contains(3);    // 返回 false (未找到)
            hashSet.Add(2);
            hashSet.Contains(2);    // 返回 true
            hashSet.Remove(2);
            hashSet.Contains(2);    // 返回  false (已经被删除)
        }
    }

    public class MyHashSet
    {
        private List<int> hashSet;
        public MyHashSet()
        {
            hashSet = new List<int>();
        }

        public void Add(int key)
        {
            if (hashSet.Contains(key))
            {
                return;
            }
            hashSet.Add(key);
        }

        public void Remove(int key)
        {
            hashSet.Remove(key);
        }

        public bool Contains(int key)
        {
            return hashSet.Contains(key);
        }
    }
}