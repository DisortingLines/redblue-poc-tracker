using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{
    [Min(0)]
    public int monObtained;

    public VersionAvailability gameSelected;

    public List<PokemonObject> choicesTaken;

    public GameObject[] bulbaHide, charHide, squirtHide, allChoices;

    public void AdjustCatchCount(bool isObtained)
    {
        switch(isObtained)
        {
            case true:
                {
                    monObtained += 1;
                    break;
                }
            case false:
                {
                    monObtained -= 1;
                    break;
                }
        }
    }

    public void HideChoices()
    {
        for(int i = 0; i > choicesTaken.Count; i++)
        {
            switch (choicesTaken[i].monName)
            {
                case "Bulbasaur":
                    {
                        HideChoicesBulbasaur();
                        break;
                    }
                case "Charmander":
                    {
                        HideChoicesCharmander();
                        break;
                    }
                case "Squirtle":
                    {
                        HideChoicesSquirtle();
                        break;
                    }
                case null:
                    {
                        ShowAllChoices();
                        break;
                    }
            }
        }
    }

    void HideChoicesBulbasaur() 
    {
        foreach (GameObject obj in bulbaHide)
            obj.SetActive(false);
    }
    void HideChoicesCharmander()
    {
        foreach (GameObject obj in charHide)
            obj.SetActive(false);
    }
    void HideChoicesSquirtle()
    {
        foreach (GameObject obj in squirtHide)
            obj.SetActive(false);
    }

    void ShowAllChoices()
    {
        foreach (GameObject obj in allChoices)
            obj.SetActive(true);
    }
}
