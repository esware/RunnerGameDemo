using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "EWGames/AbiltiyData/MoveForward")]
public class MoveForward : StateData
{
    private Vector3 move;

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float laneDistance = 1.5f; //The distance between tow lanes

    private int desiredLane = 1;//0:left, 1:middle, 2:right


    public override void UpdateAbility(CharacterState characterState, Animator animator,AnimatorStateInfo stateInfo)
    {
        CharacterControl controller = characterState.GetCharacterController(animator);
        if (controller.can == 0)
        {
            animator.SetBool("lose", true);
            animator.SetBool("running", false);
        }
        if (controller.isFinish)
        {
            animator.SetBool("win", true);
            animator.SetBool("running", false);
        }

        move.z = forwardSpeed;
        //Gather the inputs on which lane we should be
        Debug.Log("Desired Line :" + desiredLane);
        if (SwipeManager.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }
        if (SwipeManager.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }
        //Calculate where we should be in the future
        Vector3 targetPosition = controller.transform.position.z * controller.transform.forward + controller.transform.position.y * controller.transform.up;
        if (desiredLane == 0)
            targetPosition += Vector3.left * laneDistance;
        if (desiredLane == 2)
            targetPosition += Vector3.right * laneDistance;

        //controller.transform.position = targetPosition;
        if (controller.transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - controller.transform.position;
            Vector3 moveDir = diff.normalized * 10 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.magnitude)
                controller.GetComponent<CharacterController>().Move(moveDir);
            else
                controller.GetComponent<CharacterController>().Move(diff);
        }
        controller.GetComponent<CharacterController>().Move(move * Time.deltaTime);
    }
}
