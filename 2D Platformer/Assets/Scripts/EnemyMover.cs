using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;
    [SerializeField] private float _duaration;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, _duaration, PathType.CatmullRom, PathMode.Sidescroller2D).SetOptions(true).SetLookAt(0.01f);
        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}

    