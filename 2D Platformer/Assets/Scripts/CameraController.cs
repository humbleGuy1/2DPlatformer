using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    private void Update()
    {
        Vector3 position = new Vector3(_player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = position;
    }
}
