using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePensionerClass : BaseCharacterClass
{
    public void PensionerClass()
    {
        CharacterClassName = "Pensioner";
        CharacterClassDescription = "Too old to understand";
        Speed = 1.5f;
        Health = 60;
        Hunger = 120;
        Antibody = 120;
    }
}
