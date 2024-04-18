using UnityEngine;
using UnityEngine.Audio;

public class SoundPanel : MonoBehaviour
{
    const string BackgroundVolume = "BackgroundVolume";
    const string ButtonVolume = "ButtonVolume";
    const string MasterVolume = "MasterVolume";

    [SerializeField] private AudioMixerGroup _mixer;
    
    private int _logKoefficient = 20;

    public void ChangeBackgroundVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(BackgroundVolume, Mathf.Log10(volume) * _logKoefficient);
    }

    public void ChangeButtonsVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(ButtonVolume, Mathf.Log10(volume) * _logKoefficient);
    }

    public void ChangeOverallVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(MasterVolume, Mathf.Log10(volume) * _logKoefficient); 
    }    
}
