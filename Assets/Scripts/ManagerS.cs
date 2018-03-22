using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerS : MonoBehaviour
{
    private GameObject _target;
    
    
    public void LoadScene()
    {
        SceneManager.LoadScene("Main");

    }

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (_target == null)
        {
            LoadScene();
        }
    }
}
