using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DoYouFramework;

public class TestOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calls.GetInstance().Invoke(Test, 1f);
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
