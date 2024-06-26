using RoundsMenu.Classes;
using UnityEngine;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Mods
{
    class Buttons
    {
        public static ButtonInfo[] button = [
            new (){
                buttonText = "OP",
                method = () => PageHandler.ChangePage(Page.OP),
                page = Page.Front,
                position = new(-30f, 67f),
                size = new(115, 30),
                isTogglable = false,
                anchorPoint = AnchorPoints.TopLeft,
            }
        ];
    }
}
