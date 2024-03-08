using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBase : ScriptableObject
{
    [SerializeField] string Bulbasaur;

    [SerializeField] string frontSprite;
    [SerializeField] string backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;


    //Base Stats
    [SerializeField] int maxHP = 45;
    [SerializeField] int attack = 49;
    [SerializeField] int defense = 49;
    [SerializeField] int speed = 45;

    public string Name
    {
        get { return Bulbasaur; }
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
