using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ScriptsLearn
{
    class Wife
    {
        string name;
        int age;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        //一般用这个方法
        public int Sex { get; set; }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        //porp tab 会自动生成属性
        public int Friend { get; set; }
        public Wife()
        {
            Debug.Log("构造函数开始");
        }
        public Wife(string name):this()
        {
            this.name = name;
        }
        public Wife(string name ,int age):this(name)
        {
            this.age = age;
        }

    }
}
