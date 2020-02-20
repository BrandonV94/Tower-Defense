using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator FollowPath()
    {
        print("Starting Patrol.");
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1);
        }
        print("Ending Patrol");
    }

    // Update is called once per frame
    void Update()
    {

    } 
}
