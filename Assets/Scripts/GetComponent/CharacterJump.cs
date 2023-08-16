using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;

    public void JumpAction(Vector3 direction, float jumpPower)
    {
        rigidbody.AddForce(direction * jumpPower);
    }
}
