using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Vector2[] _points;

    private void Start()
    {
        foreach(var point in _points)
        {
            Instantiate(_coin, point, _coin.transform.rotation);
        }
    }
}
