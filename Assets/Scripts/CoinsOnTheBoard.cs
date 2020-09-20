using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsOnTheBoard : MonoBehaviour
{
    [SerializeField]
    Transform[] waypointsList;


    public float movementSpeed = 2f;
    public int wayPointIndex = 0;

    public Image kisu;
    public Transform playerPrefab;
    public Button testButton;

    void Start()
    {
        //transform.position = waypointsList[wayPointIndex].transform.position;
        Button tButton = testButton.GetComponent<Button>();
        tButton.onClick.AddListener(InstantiatePrefab);
        
    }

    void Update()
    {
        //Instantiate(playerPrefab);
    }

    void InstantiatePrefab()
    {
        Debug.Log("Jjee button painettu!");

        Transform imagePath = GameObject.FindWithTag("Path").transform;
        Instantiate(kisu, imagePath);

        MoveTroughWayPoints();
    }

    void MoveTroughWayPoints()
    {
        //for(int i = 0; i >= 6; i++)
        //{
            kisu.transform.position = Vector2.MoveTowards(transform.position, waypointsList[wayPointIndex].transform.position, movementSpeed * Time.deltaTime);
        //}
    }

}
