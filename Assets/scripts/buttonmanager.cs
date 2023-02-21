using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonmanager : MonoBehaviour
{

    enum Button { Sample, openPref, closePref, quit };
    [SerializeField] Button buttonType;

    [SerializeField] GameObject preferencesPanel;

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
        } else if (buttonType == Button.quit) {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
