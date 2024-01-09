using UnityEngine;

public class MoverForward : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private Vector3 _movementDirection;

	private void Start()
	{
		transform.rotation *= Quaternion.Euler(0,  Random.Range(0, 360), 0);
	}

	private void Update()
	{
		transform.Translate(_movementDirection * Time.deltaTime);
	}
}
