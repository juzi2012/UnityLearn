using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class TimeScript : MonoBehaviour 
{
    //字段
    private void Awake()
    {
        
    }
    private void Start()
    {

    }
    private void OnGUI()
    {
        if(GUILayout.Button("jump"))
        {
            Time.timeScale = 0.2f;
        }
    }
    private void Update()
    {
        
    }
    //方法
}
