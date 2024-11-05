using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

public class VairblesAndFunctions : MonoBehaviour
{
    //Creat a vairable of type int and set it tto number 5 
    int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo(int number)
    {



        int result;
        result = number * 2;
        return result;
    }
}


