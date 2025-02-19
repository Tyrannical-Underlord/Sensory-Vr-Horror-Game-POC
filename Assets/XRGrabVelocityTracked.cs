using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabVelocityTracked : XRGrabInteractable
{

    /*protected override void selectEntered(XRBaseInteractor interactor)
    {
        SetParentToXRRig();
        base.OnSelectEntered(interactor);
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        SetParentToWorld();
        base.OnSelectExited(interactor);
    }*/

    public void SetParentToXRRig(SelectEnterEventArgs args)
    {
        transform.SetParent(args.interactorObject.transform.parent.parent.parent);
    }

    public void SetParentToWorld(SelectExitEventArgs args)
    {
        transform.SetParent(null);
    }

    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(SetParentToXRRig);
        grabInteractable.selectExited.AddListener(SetParentToWorld);
    }
}