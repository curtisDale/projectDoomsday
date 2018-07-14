using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZAttackScript : MonoBehaviour {
	public GameObject player;
	Animator controller;
	//Component hit;
	Component nav;


	// Use this for initialization
	void Start () {
		player.GetComponent<AttackScript> ();
		controller = GetComponent<Animator> ();
		nav = GetComponent<NavMeshAgent> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<AttackScript>().PlayerFound == true)
		{
			print ("SetBool");
			GetComponent<NavMeshAgent>().speed = 0;
			StartCoroutine(SpeedUp());
			controller.SetBool("Attack", true);
	}
		if (GetComponent<AttackScript>().PlayerFound == false)
		{
			print ("AttackFAlse");
			controller.SetBool("Attack", false);
		}
}
	IEnumerator SpeedUp()
	{
		//print(Time.time);
		yield return new WaitForSeconds(1);
		GetComponent<NavMeshAgent>().speed = Random.Range(6.0f,8.1f);
	}
}
