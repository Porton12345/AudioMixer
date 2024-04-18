using UnityEngine;
using UnityEngine.Audio;

public class MainPanel : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;    

    public void ChangeBackgroundVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("BackgroundVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeButtonsVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("ButtonVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeOverallVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20); 
    }

    public void SetSound()
    {
        _mixer.audioMixer.GetFloat("MasterVolume", out float value);        

        if (value > -80)
             _mixer.audioMixer.SetFloat("MasterVolume", -80);       
        else if (value == -80)
             _mixer.audioMixer.SetFloat("MasterVolume", 0);                 
    }
}
