using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BossModifier : MonoBehaviour
{
    [SerializeField] public static int _bossHearts;
    [SerializeField] TextMeshProUGUI _text;

    void Start()
    {
        _bossHearts = int.Parse(_text.text);
    }
    

    public void DecrOne()
    {
        _bossHearts--;
        _text.text = _bossHearts.ToString();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
