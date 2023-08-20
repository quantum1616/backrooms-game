using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBool : MonoBehaviour
{
    public Light FlashlightSpotLight;

    public bool FlashlightEnabled = true;
   
    void Start()
    {
        
     



    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            FlashlightEnabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FlashlightEnabled = true;
        }
        if (FlashlightEnabled == true)
        {
            FlashlightSpotLight.enabled = true;
        }
        if (FlashlightEnabled == false)
        {
            FlashlightSpotLight.enabled = false;
        }







    }
}
