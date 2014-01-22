using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour
{
	public float speed = 500.0f;

	private Manager _manager;

	void Start ()
	{
		_manager = GameObject.FindGameObjectsWithTag("ManagerTag")[0].GetComponent<Manager>();
	}

	// Update is called once per frame
	void Update ()
	{
		float hInput = Input.GetAxis("Horizontal");
		float vInput = Input.GetAxis("Vertical");
		if (Mathf.Abs(hInput) < _manager.deadzone) hInput = 0;
		if (Mathf.Abs(vInput) < _manager.deadzone) vInput = 0;

		float xSpeed = hInput * speed * Time.deltaTime;
		float ySpeed = vInput * speed * Time.deltaTime;
		rigidbody2D.velocity = new Vector2(xSpeed, ySpeed);

		Debug.Log(xSpeed);
	}
}
