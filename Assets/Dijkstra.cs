using NUnit.Framework;
using UnityEngine;

namespace MyPathFinding
{
    public class Dijkstra : MonoBehaviour
    {
        protected Node[] nodesInScene;

        public void GetAllNodes()
        {
            nodesInScene = FindObjectsByType<Node>(FindObjectsSortMode.Node);
        }

        public void DebugPath(List<Node> path)
        {
            for(int i = 0; i < path.Count - 1; i++)
            {
                Debug.DrawLine(path[i].transform.position, path[i + 1].transform.position, Color.green, 10f);
            }
        }

        public List<Node> FindShortestPath(Node start, Node goal)
        {
            return null;
        }

        protected virtual bool RunAlgorithm(Node start, Node goal)
        {
            return false;
        }

        public void SetUnexplored(List<Node> unexplored)
        {

        }
    }

}
