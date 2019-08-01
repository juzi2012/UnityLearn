using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/*
* AUTHER:WT
* DESCRIPTION:
*/
namespace Assets.Scripts.ScriptsLearn.Advance
{
    class Hero
    {
        //字段
        public SkillDelegate q;
        public SkillDelegate1 q1;

        public int a;
        private int b;
        public static int c;
        private static int d;
        //属性


        //构造函数
        public Hero()
        {
            Debug.Log("hhahhah ");
        }
        public Hero(string name)
        {
            Debug.Log(name);
        }
        private Hero(int age)
        {
            Debug.Log(age.ToString());
        }

        //方法
        public void GetA()
        {
            Debug.Log(this.a);
        }
        private void GetB()
        {
            Debug.Log(this.b);
        }
        public static void GetC()
        {
            Debug.Log(c);
        }
        private static void GetD()
        {
            Debug.Log(d);
        }
        public int GetB(int value)
        {
            return value;
        }
        private static int GetD(int value)
        {
            return value;
        }
    }
}
