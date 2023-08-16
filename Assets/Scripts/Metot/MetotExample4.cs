using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotExample4 : MonoBehaviour
{
    public List<int> myNumbers = new List<int>();
    public List<int> myNumbers2 = new List<int>();

    private void Start()
    {
        ForLoopExample(myNumbers);
        ForLoopExample(myNumbers2);

        WhileLoopExample();
    }

    private void ForLoopExample(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log("FOR LOOP Index : " + i + " FOR LOOP Value :" + list[i]);
        }

        Debug.Log("List Lenght : " + list.Count);
    }

    private void WhileLoopExample()
    {
        int counter = 0;
        while (counter < 10)
        {
            counter++;
            Debug.Log("WHILE LOOP :" + counter);
        }
    }
}
