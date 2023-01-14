using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    AudioClip MenuSound;
    [SerializeField]
    AudioClip[] HitSounds;
    [SerializeField]
    AudioClip[] BooSounds;

    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void PlayMenuSound()
    {
        audioSource.PlayOneShot(MenuSound, 1f);
    }

    public void PlayHitSound()
    {
        int index = Random.Range(0, HitSounds.Length);
        audioSource.PlayOneShot(HitSounds[index], .5f);
    }

    public void PlayBooSound()
    {
        int index = Random.Range(0, BooSounds.Length);
        audioSource.PlayOneShot(BooSounds[index], 1f);
    }

}
