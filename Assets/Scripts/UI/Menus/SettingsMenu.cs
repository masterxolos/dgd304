using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : Menu
{
    public Button closeButton;
    public Button toggleMusicButton;
    private bool isSoundOn = true;

    protected override void OnInitialize()
    {
        closeButton.onClick.AddListener(OnCloseButtonClicked);
        toggleMusicButton.onClick.AddListener(OnToggleMusicButtonClicked);
    }

    private void OnCloseButtonClicked()
    {
        menuManager.Hide<SettingsMenu>();
    }

    private void OnToggleMusicButtonClicked()
    {
        if (isSoundOn)
        {
            Camera.main.GetComponent<AudioSource>().Pause();
            isSoundOn = false;
        }
        else
        {
            Camera.main.GetComponent<AudioSource>().Play();
            isSoundOn = true;
        }
    }
}
