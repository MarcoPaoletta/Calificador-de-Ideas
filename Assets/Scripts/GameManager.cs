using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ideaPrefab;
    public Canvas canvas;
    public Transform ideasContainer;

    public static int ideasCount;

    void InstantiateIdea()
    {
        Instantiate(ideaPrefab, ideasContainer);
    }

    public void AddButtonClicked()
    {
        ideasCount += 1;
        InstantiateIdea();
        for (int i = 0; i < ideasCount; i++) 
        {
            ideaPrefab.name = "Idea" + (i + 1);
        }
    }

    #region START()

    void LoadData()
    {
        GameData gameData = SaveManager.LoadData();
        ideasCount = gameData.ideasCount;
    }

    void CreateIdeas()
    {
        for (int i = 0; i < ideasCount; i++) 
        {
            InstantiateIdea();
            ideaPrefab.name = "Idea" + (i + 1);
        }
    }

    void Start()
    {
        LoadData();
        CreateIdeas();
    }

    #endregion

}
