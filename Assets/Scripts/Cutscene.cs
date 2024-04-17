using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject player;
    public GameObject wobImage;
    public GameObject gameImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        wobImage.SetActive(true);
        gameImage.SetActive(false);
    }
    private void OnTriggerExit(Collider collider)
    {
        wobImage.SetActive(false);
        gameImage.SetActive(true);
    }
}
