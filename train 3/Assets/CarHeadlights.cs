using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CarHeadlights : MonoBehaviour
{
    public Light[] headlights;
    private bool lightsOn = false;
    void Start()
    {

        foreach (Light light in headlights)
        {
            light.enabled = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            lightsOn = !lightsOn;

            foreach (Light light in headlights)
            {
                light.enabled = lightsOn; 

                if (lightsOn)
                {
                    light.color = Color.yellow;
                }
                else
                {
                    light.color = Color.white; 
                }
            }
        }
    }
}
    

