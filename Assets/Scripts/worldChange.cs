using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldChange : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;
    public GameObject postProcessing;
    public AudioSource happy;
    public AudioSource sad;

    public bool world = false;


    void OnEnable()
    {
        changeWorld();
    }

    void changeWorld()
    {
        if (world == false)
        {


            RenderSettings.skybox = skybox2;
            happy.volume = 0;
            sad.volume = 1;

            postProcessing.SetActive(true);

            
            world = true;
        }
        else
        {
            RenderSettings.skybox = skybox1;
            world = false;
            happy.volume = 1;
            sad.volume = 0;
            postProcessing.SetActive(false);
        }
    }
}
