using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;
    public bool _startPlaying;
    public float songBpm;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float dspSongTime;
    public AudioSource musicSource;
    
     private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }

    public void Play()
    {
        _startMenu.SetActive(false);
        _startPlaying = true;
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;
        musicSource.Play();
        FindObjectOfType<CharBehaviour>().Play();
    }

    public void Update()
    {
        //determine how many seconds since the song started
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        //determine how many beats since the song started
        songPositionInBeats = songPosition / secPerBeat;
    }

    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
    }

    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings) {
            SceneManager.LoadScene(next);
        } else {
            SceneManager.LoadScene(1);
        }
        
    }

    // public void ReplayLevel()
    // {
    //     int this = SceneManager.GetActiveScene().buildIndex;
    //     SceneManager.LoadScene(this);     
    // }
}
