using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RomansRoadSceneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
        if (col.name == "Capsule")
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        Debug.Log("Loading Dead Garden");
        SceneManager.LoadScene("Scenes/alive_garden", LoadSceneMode.Single);
    }
}
