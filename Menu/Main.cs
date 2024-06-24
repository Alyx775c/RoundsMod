using UnityEngine;
using UnityEngine.UI;

namespace RoundsMod.Menu
{
    public class MainModMenuHandler
    {
        public void AddMenu()
        {
            GameObject canvasObject = new GameObject("Canvas");
            Canvas canvas = canvasObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            Vector2 referenceSize = new Vector2();
            referenceSize.x = 1920;
            referenceSize.y = 1080;

            CanvasScaler scaler = canvasObject.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = referenceSize;

            GameObject panelObject = new GameObject("Panel");
            RectTransform rectTransform = panelObject.AddComponent<RectTransform>();
            Image image = panelObject.AddComponent<Image>();

            rectTransform.SetParent(canvas.transform);
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = new Vector2(200, 100);

            image.color = Color.black;
        }

    }
}
