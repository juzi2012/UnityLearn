using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
public class VectorDemo : MonoBehaviour
{
    //字段
    public GameObject a;
    public GameObject b;
    public float angle;
    public float angle1;
    public float angle2;
    public float angleFront = 120;
    public float dis = 3;
    public float angle3;
    //方法
    private void Update()
    {
        //DrawLine();
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Demo1();
        //}
        //Demo3();
        Demo4();
        //Demo5();
    }
    private void DrawLine()
    {
        Debug.DrawLine(Vector3.zero, this.transform.position);
        Vector2 a = new Vector2(this.transform.position.x, this.transform.position.y);
        float b = this.transform.position.magnitude;
        float c = Vector3.Distance(Vector3.zero, this.transform.position);
        Debug.Log(this.transform.position.normalized);
    }
    //向量运算
    private void Demo1()
    {
        float d2 = 10;
        float r1 = d2 * Mathf.Deg2Rad;
        Debug.Log(r1);
        float r2 = 0.33f;
        float d1 = r2 * Mathf.Rad2Deg;
        Debug.Log(d1);
    }
    /// <summary>
    /// 找出当前物体右前方30度，1米远的点,并画出线
    /// </summary>
    private void Demo2()
    {
        float dis = 10;
        float offsetx = Mathf.Sin(30 * Mathf.Deg2Rad) * dis;
        float offsetz = Mathf.Cos(30 * Mathf.Deg2Rad) * dis;
        Vector3 tarPos = this.transform.TransformPoint(offsetx, 0, offsetz);
        Debug.DrawLine(this.transform.position, tarPos);
    }
    /// <summary>
    /// 点乘叉乘
    /// </summary>
    private void Demo3()
    {
        //点乘一般用来计算夹角
        float result = Vector3.Dot(a.transform.position.normalized, b.transform.position.normalized);
        float result1 = Vector3.Dot(a.transform.position, b.transform.position) / (a.transform.position.magnitude * b.transform.position.magnitude);
        angle = Mathf.Acos(result) * Mathf.Rad2Deg;
        angle1 = Mathf.Acos(result1) * Mathf.Rad2Deg;
        Debug.DrawLine(Vector3.zero, a.transform.position);
        Debug.DrawLine(Vector3.zero, b.transform.position);

        //叉乘计算两个向量所形成的面的垂直向量
        Vector3 result2 = Vector3.Cross(a.transform.position.normalized, b.transform.position.normalized);
        angle2 = Mathf.Asin(result2.magnitude) * Mathf.Rad2Deg;
        Debug.DrawLine(Vector3.zero, result2);

    }
    /// <summary>
    /// 检查正前方120度范围内，3米以内的敌方
    /// </summary>
    private void Demo4()
    {
        Vector3 leftUp;
        Vector3 rightUp;
        Vector3 frontUp = new Vector3(this.transform.position.x, 0, this.transform.position.z) + new Vector3(0, 0, dis);

        //这里是通过三角函数算出来的左右角的位置
        //float xoffset = Mathf.Tan(angleFront / 2 * Mathf.Deg2Rad) * dis;
        //rightUp = Vector3.Normalize(new Vector3(xoffset, 0, dis)) * dis;
        //leftUp = Vector3.Normalize(new Vector3(-xoffset, 0, dis)) * dis;
        //rightUp = this.transform.TransformPoint(rightUp);
        //leftUp = this.transform.TransformPoint(leftUp);

        //其实有更方便的方法，直接用向量乘以四元数即可 - - 但是记住是左乘
        rightUp = Quaternion.Euler(0, angleFront / 2, 0) * new Vector3(0, 0, dis);
        leftUp = Quaternion.Euler(0, -angleFront / 2, 0) * new Vector3(0, 0, dis);
        rightUp = this.transform.TransformPoint(rightUp);
        leftUp = this.transform.TransformPoint(leftUp);
        //打印夹角
        float dd = Vector3.Dot((leftUp - this.transform.position).normalized, (rightUp - this.transform.position).normalized);
        angle3 = Mathf.Acos(dd) * Mathf.Rad2Deg;

        //计算敌人和我正前方的两个向量的夹角
        Vector3 enemy = b.transform.position - this.transform.position;
        Vector3 center = this.transform.TransformPoint(new Vector3(0, 0, dis))-this.transform.position;
        float angle_tar = Mathf.Acos(Vector3.Dot(enemy.normalized, center.normalized)) * Mathf.Rad2Deg;
        if (angle_tar < 60 && Vector3.Distance(this.transform.position, b.transform.position) < dis)
        {
            b.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            b.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        Debug.DrawLine(this.transform.position, rightUp);
        Debug.DrawLine(this.transform.position, leftUp);
    }
    /// <summary>
    /// 欧拉角和四元素
    /// </summary>
    private void Demo5()
    {
        //沿着y轴旋转
        Vector3 axis = Vector3.up;
        //旋转50度
        float rad = 50 * Mathf.Deg2Rad;

        //这个是正常的按照公式的算法

        Quaternion qt = new Quaternion();
        qt.x = Mathf.Sin(rad / 2) * axis.x;
        qt.y = Mathf.Sin(rad / 2) * axis.y;
        qt.z = Mathf.Sin(rad / 2) * axis.z;
        qt.w = Mathf.Cos(rad / 2);
        this.transform.rotation = qt;

        //unity提供了api
        this.transform.rotation = Quaternion.Euler(0, 50, 0);
        //四元数的累计不是用加号，而是用*
        this.transform.rotation *= Quaternion.Euler(1, 0, 0);
    }
    private void OnGUI()
    {
        if (GUILayout.RepeatButton("X旋转"))
        {
            //this.transform.rotation *= Quaternion.Euler(1, 0, 0);
            this.transform.Rotate(1,0,0);
            float angle;
            Vector3 axis;
            this.transform.rotation.ToAngleAxis(out angle, out axis);
            Debug.LogFormat("{0}--{1}",angle,axis);
        }

    }
}
