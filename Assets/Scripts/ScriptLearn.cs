using Assets.Scripts.ScriptsLearn;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLearn : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Add(new int[] { 1, 2, 3, 1 });
        Add(new int[] { 1, 2, 3, 1, 4 });

        Add(1, 1, 1);

        int[] a1 = new int[] { 1, 3 };
        int[] a2 = a1;
        //a1[0] = 2;
        a1 = new int[] { 2, 3 };
        print(a2[0]);
        int a = 1;
        int[] arr = new int[] { 1 };
        Fun(a, arr);
        print(a);
        print(arr[0]);

        int result;
        bool state = int.TryParse("250", out result);
        print(state);
        print(result);

        string s1 = "八戒";
        string s2 = "八戒";
        string s3 = new string(new char[] { '八', '戒' });
        string s4 = new string(new char[] { '八', '戒' });
        print(object.ReferenceEquals(s1,s2));
        print(object.ReferenceEquals(s3,s4));
        //这里用到枚举叠加
        GetPersonType(PersonStyle.Builty | PersonStyle.Good);

        Wife wife1 = new Wife();
        Wife wife2 = new Wife("Min");
        Wife wife3 = new Wife("Min",18);

        Dictionary<int, string> user = new Dictionary<int, string>();

        Direct dir = new Direct(10);
    }

    void GetPersonType(PersonStyle style)
    {
        if ((style & PersonStyle.High)==PersonStyle.Builty)
        {

        }
    }

    void Fun(int a,int[] arr)
    {
        a = 2;
        //arr[0] = 2;
        arr = new int[] { 2 };
    }

    // Update is called once per frame
    void Update()
    {

    }
    private int sum = 0;
    int Add(params int[] arr)
    {
        sum = 0;
        foreach (int item in arr)
        {
            sum += item;
        }
        print(sum);
        return sum;
    }
}
