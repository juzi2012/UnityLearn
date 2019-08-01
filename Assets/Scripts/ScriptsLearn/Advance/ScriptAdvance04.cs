using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

/*
* AUTHER:WT
* DESCRIPTION:
* Stack Queue
* HashTable
* Dictionary 
*/
namespace Assets.Scripts.ScriptsLearn.Advance
{
    class ScriptAdvance04
    {
        //字段

        //属性

        //构造函数
        public ScriptAdvance04()
        {
            //栈是先进后出，
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            //队列是先进先出
            Queue queue = new Queue();
            //queue.

            //允许出现相同的值,按照key的哈希码进行排序，和添加的顺序无关
            Hashtable table = new Hashtable();
            table.Add("name", "Walt");
            table.Add("age", 12);
            foreach (DictionaryEntry item in table)
            {
                //item.Key;
                //item.Value;
            }

            //Dictionary

            Dictionary<int,string> dic = new Dictionary<int, string>();
            dic.Add(1, "adfa");
            dic.Remove(1);
            dic[1] = "fasdfas";

            foreach (KeyValuePair<int,string> item in dic)
            {
                //item.Key
                //item.Value
            }
            foreach (int key in dic.Keys)
            {
                //dic[key];
            }
        }
        //方法
    }
}
