using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public Image gridImage;
    public Text num;

    public item item;
    public void gridOnClicked()
    {
        bagDisplayUI.displayItemInfo(item);
    }
}
