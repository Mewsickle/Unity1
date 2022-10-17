using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    [Header("Levels to load")]
    [SerializeField] string _newGameLevel;
    [SerializeField] string _levelToLoad;
    
    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);

    }

    public void LoadGameDialogYes()
    {
        SceneManager.LoadScene(_levelToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
