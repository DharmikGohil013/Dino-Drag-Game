using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundEffect : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource

    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(PlaySound);
        }
    }

    void PlaySound()
    {
       
        if (audioSource != null)
        {
            if (audioSource.isPlaying) // Check if the audio is already playing
            {
                audioSource.Stop(); // Stop it if it is
            }
            audioSource.Play(); // Play the sound
          
        }
        else
        {
            
        }
    }

}
