using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentExample2 : MonoBehaviour
{
    private void Start()
    {
        GetComponent<CharacterJump>().JumpAction(Vector3.forward, 100);
    }
}
