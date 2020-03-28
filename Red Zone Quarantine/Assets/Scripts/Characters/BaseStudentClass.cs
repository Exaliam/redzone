using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStudentClass : BaseCharacterClass
{
    public BaseStudentClass()
    {
        CharacterClassName = "Student";
        CharacterClassDescription = "Young and fast";
        Speed = 1.8f;
        Health = 100;
        Hunger = 100;
        Antibody = 100;
    }
}
