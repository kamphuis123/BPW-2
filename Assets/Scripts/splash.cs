using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour
{
    public AudioSource splish;

    private void OnCollisionEnter(Collision collision)
    {
        splish.Play();
    }
}
