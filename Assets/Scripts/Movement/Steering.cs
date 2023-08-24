// using System;
// using InputControl;
// using UnityEngine;
//
// namespace Movement
// {
//     public class Steering : MonoBehaviour
//     {
//         public float maxSpeed;
//         public float maxForce;
//         public InputHandler inputHandler;
//         public new Rigidbody2D rigidbody2D;
//         private Vector2 _inputDirection;
//         public GameObject carSprite;
//         public float turn;
//
//         private void OnEnable()
//         {
//             inputHandler.inputChangedEvent.AddListener(OnInputChanged);
//         }
//
//         private void OnInputChanged(Vector2 inputDirection)
//         {
//             _inputDirection = inputDirection;
//         }
//
//         private void OnDisable()
//         {
//             inputHandler.inputChangedEvent.RemoveListener(OnInputChanged);
//         }
//
//         private void FixedUpdate()
//         {
//             var desiredVelocity = _inputDirection * maxSpeed;
//             var steeringForce = desiredVelocity - rigidbody2D.velocity;
//             steeringForce = Vector2.ClampMagnitude(steeringForce, maxForce);
//             var velocity = steeringForce * Time.deltaTime;
//             rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity + velocity, maxSpeed);
//             //transform.position += (Vector3) velocity;
//             carSprite.transform.up = Vector2.Lerp(transform.up, _inputDirection, turn * Time.deltaTime);
//             print(velocity);
//         }
//     }
// }