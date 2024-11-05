using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;



    private int stapler;
    private int sellotape;



    // Start is called before the first frame update
    public void FruitMachine(int A,int B)
    {
        int answer;
        answer = A + B;
        Debug.Log("Fruit total: " + answer);
        
    }


    // Update is called once per frame
    void OfficeSort(int A,int B)
    {
        int answer;
        answer = A + B;
        Debug.Log("Office Supplies total: " + answer);
    }
}
