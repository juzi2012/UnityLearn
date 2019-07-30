using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class GUPInstanceLearn : MonoBehaviour 
{
    //字段
    private MeshRenderer[] meshRenders;
    private MaterialPropertyBlock props;
    //方法
    private void Start()
    {
        meshRenders = GameObject.FindObjectsOfType<MeshRenderer>();
    }
    private void OnGUI()
    {
        if (GUILayout.Button("修改颜色"))
        {
            foreach (MeshRenderer item in meshRenders)
            {
                float r = Random.Range(0.0f, 1.0f);
                float g = Random.Range(0.0f, 1.0f);
                float b = Random.Range(0.0f, 1.0f);
                props = new MaterialPropertyBlock();
                props.SetColor("_Color", new Color(r, g, b));
                item.SetPropertyBlock(props);
            }
        }
    }
}
