using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
        if (col.name == "env_tree2" || col.name == "env_tree1" || col.name == "env_tree3")
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        Debug.Log("Loading Dead Garden");
        SceneManager.LoadScene("Scenes/dead_garden", LoadSceneMode.Single);
    }
}
