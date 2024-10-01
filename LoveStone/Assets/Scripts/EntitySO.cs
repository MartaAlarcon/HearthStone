using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "ScriptableEntity", menuName = "ScriptableObjects/Entity")]

public class EntitySO : ScriptableObject
{
    public string Name;
    public Sprite Design;
    public string Description;
    public Sprite Border;
    
}
