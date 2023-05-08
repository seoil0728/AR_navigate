using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DrawPathfinding : MonoBehaviour
{
    public NavMeshAgent agent;
    public LineRenderer lineRenderer;
    public Transform target;
    private void Start()
    {
        agent.destination = target.position;
    }

    private void Update()
    {
        // NavMeshAgent �� �̵����� �ƴ� ��� return
        if (!agent.hasPath) return;

        // ��θ� �����ͼ� ���� �׸���
        var path = agent.path;
        var corners = path.corners;
        lineRenderer.positionCount = corners.Length;
        for (int i = 0; i < corners.Length; i++)
        {
            corners[i] += new Vector3(0, 3, 0);
            lineRenderer.SetPosition(i, corners[i]);
        }
    }
}
