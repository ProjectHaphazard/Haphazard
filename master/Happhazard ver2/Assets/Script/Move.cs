using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

 //if(Physics.Raycast(ray,out hit,LayerMask.GetMask("Field")))
 //           {
 //               //targetPosition = hit.point;
 //               agent.SetDestination(hit.point);
 //               //agent.SetDestination(targetPosition);
 //           }
public class Move : MonoBehaviour
{
    private Vector3 targetPosition; //移動する位置
    private NavMeshAgent agent;

    private RaycastHit hit;
    private Ray ray;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}