using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OK_UnitMovement : MonoBehaviour
{

    NavMeshAgent agent;
    public GameObject GO_select;
    private int IN_speed;


    void Start()
    {
        // Gather the Navmesh agent from the unit as well as make sure Go_select is not active.
        agent = GetComponent<NavMeshAgent>();
        GO_select.SetActive(false);
    }//---

    void Update()
    {
        if (gameObject.tag == "Selected")
        {
            GO_select.SetActive(true);
            if (Input.GetMouseButtonDown(1))
            {
                RaycastHit hit;

                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                {
                    agent.destination = hit.point;
                    ;
                }
            }

        }
        else
        {
            GO_select.SetActive(false);
        }



    }//---
    public void SpeedUp()
    {

        agent.speed = agent.speed + 2;

    }
}