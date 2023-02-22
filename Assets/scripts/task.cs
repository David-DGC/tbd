using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class task : MonoBehaviour
{
    TextMeshProUGUI text;
    Image BgImage;
    Image checkImage;

    void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        BgImage = GetComponentInChildren<Image>();
        checkImage = GetComponentInChildren<Image>();
        text.color = new Color (1f, 1f, 1f, 1f);
        BgImage.color = new Color (1f, 1f, 1f, 1f);
    }

    public void completeTask()
    {
        Destroy(gameObject);
    }

}