using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataRetrieval : MonoBehaviour
{
    [SerializeField] private ScriptableTest myScriptableObj;
    [SerializeField] private RawImage objIcon;
    [SerializeField] private TMP_Text titleText;

    public void Generate()
    {
        objIcon.texture = myScriptableObj.objIcon;
        titleText.text = myScriptableObj.name;
    }
}
