using UnityEngine;
using UnityEngine.UI;

public class RegisterBase
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RepeatPassword { get; set; }

  

    public void Register(Text _resultText)
    {
        PlayerPrefs.SetString("Email", Email);
        PlayerPrefs.SetString("Username", Username);
        PlayerPrefs.SetString("Password", Password);

      
        _resultText.text = "Kayýt Baþarýlý";
    }
}