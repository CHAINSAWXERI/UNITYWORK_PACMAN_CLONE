using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControll : MonoBehaviour
{
    private float originalTimeScale;
    void Start()
    {
        originalTimeScale = Time.timeScale;
    }

    public void StopTime()
    {
        Time.timeScale = 0;
    }

    public void StartTime()
    {
        Time.timeScale = originalTimeScale;
    }
}
