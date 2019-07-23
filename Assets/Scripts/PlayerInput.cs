using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("====== key settings =====")]
    public string keyUp = "w";
    public string keyDown = "s";
    public string keyLeft = "a";
    public string keyRight = "d";

    public string keyA = "";
    public string keyB = "";
    public string keyC = "";
    public string keyD = "";

    [Header("====== output signals =====")]
    public float DUp;
    public float DRight;
    public float Dmag;
    public Vector3 Dvec;

    public bool run;
    public bool jump;
    public bool lastJump;
    [Header("====== others =====")]
    public bool InputEnable = true;

    private float targetDup;
    private float targetDRight;
    private float velocityDup;
    private float velocityDRight;

    // Use this for initialization
    void Start()
    {
        int[] aa = new int[2];
        float[] bb = { 1.0f, 2 };

    }

    // Update is called once per frame
    void Update()
    {
        targetDup = (Input.GetKey(keyUp) ? 1.0f : 0) - (Input.GetKey(keyDown) ? 1.0f : 0);
        targetDRight = (Input.GetKey(keyRight) ? 1.0f : 0) - (Input.GetKey(keyLeft) ? 1.0f : 0);

        if (InputEnable == false)
        {
            targetDup = 0;
            targetDRight = 0;
        }

        DUp = Mathf.SmoothDamp(DUp, targetDup, ref velocityDup, 0.1f);
        DRight = Mathf.SmoothDamp(DRight, targetDRight, ref velocityDRight, 0.1f);

        Vector2 input = new Vector2(DRight, DUp);
        Vector2 output = SquareToCircle(input);

        Dmag = Mathf.Sqrt((output.y * output.y) + (output.x * output.x));
        Dvec = output.y * transform.forward + output.x * transform.right;

        run = Input.GetKey(keyA);
        bool tempJump = Input.GetKey(keyB);
        if (tempJump == true && tempJump != lastJump)
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
        lastJump = tempJump;
    }
    /// <summary>
    /// 为了防止同时按上右键的时候，出现速度大于1的情况，将方形转成原型计算
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Vector2 SquareToCircle(Vector2 input)
    {
        Vector2 output = new Vector2();
        output.x = input.x * Mathf.Sqrt(1 - (input.y * input.y) / 2.0f);
        output.y = input.y * Mathf.Sqrt(1 - (input.x * input.x) / 2.0f);
        return output;
    }
}
