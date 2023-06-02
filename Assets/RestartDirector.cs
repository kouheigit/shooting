using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartDirector : MonoBehaviour
{
    GameObject director;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //this.director.GetComponent<GameDirector>().Subremain();
            SceneManager.LoadScene("GameScene");
        }
    }
}
