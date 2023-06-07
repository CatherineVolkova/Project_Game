using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatRed : MonoBehaviour
{
    public bool canBePressedRed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            if (canBePressedRed) {
                FindObjectOfType<BeatManager>().AddOne();
                FindObjectOfType<BeatManager>().AddOne();
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        canBePressedRed = true;
    }

    private void OnTriggerExit(Collider other) {
        canBePressedRed = false;
    }
}
