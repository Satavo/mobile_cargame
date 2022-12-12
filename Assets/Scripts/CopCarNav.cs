using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CopCarNav : MonoBehaviour
{
    public GameObject target; // Собственно цель
    private NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target) // Если объект существует
        {
            nav.SetDestination(target.transform.position);
        }
    }
}
