using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample1 : MonoBehaviour
{
    MyCalculator myCalculator = new MyCalculator();
    Calculator myCalculator2 = new Calculator();

    private void Start()
    {
        myCalculator.Toplama(5, 2);
        myCalculator.Cikarma(10, 5);

        myCalculator2.Toplama(5, 5);
        myCalculator2.Cikarma(20, 5);
    }
}

public class MyCalculator
{
    public void Toplama(int x, int y)
    {
        Debug.Log("TOPLAMA : " + (x + y));
    }

    public void Cikarma(int x, int y)
    {
        Debug.Log("CİKARMA : " + (x - y));
    }
}