using Meta.HandInput;
using UnityEngine;



public class HandClickInteraction : Meta.Interaction
{
    private HandFeature _handFeature;

    protected override bool CanEngage(Hand handProxy)
    {
        return GrabbingHands.Count == 1;
    }

    protected override void Engage()
    {
        _handFeature = GrabbingHands[0];
    }

    protected override bool CanDisengage(Hand handProxy)
    {
        if (_handFeature != null && handProxy.Palm == _handFeature)
        {
            foreach (var hand in GrabbingHands)
            {
                if (hand != _handFeature)
                {
                    _handFeature = hand;
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    protected override void Disengage()
    {
        Manipulate();
        RestoreRigidbodySettingsAfterInteraction();
        _handFeature = null;
    }

    protected override void Manipulate()
    {
    }

}
