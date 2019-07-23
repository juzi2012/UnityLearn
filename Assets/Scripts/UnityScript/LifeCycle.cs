using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class LifeCycle : MonoBehaviour 
{
    //字段
    [SerializeField]
    private int a;

    [HideInInspector]
    public int b;

    [Range(1,100)]
    public int c;


    //方法

    //游戏物体创建立即执行
    private void Awake()
    {
        Debug.Log("Awake--"+Time.time);
        this.enabled = true;
    }
    //脚本启用才执行,可以多次执行
    private void OnEnable()
    {
        Debug.Log("OnEnable--" + Time.time);
    }
    //在Awake后执行
    private void Start()
    {
        Debug.Log("Start--" + Time.time);
    }
    //固定更新 对游戏对象做物理操作
    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate--" + Time.time);
    }
    //更新游戏逻辑
    private void Update()
    {
        //Debug.Log("Update--" + Time.time);
    }
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate--" + Time.time);
    }
    //相机不可见的时候
    private void OnBecameInvisible()
    {
        
    }
    //相机可见的时候
    private void OnBecameVisible()
    {
        
    }
    private void OnDisable()
    {
        
    }
    private void OnDestroy()
    {
        
    }
    private void OnApplicationQuit()
    {
        
    }
}
