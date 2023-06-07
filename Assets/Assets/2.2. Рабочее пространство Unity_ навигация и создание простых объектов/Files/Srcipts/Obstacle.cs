using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] public int _trigger = 0;
    [SerializeField] Char _char;
    private void OnTriggerEnter(Collider other) {
        CharBehaviour charBehaviour = other.attachedRigidbody.GetComponent<CharBehaviour>();
        if (charBehaviour) {
            charBehaviour.StartFinishBehaviour();
        }
    
    }

}
