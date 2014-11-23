using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		RaycastHit hit;
		float distance = 10;
		Vector3 origin = transform.position;
		Vector3 direction = transform.forward;
		if(Input.GetButtonDown("Fire1"))
		{
			if(Physics.Raycast(origin,direction,out hit,distance))
			{
				//Debug.Log (hit.collider.gameObject.name);
				hit.collider.gameObject.SendMessage("TakeDamage",Random.Range (20,60));
				hit.collider.gameObject.rigidbody.AddForce(10*transform.forward + 5*Vector3.up,ForceMode.Impulse);
			}
			//Debug.Log ("Raycast: " + Time.time);
			Debug.DrawRay(origin,direction,Color.white,10f);
		}
	}
}
