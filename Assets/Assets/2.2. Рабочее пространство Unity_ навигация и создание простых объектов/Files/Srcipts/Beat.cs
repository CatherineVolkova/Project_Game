using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public bool canBePressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            if (canBePressed) {
                FindObjectOfType<BeatManager>().AddOne();
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        canBePressed = true;
    }

    private void OnTriggerExit(Collider other) {
        canBePressed = false;
    }
}
