using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] private float _speed = 1f;
	[SerializeField] private Transform[] _targets;

	private int _currentTarget = 0;

	private void Update()
	{
		if (Vector3.Distance(transform.position, _targets[_currentTarget].position) < 0.01f)
		{
			_currentTarget = (_currentTarget + 1) % _targets.Length;
		}

		transform.position = Vector3.MoveTowards(transform.position, _targets[_currentTarget].position, _speed * Time.deltaTime);
	}
}
