using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotExample5 : MonoBehaviour
{
    public List<string> myEnemys = new List<string>();

    private void Start()
    {
        if (CheckEnemyCount(myEnemys))
        {
            Debug.Log("LEVEL COMPLETED!");
        }
        else
        {
            Debug.Log("LEVEL CONTINUE");
        }

        Debug.Log(Result(10, 5));
    }

    private bool CheckEnemyCount(List<string> enemyList)
    {
        bool state;

        if (enemyList.Count < 1)
        {
            state = true;
        }
        else
        {
            state = false;
        }

        return state;
    }

    private int Result(int number1, int number2)
    {
        return number1 + number2;
    }
}
