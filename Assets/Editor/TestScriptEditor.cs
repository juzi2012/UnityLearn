using System;
using UnityEditor;
using UnityEngine;
/*
* AUTHER:WT
* DESCRIPTION:
*/
[CustomEditor(typeof(TestScript))]
public class TestScriptEditor : Editor
{
    //字段
    TestScript targetScript;

    GUIStyle headStyle = new GUIStyle();
    GUIStyle bottomStyle = new GUIStyle();

    //一套默认的GUI的皮肤，可以直接在后面的gui设置中使用
    GUISkin guiSkin;
    //方法
    private void OnEnable()
    {
        targetScript = (TestScript)target;
        InitGUIStyle();
        if (guiSkin==null)
        {
            guiSkin = Resources.Load<GUISkin>("GUI/testSkin");
        }
    }

    private void InitGUIStyle()
    {
        Texture2D texture = Resources.Load<Texture2D>("GUI/gui_layout_bg");
        headStyle.normal.background = texture;
        headStyle.normal.textColor = Color.white;
        headStyle.fontSize = 16;
        headStyle.alignment = TextAnchor.MiddleCenter;
        //headStyle.font = Resources.Load<Font>("xxxxx");


        bottomStyle.normal.background = texture;
        bottomStyle.normal.textColor = Color.white;
        bottomStyle.fontSize = 14;
        bottomStyle.alignment = TextAnchor.MiddleCenter;
        bottomStyle.overflow = new RectOffset(5, 0, 0, 0);
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        //DrawDefaultInspector();
        GUILayout.Space(5);
        //一个带背景的文本框
        EditorGUILayout.TextField("Editor Header", headStyle, GUILayout.Height(32));
        //间隔
        GUILayout.Space(5);
        //开始一个垂直段
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();
        targetScript.sppedValue = EditorGUILayout.Slider("speedValue", targetScript.sppedValue, 0, 10);
        //GUILayout.Label(targetScript.sppedValue.ToString(), GUILayout.Width(20));
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("open a window"))
        {
            TestGUIWindow window = (TestGUIWindow)EditorWindow.GetWindow(typeof(TestGUIWindow));
            window.Show();
        }
        GUILayout.TextField("12");
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
        //结束一个垂直段
        GUILayout.Space(5);

        //直接使用GUISkin的默认皮肤来设置
        GUILayout.Label("afs", guiSkin.label);
        GUILayout.Button("this is a skin button",guiSkin.button);
        EditorGUILayout.TextField("Editor End", bottomStyle, GUILayout.Height(16));
        GUILayout.Space(5);

    }
}
