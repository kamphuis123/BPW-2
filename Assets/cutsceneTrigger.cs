using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneTrigger : MonoBehaviour
{
    public gameObject player;
    public gameObject image;

    void onTriggerEnter(collider, player)
    {
        image.SetActive(true);

        
    }


    
}
