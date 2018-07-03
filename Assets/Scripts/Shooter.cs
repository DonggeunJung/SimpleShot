using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public GameObject ballPrefab;
	public float shotSpeed;
	//public float shotTorque;
	public float createInterver = 3.0f;
	float nextCreateTime = 0.0f;

	// Use this for initialization
	void Start () {
		nextCreateTime = createInterver;
	}

	// Update is called once per frame
	void Update () {
		// 압력 감지
		//if (Input.GetButtonDown("Fire1"))    // "Fire1" 은 기본 입력 명칭
		//	Shot();

		if ((Time.time * createInterver) > nextCreateTime) {
			Shot ();
			nextCreateTime += createInterver;
		}
	}

	public void Shot()
	{
		// 프리팹에서 Candy 오브젝트를 생성
		GameObject candy = (GameObject)Instantiate(
			ballPrefab,
			transform.position,
			Quaternion.identity    // 회전이 없음
		);

		// Candy 오브젝트의 Rigidbody 를 취득하여 힘과 회전을 더한다
		Rigidbody candyRigidBody = candy.GetComponent<Rigidbody>();
		candyRigidBody.AddForce(transform.forward * shotSpeed);
		//candyRigidBody.AddTorque(new Vector3(0, shotTorque, 0));
	}
}
