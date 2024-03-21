using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundTrack : MonoBehaviour
{
    public static AudioMixerGroup StaticaudioMixer;
    public AudioMixerGroup audipMixer;
    private void Start()
    {
        StaticaudioMixer = audipMixer;
    }

    public static void Audio(float volume)
    {
        StaticaudioMixer.audioMixer.SetFloat("MyExposedParam", LerpSliderValue(volume));
    }
    private static float LerpSliderValue(float value)
    {
        if (value == 0)
        {
            return -80;
        }
        else
        {
            return 20f * Mathf.Log10(value);
        }
    }
}
