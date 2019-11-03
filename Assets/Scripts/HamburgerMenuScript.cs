#pragma warning disable CS0649
using UnityEngine;

public class HamburgerMenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject mainImage, /*settings,*/ player/*, history*/;
        private void Awake()
    {
        this.gameObject.SetActive(false);
    }
    public void MainMenuButton()
    {
        mainImage.SetActive(true);
        this.gameObject.SetActive(false);
    }/*

    public void SettingsButton()
    {
        settings.SetActive(true);
        this.gameObject.SetActive(false);
    }*/

    public void PlayerStatsButton()
    {
        player.SetActive(true);
        this.gameObject.SetActive(false);
    }/*
    public void HistoryButton()
    {
        history.SetActive(true);
        this.gameObject.SetActive(false);
    }*/

}
