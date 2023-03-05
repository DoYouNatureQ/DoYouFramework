using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("DoYouFreamworkTools/TextTranslation")]
public class TextTranslation : MonoBehaviour
{
    //使用text(old)
    Text m_Text;
    private void OnEnable()
    {
        m_Text = GetComponent<Text>();

        m_Text.text = this.gameObject.name.ToString();

        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
