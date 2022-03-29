using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    public void Loadcene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
