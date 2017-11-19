﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Load Scene: " + sceneName + ".");
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
