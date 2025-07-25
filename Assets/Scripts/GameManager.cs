using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum Animals
{
    Ant = 0,
    Bat,
    Bear,
    Bee,
    Bug,
    Bird,
    Butterfly,
    Cat,
    Chicken,
    Fish,
    Cow,
    Deer,
    Dog,
    Dragonfly,
    Duck,
    Falcon,
    Fly,
    Grasshopper
}

public struct AnimalProperties
{
    public bool Flying;
    public bool Insect;
    public bool Omnivorous;
    public bool LivesInGroup;
    public bool LaysEggs;

    public string Description;
}