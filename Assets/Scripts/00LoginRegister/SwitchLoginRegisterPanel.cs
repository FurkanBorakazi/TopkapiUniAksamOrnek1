using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLoginRegisterPanel : MonoBehaviour
{

    [SerializeField] GameObject _loginPanel, _RegisterPanel;

    private void Start()
    {
        SwicthPanel();
    }
    public void SwicthPanel()
    {
        switch (_RegisterPanel.activeInHierarchy)
        {
            case true:
                _RegisterPanel.SetActive(false);
                _loginPanel.SetActive(true);
                break;
            case false:
                _RegisterPanel.SetActive(true);
                _loginPanel.SetActive(false);
                break;
        }
    }
}
