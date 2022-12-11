using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CopCarNav : MonoBehaviour
{
    public GameObject target; // ���������� ����
    private NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target) // ���� ������ ����������
        {
            nav.SetDestination(target.transform.position);
        }
    }
}
