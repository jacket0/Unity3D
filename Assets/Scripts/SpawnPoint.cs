using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	[SerializeField] private Enemy _enemyPrefab;
	[SerializeField] private Transform _target;

	public void CreateEnemy(Vector3 position)
	{
		var newEnemy = Instantiate(_enemyPrefab, position, Quaternion.identity);
		newEnemy.SetDirection(_target);
	}
}
