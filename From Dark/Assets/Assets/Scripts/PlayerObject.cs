using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour {
	public Rigidbody2D rb;
	private Vector3 spawn;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		spawn = transform.position;
	}

	// Update is called once per frame
	void Update () {

	}
}
