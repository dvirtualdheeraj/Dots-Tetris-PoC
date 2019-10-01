using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Color = UnityEngine.Color;
//using Color = System.Drawing.Color;
public class DotComponent : MonoBehaviour, IPointerDownHandler
{
    public GameObject dotComponent;
    readonly List<Color> colorList = new List<Color>()
     {
         Color.red,
         Color.yellow,
         Color.blue
     };

    // Start is called before the first frame update
    void Start()
    {    
        CreateRandomColor();
    }

    public void CreateRandomColor()
    {       
        dotComponent.GetComponent<Image>().color = colorList[Random.Range(0, colorList.Count)];
    }

    public void ChangeColorOnTouch()
    {
        dotComponent.GetComponent<Image>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ChangeColorOnTouch();
        
    }
}
