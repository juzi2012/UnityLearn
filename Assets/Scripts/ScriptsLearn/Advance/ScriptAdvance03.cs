using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* AUTHER:WT
* DESCRIPTION:
* 各种容器 array 字典 集合等等对比
* ArrayList 可以存任何数据
* List 只能存指定类型的数据
* HashSet 相当于没有value的Dic
* 
*/
namespace Assets.Scripts.ScriptsLearn.Advance
{
    class ScriptAdvance03
    {
        //字段

        //属性

        //构造函数
        public ScriptAdvance03()
        {
            //可以添加任何元素
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Remove(1);

            //批量添加多个元素
            arrayList.AddRange(new int[] { 1, 2, 3 });

            arrayList.RemoveRange(0, 2);

            arrayList.Add(new Person(40));
            arrayList.Add(new Person(12));
            arrayList.Add(new Person(14));
            arrayList.Add(new Person(4));
            arrayList.Add(new Person(30));
            arrayList.Sort();

            List<string> list = new List<string>();
            list.Add("A");
            list.Add("b");
            list.Add("V");
            list.AddRange(new string[] { "c","d","c","ad","c"});

            //list的删除要传一个委托方法，来处理删除的内容的逻辑
            list.RemoveAll(Method);
            //简单的也可以直接用lamda函数来替代
            list.RemoveAll((a) => a == "b");

            list.Find((a) => a == "b");
            list.Exists((a) => a == "b");

            //多个的时候，hashset比list要快
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
        }
        public bool Method(string value)
        {
            return value == "c";
        }
        //方法
    }
    class Person : IComparable,IComparable<Person>
    {
        public int Age;
        public Person(int age)
        {
            this.Age = age;
        }
        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person anotherPerson = obj as Person;
                return this.Age - anotherPerson.Age;
            }
            return 0;
        }

        public int CompareTo(Person other)
        {
            return this.Age - other.Age;
        }
    }
}
