using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DigitalClockManager : MonoBehaviour
{
    private TimeManager timeManager;
    private TextMeshPro textMesh;
    void Start()
    {
        timeManager = GetComponent<TimeManager>();
        textMesh = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        string time = timeManager.Clock24Hour();
        textMesh.text = time;
    }
}
