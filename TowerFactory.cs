using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour
{
    [SerializeField] int towerLimit = 5;
    [SerializeField] Tower towerPrefab = null;
    public int numOfTowers = 0;

    public void AddTower(Waypoint baseWaypoint)
    {
        if (numOfTowers < towerLimit)
        {
            InstatiateNewTower(baseWaypoint);
        }
        else
        {
            MoveExistingTower();
        }
    }

    private static void MoveExistingTower()
    {
        print("Reached max towers.");
    }

    private void InstatiateNewTower(Waypoint baseWaypoint)
    {
        var newTower = Instantiate(towerPrefab,
                            new Vector3(baseWaypoint.transform.position.x, 10f, baseWaypoint.transform.position.z),
                            Quaternion.identity);
        baseWaypoint.isPlaceable = false;
        numOfTowers++;
    }
}
