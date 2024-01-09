using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{	
	[SerializeField] private Vector3 _movementDirection;


	private void Start()
	{
		_movementDirection = new Vector3(0, 0, 1);
	}
	private void Update()
	{
		transform.Translate(_movementDirection * Time.deltaTime);
	}

	public void SetDirection(float rotation)
	{
		Vector3 rotate = transform.eulerAngles;
		rotate.y = rotation;
		transform.rotation = Quaternion.Euler(rotate);
	}
}
