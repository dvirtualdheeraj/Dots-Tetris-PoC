using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Color = UnityEngine.Color;
//using Color = System.Drawing.Color;
public class DotComponent : MonoBehaviour
{
    public GameObject dotComponent;
    readonly List<Color> colorList = new List<Color>()
     {
         Color.red,
         Color.yellow,
         Color.blue,
     };

    // Start is called before the first frame update
    void Start()
    {    
        ChangeColor();
    }

    public void ChangeColor()
    {       
        dotComponent.GetComponent<Image>().color = colorList[Random.Range(0, colorList.Count)];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
