using UnityEngine;

public class PlayButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonSound;   

    public void ClickSound()
    {
        _buttonSound.Play();
    }
}
