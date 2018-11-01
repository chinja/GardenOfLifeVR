using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadGardenScript : MonoBehaviour {

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    public bool entered_tomb = false;

    // Use this for initialization
    /*
    void Start () {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }
    */
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name);
        if (col.name == "tomb_stone")
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        Debug.Log("Loading Alive Garden");
        SceneManager.LoadScene("Scenes/alive_garden", LoadSceneMode.Single);
    }
}
