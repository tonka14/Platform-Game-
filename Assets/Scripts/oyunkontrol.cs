using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{    

    public PauseMenu PauseMenu;

    bool audioController = true;

    void Update()
    {
        // if (PauseMenu.GameIsPaused){
        //     GetComponent<AudioSource>().Pause();
        //     audioController = false;
        // }else if(!audioController)
        // {
        //     GetComponent<AudioSource>().Play();
        //     audioController = true;
        // }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        };
    }
}
