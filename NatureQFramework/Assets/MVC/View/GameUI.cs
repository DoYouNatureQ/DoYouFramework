using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI<T> where T : Text
{
    public string newtext;
    public Button newbtn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public T UpdateUI(T _ui)
    {
        return _ui;
    }
}
