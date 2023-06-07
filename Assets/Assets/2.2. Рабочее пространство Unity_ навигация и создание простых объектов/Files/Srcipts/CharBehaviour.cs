using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour
{
    [SerializeField] Char _char;
    [SerializeField] Animator _animator;
    public int hearts;
    public int bosshearts;

    void Start()
    {
        _char.enabled = false;
    }

    public void Play()
    {
        _char.enabled = true;
    }

    IEnumerator WaitingSecs() {
        yield return new WaitForSeconds(5);
        Debug.Log("WaitIsOver");
        hearts = BeatManager._heartCountInLevel;
        bosshearts = BossModifier._bossHearts;
        if (bosshearts <= hearts) {
            // while (bosshearts > 0) {
            //     if (Input.GetKeyDown(KeyCode.D)) {
            //         FindObjectOfType<BossModifier>().DecrOne();
            //     }
            // }
            FindObjectOfType<BossModifier>().Die();
        } else {
            FindObjectOfType<CharModifier>().Die();
        }
        FindObjectOfType<GameManager>().ShowFinishWindow();
    }

    public void StartFinishBehaviour() {
        _char.enabled = false;
        _animator.SetTrigger("Fight");
        StartCoroutine(WaitingSecs());


        // while (_bossHearts > 0) {
        //     if (Input.GetKeyDown(KeyCode.D))
        //     {
        //         FindObjectOfType<BeatManager>().DecrOne();
        //         _bossHearts--;
        //     }
        // }
        
        
        // if (_bossHearts <= hearts) {
        //     Destroy(gameObject);
        //     FindObjectOfType<BossModifier>().Die();
        // } else {
        //     FindObjectOfType<CharModifier>().Die();
        // }
    }

}
