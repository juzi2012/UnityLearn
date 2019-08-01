using Assets.Scripts.ScriptsLearn.Advance;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
* lamda 委托delegate(就是一个方法的类型)
*/
delegate void SkillDelegate(int a);
delegate int SkillDelegate1(int a);
public class ScriptAdvance01 : MonoBehaviour
{
    //字段
    //方法
    private void Start()
    {
        DoLamda();
    }
    void DoLamda()
    {
        //(x, y) => { return x + y};
        //a指向了要给方法TestMethon
        //TestDelegate a = new TestDelegate(TestMethon);
        //a(11);

        Hero hero1 = new Hero();
        hero1.q = SkillPool.Dabaojian;

        Hero hero2 = new Hero();
        hero2.q = SkillPool.Naochanpi;

        hero1.q(1);
        hero2.q(2);

        Hero hero3 = new Hero();
        hero3.q1 = (int x) => {
            return x;
        };
        //参数类型可以省略，如果只有一个返回值，则return也可以省略
        hero3.q1 = (x) => x + 9;
    }
    void TestMethon(int value)
    {
        Debug.Log(value);
    }
}


