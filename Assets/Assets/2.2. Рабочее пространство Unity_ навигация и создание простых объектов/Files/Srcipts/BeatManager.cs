using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    [SerializeField] public static int _heartCountInLevel;
    [SerializeField] TextMeshProUGUI _text;
    
    public void AddOne()
    {
        _heartCountInLevel++;
        _text.text = _heartCountInLevel.ToString();
    }

    public void DecrOne()
    {
        _heartCountInLevel--;
        _text.text = _heartCountInLevel.ToString();
    }

}
