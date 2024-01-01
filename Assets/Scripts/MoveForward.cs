using UnityEngine;

public class MoveForward : MonoBehaviour
{
	[SerializeField] private Vector3 _movementDirection;
	[SerializeField] private float _speed;

	private void Update()
	{
		transform.Translate(_movementDirection * Time.deltaTime);
	}
}
