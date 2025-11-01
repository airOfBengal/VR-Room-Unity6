using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{
    [Header("Clock Hands (Assign in Inspector)")]
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        // Get current system time
        DateTime time = DateTime.Now;

        // Calculate hand angles
        float hourAngle = (time.Hour % 12 + time.Minute / 60f) * 30f;   // 360 / 12 = 30° per hour
        float minuteAngle = (time.Minute + time.Second / 60f) * 6f;     // 360 / 60 = 6° per minute
        float secondAngle = time.Second * 6f;                           // 360 / 60 = 6° per second

        // Apply rotations (negative for clockwise rotation)
        if (hourHand != null)
            hourHand.localRotation = Quaternion.Euler(hourAngle, 0f, 0f);

        if (minuteHand != null)
            minuteHand.localRotation = Quaternion.Euler(minuteAngle, 0f, 0f);

        if (secondHand != null)
            secondHand.localRotation = Quaternion.Euler( secondAngle, 0f, 0f);
    }
}
