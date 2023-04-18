using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Movement3D movement3D;

    private void Awake()
    {
        movement3D = GetComponent<Movement3D>();
    }

    private void Update()
    {
        //방향키를 눌러 이동
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if ( x != 0 || z != 0)
        {
            //(x,0,z) 방향으로 이동
            movement3D.MoveTo(new Vector3(x, 0, z));
        }
    }









}
