using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private EventKicker m_eventKicker;
    [SerializeField] private GameObject m_go;

	void Start ()
    {
        Debug.Log("Deactivate m_go.");
        m_go.SetActive(false);
        Debug.Log("Add Event Handler.");
        EventKicker.Kick += EventHandler;
	}

    void EventHandler()
    {
        m_go.SetActive(true);
    }

    private void OnDestroy()
    {
        EventKicker.Kick -= EventHandler;
    }
}
