using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[AddComponentMenu("DoYouFreamworkTools/TextTranslation_TMP")]
public class TextTranslation_TMP : MonoBehaviour
{
    //使用tmp
    TMP_Text m_Text;
    private void OnEnable()
    {
        m_Text = GetComponent<TMP_Text>();

        m_Text.text = this.gameObject.name.ToString();

        Debug.Log("OnEnable:" + m_Text.text);
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
