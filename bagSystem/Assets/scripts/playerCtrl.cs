using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    public float speed;
    private Vector3 v;
    public GameObject bagUI;
    private void Awake()
    {
        bagUI.SetActive(false);
    }
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        v=new Vector3(x,0,y);
        transform.Translate(v*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.B))
        {
            bagUI.SetActive(!bagUI.activeSelf); 
        }
    }

}
