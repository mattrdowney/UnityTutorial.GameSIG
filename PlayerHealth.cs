using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	int health;
	GameObject gui;

	// Use this for initialization
	void Start () {
		health = 100;
		gui = GameObject.Find("HealthBar");
	}
	
	// Update is called once per frame
	void Update () {
		gui.transform.localScale = new Vector3(((float)health) / 100,0.2f,1f);
	}

	void TakeDamage(int dmg)
	{
		health = health - dmg;
	}
}
