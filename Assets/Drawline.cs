using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawline : MonoBehaviour {
    Node[] PathNode;

    // Use this for initialization
    void Start () {
		
	}
    void DrawLine()
    {
        for (int i = 0; i < PathNode.Length; i++)
        {
            //we will paint from PathNode[0] to 1 , 1 to 2 and like this to end of Pathnode
            if (i < PathNode.Length - 1)
            {
                Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.green);
            }

        }
    }
    // Update is called once per frame
    void Update () {
        

    }
}
