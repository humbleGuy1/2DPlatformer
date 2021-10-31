using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private List<Vector2> _points;

    private void Start()
    {
        foreach(var point in _points)
        {
            Instantiate(_coinPrefab, point, _coinPrefab.transform.rotation);
        }
    }
}
