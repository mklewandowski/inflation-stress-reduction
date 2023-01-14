using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    AudioClip MenuSound;

    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void PlayMenuSound()
    {
        audioSource.PlayOneShot(MenuSound, 1f);
    }

}
