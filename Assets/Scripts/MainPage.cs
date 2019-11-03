#pragma warning disable CS0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPage : MonoBehaviour
{
    [SerializeField]
    private GameObject startPanel;
    [SerializeField]
    private GameObject loginPanel;
    [SerializeField]
    private GameObject createAccount;

    private void Awake()
    {
        startPanel.SetActive(true);
    }
    private void Start()
    {
        loginPanel.SetActive(false);
        createAccount.SetActive(false);
    }
    private void Update()
    {
        if (CreateNewAccount.creatTrue)
        {
            createAccount.SetActive(false);
            startPanel.SetActive(true);
            CreateNewAccount.creatTrue = false;
        }

    }
    public void LoginPlayer()
    {
        loginPanel.SetActive(true);
        startPanel.SetActive(false);
    }
    public void CreateNewAccounts()
    {
        createAccount.SetActive(true);
        startPanel.SetActive(false);
    }
    public void MainLoginPage()
    {
        createAccount.SetActive(false);
        loginPanel.SetActive(false);
        startPanel.SetActive(true);
    }
}
