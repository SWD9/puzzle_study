using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.anyKey)
        {
            Invoke("ChangeScene", 1.0f);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
