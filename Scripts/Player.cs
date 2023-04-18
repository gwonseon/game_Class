using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            //점프는 물리적인 힘을 가할 때 발생
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);



        }





    }
}
