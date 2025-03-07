using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class speedAttack : Weapon.WeaponAttackEffect
{
    int attacks;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attacks++;
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        if (attacks == 2) {
            target.Damage(data);//if you hit the target enough you get an extra hit
            attacks = 0;
        }
    }
}
