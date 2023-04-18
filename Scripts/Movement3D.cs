using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Movement3D : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed;
    private Rigidbody rigidbody3D;

    private void Awake()
    {
        rigidbody3D = GetComponent<Rigidbody>();
    }

    public void MoveTo(Vector3 direction)
    {
        Vector3 moveForce = Vector3.zero;

        direction.y = 0;
        moveForce = direction.normalized * moveSpeed;

        //moveForce 의 힘으로 오브젝트를 민다
        rigidbody3D.AddForce(moveForce);
    }










}
