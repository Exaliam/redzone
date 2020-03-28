using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickpocketClass : BaseCharacterClass
{
    public void PickpocketClass()
    {
        CharacterClassName = "Pickpocket";
        CharacterClassDescription = "You can't see me";
        Speed = 1.5f;
        Health = 80;
        Hunger = 120;
        Antibody = 100;
    }
}
