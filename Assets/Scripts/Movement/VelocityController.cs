using InputControl;
using UnityEngine;
using UnityEngine.Events;

namespace Movement
{
    public class VelocityController : MonoBehaviour
    {
        public float acceleration;
        public InputHandler inputHandler;
        public new Rigidbody2D rigidbody2D;
        private Vector2 _inputDirection;
        public float speed => rigidbody2D.velocity.magnitude * Mathf.Sign(Vector2.Dot(rigidbody2D.velocity, carTransform.up));
        public Transform carTransform;
        public float maxSpeed;
        public float desaceleration;
        public UnityEvent<bool> criticalVelocityReachedEvent;
        [Range(0f, 1f)]public float criticalPercent = .9f;
        public bool isCritical;
        

        void Update()
        {
            
            var localSpeed = speed - desaceleration * Time.deltaTime * Mathf.Sign(speed);
            localSpeed = localSpeed + acceleration * Time.deltaTime * _inputDirection.y;
            localSpeed = Mathf.Clamp(localSpeed, -maxSpeed, maxSpeed);
            rigidbody2D.velocity = carTransform.up * localSpeed;
            
            var wasCritical = isCritical;
            isCritical = localSpeed / maxSpeed >= criticalPercent;
            if (wasCritical != isCritical)
            {
                criticalVelocityReachedEvent.Invoke(isCritical);
                
            }
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