using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]  //创建快捷创建方法
public class item : ScriptableObject
{
    public Sprite itemImage;
    public string itemName;
    public int itemNub;
    [TextArea]
    public string itemInfo;
}
