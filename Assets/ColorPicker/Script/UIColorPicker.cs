using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;  
using System.Collections.Generic;

namespace saurabhstudio.colorPicker {
    public class UIColorPicker : MonoBehaviour {
        public Camera camera;
        bool dragging;
        public Texture2D ColorMap;
        public delegate void ColorPicker(Color color);
        public static event ColorPicker MyColor;
        public float xValueImg = 256f;
        public float yValueImg = 256f;
        public float xValueCanvasImg = 400f;
        public float yValueCanvasImg = 200f;

        void Start() {
            ColorMap = gameObject.GetComponent<RawImage>().texture as Texture2D;
        }

        void Update() {
            if (dragging) {
                PointerEventData pointer = new PointerEventData(EventSystem.current);
                pointer.position = Input.mousePosition;

                List<RaycastResult> raycastResults = new List<RaycastResult>();
                EventSystem.current.RaycastAll(pointer, raycastResults);

                if (raycastResults.Count > 0) {
                    if (raycastResults[0].gameObject.name == "ImgGetColor") {
                        RectTransform clrPkrRect = gameObject.GetComponent<RectTransform>();//gets the RectTransform reference
                        Vector2 mPos = Input.mousePosition;
                        Vector2 pv;
                        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(clrPkrRect, mPos, camera, out pv)) {
                            return;
                        }
                        //covert coords to int for GetPixel
                        float relX = (pv.x);
                        float relY = (pv.y);

                        relX = (relX * xValueImg) / xValueCanvasImg;
                        relY = (relY * yValueImg) / yValueCanvasImg;

                        Color customColor = ColorMap.GetPixel((int)relX, (int)relY);
                        //MR.sharedMaterial.SetColor("_Color", customColor);
                        if (MyColor != null) {
                            MyColor(customColor);
                        }
                    }
                }
            }
        }

        public void ColorTakingOn() {
            dragging = true;
        }

        public void ColorTakingOff() {
            dragging = false;
        }
    }
}