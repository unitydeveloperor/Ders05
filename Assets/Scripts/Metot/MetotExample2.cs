using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotExample2 : MonoBehaviour
{
    private void Start()
    {
        Toplama(5, 5);
    }

    private void Toplama(int number1, int number2)
    {
        int result = number1 + number2;
        Debug.Log(result);
    }
}
