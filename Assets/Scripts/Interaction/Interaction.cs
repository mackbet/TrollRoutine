using UnityEngine;
using Photon.Pun;

public class Interaction : MonoBehaviourPunCallbacks
{
    [SerializeField] private Outline outline;
    [SerializeField] protected bool isActivated;

    public void SetOutline(bool state)
    {
        if (isActivated)
            return;

        outline.enabled = state;
    }

    public virtual void Activate() { }
    public virtual void Deactivate() { }
}
