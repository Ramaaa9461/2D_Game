using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceColor : MonoBehaviour
{

    Camera cam;
    private void Awake()
    {
        cam = Camera.main;

        cam.backgroundColor = Color.blue;
    }

    public void changeBackgroundColor()
    {

             cam.backgroundColor = Color.yellow;
        

     
    }
        


}
