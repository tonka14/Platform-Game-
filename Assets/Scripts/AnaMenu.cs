using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    public void Basla()
    {
        SceneManager.LoadScene(1);
    }

    public void Cikis()
    {
        Application.Quit();
    }

}
