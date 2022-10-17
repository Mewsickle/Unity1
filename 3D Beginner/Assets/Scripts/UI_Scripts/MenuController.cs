using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuControllerScript : MonoBehaviour
{
    [Header("Levels to load")]
    [SerializeField] string _newGameLevel;
    [SerializeField] string _level1ToLoad;
    [SerializeField] string _level2ToLoad;
    [SerializeField] string _level3ToLoad;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);

    }

    public void LoadGame1DialogYes()
    {
        SceneManager.LoadScene(_level1ToLoad);
    }
    public void LoadGame2DialogYes()
    {
        SceneManager.LoadScene(_level2ToLoad);
    }
    public void LoadGame3DialogYes()
    {
        SceneManager.LoadScene(_level3ToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
