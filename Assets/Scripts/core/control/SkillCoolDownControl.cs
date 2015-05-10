using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillCoolDownControl : MonoBehaviour
{
    private Dictionary<Pawn.eSkillFlag, float[]> coolDowns;

    private void Start()
    {
        coolDowns = new Dictionary<Pawn.eSkillFlag, float[]>();

        coolDowns [Pawn.eSkillFlag.ATTACK] = new float[] {0, 0.3F};
        coolDowns [Pawn.eSkillFlag.JUMP] = new float[] {0, 1.0F};
        coolDowns [Pawn.eSkillFlag.SKILL_Z] = new float[] {0, 1.0F};
        coolDowns [Pawn.eSkillFlag.SKILL_X] = new float[] {0, 2.0F};
        coolDowns [Pawn.eSkillFlag.SKILL_C] = new float[] {0, 3.0F};
        coolDowns [Pawn.eSkillFlag.SKILL_V] = new float[] {0, 4.0F};
    }

    private void Update()
    {
        // each skills
        if (coolDowns [Pawn.eSkillFlag.ATTACK] [0] > 0)
        {
            coolDowns [Pawn.eSkillFlag.ATTACK] [0] -= Time.deltaTime;
        }

        if (coolDowns [Pawn.eSkillFlag.JUMP] [0] > 0)
        {
            coolDowns [Pawn.eSkillFlag.JUMP] [0] -= Time.deltaTime;
        }

        if (coolDowns [Pawn.eSkillFlag.SKILL_Z] [0] > 0)
        {
            coolDowns [Pawn.eSkillFlag.SKILL_Z] [0] -= Time.deltaTime;
        }

        if (coolDowns [Pawn.eSkillFlag.SKILL_X] [0] > 0)
        {
            coolDowns [Pawn.eSkillFlag.SKILL_X] [0] -= Time.deltaTime;
        }

        if (coolDowns [Pawn.eSkillFlag.SKILL_C] [0] > 0)
        {
            coolDowns [Pawn.eSkillFlag.SKILL_C] [0] -= Time.deltaTime;
        }

        if (coolDowns [Pawn.eSkillFlag.SKILL_V] [0] > 0)
        {
            coolDowns [Pawn.eSkillFlag.SKILL_V] [0] -= Time.deltaTime;
        }
    }

    public bool TrySkill(Pawn.eSkillFlag flag)
    {
        if (coolDowns [flag] [0] <= 0)
        {
            // reset cooldown timer
            coolDowns [flag] [0] = coolDowns [flag] [1];
            return true;
        }

        return false;
    }
}
