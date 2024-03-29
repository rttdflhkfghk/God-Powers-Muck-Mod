﻿using System.Diagnostics;
using UnityEngine;

namespace announcementsPopout
{
    public class popoutUI
    {
        public static string annoucementText = "";
        public static string annoucementTitle = "";
    }
    public class InGameUI : MonoBehaviour
    {
        //type of annoucment
        public static bool newVersion = false;
        public static bool normalAnnouncement = false;
        //text
        public static string annoucementText = "";
        public static string annoucementTitle = "";
        public static void Window(int windowID)
        {
            GUI.Label(new Rect(5, 20, 215, 200), annoucementText);
            if (normalAnnouncement)
            {
                if (GUI.Button(new Rect(1, 200, 220, 20), "Close"))
                {
                    normalAnnouncement = false;
                }
            }
            if (newVersion)
            {
                if (GUI.Button(new Rect(1, 180, 130, 20), "Update"))
                {
                    Process.Start("https://muck.thunderstore.io/package/Crafterbot/God_Powers/");
                    Process.Start("https://github.com/TheOmag/How-to-update-Muck-mod-/blob/main/README.md");
                    Application.Quit();
                }
                if (GUI.Button(new Rect(131, 180, 220 - 130, 20), "Help"))
                {
                    Process.Start("https://github.com/TheOmag/How-to-update-Muck-mod-/blob/main/README.md");
                }
                if (GUI.Button(new Rect(1, 200, 220, 20), "Close"))
                {
                    newVersion = false;
                }
            }
        }
    }
}