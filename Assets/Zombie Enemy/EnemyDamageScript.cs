using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyDamageScript : MonoBehaviour {

	public float max_health = 100f;
	public float cur_health = 0f;
	public GameObject target;

	Animator controller;
    AudioSource RunSound;
	NavMeshAgent nav;

	// Use this for initialization
	void Start () {
		cur_health = max_health;
            nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
            controller = GetComponent<Animator>();
		RunSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cur_health <0f)
		{
			nav.enabled = false;
			RunSound.enabled = false;
			controller.SetBool("Death", true);
			Death();
		}
	}

    public void TakeDamage(float amount)
	{
		cur_health -= amount;
	}

		void Death()
        {
		target.SetActive(false);
            //nav.Stop;
            Destroy(gameObject, Random.Range(5f, 8f));
        }
}
