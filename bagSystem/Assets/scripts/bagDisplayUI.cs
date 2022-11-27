using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagDisplayUI : MonoBehaviour
{
    static bagDisplayUI BagDisplayUI;
    private void Awake()
    {
        if(BagDisplayUI != null)
        {
            Destroy(this);
        }
        BagDisplayUI = this;
    }//单例模式
    private void OnEnable()
    {
        updateItemToUI();
        BagDisplayUI.information.text = "";
    }
    public mainItem mainItem;
    public Grid gridPrefab;
    public GameObject bag;
    public Text information;
    public static void insertItemToUI(item item)
    {

        Grid grid = Instantiate(BagDisplayUI.gridPrefab, BagDisplayUI.bag.transform);
        grid.gridImage.sprite = item.itemImage;
        grid.num.text = item.itemNub.ToString();
        grid.item = item;

    }
    public static void displayItemInfo(item item)
    {
        BagDisplayUI.information.text = item.itemInfo;
    }

    /// <summary>
    /// 将背包数据仓库中所有物体显示在UI上
    /// </summary>
    public static void updateItemToUI()
    {
        for (int i = 0; i < BagDisplayUI.bag.transform.childCount; i++)
        {
            Destroy(BagDisplayUI.bag.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < BagDisplayUI.mainItem.items.Count; i++)
        {
            insertItemToUI(BagDisplayUI.mainItem.items[i]);
        }
    }

}
