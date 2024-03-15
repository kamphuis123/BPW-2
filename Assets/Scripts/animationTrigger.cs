using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTrigger : MonoBehaviour
{
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

        GameObject.Find("player").GetComponent<Animator>().SetTrigger("fallTrigger");
        GameObject.Find("player").GetComponent<PlayerMovement>().moveSpeed = 0;
    }
}
