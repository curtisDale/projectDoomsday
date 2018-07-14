using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTurret : MonoBehaviour {

	[Header("TURRET POP-UP SCRIPT")]
	[Header(" ")]

	public GameObject turret;
	public GameObject fX;
	public Transform capsule;

	void OnCollisionEnter(Collision col)
    {
		if (col.gameObject.tag == "terrain")
		{
			Vector3 PosOffset = transform.position;
			//PosOffset.y += 0.1f;
			//       if (col.gameObject.name == "prop_powerCube")
			//       {
			GameObject tur = Instantiate(turret, PosOffset, Quaternion.identity) as GameObject;
			GameObject fx = Instantiate(fX, PosOffset, Quaternion.identity) as GameObject;
			Destroy(gameObject);
		}

 //       }
    }
}
