using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class ComponentLearn : MonoBehaviour 
{
    //字段

    //方法
    private void OnGUI()
    {
        if (GUILayout.Button("按钮"))
        {
            Vector3 pos = this.transform.position;
            pos.x += 1;
            this.transform.position = pos;
        }
    }
}
