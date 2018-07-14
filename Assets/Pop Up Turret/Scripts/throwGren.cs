using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwGren : MonoBehaviour {

	[Header("ITEM THROWER SCRIPT")]
	[Header(" ")]
	public GameObject grenadePrefab;
	public Transform hand;
	public float throwForce = 10f;
	public float Ammo_Count;



	// Update is called once per frame
	void Update()
	{
		if (Ammo_Count > 0f)
		{
			if (Input.GetKeyDown(KeyCode.G))
			{
				Ammo_Count -= 1f;

				GameObject gren = Instantiate(grenadePrefab, hand.position, hand.rotation) as GameObject;
				gren.GetComponent<Rigidbody>().AddForce(hand.forward * throwForce, ForceMode.Impulse);
			}
		}
	}
}
