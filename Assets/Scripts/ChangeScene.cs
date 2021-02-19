using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string sceneName; //[SerializeField] allows you to see private variables in the editor without making them public

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Loading Scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
        
    }
}