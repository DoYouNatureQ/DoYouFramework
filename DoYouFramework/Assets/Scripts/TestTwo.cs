using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DoYouFramework;

public class TestTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CallMethod call = new CallMethod();
        call.Invoke(() => { Debug.Log("TestTwo"); }, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
