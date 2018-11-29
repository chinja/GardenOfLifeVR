using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void changeScene()
    {
        // Changes to Game Scene.
        Debug.Log("Change Scene.");
        SceneManager.LoadScene("dead_garden");
    }
}
