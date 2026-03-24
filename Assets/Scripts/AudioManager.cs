using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundAudio;
    [SerializeField] private AudioSource effectAudio;

    [SerializeField] private AudioClip backgroundClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip coinClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayBackgroundMusic();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayBackgroundMusic()
    {
        backgroundAudio.clip = backgroundClip;
        backgroundAudio.Play();
    }

    public void PlayJumpSound()
    {
        effectAudio.PlayOneShot(jumpClip);
    }

    public void PlayCoinSound()
    {
        effectAudio.PlayOneShot(coinClip);
    }
}
