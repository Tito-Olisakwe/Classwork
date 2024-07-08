using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Custom Scriptable Object", menuName = "Scriptable/Object/Custom")]
public class ScriptableTest : ScriptableObject
{
    public string name;
    public Texture objIcon;
}
