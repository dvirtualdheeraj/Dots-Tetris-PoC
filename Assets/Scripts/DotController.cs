using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour
{
    public GameObject dotPrefab;
    public GameObject canv;

    // Start is called before the first frame update
    void Start()
    {

        CreateGrid();
    }

    public void CreateGrid()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                GameObject currentDot = Instantiate(dotPrefab, new Vector3(dotPrefab.transform.position.x + (col * 0.7f),
                dotPrefab.transform.position.y + (row * -0.7f), canv.transform.position.z), Quaternion.identity) as GameObject;
                currentDot.transform.SetParent(canv.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
