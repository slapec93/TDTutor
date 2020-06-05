﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 70f;
	public GameObject impactEffect;

	Transform target;


	// Update is called once per frame
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
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}

	public void Seek(Transform _target)
	{
		target = _target;
	}

	void HitTarget()
	{
		GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(effectIns, 2f);
		Destroy(gameObject);
	}
}
