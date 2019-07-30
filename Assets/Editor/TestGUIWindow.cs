using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
/*
* AUTHER:WT
* DESCRIPTION:很多细节的控件可以去下面的网站地址去看看
* https://blog.csdn.net/qq_38275140/article/details/84778344
*/
public class TestGUIWindow : EditorWindow 
{
    //字段
    private int gridId;
    private bool isToggle;
    private Bounds boundsv;
    private BoundsInt boundintv;
    //方法
    [MenuItem("Tools/Test")]
	static void Init()
    {
        TestGUIWindow window = (TestGUIWindow)EditorWindow.GetWindow(typeof(TestGUIWindow));
        window.Show();
    }
    private void OnGUI()
    {
        GUILayout.Label("This is a test panel");
        gridId = GUILayout.SelectionGrid(gridId, new[] { "tab1", "tab2"}, 2);
        if (gridId==0)
        {
            isToggle = GUILayout.Toggle(isToggle, "Toggle");
        }
        else
        {

            boundsv = EditorGUILayout.BoundsField("BoundsField", boundsv);
            boundintv = EditorGUILayout.BoundsIntField("BoundsIntField", boundintv);

        }
    }
}
