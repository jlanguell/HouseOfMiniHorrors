using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomizeDrawer : MonoBehaviour
{

    public GameObject Drawer;

    // Use this for initialization
    void Start()
    {
        float width = Drawer.GetComponent<Renderer>().bounds.size.x;
        float height = Drawer.GetComponent<Renderer>().bounds.size.y;
        float DrawerX = Drawer.transform.position.x;
        float DrawerY = Drawer.transform.position.y;
        this.transform.position = new Vector3(Random.Range(DrawerX - (width / 4), DrawerX + (width / 4)), Random.Range(DrawerY - (height / 4), DrawerY + (height / 4)), Camera.main.nearClipPlane);
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
