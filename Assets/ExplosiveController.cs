﻿using UnityEngine;
using System.Collections;

public class ExplosiveController : MonoBehaviour {

	public float radius = 5.0F;
	public float power = 10.0F;
	
	void Start() {
		StartCoroutine(Explode());
	}


	IEnumerator Explode(){
		while(true) {
			yield return new WaitForSeconds(5);
			Vector3 explosionPos = transform.position;
			Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
			foreach (Collider hit in colliders) {
				Rigidbody rb = hit.GetComponent<Rigidbody>();
				
				if (rb != null)
					rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
				
			}
		}

	}
}
