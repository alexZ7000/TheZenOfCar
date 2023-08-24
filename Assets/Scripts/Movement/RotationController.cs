using InputControl;
using UnityEngine;

namespace Movement
{
    public class RotationController : MonoBehaviour
    {
        public float turnSpeed; //rps
        public InputHandler inputHandler;
        public new Rigidbody2D rigidbody2D;
        private Vector2 _inputDirection;
        public float turn; //grau de rotação
        public Transform carTransform;
        public VelocityController velocityController;

        void Update()
        {
            turn = turn -turnSpeed * Time.deltaTime * _inputDirection.x * velocityController.speed / velocityController.maxSpeed;
            rigidbody2D.SetRotation(Quaternion.Euler(0, 0, turn));
        }
        
        private void OnEnable()
        {
            inputHandler.inputChangedEvent.AddListener(OnInputChanged);
        }

        private void OnInputChanged(Vector2 inputDirection)
        {
            _inputDirection = inputDirection;
        }

        private void OnDisable()
        {
            inputHandler.inputChangedEvent.RemoveListener(OnInputChanged);
        }
    }
}