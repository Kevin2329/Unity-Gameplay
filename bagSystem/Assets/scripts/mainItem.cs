using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Inventory/New mainItem",fileName ="New mainItem")]
public class mainItem : ScriptableObject 
{
    public List<item> items = new List<item>();
}