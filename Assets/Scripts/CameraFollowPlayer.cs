using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour
{
	public float tightness = 2;
	public float cameraDeadzone = 1;

	private Vector3 _cameraGoTo = new Vector3();

	private GameObject _player;

	void Start ()
	{
		_player = GameObject.FindGameObjectWithTag("PlayerTag");
		_cameraGoTo = _player.transform.position;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector3 camPos = transform.position;
		camPos.z = _player.transform.position.z;
		if (Vector3.Distance(camPos, _player.transform.position) > cameraDeadzone)
		{
			_cameraGoTo = _player.transform.position;
		}

		Vector3 camNewPos = transform.position;
		camNewPos.x += (_cameraGoTo.x - transform.position.x) / tightness;
		camNewPos.y += (_cameraGoTo.y - transform.position.y) / tightness;
		camNewPos.z = transform.position.z;
		transform.position = camNewPos;

		Debug.Log(Vector3.Distance(transform.position, _player.transform.position));
	}
}