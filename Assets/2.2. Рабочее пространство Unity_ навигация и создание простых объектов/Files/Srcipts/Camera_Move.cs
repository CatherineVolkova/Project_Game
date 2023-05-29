using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    [SerializeField] Transform _target;
    

    void LateUpdate()
    {
        if (_target)
        {
            transform.position = _target.position;
        }
    }
}
