using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadnator : MonoBehaviour {
    public string sceneToLoad;

	// Use this for initialization
	public void SceneLoad () {
        SceneManager.LoadScene(sceneToLoad);
		
	}

}
