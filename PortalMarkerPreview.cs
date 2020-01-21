using UnityEngine;
using System.Collections;
using UnityEditor;

namespace E1on {

    class PortalMarkerPreview : EditorWindow {

        [MenuItem ("VRChat SDK Helper/Portal Marker Preview")]

        public static void  ShowWindow () {
            EditorWindow.GetWindow(typeof(PortalMarkerPreview));
        }

        void OnGUI () {

            EditorGUILayout.LabelField ("Portal Marker Preview");

        }

    }

}
