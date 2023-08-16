using UnityEngine;

public class Calculator : MonoBehaviour
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
