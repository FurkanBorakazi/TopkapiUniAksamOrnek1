using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Text _randomNumberText, _userListText;
    [SerializeField] InputField _username;
    Dictionary<string, int> _userList = new Dictionary<string, int>();
    int random;

    private void Start()
    {
        _username.text = PlayerPrefs.GetString("Username");
    }
    public void RandomTextOnClick()
    {
        random = Random.Range(1, 1000000);
        _randomNumberText.text = random.ToString();
    }

    public void SaveUserAndScore()
    {
        _userList.Add(PlayerPrefs.GetString("Username"), random);
    }

    public void GetUserList()
    {
        foreach (var item in _userList)
        {
            _userListText.text += "\n" + item.Key.ToString() + " " + item.Value.ToString();
        }

        //for (int i = 0; i < _userList.Count; i++)
        //{
        //    _userListText.text += "\n" + _userList[i].ToString();
        //}
    }

    public void ChangeUserOnClick()
    {
        PlayerPrefs.SetString("Username", _username.text);
    }

}
