using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<int, string> myDictionaryList = new MyDictionaryList<int, string>();
           
            myDictionaryList.Add(1, "Subaru");
            myDictionaryList.Add(2, "Toyota");
            myDictionaryList.Add(3, "Nissan");
            myDictionaryList.Add(4, "Honda");
            myDictionaryList.Add(5, "Yamaha");

            myDictionaryList.Check();
        }
    }
    class MyDictionaryList<Key, Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionaryList()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key1, Value value1)
        {
            Key[] _tempKey = keys;
            Value[] _tempValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                keys[i] = _tempKey[i];
                values[i] = _tempValue[i];
            }

            keys[keys.Length - 1] = key1;
            values[values.Length - 1] = value1;
        }

        public void Check()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);
            }
        }
    }
}