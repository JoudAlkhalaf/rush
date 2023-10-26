using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using System;

public class Loading : MonoBehaviour
{

    public ManualLoadSlider loadSlider;

    private void Start()
    {
        // Simulate loading progress by setting the slider value over time
        StartCoroutine(SimulateLoading());
    }

    private System.Collections.IEnumerator SimulateLoading()
    {
        float progress = 0f;

        while (progress <= 1f)
        {
            loadSlider.SetSliderValue(progress);
            progress += 0.004f; // Adjust the increment value to control the loading speed
            yield return new WaitForSeconds(0.05f); // Adjust the delay between updates to control the loading speed
        }

        loadSlider.SetSliderValue(1f); // Ensure the slider value reaches 100% at the end
        Debug.Log("Loading complete!");
    }
}

