using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataManager : MonoBehaviour
{
    public static PlayerDataManager Instance;

    public string PlayerName;

    public InputField InputField;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void NewPlayerNameEntered()
    {
        Instance.PlayerName = InputField.text;
    }
}
