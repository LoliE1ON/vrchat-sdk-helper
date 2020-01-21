using UnityEngine;
using System.Collections;
using UnityEditor;

class VrchatSdkHelper : EditorWindow {

    [MenuItem ("VrchatSdkHelper/Window")]

    public static void  ShowWindow () {
        EditorWindow.GetWindow(typeof(VrchatSdkHelper));
    }

    void OnGUI () {

    	EditorGUILayout.LabelField ("VrchatSdkHelper");
    	Debug.Log("Hello");

    }

}
