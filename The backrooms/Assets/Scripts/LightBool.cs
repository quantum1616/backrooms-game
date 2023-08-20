using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBool : MonoBehaviour
{
    public Light FlashlightSpotLight;

    public bool FlashlightEnabled = true;

    public float battarytime = 100000f;

    public float depletionspeed = 1f;

    public float lightturnoffnumber = 0f;

    public float BattaryCalculation;


   
    void Start()
    {
       FlashlightEnabled = false;
     



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

            battarytime = battarytime - depletionspeed * Time.deltaTime;
        }
        if (FlashlightEnabled == false)
        {
            FlashlightSpotLight.enabled = false;
        }
        if (battarytime <= 0)
        {
            FlashlightSpotLight.enabled = false;
        }

        BattaryCalculation = battarytime / 100;
        BattaryCalculation = Mathf.Round(BattaryCalculation * Mathf.Pow(10, 0)) / Mathf.Pow(10, 0);







    }
}
