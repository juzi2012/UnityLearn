using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class UnityMath : MonoBehaviour 
{
    //字段
    public Camera camera;
    private bool state = false;
    private int targetFOV=60;
    [SerializeField]
    private float speed = 1;
    private void Start()
    {
        this.camera = this.GetComponent<Camera>();
    }

    //方法
    private void Update()
    {
        //if (Input.GetMouseButtonDown(1) == true)
        //{
        //    state = !state;
        //    if (state==true)
        //    {
        //        targetFOV = 20;
        //    }
        //    else
        //    {
        //        targetFOV = 60;
        //    }
        //}
        
        //this.camera.fieldOfView = Mathf.Lerp(this.camera.fieldOfView, targetFOV, 0.1f);

        //float mousex = Input.GetAxis("Mouse X");
        //float mousey = Input.GetAxis("Mouse Y");
        //this.camera.transform.Rotate(0, mousex*Time.deltaTime* speed, 0,Space.World);
        //this.camera.transform.Rotate(mousey * Time.deltaTime* speed, 0, 0);
    }

}
