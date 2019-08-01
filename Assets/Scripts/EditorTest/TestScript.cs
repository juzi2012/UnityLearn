using Assets.Scripts.ScriptsLearn.Advance;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class TestScript : MonoBehaviour 
{
    //字段
    #region public variables
    public float sppedValue;
    public float heightValue;
    public float distanceValue;
    #endregion

    #region private variables

    #endregion
    //方法
    private void Start()
    {
        ScriptAdvance05 script5 = new ScriptAdvance05();
    }
}
