using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    public AudioSource[] BGMs;
    public AudioSource[] Effects;
    public Slider BGMSlider;
    public Slider EffectSlider;
    public Text BGMVolumeText;
    public Text EffectVolumeText;

    private int BGMInt;
    private int EffectInt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BGMInt = (int)BGMSlider.value;
        EffectInt = (int)EffectSlider.value;
        for(int i = 0; i < 2; i++)
        {
            BGMs[i].volume = (BGMSlider.value / 100) * 0.85f;
        }
        for (int j = 0; j < 30; j++)
        {
            Effects[j].volume = EffectSlider.value / 100;
        }

        BGMVolumeText.text = BGMInt.ToString() + "%";
        EffectVolumeText.text = EffectInt.ToString() + "%";
    }
}
