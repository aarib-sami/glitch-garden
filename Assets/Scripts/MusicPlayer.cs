using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
