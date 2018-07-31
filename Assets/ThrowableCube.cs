using UnityEngine;

public class ThrowableCube : MonoBehaviour {

    public float force = 10.0f;

    private bool isTaken;
    private Vector3 lastPosition;

    void Update()
    {
        if (isTaken)
        {
            lastPosition = transform.position;
        }
    }

    public void Take()
    {
        isTaken = true;
    }

    public void Release()
    {
        isTaken = false;

        Throw();
    }

    private void Throw()
    {
        var vector = transform.position - lastPosition;
        //Debug.Log(vector * force);
        GetComponent<Rigidbody>().AddForce(vector * force);
    }
}
