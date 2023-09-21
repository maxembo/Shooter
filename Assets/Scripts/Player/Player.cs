using Player.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        
        private CharacterController _controller;
        private StarterInputs _input;
        private PlayerInput _playerInput;
        private float _verticalVelocity;

        private void Start()
        {
            _controller = GetComponent<CharacterController>();
            _input = GetComponent<StarterInputs>();
            _playerInput = GetComponent<PlayerInput>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 inputDirection = new Vector3(_input.move.x, 0.0f, _input.move.y).normalized;
            
            _controller.Move(inputDirection.normalized * (moveSpeed * Time.deltaTime) + 
                             new Vector3(0.0f,_verticalVelocity, 0.0f) * Time.deltaTime);
        }
    }
}
