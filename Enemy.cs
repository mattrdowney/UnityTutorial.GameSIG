using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	GameObject player;
	int health;

	// Use this for initialization
	void Start () {
		health = 100;
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.MoveTowards(transform.position,
			                    				  player.transform.position,
			                    				  3f * Time.deltaTime);
		if(health <= 0) Destroy(this.gameObject);
	}

	void TakeDamage(int dmg)
	{
		health = health - dmg;
	}
}
