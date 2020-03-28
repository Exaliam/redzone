using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHypochondriacClass : BaseCharacterClass
{
    public void HypochondriacClass()
    {
        CharacterClassName = "Hypochondriac";
        CharacterClassDescription = "ETCIÙ";
        Speed = 1.5f;
        Health = 150;
        Hunger = 100;
        Antibody = 50;
    }
}
