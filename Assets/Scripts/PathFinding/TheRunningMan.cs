using UnityEngine;
using System.Collections.Generic;

using System.Diagnostics;
using MyPathFinding;
using Debug = UnityEngine.Debug;

public class TheRunningMan : MonoBehaviour
{

    public Dijkstra pathFinder;
    public Dijkstra pathFinder2;
    public GridGenerator grid;

    [ContextMenu("Run Forest")]
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pathFinder.GetAllNodes();
        pathFinder2.GetAllNodes();

        Node[] nodes = FindObjectsByType<Node>(FindObjectsSortMode.InstanceID);
        int startNode = nodes.Length - 1;
        int goalNode = Random.Range(0, nodes.Length);

        Stopwatch timer = new Stopwatch();
        timer.Start();
        List<Node> path = pathFinder.FindShortestPath(nodes[startNode], nodes[goalNode]);
        timer.Stop();
        pathFinder.DebugPath(path);
        Debug.Log("Pathfinder 1 = " + timer.ElapsedMilliseconds);

        //-----Pathfinder 2
        timer = new Stopwatch();
        timer.Start();
        List<Node> path2 = pathFinder2.FindShortestPath(nodes[startNode], nodes[goalNode]);
        timer.Stop();
        Debug.Log("Pathfinder 2 " + timer.ElapsedMilliseconds);
        pathFinder.DebugPath(path2);

    }


}
