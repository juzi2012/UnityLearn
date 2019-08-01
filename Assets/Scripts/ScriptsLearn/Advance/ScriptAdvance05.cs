using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Reflection;

/*
* AUTHER:WT
* DESCRIPTION:
* 反射 reflact
*/
namespace Assets.Scripts.ScriptsLearn.Advance
{
    class ScriptAdvance05
    {
        //字段

        //属性

        //构造函数
        public ScriptAdvance05()
        {
            Type t = Type.GetType("Assets.Scripts.ScriptsLearn.Advance.Hero");
            System.Object obj = Activator.CreateInstance(t);

            //哪怕构造函数不是public，可以反射出来
            System.Object obj1 = Activator.CreateInstance(t,true);

            //带参数的public构造函数
            System.Object obj2 = Activator.CreateInstance(t,"asdf");
            //带参数的非public的构造函数反射
            System.Object obj3 = Activator.CreateInstance(t, BindingFlags.NonPublic|BindingFlags.Instance,null,new object[] {12},null);
            Debug.Log(obj3);


            //通过反射访问类中的字段

            //访问public 非静态
            FieldInfo a = t.GetField("a");
            a.SetValue(obj3, 1);
            object a1 = a.GetValue(obj3);
            Debug.Log(a1);
            //访问非public 非静态
            FieldInfo b = t.GetField("b", BindingFlags.NonPublic | BindingFlags.Instance);
            b.SetValue(obj3, 2);
            object b1 = b.GetValue(obj3);
            Debug.Log(b1);
            //访问public 静态
            FieldInfo c = t.GetField("c", BindingFlags.Public | BindingFlags.Static);
            c.SetValue(null, 3);
            object c1 = c.GetValue(null);
            Debug.Log(c1);
            //访问非public 静态
            FieldInfo d = t.GetField("d", BindingFlags.NonPublic | BindingFlags.Static);
            d.SetValue(null, 4);
            object d1 = d.GetValue(null);
            Debug.Log(d1);

            //通过反射访问类中的方法
            //没有参数的方法
            MethodInfo m1 = t.GetMethod("GetB", BindingFlags.NonPublic | BindingFlags.Instance);
            m1.Invoke(obj3, null);
            //有参数的方法
            MethodInfo m2 = t.GetMethod("GetB", BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(int) }, null);
            object result = m2.Invoke(obj3, new object[] { 222 });
            Debug.Log(result);
            //有参数的静态方法
            MethodInfo m3 = t.GetMethod("GetD", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { typeof(int) }, null);
            object result1 = m2.Invoke(obj3, new object[] { 2221 });
            Debug.Log(result1);
        }
        //方法
    }
}
