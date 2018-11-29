using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AliveGardenScript : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
        if (col.name == "RestartText")
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        Debug.Log("Loading Start Scene");
        SceneManager.LoadScene("Scenes/start_scene", LoadSceneMode.Single);
    }
}
