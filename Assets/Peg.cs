//using UnityEditor;
//using UnityEngine;

//public class Peg : PegBase {

//    protected override void Awake()
//    {
//        base.Awake();
//        GetComponent<HandClick>().OnClicked += _ => RequestRotation();
//    }

//    public override void RequestRotation()
//    {
//        TargetAngle += 90;
//        FindObjectOfType<MainPeg>().RequestRotation();
//    }

//    public override void RotateImmediate()
//    {
//        currentRotation.y -= 90;
//        TargetAngle -= 90;
//        transform.localRotation = Quaternion.Euler(currentRotation);
//        FindObjectOfType<MainPeg>().RotateImmediate();
//    }
//}

//[CustomEditor(typeof(Peg))]
//[DisallowMultipleComponent]
//[CanEditMultipleObjects]
//public class PegEditor : Editor {

//    public override void OnInspectorGUI()
//    {
//        DrawDefaultInspector();

//        if (GUILayout.Button("Rotate"))
//        {
//            (target as Peg).RequestRotation();
//        }
//    }

//}