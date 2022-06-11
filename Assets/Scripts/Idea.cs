using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idea : MonoBehaviour
{
    public Dropdown dropdown;
    public InputField inputField;

    public int dropdownValue;
    public string inputFieldText;

    void Start()
    {
        LoadData();
    }

    void Update()
    {
        SaveData();
    }

    void LoadData()
    {
        GameData gameData = SaveManager.LoadData();
        dropdownValue = gameData.dropdownValue;
        inputFieldText = gameData.inputFieldText;
        dropdown.value = gameData.dropdownValue;
        inputField.text = gameData.inputFieldText;
    }

    void SaveData()
    {
        dropdownValue = dropdown.value;
        inputFieldText = inputField.text;
        SaveManager.SaveData(this);
    }
}
