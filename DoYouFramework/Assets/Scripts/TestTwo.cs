using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DoYouFramework;

public class TestTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calls.GetInstance().Invoke(() => { Debug.Log("TestTwo"); }, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
