using RoundsMod.Classes;
using RoundsMod.Classes.RoundsMod.Classes;
using RoundsMod.Mods;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace RoundsMod.Menu
{
    public class MainModMenuHandler
    {
        public void AddMenu()
        {
            // canvas stuff
            GameObject canvasObject = GameObject.FindAnyObjectByType<Canvas>().gameObject;
            Canvas canvas = canvasObject.GetComponent<Canvas>();
            CanvasScaler scaler = canvasObject.GetComponent<CanvasScaler>();

            // panel stuff
            GameObject panelObject = new GameObject("Panel");
            RectTransform rectTransform = panelObject.AddComponent<RectTransform>();
            Image image = panelObject.AddComponent<Image>();

            Vector2 referenceSize = new Vector2
            {
                x = 1920,
                y = 1080
            };

            Vector2 sizeOfMenu = new Vector2
            {
                x = 500,
                y = 250
            };

            rectTransform.sizeDelta = referenceSize;

            // handle canvas stuff
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = referenceSize;

            rectTransform.SetParent(canvas.transform);
            rectTransform.anchoredPosition = AnchorPoints.TopLeft;
            rectTransform.sizeDelta = new Vector2(200, 100);

            Color transparent_gray = new Color
            (
               colours.DarkGray.r,
               colours.DarkGray.g,
               colours.DarkGray.b,
               .5f
            );

            image.color = transparent_gray;

            AddButtons(panelObject);
        }

        public void AddButtons(GameObject panelObject)
        {
            foreach (var row in Buttons.button)
            {
                foreach (var buttonInfo in row)
                {
                    CreateAndAddButton(buttonInfo, panelObject);
                }
            }
        }

        private void CreateAndAddButton(ButtonInfo buttonInfo, GameObject panelObject)
        {
            GameObject buttonObject = new GameObject(buttonInfo.buttonText);
            buttonObject.transform.SetParent(panelObject.transform);

            Button btn = buttonObject.AddComponent<Button>();
            btn.onClick.AddListener(() => buttonInfo.method());

            Image img = buttonObject.AddComponent<Image>();
            img.color = Color.gray;

            GameObject textObject = new GameObject($"text object for {buttonInfo.buttonText}");
            textObject.gameObject.transform.parent = btn.transform;
            textObject.AddComponent<TextMeshProUGUI>();
            textObject.transform.position = btn.transform.position;

            TextMeshProUGUI textMeshObject = textObject.GetComponent<TextMeshProUGUI>();
            textMeshObject.text = "painful";

            RectTransform rectTransform = buttonObject.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, 0);
            rectTransform.sizeDelta = new Vector2(50, 50);
        }
    }
}
