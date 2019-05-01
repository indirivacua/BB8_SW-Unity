using UnityEngine;
using System.Collections;

public class Head : MonoBehaviour {

    public Transform body;
    public float rotSpeed = 10.0f, offset = 0.5f;
	
	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {
		float rotX = Input.GetAxis ("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        transform.RotateAround (-Vector3.up, -rotX);
        transform.position = new Vector3(body.localPosition.x, body.localPosition.y - offset, body.localPosition.z);
    }
}
