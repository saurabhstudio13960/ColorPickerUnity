using UnityEngine;
using UnityEngine.UI;

namespace saurabhstudio.colorPicker {

    public class Example : MonoBehaviour {
        public Image exampleImg;

        void Start() {
            UIColorPicker.MyColor += MyListener;
        }

        public void MyListener(Color color) {
            exampleImg.color = color;
        }

        void OnDisable() {
            UIColorPicker.MyColor -= MyListener;
        }
    }
}
