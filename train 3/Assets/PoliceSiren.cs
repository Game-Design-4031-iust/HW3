using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSiren : MonoBehaviour
{
    public Light redLight; 
    public Light blueLight; 
    public AudioSource sirenSound; 
    private bool isSirenActive = false; 

    public float waitTime = 0.2f;

    void Start()
    {
        
        redLight.enabled = false;
        blueLight.enabled = false;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSirenActive = !isSirenActive;

            if (isSirenActive)
            {
                StartCoroutine(Siren());
                sirenSound.Play(); 
            }
            else
            {
                StopAllCoroutines();
                redLight.enabled = false;
                blueLight.enabled = false;
                sirenSound.Stop(); 
            }
        }
    }

    IEnumerator Siren()
    {
        while (isSirenActive)
        {
            redLight.enabled = true;
            blueLight.enabled = false;
            yield return new WaitForSeconds(waitTime);

            redLight.enabled = false;
            blueLight.enabled = true;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
