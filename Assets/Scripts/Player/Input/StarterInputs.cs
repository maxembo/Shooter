using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.Input
{
    public class StarterInputs : MonoBehaviour
    {
        [Header("Character Input Values")]
        public Vector2 move;
        
        public void OnMove(InputValue value)
        {
            MoveInput(value.Get<Vector2>());
        }

        public void MoveInput(Vector2 newMoveDirection)
        {
            move = newMoveDirection;
        }
    }
}
