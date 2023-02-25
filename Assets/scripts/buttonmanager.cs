using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonmanager : MonoBehaviour
{

    enum Button { Sample, openPref, closePref, newTaskDone, newTask, quit };
    [SerializeField] Button buttonType;

    [SerializeField] GameObject preferencesPanel;
    [SerializeField] GameObject newTaskPanel;
    [SerializeField] TMP_InputField TaskName;
    [SerializeField] GameObject newTask;
    [SerializeField] Transform contentTransform;

    public void buttonPressed()
    {
        if(buttonType == Button.Sample)
        {
            Debug.LogWarning("GameObject: " + gameObject.name + " has been clicked, but has no function assigned");
        } else if (buttonType == Button.openPref) {
            Debug.Log("Open Preferences");
            preferencesPanel.SetActive(true);
        } else if (buttonType == Button.closePref) {
            Debug.Log("Close Preferences");
            preferencesPanel.SetActive(false);
        } else if (buttonType == Button.newTaskDone) {
            Debug.Log("New Task Done");
            GameObject newObject = Instantiate(newTask);
            newObject.transform.SetParent(contentTransform, false);
            TextMeshProUGUI label = newObject.GetComponentInChildren<TextMeshProUGUI>();
            label.text = TaskName.text;
            Debug.Log("New Task: " + TaskName.text + " has been created");
            TaskName.text = "";
            newTaskPanel.SetActive(false);
        } else if (buttonType == Button.newTask) {
            Debug.Log("New Task");
            newTaskPanel.SetActive(true);
        } else if (buttonType == Button.quit) {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
