using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    #region Auth
    public void GotoSignUp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SignUp");
    }
    public void GotoLogin()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Login");
    }
    #endregion

    #region UI Button

    public void GotoLobby()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lobby");
    }
    public void GotoGameMap()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameMap");
    }
    public void GotoQuest()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Quest");
    }
    public void GotoAlbum()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Album");
    }
    public void GotoShop()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Shop");
    }

    #endregion
}
