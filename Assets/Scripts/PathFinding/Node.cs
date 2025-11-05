using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

namespace MyPathFinding
{
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

            Gizmos.color = Color.black;
            foreach (var node in Neighbours)
            {
                if (node == null) continue;
                Vector3 direction = node.transform.position - transform.position;
                Vector3 right = Vector3.Cross(direction, Vector3.up).normalized * 0.03f;

                Gizmos.DrawRay(transform.position + right, direction);
            }
        }
    }
}