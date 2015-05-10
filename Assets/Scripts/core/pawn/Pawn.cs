using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour
{
    // skills
    public enum eSkillFlag
    {
        ATTACK,
        JUMP,
        SKILL_Z,
        SKILL_X,
        SKILL_C,
        SKILL_V,
    }

    protected const float WALK_POWER = 1;
    protected const float FRICTION = 0.9F;
    private float _walkPower = 0;

    // controls cooldown time
    private SkillCoolDownControl skillCoolDownControl;


    // Initialize
    protected virtual void Start()
    {
        skillCoolDownControl = gameObject.AddComponent<SkillCoolDownControl> ();
    }

    protected virtual void Update()
    {
        transform.position += new Vector3(_walkPower, 0, 0);
        _walkPower *= FRICTION;
    }


    // Called by InputControl
    public void Walk(float amount)
    {
        _walkPower += amount;
    }

    public void Crouch()
    {
        Debug.Log("Crouch");
    }

    public void Skill(eSkillFlag flag)
    {
        UseSkill(flag);
    }

    protected void UseSkill(eSkillFlag flag)
    {
        if (skillCoolDownControl.TrySkill(flag))
        {
            // use skill
            Debug.Log(flag);
        }
    }
}
