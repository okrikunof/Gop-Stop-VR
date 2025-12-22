using UnityEngine;


public class XRSocketTagInteractor : UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor
{
    public string targetTag;

    public override bool CanHover(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable) &&
               interactable.transform.CompareTag(targetTag);
    }

    public override bool CanSelect(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) &&
               interactable.transform.CompareTag(targetTag);
    }
}
