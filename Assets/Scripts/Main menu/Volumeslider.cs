using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volumeslider : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; 
    [SerializeField] private Slider volumeSlider;
    public GameObject mainmenu;
    public GameObject settingsmenu;
    public GameObject camera1;
    public GameObject camera2;

    public void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            Loadvolume();
        }
        else
        {
            setmusicvolume();
        }
    }

    public void setmusicvolume()
    {
        float volume = volumeSlider.value;
        audioMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    private void Loadvolume()
    { 
        volumeSlider.value=PlayerPrefs.GetFloat("musicVolume");
        setmusicvolume();

    }

    public void returntomain()
    { 
        camera1.SetActive(true);
        camera2.SetActive(false);
        mainmenu.SetActive(true);
        settingsmenu.SetActive(false);

    }
}
