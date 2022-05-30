using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Jump", menuName = "EWGames/AbiltiyData/Jump")]
public class Jump : StateData
{
    [SerializeField] private float jumpHeight;
    [SerializeField] private float gravity;
    Vector3 velocity;
    public override void UpdateAbility(CharacterState characterState, Animator animator,AnimatorStateInfo stateInfo)
    {
        CharacterControl controller = characterState.GetCharacterController(animator);
        velocity.y = Mathf.Sqrt(jumpHeight * 2 * -gravity);
        controller.GetComponent<CharacterController>().Move(velocity * Time.deltaTime);

        if (velocity.y >= -1)
        {
            animator.SetBool("jumping", false);
            if (!SwipeManager.swipeDown)
            {
                animator.SetBool("running", true);
            }
            else if (SwipeManager.swipeDown)
                animator.SetBool("sliding", true);
        }
    }

}
