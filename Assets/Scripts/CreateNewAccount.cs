using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateNewAccount : MonoBehaviour
{
    public GameObject email;
    public GameObject userName;
    public GameObject password;
    public GameObject passwordVerification;
    // public GameObject country;
    // public GameObject city;
    private string emailString;
    private string userNameString;
    private string passwordString;
    private string passwordStringVerify;
    public static string emailStringST = "n.meladzejaiani@gmail.com";
    public static string userNameStringST = "nmj";
    public static string passwordStringST = "nmj";
    public static bool creatTrue = false;

    private void Update()
    {
        emailString = email.GetComponent<InputField>().text;
        userNameString = userName.GetComponent<InputField>().text;
        passwordString = password.GetComponent<InputField>().text;
        passwordStringVerify = passwordVerification.GetComponent<InputField>().text;
    }
    public void Register()
    {
        emailStringST = emailString;
        userNameStringST = userNameString;
        passwordStringST = passwordString;
        if (emailString != "" && userNameString != "" && passwordString != "" &&
            passwordStringVerify != "" && passwordStringVerify == passwordString)
            print("Yeah");
        creatTrue = true;
    }
}
