using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider VolumeSlider;
    void Start()
    {
        if (PlayerPrefs.HasKey("soundVolume")) LoadVolume();
        else
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
            LoadVolume();
        }
        
    }
    public void SetVolume() {
        AudioListener.volume=VolumeSlider.value;
        SaveVolume();
    }
    public void SaveVolume() {
        PlayerPrefs.SetFloat("soundVolume",VolumeSlider.value);
    }
    public void LoadVolume() {
        VolumeSlider.value = PlayerPrefs.GetFloat("soundVolume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
