using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	[SerializeField] private Enemy _enemyPrefab;
	[SerializeField] private Transform[] _targets;

	private int _currentTarget = 0;
	private Enemy newEnemy;

	private void Update()
	{
		if (newEnemy != null && Vector3.Distance(newEnemy.transform.position, _targets[_currentTarget].position) < 0.01f)
		{
			_currentTarget = (_currentTarget + 1) % _targets.Length;
			newEnemy.SetDirection(_targets[_currentTarget]);
		}
	}

	public void CreateEnemy(Vector3 position)
	{
		newEnemy = Instantiate(_enemyPrefab, position, Quaternion.identity);
		newEnemy.SetDirection(_targets[_currentTarget]);
	}
}
