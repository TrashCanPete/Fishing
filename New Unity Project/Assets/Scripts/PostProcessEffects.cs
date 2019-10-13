using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessEffects : MonoBehaviour
{
    public PostProcessVolume volume;

    private ColorGrading colorGrade;
    private Bloom bloom;
    private float subtractPerSecond = 1f;

    

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out colorGrade);
        volume.profile.TryGetSettings(out bloom);

        colorGrade.tint.value = 0f;
        bloom.intensity.value = 0f;
        colorGrade.saturation.value = 0f;
        colorGrade.ldrLutContribution.value = 0f;

        
    }

    // Update is called once per frame
    void Update()
    {
        colorGrade.tint.value = Mathf.Lerp(colorGrade.tint.value, 50, 0.5f * Time.deltaTime);
        colorGrade.ldrLutContribution.value = Mathf.Lerp(colorGrade.ldrLutContribution.value, 1, 0.1f * Time.deltaTime);
        colorGrade.saturation.value -= subtractPerSecond * Time.deltaTime;
        bloom.intensity.value = Mathf.Lerp(bloom.intensity.value, 20, 0.5f * Time.deltaTime);
    }
}
