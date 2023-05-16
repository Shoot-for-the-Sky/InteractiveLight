using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light myLight;

    private bool isOn;
    public GameObject player;
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 lightPos = transform.position;
        float distance = Vector3.Distance(playerPos, lightPos);
        if (distance < 3.5 && Input.GetKeyDown(KeyCode.E))
        {
            if(myLight.enabled == false)
            {
                myLight.enabled = true;
            }
            else
            {
                myLight.enabled = false;
            }
        }
        
    }
}
