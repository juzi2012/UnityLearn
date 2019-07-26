using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
* 用之前学习的数学的知识来完成一个玩家移动的简单实例
*/
public class PlayerMoveByUnityMath : MonoBehaviour 
{
    //字段
    public float Horizontal;
    public float Vertical;
    //方法
    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Horizontal!=0 || Vertical!=0)
        {
            Quaternion rot = Quaternion.LookRotation(new Vector3(Horizontal, 0, Vertical));
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation,rot,0.1f);
            //这里不做动作切换，只做移动
            this.transform.Translate(0, 0, Time.deltaTime * 3);
        }
    }
}
