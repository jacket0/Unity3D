using UnityEngine;

public class MoveForward : MonoBehaviour
{
	[SerializeField] private Vector3 _movementDirection;
	[SerializeField] private float _speed;

	void Update()
	{
		transform.Translate(_movementDirection * Time.deltaTime);
	}
}
