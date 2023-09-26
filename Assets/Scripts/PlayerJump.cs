using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour, IJump
{
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private float _jumpForce = 5f;

    public void Initialize(Rigidbody rigidbody)
    {
        _rb = rigidbody;
    }

    public void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
}
