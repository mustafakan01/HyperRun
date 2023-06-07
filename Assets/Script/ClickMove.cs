using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]




public class ClickMove : MonoBehaviour
{
    NavMeshAgent nAgent;
    RaycastHit hitInfo = new RaycastHit();

    void Start()
    {
        nAgent=GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            var ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin,ray.direction,out hitInfo))
            {
                nAgent.destination = hitInfo.point;
            }
        }
        
    }
}
