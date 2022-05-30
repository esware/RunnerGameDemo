using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Data", menuName ="EWGames/CharacterController/Data/MovementData")]
public class MovementInputData : ScriptableObject
{
    private bool running;
    private bool sliding;
    private bool jumping;
    private bool moveRight;
    private bool moveLeft;



    public bool Running { get => running; set => running = value; }
    public bool Sliding { get => sliding; set => sliding = value; }
    public bool Jumping { get => jumping; set => jumping = value; }
    public bool MoveLeft { get => moveLeft; set => moveLeft = value; }
    public bool MoveRight { get => moveRight; set => moveRight = value; }


}
