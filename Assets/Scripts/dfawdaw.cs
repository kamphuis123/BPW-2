using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class dfawdaw : MonoBehaviour
{
    public PlayableDirector Timeline;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Timeline.Play();
        }
    }
}
