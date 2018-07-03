using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	public float jump_speed = 12.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 압력 감지
		if (Input.GetButtonDown ("Fire1")) {    // "Fire1" 은 기본 입력 명칭
			Rigidbody thisRigidbody = this.GetComponent<Rigidbody>();
			thisRigidbody.velocity = Vector3.up * jump_speed;
			transform.TransformVector(0.0f, jump_speed, 0.0f);
		}
	}
}
