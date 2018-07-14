using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticktoground : MonoBehaviour {


	public float offsetDistance;
	public GameObject Object;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		UpdateStats();
	}

    public void UpdateStats()
	{
		RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
            print("Found an object - distance: " + hit.collider.gameObject.name);
		
        
	}
}
