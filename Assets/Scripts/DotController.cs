using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour
{
    public GameObject DotVariable;
    public GameObject canv;
    public float posX = 0;
    public float posY = 0;
    public float posZ = 0;

    public void MakeGrid()
    {
        Vector3 DummyDot = DotVariable.GetComponent<Transform>().position;
        posX = DotVariable.transform.position.x;
        posY = DotVariable.transform.position.y;
        posZ = DotVariable.transform.position.z;
         Debug.Log(DotVariable.transform.position);
        for (int i = 0; i < 5; i++)
        {
            posX = DotVariable.transform.position.x - 0.9F;
            if(i > 0){

            posY = posY - 0.9F;
            }
            for(int j = 0; j < 5; j++){
            GameObject SingleDot = Instantiate(DotVariable, new Vector3((posX + 0.9F), posY, posZ), Quaternion.identity);
            SingleDot.transform.localScale = new Vector3(0.0274F, 0.0274F, 0.0274F);
            posX = posX + 0.9F;
            SingleDot.transform.SetParent(canv.transform);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        this.MakeGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
