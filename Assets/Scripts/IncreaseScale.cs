using UnityEngine;

public class IncreaseScale : MonoBehaviour
{
	[SerializeField] private Vector3 _scaleIncreaseSpeed;

	private void Update()
	{
		transform.localScale += _scaleIncreaseSpeed;
	}
}
