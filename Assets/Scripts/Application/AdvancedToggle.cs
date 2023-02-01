using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancedToggle : MonoBehaviour
{
    private GameObject applicationSettings;
    private ApplicationData applicationData;
    private Toggle toggle;

    private void Awake()
    {
        applicationSettings = GameObject.FindGameObjectWithTag("ApplicationSettings");
        if (applicationSettings == null)
        {
            applicationSettings = new GameObject("ApplicationSettings");
            applicationSettings.tag = "ApplicationSettings";
            applicationSettings.AddComponent<ApplicationData>();
        }
        applicationData = applicationSettings.GetComponent<ApplicationData>();

        toggle = gameObject.GetComponent<Toggle>();
    }
    private void Start()
    {
        toggle.isOn = applicationData.equalizerMode;
        toggle.onValueChanged.AddListener(delegate { applicationData.SetEqualizerOn(toggle.isOn); });
    }
}
