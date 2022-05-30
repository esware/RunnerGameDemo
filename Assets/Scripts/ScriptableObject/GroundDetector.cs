using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GroundDetector", menuName = "EWGames/AbiltiyData/GroundDetector")]
public class GroundDetector : StateData
{
    [SerializeField] private LayerMask groundLayer;
    [Range(0.01f, 1f)]
    [SerializeField] private float CheckTime;
    Vector3 velocity;

    public override void UpdateAbility(CharacterState characterState, Animator animator,AnimatorStateInfo stateInfo)
    {
        CharacterControl control = characterState.GetCharacterController(animator);
            if (IsGrounded(control))
            {
                if(velocity.y < 0)
                {
                    velocity.y = -1f;
                }
                if (SwipeManager.swipeUp)
                {
                    animator.SetBool("jumping", true);
                    animator.SetBool("running",false);
                }
                if (SwipeManager.swipeDown)
                {
                    animator.SetBool("sliding", true);
                    animator.SetBool("running", false);
                velocity.y = -10f;
            }
            }
            else
            {
                velocity.y += -15f * Time.deltaTime;
                control.GetComponent<CharacterController>().Move(velocity*Time.deltaTime);
            
            }
    }

    bool IsGrounded(CharacterControl control)
    {
        bool isGrounded = Physics.CheckSphere(control.transform.position, 0.17f, groundLayer);

        return isGrounded;
    }
}
