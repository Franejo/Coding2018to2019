using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;



public class Character : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	float speed = 10;
	public List<Vector3> teleportloca = new List<Vector3>();

	public GameObject Enemy;

	Vector3 velocity = new Vector3(0, 0, 0);
	Rigidbody2D rbody;
	// Use this for initialization
	void Start()
	{
		rbody = GetComponent<Rigidbody2D>();
		GameManager.Instance.MyCharater = this;
 

	}

	// Update is called once per frame
	void Update()

	{
		float jump;

		jump = 5;
		velocity = rbody.velocity;


		if (Input.GetKeyDown(KeyCode.W))
		{
			velocity += Vector3.up * jump;
			AudioManager.Instance.PlayOneShot(SoundEffect.Jump);

		}
		if (Input.GetKey(KeyCode.A))
		{

			velocity -= Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D))
		{

			velocity += Vector3.right * speed * Time.deltaTime;
		}
		if (!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
		{
			velocity = new Vector3(velocity.x * 1 - Time.deltaTime, velocity.y, 0);
		}
		if (Input.GetKey(KeyCode.S))
		{

			velocity += Vector3.down * speed * 4000 * Time.deltaTime;
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Fire();
		}

		rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -speed, speed), Mathf.Clamp(velocity.y, -jump, jump), 0);
	}
	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);
	}



	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "TP TO SPAWN")
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);


		
		



	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Spawn enemy")
		{
			Enemy.SetActive(true);
		}
		if (collision.tag == "level2")
		{
			transform.position = new Vector3(174.4f, -198.4f, 0);
		}
		if (collision.tag == "SPEED")
		{
			velocity -= Vector3.right * speed * 300 * Time.deltaTime;
		}

	}



}
