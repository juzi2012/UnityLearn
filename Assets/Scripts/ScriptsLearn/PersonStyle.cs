using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.ScriptsLearn
{
    /// <summary>
    /// 如果枚举能够多选，必须满足两个条件，1 每个值都是2的n次方，2 前面加[Flag]标签
    /// </summary>
    [Flags]
    enum PersonStyle
    {
        High = 1,
        Small = 2,
        Builty = 4,
        Rich = 8,
        Good = 16,
    }
}
