using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    [SerializeField] InputField _username, _email, _password, _repeatPassword;
    RegisterBase _registerBase = new RegisterBase();
    [SerializeField] Text _resultText;
    [SerializeField] Button _registerButton;

    //[SerializeField] string _usernameSt, _emailSt, _passwordSt;

    //private void Start()
    //{
    //    _usernameSt = PlayerPrefs.GetString("Username");
    //    _emailSt = PlayerPrefs.GetString("Email");
    //    _passwordSt = PlayerPrefs.GetString("Password");
    //}

    public void InputControllers()
    {
        if (_username.text.Length< 5 || _password.text != _repeatPassword.text || _password.text.Length <6 || _email.text.IndexOf('@') <0 || _email.text.IndexOf('.') < 0 )
        {
            _registerButton.interactable = false;
        }
        else
        {
            _registerButton.interactable = true;

        }

    }

    public void RegisterOnClick()
    {
        _registerBase.Username = _username.text;
        _registerBase.Email = _email.text;
        _registerBase.Password = _password.text;
        _registerBase.RepeatPassword = _repeatPassword.text;

        _registerBase.Register(_resultText);
    }

    
}
