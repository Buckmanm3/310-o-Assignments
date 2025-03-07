using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class DeathPotionUse : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(user.Stats.CurrentHealth * -1);
        return true;
    }
}
