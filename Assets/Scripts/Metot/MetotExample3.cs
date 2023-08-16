using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotExample3 : MonoBehaviour
{
    private void Start()
    {
        Toplama(2, 2);
        Cikarma(10, 2);
        Bolme(10, 3);
        Carpma(10, 10);
    }

    private void Toplama(int number1, int number2)
    {
        int result = number1 + number2;
        Debug.Log("Toplama : " + result);
    }

    private void Cikarma(int number1, int number2)
    {
        int result = number1 - number2;
        Debug.Log("Cikarma : " + result);
    }

    private void Bolme(int number1, int number2)
    {
        float result = number1 / number2;
        Debug.Log("Bolme : " + result);
    }

    private void Carpma(int number1, int number2)
    {
        int result = number1 * number2;
        Debug.Log("Carpma : " + result);
    }
}
