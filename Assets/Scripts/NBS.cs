using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public void LoadMyScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void LoadMyScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
