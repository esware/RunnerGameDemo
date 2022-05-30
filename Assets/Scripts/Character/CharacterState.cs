using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : StateMachineBehaviour
{
    public List<StateData> ListAbilityData = new List<StateData>();

    public void UpdateAll(CharacterState characterState,Animator animator, AnimatorStateInfo stateInfo)
    {
        foreach(StateData d in ListAbilityData)
        {
            d.UpdateAbility(characterState, animator,stateInfo);
        }
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        UpdateAll(this, animator,stateInfo);
    }

    private CharacterControl controller;
    public CharacterControl GetCharacterController(Animator animator)
    {
        if(controller == null)
        {
            controller = animator.GetComponentInParent<CharacterControl>();
        }
        return controller;
    }
}
