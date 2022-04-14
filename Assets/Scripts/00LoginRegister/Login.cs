using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField] InputField _username, _password;
    LoginBase _loginBase = new LoginBase();
    [SerializeField] Text _resultText;

    public void LoginOnClick()
    {
        _loginBase.Login(_username.text, _password.text, _resultText);
    }
  
}
