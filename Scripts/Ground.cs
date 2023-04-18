using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Input.GetAxis("Horizontal"));


        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(0,0,zRotation);



        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            Debug.Log("Mouse down:" + Input.mousePosition);
            if ( Input.mousePosition.x < Screen.width / 2)
            {
                //left click = 좌우로 기울어진다
                transform.localEulerAngles = new Vector3(0, 0, zRotation + 1);
            }
            else
            {
                //left click = 좌우로 기울어진다 
                transform.localEulerAngles = new Vector3(0, 0, zRotation - 1);
            }
        }

    }
}
