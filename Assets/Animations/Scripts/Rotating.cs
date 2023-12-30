using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 1;

    void Update()
    {
        transform.Rotate(0, _rotateSpeed * Time.deltaTime, 0);
    }
}
