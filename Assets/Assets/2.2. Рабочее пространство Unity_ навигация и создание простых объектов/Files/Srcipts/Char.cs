using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{   
    [SerializeField] private float _beatTempo;
    [SerializeField] private int _speed;
    [SerializeField] Animator _animator;

    void Start()
    {
        _beatTempo = _speed*2f;
    }

    void Update()
    {
            transform.position += transform.forward * _beatTempo * Time.deltaTime;
            _animator.SetBool("Run", true);
        
    }
}
