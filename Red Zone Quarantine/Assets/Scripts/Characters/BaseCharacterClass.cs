using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    private string characterClassName;
    private string characterClassDescription;
    //Stats
    private float speed;
    private int health;
    private int hunger;
    private int antibody;

    public string CharacterClassName { get { return characterClassName; } set { characterClassName = value; } }
    public string CharacterClassDescription { get { return characterClassDescription; } set { characterClassDescription = value; } }
    public float Speed { get { return speed; } set { speed = value; } }
    public int Health { get { return health; } set { health = value; } }
    public int Hunger { get { return hunger; } set { hunger = value; } }
    public int Antibody { get { return antibody; } set { antibody = value; } }
}
