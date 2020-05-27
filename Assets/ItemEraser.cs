using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour {

    Camera cam;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z < cam.transform.position.z - 1)
        {
            Destroy(gameObject);
        }
    }
}
