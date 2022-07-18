using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    private Vector2 _Movedir;
    private CharacterController _CharacterController;

    [SerializeField] private float _MovementSpeed;

    private void Awake()
    {
        _CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _CharacterController.Move(new Vector3(_Movedir.x, 0, _Movedir.y) * _MovementSpeed * Time.deltaTime);
    }
    public void Move(InputAction.CallbackContext context)
    {
        _Movedir = context.ReadValue<Vector2>();
    }
}
