using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour
{
    [SerializeField] Char _char;
    [SerializeField] Animator _animator;
    [SerializeField] public int _bossHearts;
    public int hearts;

    void Start()
    {
        _char.enabled = false;
    }

    public void Play()
    {
        _char.enabled = true;
    }

    public void StartFinishBehaviour() {
        _char.enabled = false;
        _animator.SetTrigger("Fight");
        StartCoroutine(WaitingSecs());

        hearts = BeatManager._heartCountInLevel;

        // yield return new WaitForSeconds(3);

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

    IEnumerator WaitingSecs() {
        yield return new WaitForSeconds(5);
        Debug.Log("WaitIsOver");
    }

}
