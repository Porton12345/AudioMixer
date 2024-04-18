using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OnOffSoundButton : MonoBehaviour
{    
    const string MasterVolume = "MasterVolume";

    [SerializeField] private AudioMixerGroup _mixer;

    private float _minVolume = -80;
    private float _maxVolume = 0;    

    public void SetSound()
    {
        _mixer.audioMixer.GetFloat(MasterVolume, out float value);

        if (value > _minVolume)
            _mixer.audioMixer.SetFloat(MasterVolume, _minVolume);
        else if (value == _minVolume)
            _mixer.audioMixer.SetFloat(MasterVolume, _maxVolume);
    }
}
