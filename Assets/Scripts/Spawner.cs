using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] private Enemy _enemy;
	[SerializeField] private Transform[] _spawnPoints;
	[SerializeField] private float _waitSecond = 2f;
	private void Start()
	{
		Shuffle(_spawnPoints);
		StartCoroutine(nameof(CreateEnemy));
	}

	private IEnumerator CreateEnemy()
	{
		for (int i = 0; i < _spawnPoints.Length; i++)
		{
			var newEnemy = Instantiate(_enemy, _spawnPoints[i].position, Quaternion.identity);
			newEnemy.SetDirection(Random.Range(0, 360));
			yield return new WaitForSecondsRealtime(_waitSecond);
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
