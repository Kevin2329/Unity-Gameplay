using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagCanvas : MonoBehaviour
{
    private bool isPlaying = false;
    private CanvasGroup canvasGroup;
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            isPlaying = !isPlaying;
            if (isPlaying)
            {
                canvasGroup.alpha = 1;
            }
            else
            {
                canvasGroup.alpha = 0;
            }

        }
    }
}
