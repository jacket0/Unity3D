using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] private SpawnPoint[] _spawnPoints;
	[SerializeField] private int _waitSeconds = 2;

	private void Start()
	{
		Shuffle(_spawnPoints);
		StartCoroutine(nameof(CreateEnemies));
	}

	private IEnumerator CreateEnemies()
	{
		var waiting = new WaitForSecondsRealtime(_waitSeconds);

		for (int i = 0; i < _spawnPoints.Length; i++)
		{
			_spawnPoints[i].CreateEnemy(_spawnPoints[i].transform.position);
			yield return waiting;
		}
	}

	private void Shuffle(SpawnPoint[] _spawnPoints)
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
