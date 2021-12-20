using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PokemonData", menuName ="Scriptable Objects/New Pokémon Data")]
public class PokemonObject : ScriptableObject
{
    public int dexNo;
    public string monName;
    public int evoLevel;
    public VersionAvailability exclusivity;
    public bool isObtained;
    public Sprite uncheckedSprite, checkedSprite;
    public bool isChoice;
}

public enum VersionAvailability
{
    Red,
    Blue,
    Both
}