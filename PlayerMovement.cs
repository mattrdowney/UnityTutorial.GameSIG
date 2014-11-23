using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	bool canJump;

	//this.rigidbody == this.gameObject.Get
	// Use this for initialization
	void Start () 
	{
		speed = 6;
		canJump = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (rigidbody.velocity);
		transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed;
		if(Input.GetButtonDown("Jump") && canJump) 
		{
			rigidbody.velocity =  new Vector3(0f,10f,0f);
			canJump = false;
			this.gameObject.transform.parent = null;
		}
		if(!canJump) rigidbody.velocity -= Vector3.up * 9.8f * Time.deltaTime;
		transform.Rotate(new Vector3(0f,1f,0f) * Input.GetAxis ("Mouse X") * Time.deltaTime * 90f);
	}

	void OnCollisionEnter(Collision c)
	{
		canJump = true;
		rigidbody.velocity = Vector3.zero;
		if(c.gameObject.GetComponent<MovingPlatform>())
		{
			this.gameObject.transform.parent = c.gameObject.transform;
		}
	}

}
