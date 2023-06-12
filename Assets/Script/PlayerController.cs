using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;
    public float xSpeed;
    public float limitX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       SwipeCheck();
    }

    void SwipeCheck()
    {
        float newX = 0;
        float touchXDelta = 0;


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Debug.Log(Input.GetTouch(0).deltaPosition.x);
            touchXDelta = Input.GetTouch(0).deltaPosition.x;
        }
        newX = transform.position.x + xSpeed * touchXDelta * Time.deltaTime;
        newX = Math.Clamp(newX, -limitX, limitX);

        Vector3 newPos = new Vector3(newX, transform.position.y, transform.position.z + runningSpeed * Time.deltaTime);
        transform.position = newPos;
    }
}
