using UnityEngine;
using System.Collections;

public class InputControl : MonoBehaviour
{
    private const float INPUT_MOVE_SPEED = 0.01F;

    // Update is called once per frame
    void Update()
    {
        if (null == ControlledPawn)
        {
            return;
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ControlledPawn.Walk(-INPUT_MOVE_SPEED);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ControlledPawn.Walk(INPUT_MOVE_SPEED);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            ControlledPawn.Crouch();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ControlledPawn.Skill(Pawn.eSkillFlag.JUMP);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            ControlledPawn.Skill(Pawn.eSkillFlag.ATTACK);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            ControlledPawn.Skill(Pawn.eSkillFlag.SKILL_Z);
        }
        if (Input.GetKey(KeyCode.X))
        {
            ControlledPawn.Skill(Pawn.eSkillFlag.SKILL_X);
        }
        if (Input.GetKey(KeyCode.C))
        {
            ControlledPawn.Skill(Pawn.eSkillFlag.SKILL_C);
        }
        if (Input.GetKey(KeyCode.V))
        {
            ControlledPawn.Skill(Pawn.eSkillFlag.SKILL_V);
        }
    }


    /**
     * Controllable Pawn
     */
    public Pawn ControlledPawn;
}
