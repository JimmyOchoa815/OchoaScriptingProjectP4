
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
      int myint = 5;

    void Start()
    {
       myint =  MultiplyByTwo(myint);
        Debug.Log(myint);
    }

        
    int MultiplyByTwo(int number)
    {
        
        int result;
        result = number * 2;
        return result;
    }
}
