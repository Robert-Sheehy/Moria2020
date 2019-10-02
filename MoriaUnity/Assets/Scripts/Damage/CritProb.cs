using UnityEngine;

public class CritProb : MonoBehaviour
{
    bool canCrit = false, canGetHitBonus = true;
    //need script from other cs file for these stats
    int fightingAbility = 0,
        hitBonusOnItem = 0,
        hitBonusForDEX = 0,
        hitBonusForSTR = 0,
        monsterAC = 0,
        weightOfWeapon = 0,
        /////////////
        fightingAbilityAt0thLevel; //wtf ????
        ////////////

    //the below var are to be kept
    int hitBonusOnWeapon = 0,
        hitBonus = 0,
        chanceToCrit = 0;
    
    public void Start()
    {
        //calculates the chance to crit
        chanceToCrit = (((((((hitBonusOnWeapon +
                        hitBonusOnItem) +
                        hitBonusForDEX) +
                        hitBonusForSTR) *
                        5) +
                        fightingAbility) +
                        (weightOfWeapon * 10)) -
                        fightingAbilityAt0thLevel);

        //can it crit ?
        if (chanceToCrit < 1 && chanceToCrit > 5000)
        {
            canCrit = true;
        }

        //claculates hit bonus
        hitBonus = ((((((hitBonusOnWeapon +
                         hitBonusOnItem) +
                         hitBonusForDEX) +
                         hitBonusForSTR)) *
                         3) +
                         fightingAbility);

        //is the bonus hit number bigger then the monster AC
        if (hitBonus<1 && hitBonus < monsterAC)
        {
            canGetHitBonus = true;
        }
        else
        {
            canGetHitBonus = false;
        }
    }
}