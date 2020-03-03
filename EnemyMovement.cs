using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementDelay = 1f;
    [SerializeField] float enemyHeight = 10f;

    void Start()
    {
        PathFinder pathFinder = FindObjectOfType<PathFinder>();
        var path = pathFinder.GetPath();
        StartCoroutine(FollowPath(path));
    }
   
    IEnumerator FollowPath(List<Waypoint> path)
    {
        foreach (Waypoint waypoint in path)
        {
            transform.position = new Vector3(waypoint.transform.localPosition.x, enemyHeight, waypoint.transform.localPosition.z);
            yield return new WaitForSeconds(movementDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {

    } 
}
