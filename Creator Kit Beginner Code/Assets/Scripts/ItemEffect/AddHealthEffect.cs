using System.Collections;
using System.Collections.Generic;
using CreatorKitCode;
using UnityEngine;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HealthAmount;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthAmount);
        return true;
    }
}