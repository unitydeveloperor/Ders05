using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample2 : MonoBehaviour
{
    public Calculator myCalculator;

    private void Start()
    {
        myCalculator.Toplama(5, 5);
    }
}
