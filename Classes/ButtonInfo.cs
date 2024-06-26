using System;
using UnityEngine;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Classes
{
    public class ButtonInfo
    {
        public string buttonText = "-";
        public Page page = Page.None;
        public Vector2 anchorPoint = Vector2.zero;
        public Vector2 position = Vector2.zero;
        public Vector2 size = Vector2.zero;
        public Action method = null;
        public Action enableMethod = null;
        public Action disableMethod = null;
        public bool enabled = false;
        public bool isTogglable = true;
    }
}
