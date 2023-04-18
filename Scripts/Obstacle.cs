using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(float delta)
    {
        float newXPosition = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newXPosition, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x < -5)
        {
            delta = 0.1f;
        }
        else if (transform.localPosition.x > 5)
        {
            delta = -0.1f;
        }

    }
}
