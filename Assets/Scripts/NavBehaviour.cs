using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavBehaviour : MonoBehaviour
{
    public void LoadMyScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
