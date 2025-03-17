using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnalogClockManager : MonoBehaviour
{
    private const float hourToDegree = 360/12;
    private const float minuteToDegree = 360/60;
    private const float secondToDegree = 360/60;
    [SerializeField] private Transform hourHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private Transform secondHand;
    private TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        timeManager = GetComponent<TimeManager>();
        Debug.Log("Start!");
        if (hourHand == null) {
            Debug.Log("Hour hand is null");
        } else {
            Debug.Log("Hour hand is not null");
        }

        if (minuteHand == null) {
            Debug.Log("Minute hand is null");
        } else {
            Debug.Log("Minute hand is not null");
        }

        if (secondHand == null) {
            Debug.Log("Second hand is null");
        } else {
            Debug.Log("Second hand is not null");
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update!");
        if (hourHand == null) {
            Debug.Log("Hour hand is null");
        }

        if (minuteHand == null) {
            Debug.Log("Minute hand is null");
        }

        if (secondHand == null) {
            Debug.Log("Second hand is null");
        }

        //hourHand.rotation = Quaternion.Euler(timeManager.GetHour12Format()*hourToDegree ,0,0);
        minuteHand.rotation = Quaternion.Euler(timeManager.GetMinute()*minuteToDegree ,0,0);
        //secondHand.rotation = Quaternion.Euler(timeManager.GetSecond()*secondToDegree ,0,0);

        //hourHand.Rotate(timeManager.GetHour()*hourToDegree, 0, 0);
        //minuteHand.Rotate(timeManager.GetMinute()*minuteToDegree, 0, 0);
        //secondHand.Rotate(timeManager.GetSecond()*secondToDegree ,0,0);
    }
}
