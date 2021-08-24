using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHorizontalMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed;

    public void Move(Vector3 direction)
    {
        _characterController.Move(direction.normalized * _speed * Time.deltaTime);
    }
}
