using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
/// This script tells the zombie that it has cought up to the player
/// </summary>

public class AttackScript : MonoBehaviour {
	public bool PlayerFound;

	// Use this for initialization
	void Start () {
		PlayerFound = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "AttkZone") 
		{
			print("HitPlayer");
			PlayerFound = true;
			StartCoroutine(HitOff());
		}

	}
	IEnumerator HitOff()
	{
		//print(Time.time);
		yield return new WaitForSeconds(0);
		print ("playerNOTfound");
		PlayerFound = false;
		//print(Time.time);
	}
}
