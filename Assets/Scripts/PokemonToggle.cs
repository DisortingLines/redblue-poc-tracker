using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonToggle : MonoBehaviour
{
    public ProgressManager manager;
    public PokemonObject pokemonObject;
    public Image img;
    public Toggle toggle;

    private void Start()
    {
        toggle.isOn = pokemonObject.isObtained;

        ToggleObjectObtained(pokemonObject.isObtained);
    }

    public void ToggleObjectObtained(bool input)
    {
        pokemonObject.isObtained = input;

        switch(pokemonObject.isObtained)
        {
            case true:
                {
                    img.sprite = pokemonObject.checkedSprite;

                    manager.AdjustCatchCount(input);

                    switch (pokemonObject.isChoice)
                    {
                        case true:
                            {
                                manager.choicesTaken.Add(pokemonObject);
                                break;
                            }
                    }

                    break;
                }
            case false:
                {
                    img.sprite = pokemonObject.uncheckedSprite;

                    manager.AdjustCatchCount(input);

                    switch (pokemonObject.isChoice)
                    {
                        case true:
                            {
                                manager.choicesTaken.Remove(pokemonObject);
                                break;
                            }
                    }

                    break;
                }
        }
    }
}
