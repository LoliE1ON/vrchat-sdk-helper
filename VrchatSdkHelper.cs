using UnityEngine;
using System.Collections;
using UnityEditor;

namespace E1on {

    class VrchatSdkHelper : EditorWindow {

        [MenuItem ("VRChat SDK Helper/Window")]

        public static void  ShowWindow () {
            EditorWindow.GetWindow(typeof(VrchatSdkHelper));
        }

        void OnGUI () {

            EditorGUILayout.LabelField ("VrchatSdkHelper");

        }

    }

}
