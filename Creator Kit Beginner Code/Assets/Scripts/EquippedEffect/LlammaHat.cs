using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting;

public class LlammaHat : EquipmentItem.EquippedEffect
{
    public GameObject prefab;
    GameObject llama;

    public override void Equipped(CharacterData user)
    {

    }

    public override void Removed(CharacterData user) { }
}
