using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour
{
    public GameObject DotVariable;
    public GameObject canv;
    public float PosX = 0;
    public float PosY = 0;
    public float PosZ = 0;

    public void MakeGrid()
    {
        Vector3 DummyDot = DotVariable.GetComponent<Transform>().position;
        PosX = DotVariable.transform.position.x;
        PosY = DotVariable.transform.position.y;
        PosZ = DotVariable.transform.position.z;
         Debug.Log(DotVariable.transform.position);
        for (int i = 0; i < 5; i++)
        {
            PosX = DotVariable.transform.position.x - 0.9F;
            if(i > 0){

            PosY = PosY - 0.9F;
            }
            // PosX = PosX - 0.9F;
            for(int j = 0; j < 5; j++){
            //     if(j > 0){

            // PosY = PosY - 0.9F;
            // PosX = DotVariable.transform.position.x;
            // }
            
            // Instantiate(DotVariable, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);

            // GameObject enemy = Instantiate(DotVariable, new Vector3(i * 2.0F, 0, 0), Quaternion.identity) as GameObject;
            // enemy.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

            // GameObject SingleDot = Instantiate(DotVariable, new Vector2((PosX + 0.9F), PosY), Quaternion.identity) as GameObject;
            GameObject SingleDot = Instantiate(DotVariable, new Vector3((PosX + 0.9F), PosY, PosZ), Quaternion.identity);
            SingleDot.transform.localScale = new Vector3(0.0274F, 0.0274F, 0.0274F);
            PosX = PosX + 0.9F;
            // PosY = PosY + 0.9F;
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
