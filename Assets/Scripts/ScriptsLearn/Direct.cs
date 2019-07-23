using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ScriptsLearn
{
    struct Direct
    {
        private int Age;
        public int MyProperty { get; set; }
        public Direct(int age)
        {
            this.Age = 10;
            this.MyProperty = 10;
            Debug.Log(this.Age);
        }

    }
}
