using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardInput : MonoBehaviour
{
    [SerializeField] private CharacterHorizontalMovement _characterMovement;

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        movement.x = transform.right.x * Input.GetAxis(Axis.Horizontal);
        movement.z = transform.forward.z * Input.GetAxis(Axis.Vertical);

        _characterMovement.Move(movement);
    }
}
