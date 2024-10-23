using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioSource musicSource;  // Reference to the AudioSource
    public Slider volumeSlider;      // Reference to the UI Slider

    void Start()
    {
        // Set initial volume to match the slider's value
        musicSource.volume = volumeSlider.value;

        // Add listener to detect when the slider value changes
        volumeSlider.onValueChanged.AddListener(delegate { AdjustVolume(); });
    }

    // Method to adjust volume based on slider value
    public void AdjustVolume()
    {
        musicSource.volume = volumeSlider.value;
    }
}
