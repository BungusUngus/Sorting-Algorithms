using UnityEngine;
using System.Collections.Generic;

using System.Diagnostics;
using MyPathFinding;

public class TheRunningMan : MonoBehaviour
{

    public Dijkstra pathFinder;
    public GridGenerator grid;

    [ContextMenu("Run Forest")]
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pathFinder.GetAllNodes();

        Node[] nodes = FindObjectsByType<Node>(FindObjectsSortMode.InstanceID);
        int startNode = nodes.Length - 1;
        int goalNode = Random.Range(0, nodes.Length);

        List<Node> path = pathFinder.FindShortestPath(nodes[startNode], nodes[goalNode]);
        pathFinder.DebugPath(path);
    }


}
