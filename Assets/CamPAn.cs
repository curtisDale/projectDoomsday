using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPAn : MonoBehaviour
{

    public float mouseSensitivity = 1.0f;
    new Vector3 lastPosition;
	public bool permatrack;

    void Update()
    {
		 if (Input.GetMouseButtonDown(0))
		//if (permatrack = true)
        {
            lastPosition = Input.mousePosition;
        }

		//if (permatrack = true) 
		if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - lastPosition;
            transform.Translate(delta.x * mouseSensitivity, delta.y * mouseSensitivity, 0);
            lastPosition = Input.mousePosition;
        }
    }
}