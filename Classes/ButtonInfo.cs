using System;
using UnityEngine;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Classes
{
    public class ButtonInfo
    {
        public Vector2 anchorPoint = Vector2.zero;
        public string buttonText = "-";
        public bool enabled = false;
        public int fontSize;
        public bool isTogglable = true;
        public Action method = null;
        public Page page = Page.None;
        public Vector2 position = Vector2.zero;
        public Vector2 size = Vector2.zero;
    }
}
