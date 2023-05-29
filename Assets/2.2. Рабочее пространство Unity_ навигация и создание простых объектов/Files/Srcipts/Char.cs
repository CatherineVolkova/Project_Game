using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{   
    [SerializeField] private float _beatTempo;
    [SerializeField] Animator _animator;

    void Start()
    {
        _beatTempo = 4*2f;
    }

    void Update()
    {
            transform.position += transform.forward * _beatTempo * Time.deltaTime;
            _animator.SetBool("Run", true);
        
    }
}
