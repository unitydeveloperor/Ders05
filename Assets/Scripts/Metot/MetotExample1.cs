using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotExample1 : MonoBehaviour
{
    private string userName = "Orkun";
    private void Start()
    {
        Toplama();
        Test();
    }

    private void Toplama()
    {
        int number1 = 5;
        int number2 = 2;
        int result = number1 + number2;

        Debug.Log(result);
    }

    private void Test()
    {
        Debug.Log(userName);
    }
}
