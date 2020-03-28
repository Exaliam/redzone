using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGasmanClass : BaseCharacterClass
{
    public void GasmanClass()
    {
        CharacterClassName = "Gasman";
        CharacterClassDescription = "Fire and Blood";
        Speed = 1.5f;
        Health = 70;
        Hunger = 100;
        Antibody = 130;
    }
}
