using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TNRD;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IJump> _jump;

    public void Initialize(IJump jump)
    {
        _jump = new SerializableInterface<IJump>();
        _jump.Value = jump;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            JumpControlActivated();
        }
    }

    public void JumpControlActivated()
    {
        _jump.Value.Jump();
    }
}
