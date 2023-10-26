using UnityEngine;
using UnityEngine.UI;

public class ManualLoadSlider : MonoBehaviour
{
    public Slider slider;

    public void SetSliderValue(float value)
    {
        slider.value = value;
    }
}