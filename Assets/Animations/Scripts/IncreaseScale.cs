using UnityEngine;

public class IncreaseScale : MonoBehaviour
{
	[SerializeField] private Vector3 _scaleIncreaseSpeed;

	void Update()
	{
		transform.localScale += _scaleIncreaseSpeed;
	}
}
