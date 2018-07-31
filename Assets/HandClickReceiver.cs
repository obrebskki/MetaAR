using UnityEngine;

public class HandClickReceiver : MonoBehaviour {

	void Start ()
    {
        FindObjectOfType<HandClick>().OnClicked += _ => Debug.Log("JAK ON TO KLIKNĄŁ");
	}
}
