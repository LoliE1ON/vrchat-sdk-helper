using UnityEngine;
using System.Collections;
using UnityEditor;

namespace E1on {

    class AvatarPedestalPreview : EditorWindow {

        [MenuItem ("VRChat SDK Helper/Avatar Pedestal Preview")]

        public static void  ShowWindow () {
            EditorWindow.GetWindow(typeof(AvatarPedestalPreview));
        }

        void OnGUI () {

            EditorGUILayout.LabelField ("Avatar Pedestal Preview");

        }

    }

}
