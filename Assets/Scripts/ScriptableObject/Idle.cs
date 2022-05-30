using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New State",menuName ="EWGames/AbiltiyData/Idle")]
public class Idle : StateData
{
    public override void UpdateAbility(CharacterState characterState, Animator animator,AnimatorStateInfo stateInfo)
    {
        CharacterControl controller = characterState.GetCharacterController(animator);
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("running", true);
        }
    }
}
