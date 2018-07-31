using UnityEngine;

public abstract class PegBase : MonoBehaviour {

    public float TargetAngle { get; set; }
    public float deltaRotation = 30;
    protected Vector3 currentRotation;

    protected virtual void Awake()
    {
        currentRotation = transform.localEulerAngles;
        TargetAngle = currentRotation.y;
    }

    protected virtual void Update()
    {
        float difference = Mathf.DeltaAngle(TargetAngle, currentRotation.y);
        if (difference <= -180)
        {
            difference += 360;
        }
        if (Mathf.Abs(difference) > deltaRotation * Time.deltaTime)
        {
            currentRotation.y += Mathf.Sign(TargetAngle - currentRotation.y) * deltaRotation * Time.deltaTime;
        }
        else
        {
            currentRotation.y = TargetAngle;
        }
        transform.localEulerAngles = currentRotation;
    }

    public abstract void RequestRotation();

    public abstract void RotateImmediate();
}
