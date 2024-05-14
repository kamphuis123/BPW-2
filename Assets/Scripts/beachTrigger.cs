using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class beachTrigger : MonoBehaviour
{
    public int timesDipped;
    public GameObject player;
    public GameObject spawnPoint;
    public PlayableDirector fade;
    public AudioSource song1;
    public AudioSource song2;
    public AudioSource song3;

    void Start()
    {
        state = StateEnum.s1;
    }

    private void Update()
    {
        if (timesDipped == 0)
        {
            state = StateEnum.s1;
        }
        else if (timesDipped == 2)
        {
            state = StateEnum.s2;
        }
        else if (timesDipped == 3)
        {
            state = StateEnum.s3;
        }

        checkState();
    }

    public enum StateEnum
    {
        s1,
        s2,
        s3
    }

    public StateEnum state;

    private void checkState()
    {
        switch (state)
        {
            case StateEnum.s1: Song1(); break;
            case StateEnum.s2: Song2(); break;
            case StateEnum.s3: Song3(); break;

        }
    }

    private void Song1()
    {
        song1.volume = 0.3f;
        song2.volume = 0;
        song3.volume = 0;

    }

    private void Song2()
    {
        song1.volume = 0;
        song2.volume = 0.3f;
        song3.volume = 0;

    }

    private void Song3()
    {
        song1.volume = 0;
        song2.volume = 0;
        song3.volume = 0.3f;

    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = spawnPoint.transform.position;
        
        
    }

}
