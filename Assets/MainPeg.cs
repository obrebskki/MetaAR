using UnityEngine;

public class MainPeg : PegBase
{
    public int roto = 4;

    void Start()
    {
        var r = new System.Random();

        var pegs = FindObjectsOfType<Peg>();
        for(int i = 0; i < roto; i++)
        {
            pegs[r.Next(0, pegs.Length)].RotateImmediate();
        }
    }

    public override void RequestRotation()
    {
        TargetAngle -= 90;
    }

    public override void RotateImmediate()
    {
        currentRotation.y += 90;
        TargetAngle += 90;
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
