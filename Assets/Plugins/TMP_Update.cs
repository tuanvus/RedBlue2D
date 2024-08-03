using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class TMP_Update : MonoBehaviour
{
    [SerializeField] TMP_FontAsset _FontAsset;
    [SerializeField]
    TextMeshProUGUI[] textMeshProGuiArray;
    private void OnEnable()
    {
        textMeshProGuiArray = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI textMeshProGui in textMeshProGuiArray)
        {
            Debug.Log("TextMeshPro GUI: " + textMeshProGui.name);
            textMeshProGui.font = _FontAsset;
            //textMeshProGui.UpdateFontAsset();
        }
    }
    void Start()
    {
       
    }

   
}
