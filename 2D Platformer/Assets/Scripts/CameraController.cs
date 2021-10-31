using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    
    private void Update()
    {
        Vector3 position = new Vector3(_playerPrefab.transform.position.x, transform.position.y, transform.position.z);
        transform.position = position;
    }
}
