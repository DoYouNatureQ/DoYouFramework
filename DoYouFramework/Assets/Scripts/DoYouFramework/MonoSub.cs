using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSub : MonoBehaviour
{
    public static MonoSub instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
