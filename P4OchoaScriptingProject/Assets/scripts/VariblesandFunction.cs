using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //create my interger variable
     public int myint = 5;

    // Start is called before the first frame update
    void Start()
    {
        //run my variable thru my function
        myint = MutiplyByTwo(myint);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //create the mutiply by two functions
    int MutiplyByTwo(int number)
    {
        //create local variable
        int result;

        //multiplying the num,ber by two
        result = number * 2;

        //return the value
        return result;

    }

}
