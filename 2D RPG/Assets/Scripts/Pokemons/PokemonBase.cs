using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create a new pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] string frontSprite;
    [SerializeField] string backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;


    //Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }
 
    public int MaxHP
    {
        get { return maxHP; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Defense
    {
        get { return defense; }
    }

    public int SPAttack
    {
        get { return spAttack; }
    }

    public int SPDefense
    {
        get { return spDefense; }
    }

    public int Speed
    {
        get { return speed; }
    }
}

public enum PokemonType
{
    Normal,
    Fire,
    Water,
}
