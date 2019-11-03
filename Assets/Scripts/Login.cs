#pragma warning disable CS0649
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Login : MonoBehaviour
{
    public GameObject loginIn;
    public GameObject loginDaikide;
    private void Awake()
    {
        loginIn.SetActive(true);
        loginDaikide.SetActive(false);
    }
    ////[SerializeField]
    ////private GameObject password;
    //string userNameString;
    //string passwordString;
    //private void Update()
    //{
    //    userNameString = userName.GetComponent<InputField>().text;
    //    passwordString = password.GetComponent<InputField>().text;
    //}
    //public void LoginInAccount()
    //{
    //    if (userNameString == CreateNewAccount.userNameStringST && passwordString == CreateNewAccount.passwordStringST)
    //    {
    //        SceneManager.LoadScene(1);
    //    }
    //}
    public void LoginINSame()
    {
        loginDaikide.SetActive(true);
        loginIn.SetActive(false);
    }
    public void LoginThis()
    {
        SceneManager.LoadScene(1);
    }
}
