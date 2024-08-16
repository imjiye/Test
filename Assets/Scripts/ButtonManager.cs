using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject errorpopup;
   public void SceneLoad()
    {
        SceneManager.LoadScene("TestScene");
        Debug.Log("LoadScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("ExitGame");
    }

    public void ErrorPopup()
    {
        errorpopup.SetActive(true);
    }

    public void PopupOff()
    {
        errorpopup.SetActive(false);
    }
}