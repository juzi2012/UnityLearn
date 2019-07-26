using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class ParticleLearn : MonoBehaviour 
{
    //字段
    private ParticleSystem ps;
    //方法
    private void Start()
    {
        ps = this.GetComponent<ParticleSystem>();
    }
}
