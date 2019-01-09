using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	Transform Character;
	Vector3 velocity;
	float speed = 200;
	// Use this for initialization
	void Start()
	{
		velocity = new Vector3(0, speed, 0);

	}

	// Update is called once per frame
	void Update()
	{
		velocity = (GameManager.Instance.MyCharater.transform.position - transform.position).normalized;
		GetComponent<Rigidbody2D>().velocity = velocity * Time.deltaTime *speed;
	}
}