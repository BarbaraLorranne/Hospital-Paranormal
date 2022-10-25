using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public GameObject night;
    public float time;
    private float timeSet;
    private float cycleStage;

    void Awake()
    {
        timeSet = 0.1f / time * -1;
    }

    public void SetLightDarker()
    {
        RenderSettings.ambientIntensity = 0.38f;
        night = transform.GetChild(0).gameObject;
        night.GetComponentInChildren<Light>().intensity = 0;
    }

    public void NormalizeLight()
    {
        RenderSettings.ambientIntensity = 1;
        night = transform.GetChild(0).gameObject;
        night.GetComponentInChildren<Light>().intensity = 0;
    }

    public void NightDiscoverer()
    {
        if(cycleStage < -0.45f || cycleStage > 0.45f)
        {
            SetLightDarker();
        }
        else
        {
            NormalizeLight();
        }
    }
    
    void Update()
    {
        transform.Rotate(0, 0, timeSet, Space.World);
        cycleStage = transform.rotation.z;
        NightDiscoverer();
    }
}
