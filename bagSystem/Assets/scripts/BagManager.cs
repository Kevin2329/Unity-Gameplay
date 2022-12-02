using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BagManager : MonoBehaviour
{
    public GameObject GridParent;
    public Text InfoText;
    private HashSet<int> set;

    private BagManager() { }
    private static BagManager instance;
    public static BagManager Instance
    {
        get
        {
            return instance;
        }
        private set { }
    }
    private void Awake()
    {
        instance = this;
        set = new HashSet<int>();
    }


    public void AddItem(GameObject item)
    {
        item info = item.GetComponent<item>();
        if (set.Contains(info.Num))
        {
            info.AddCount();
        }
        else
        {
            set.Add(info.Num);
            var obj = GameObject.Instantiate(item);
            obj.transform.parent = GridParent.transform;
        }
    }
    public void DisplayInfo(item i)
    {
        InfoText.text = i.Description;

    }

}
