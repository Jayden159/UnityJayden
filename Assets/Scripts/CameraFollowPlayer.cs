using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour
{
	public float tightness = 2;
	public float cameraDeadzone = 1;

	private GameObject _player;

	void Start ()
	{
		_player = GameObject.FindGameObjectWithTag("PlayerTag");
	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 camNewPos = _player.transform.position;
		camNewPos.z = transform.position.z;
		if (Vector3.Distance(transform.position, camNewPos) > cameraDeadzone)
		{
			transform.position = Vector3.Lerp(transform.position, camNewPos, tightness * Time.deltaTime);
		}
	}
}
