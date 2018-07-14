using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MyEnemyController : MonoBehaviour {

	[Header("ZOMBIE CONTROLLER")]
    [Header(" ")]

	NavMeshAgent nav;

	[Header("LINKAGES & STATS:")]
	[Header(" ")]

	public Transform PlayerPos;
	public GameObject Player;

	Animator controller;
	AudioSource RunSound;

	[Header("REFERENCE:")]
	[Header(" ")]

	public bool ds;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		controller = GetComponent<Animator> ();
		GetComponent<NavMeshAgent>().speed = Random.Range(2.5f, 4.9f);
		RunSound = GetComponent<AudioSource> ();
		//ds = false;
		GetComponent<Animator> ().SetInteger ("Rval", Random.Range(1,4));

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		nav.SetDestination(PlayerPos.position);
		controller.SetFloat ("Speed", Mathf.Abs(nav.velocity.x) + Mathf.Abs(nav.velocity.z));


        ////////////////////////////// THIS IS WHAT HAPPENS WHEN THE PLAYER IS ATTACKED ////////////////////////////////////////////


		if (GetComponent<AttackScript>().PlayerFound == true) 
		{
		//	if (!Death) {
		//		print ("sentdamage to PLAYER");
		//		Player.SendMessageUpwards ("PlayerDamage", damage, SendMessageOptions.RequireReceiver);
		//	}
		}

		{
		//	health -= damage;
		}





	}



/// //////////////////////////////////// THIS IS WHEN THE PLAYER SHOOTS THE ZOMBIE ////////////////////////////////////////////



//	void OnCollisionEnter(Collision collision)
//	{
	//	if(collision.gameObject.tag == "bullet")
	//	{
	//		print ("damagezomb");
//			health -= damage;
	//	}
//	}



	void ApplyDamage(float damage)
	{
		if  (GetComponent<EnemyDamageScript>().cur_health < 0)
		{         
			nav.enabled = false;
			RunSound.enabled = false;
			controller.SetBool("Death", true);
			Death ();
	//		ds = true;
		}
	}
	void Death ()
	{
		//nav.Stop;
		Destroy (gameObject, Random.Range(5f,8f));
	}
}
