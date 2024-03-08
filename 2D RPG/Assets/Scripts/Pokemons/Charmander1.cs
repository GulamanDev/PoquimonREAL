using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBase : ScriptableObject
{
    [SerializeField] string Charmander;

    [SerializeField] string frontSprite;
    [SerializeField] string backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;


    //Base Stats
    [SerializeField] int maxHP = 39;
    [SerializeField] int attack = 52;
    [SerializeField] int defense = 43;
    [SerializeField] int speed = 45;

    public string Name
    {
        get { return Charmander; }
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
