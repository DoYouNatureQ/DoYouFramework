using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DoYouFramework;

public class TestOne : MonoBehaviour
{
    public CallMethod call = new CallMethod();
    // Start is called before the first frame update
    void Start()
    {
        call.Invoke(Test, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Test()
    {
        Debug.Log("TestOne");
    }
}
