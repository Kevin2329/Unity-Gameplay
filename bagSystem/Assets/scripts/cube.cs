using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public item Item;
    public mainItem  mainItem;
    public bagDisplayUI bagDisplayUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Player"){ 
            if (!mainItem.items.Contains(Item))
            {
                mainItem.items.Add(Item);
            }
            Item.itemNub+=1;
            bagDisplayUI.updateItemToUI();
            Destroy(this.gameObject);
        }
    }
}
