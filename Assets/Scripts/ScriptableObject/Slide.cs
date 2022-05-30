using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Slide", menuName = "EWGames/AbiltiyData/Slide")]
public class Slide : StateData
{
    public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
    {
        CharacterControl controller = characterState.GetCharacterController(animator);
        CharacterController character = controller.GetController(controller);

        controller.Slide();
        if (controller.slideEnd)
        {
            controller.slideEnd = false;
            animator.SetBool("sliding", false);
            animator.SetBool("running", true);
        }
    }
}
