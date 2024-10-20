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
        Debug.Log("Button clicked!"); // Log button click
        if (audioSource != null)
        {
            if (audioSource.isPlaying) // Check if the audio is already playing
            {
                audioSource.Stop(); // Stop it if it is
            }
            audioSource.Play(); // Play the sound
            Debug.Log("Playing sound!"); // Log sound playing
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned!");
        }
    }

}
