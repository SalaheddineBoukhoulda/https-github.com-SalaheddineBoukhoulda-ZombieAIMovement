using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Transform goal;
	public float speed = 0.5f;
	public float rotSpeed = 0.4f;
	public float accuracy = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        this.transform.LookAt(lookAtGoal);
		if(Vector3.Distance(this.transform.position,lookAtGoal)>accuracy)
			this.transform.Translate(0,0,speed*Time.deltaTime);
	}
}
