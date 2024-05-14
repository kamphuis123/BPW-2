using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject player;
    public GameObject wobImage;
    public GameObject gameImage;
    public bool alreadyTriggered = false;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - 1 * Time.deltaTime;
        if (timer <= 0)
        {
            wobImage.SetActive(false);
            gameImage.SetActive(true);
        }
        if (timer >= 0.1)
        {
            wobImage.SetActive(true);
            gameImage.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (alreadyTriggered == false) {
            wobImage.SetActive(true);
            gameImage.SetActive(false);
            alreadyTriggered = true;
            timer = 2;

        }
    }
  
}
