using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceFilter : MonoBehaviour
{
    public GameObject[] choicesToToggle;

    public PokemonToggle toggle;

    private void Start()
    {
        bool tgl = toggle.pokemonObject.isObtained;

        ToggleChoices(tgl);
    }

    public void ToggleChoices(bool isActive)
    {
        Debug.Log("Toggling...");
        foreach(GameObject obj in choicesToToggle)
        {
            obj.SetActive(isActive);
        }
    }
}
