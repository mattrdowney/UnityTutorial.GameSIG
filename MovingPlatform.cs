using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 endPos;

	bool forward;

	// Use this for initialization
	void Start ()
	{
		transform.position = startPos;
		forward = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(forward)
		{
			transform.position = Vector3.MoveTowards(transform.position,
			                    					 endPos,
			                    					 3f * Time.deltaTime);
			if(transform.position == endPos)
			{
				forward = false;
			}
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position,
			                                         startPos,
			                                         3f * Time.deltaTime);
			if(transform.position == startPos)
			{
				forward = true;
			}
		}
	}
}
