using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PathNode = GetComponentsInChildren<Node>();


    }

    Node[] PathNode;

    void DrawLine()
    {
        for (int i = 0; i < PathNode.Length; i++)
        {
            //we will paint from PathNode[0] to 1 , 1 to 2 and like this to end of Pathnode
            if (i == 0)
            {
                Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.blue);
            }
            if (i == 1)
            {
                Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.green);
            }
            if (i == 2)
            {
                Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.black);
            }

        }
    }
    // Update is called once per frame
    void Update () {
        DrawLine();

    }
}
