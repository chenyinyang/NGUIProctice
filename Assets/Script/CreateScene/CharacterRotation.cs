using UnityEngine;
using System.Collections;

public class CharacterRotation : MonoBehaviour {
    Transform myTransform;
    Vector3 characterPoint;
	// Use this for initialization
	void Awake () {
        myTransform = transform;
        characterPoint = myTransform.parent.position;
    }
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0) && mouseX != 0)
            myTransform.RotateAround(characterPoint, Vector3.up, mouseX);
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            myTransform.RotateAround(characterPoint, Vector3.up, Input.GetTouch(0).deltaPosition.x);
        }
	}
}
