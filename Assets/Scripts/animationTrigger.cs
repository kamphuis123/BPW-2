using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTrigger : MonoBehaviour
{
    public GameObject worldChanger;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        worldChanger.SetActive(true);
        GameObject.Find("player").GetComponent<Animator>().SetTrigger("fallTrigger");
        GameObject.Find("player").GetComponent<PlayerMovement>().moveSpeed = 0;
      
       

    }
}
