using System;
using System.Collections;
using UnityEngine;

#if UNITY_WSA && !UNITY_EDITOR
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
#endif

public class ToastNotificationScript : MonoBehaviour
{
    public int notificationHour = 12;
    public int notificationMinute = 0;
    public string toastTitle = "Notification Title";
    public string toastMessage = "Notification Message";

    private void Start()
    {
        StartCoroutine(CheckTime());
    }

    private IEnumerator CheckTime()
    {
        while (true)
        {
            DateTimeOffset currentTime = DateTimeOffset.Now;
            DateTimeOffset toastTime = new DateTimeOffset(currentTime.Year, currentTime.Month, currentTime.Day, notificationHour, notificationMinute, 0, currentTime.Offset);

            if (currentTime >= toastTime)
            {
                ShowToast(toastTitle, toastMessage);
                break;
            }

            yield return new WaitForSeconds(60);
        }
    }

    private void ShowToast(string title, string message)
    {
        #if UNITY_WSA && !UNITY_EDITOR
        ToastTemplateType toastTemplate = ToastTemplateType.ToastText02;
        XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);

        XmlNodeList toastTextElements = toastXml.GetElementsByTagName("text");
        toastTextElements[0].AppendChild(toastXml.CreateTextNode(title));
        toastTextElements[1].AppendChild(toastXml.CreateTextNode(message));

        ToastNotification toast = new ToastNotification(toastXml);
        ToastNotificationManager.CreateToastNotifier().Show(toast);
        #endif
    }
}
