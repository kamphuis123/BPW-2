using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMenu : MonoBehaviour
{
    public string Scene;
    private void OnEnable()
    {
        SceneManager.LoadScene(Scene);
    }
}
