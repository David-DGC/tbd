using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class task : MonoBehaviour
{
    TextMeshProUGUI text;
    public static string taskName = "Task Name";

    void Awake()
    {

        GameObject label = GameObject.Find("Label");
        TextMeshProUGUI text = label.GetComponent<TextMeshProUGUI>();
        text.text = taskName;
    }

    public void completeTask()
    {
        Debug.Log(text.text + " has been completed");
        text.color = new Color (1,1,1, 0.5f);
    }
}
