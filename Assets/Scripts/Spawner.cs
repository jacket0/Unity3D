using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] private Enemy _enemy;
	[SerializeField] private Transform[] _spawnPoints;

	private Quaternion _rotation;

	private void Awake()
	{
		_enemy.SetDirection(Random.Range(0, 360));
		Shuffle(_spawnPoints);
		StartCoroutine(nameof(CreateEnemy));
	}

	private IEnumerator CreateEnemy()
	{
		for (int i = 0; i < _spawnPoints.Length; i++)
		{
			Instantiate(_enemy, _spawnPoints[i].position, _rotation.normalized);
			yield return new WaitForSecondsRealtime(2);
		}
	}

	private void Shuffle(Transform[] _spawnPoints)
	{
		for (int i = 0; i < _spawnPoints.Length - 1; i++)
		{
			int indexToShuffle = Random.Range(0, _spawnPoints.Length);
			var temp = _spawnPoints[i];
			_spawnPoints[i] = _spawnPoints[indexToShuffle];
			_spawnPoints[indexToShuffle] = temp;
		}
	}
}
