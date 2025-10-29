using NUnit.Framework;
using UnityEngine;

namespace MyPathFinding

public class Node : MonoBehaviour
{
    public List<Node> Neighbours;

    private float pathWeight;

    public float PathWeight
    {
        get
        {
            return pathWeight;
        }

        set
        {
            pathWeight = value;
        }
    }

    private Node previousNode;
    public Node PreviousNode { get => previousNode; set => previousNode = value; }

    public void reset()
    {
        pathWeight = float.PositiveInfinity;
        previousNode = null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawSphere(transform.position, radius: 0.2f);
    } 
}
