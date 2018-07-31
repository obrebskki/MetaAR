using UnityEngine;
using System;
using Meta;

/// <summary>
/// Perform click as quick hand grab and release.
/// </summary>
public class HandClick : MonoBehaviour
{
    public event Action<GameObject> OnClicked;

    private bool isPressing;
    private float accumulator;
    private const float clickTime = 0.6f; 

    void FixedUpdate()
    {
        if (isPressing)
        {
            accumulator += Time.fixedDeltaTime;
        }
    }

    public void ClickStart(MetaInteractionData data)
    {
        isPressing = true;
        accumulator = 0;
    }

    public void ClickRelease(MetaInteractionData data)
    {
        //if we exceed this time, we should treat that grab as an drag'n'drop
        if (accumulator <= clickTime)
        {
            //otherwise click has been detected
            PerformClick();
        }
        isPressing = false;
    }

    private void PerformClick()
    {
        if (OnClicked != null)
        {
            OnClicked(gameObject);
        }
    }
}
