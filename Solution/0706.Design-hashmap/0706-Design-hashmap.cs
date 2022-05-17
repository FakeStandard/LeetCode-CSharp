using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0706.Design_hashmap
{
    public class _0706_Design_hashmap
    {
        public class MyHashMap
        {
            List<MyTuple> tuple;

            public MyHashMap()
            {
                tuple = new List<MyTuple>();
            }

            public void Put(int key, int value)
            {
                var obj = Contains(key);

                if (obj == null)
                {
                    tuple.Add(new MyTuple(key, value));
                    return;
                }

                obj.value = value;
            }

            public int Get(int key)
            {
                var obj = Contains(key);

                return obj == null ? -1 : obj.value;
            }

            public void Remove(int key)
            {
                var obj = Contains(key);

                if (obj != null) tuple.Remove(obj);
            }

            private MyTuple Contains(int key)
            {
                return tuple.Find(r => r.key == key);
            }
        }

        public class MyTuple
        {
            public int key;
            public int value;
            public MyTuple(int k, int v)
            {
                key = k;
                value = v;
            }
        }
    }
}
