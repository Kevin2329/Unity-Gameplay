using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item : MonoBehaviour
{
    public Text CntText;
    public string Name, Description;
    public int Num;

    private int cnt = 1;

    private void Start()
    {
        cnt = 1;
        Debug.Log(Name + ' ' + cnt.ToString());
    }
    public void AddCount()
    {
        cnt++;
        CntText.text = cnt.ToString();
        Debug.Log(Name + ' ' + cnt.ToString());
    }
    public void display()
    {
        BagManager.Instance.DisplayInfo(this);
    }




}
