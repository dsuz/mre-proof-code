using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Manager : MonoBehaviour
{
	void Start ()
    {
        Debug.Log("Load Scene 1.");
        UnityEngine.SceneManagement.SceneManager.LoadScene("1");
	}
}
