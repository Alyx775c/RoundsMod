using UnityEngine;


namespace RoundsMod.Classes
{
    class AnchorPoints
    {
        public static Vector2 TopLeft = new(0, 1f);
        public static Vector2 TopRight = new(1f, 1f);
        public static Vector2 BottomLeft = new(0f, 0f);
        public static Vector2 BottomRight = new(1f, 0f);
        public static Vector2 MiddleLeft = new(0f, .5f);
        public static Vector2 MiddleRight = new(1f, .5f);
        public static Vector2 MiddleBottom = new(0.5f, 0f);
        public static Vector2 MiddleTop = new(0.5f, 1f);
    }

}
