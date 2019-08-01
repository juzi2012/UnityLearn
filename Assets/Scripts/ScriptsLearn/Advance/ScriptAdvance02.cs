using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* AUTHER:WT
* DESCRIPTION:
* 泛型的相关学习
*/
namespace Assets.Scripts.ScriptsLearn.Advance
{
    class ScriptAdvance02
    {
        //字段

        //属性

        //构造函数
        public ScriptAdvance02()
        {
            Person<string> p = new Person<string>();
            p.a = "afsdfasdfas";
            p.GetResult<int>();
            p.GetResult1<string>("aa");
            p.GetResult1("bb");
        }
        //方法
    }
    class Person<T>
    {
        public T a;
        public void GetResult<M>()
        {
            
        }
        //如果泛型在参数中使用，调用方法的时候，可以不给M赋值
        public void GetResult1<M>(M a)
        {

        }

        public N GetResult2<N>(N b)
        {
            return b;
        }
    }
}
