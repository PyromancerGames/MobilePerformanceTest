using UnityEngine;
using System.Collections;

public class SoldierController : MonoBehaviour {

	public Transform target;
	public float speed = 3;


	void Update () {
		float step = speed * Time.deltaTime;
		Vector3 lookAt = target.position - transform.position;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookAt), step);
	}
}
