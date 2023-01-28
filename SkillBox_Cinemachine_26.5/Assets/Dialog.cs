using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TMP_Text TextGameObject;
    private string text;

    private void Start()
    {
        
    }

    public void Test(string text)
    {
        //text = TextGameObject.text;
        this.text = text;
        TextGameObject.text = "";
        StartCoroutine(TextCoroutine());
    }

    IEnumerator TextCoroutine()
    {
        foreach (char abc in text)
        {
            TextGameObject.text += abc;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
