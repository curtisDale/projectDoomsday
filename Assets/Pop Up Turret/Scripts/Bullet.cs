using UnityEngine;

public class Bullet : MonoBehaviour
{

	private Transform target;

	[Header("TURRET BULLET SCRIPT")]
	[Header(" ")]

	public float speed = 70f;
	//public GameObject Zorb;
    

	public void Seek(Transform _target)
	{
		target = _target;
	}

	void OnCollisionEnter(Collision coldie)
	{
		Destroy(gameObject);
		return;
	}
  
	void Update()
	{
		if (target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame)
		{
			print("hit");
			HitTarget();
			return;
		}


		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}

	void HitTarget()
	{
		Destroy(gameObject);
	}
}


