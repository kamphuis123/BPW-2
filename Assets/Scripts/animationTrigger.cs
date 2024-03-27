using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class animationTrigger : MonoBehaviour
{
    public PlayableDirector Timeline;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        Timeline.Play();
       

    }
}
