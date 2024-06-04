# ColorPickerUnity
Pick color from canvas UI panel in Unity 

1) Add UIColorPicker.cs to any gameobject.
2) Take any image as texture type : texture. As seen in example.
3) Make image read/write enable true in advance setting.
4) Make pivot 0,0 of image component.
5) Drag image in Color map field in UIColorPicker component.
6) Write aculat size of image in XValueImg and YValueImg field.
7) Write size of image in XValueCanvasImg and YValueCanvasImg field.
8) Please give img gameobject name as "ImgGetColor".
9)  code:
UIColorPicker.MyColor += MyListener;
Add listener in code.
public void MyListener(Color color)
{
exampleImg.color = color; // you can use this color any way. in texture in color
}

![index - Copy21](https://github.com/saurabhstudio13960/ColorPickerUnity/assets/19515938/08ab05ad-d823-4440-bae3-7e3414a50f29)
![index - Copy](https://github.com/saurabhstudio13960/ColorPickerUnity/assets/19515938/ed7982b1-5fa6-4ce9-aa3f-8325e5f66bfd)
![index](https://github.com/saurabhstudio13960/ColorPickerUnity/assets/19515938/784976f7-de47-4ed8-8714-abb5ef294bac)
