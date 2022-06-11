[System.Serializable]

public class GameData
{
    public int dropdownValue;
    public int ideasCount;
    public string inputFieldText;

    public GameData(Idea idea)
    {
        dropdownValue = idea.dropdownValue;
        inputFieldText = idea.inputFieldText;
        ideasCount = GameManager.ideasCount;
    }
}
