using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsOnTheBoard : MonoBehaviour
{
    public Transform[] wayPoints1 = new Transform[6];
    public int wayPointIndex = 0;
    GameObject player;
    void Start()
    {
        player.transform.position = wayPoints1[wayPointIndex].transform.position;
    }

    void Update()
    {
        
    }
}
