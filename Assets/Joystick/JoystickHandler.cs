using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;

public class JoystickHandler : MonoBehaviour,IDragHandler,IEndDragHandler,IBeginDragHandler {
    public class VirtualJoystickEvent : UnityEvent<Vector3> { }
    public Transform content;
    public UnityEvent beginControl;
    public UnityEvent endControl;
    public VirtualJoystickEvent controlling;
    public void OnBeginDrag(PointerEventData eventData)
    {
        this.beginControl.Invoke();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (this.content)
            this.controlling.Invoke(this.content.localPosition.normalized);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.endControl.Invoke();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
