using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private float _speed = 2f;

	private Transform _target;

	private void Update()
	{
		transform.LookAt(_target.transform.position);
		transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
	}

	public void SetDirection(Transform target)
	{
		_target = target;
	}
}
