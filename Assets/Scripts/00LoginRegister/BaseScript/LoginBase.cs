using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginBase
{
    public void Login(string Username, string Password, Text _resultText)
    {

        string TempUsername = PlayerPrefs.GetString("Username");
        string TempPassword = PlayerPrefs.GetString("Password");

        if (Username == TempUsername && Password == TempPassword)
        {
            _resultText.text = "Giriþ Baþarýlý";
            SceneManager.LoadScene(1);
        }
        else
            _resultText.text = "Kullanýcý bilgileri yanlýþ..";
    }





}
