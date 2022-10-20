using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuControllerScript : MonoBehaviour
{
    [Header("Volume settings")]
    [SerializeField] TMP_Text volumeTextValue;
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 1.0f;

    [SerializeField] GameObject confirmationPrompt;


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

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = volume.ToString("0.0");
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
        //show prompt
    }
    
    public void ResetBtn(string MenuType)
    {
        if(MenuType == "Audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeTextValue.text = defaultVolume.ToString("0.0");
            VolumeApply();
        }
    }

    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
