using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    private Animator _animator;

    public UnityEvent Hit;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void GetHit()
    {
        Hit?.Invoke();
        _animator.Play("GetHit");
    }
}
