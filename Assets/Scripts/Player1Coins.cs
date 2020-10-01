using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsOnTheBoard : MonoBehaviour
{
    //Every row has its own waypoint list.
    [SerializeField]
    Transform[] waypointsList0;
    [SerializeField]
    Transform[] waypointsList1;

    //public float movementSpeed = 2f;
    private int wayPointIndex = 5;
    private int loopNumber = 5;

    private int testNum = 0;

    public Image kisu;
    //public Transform playerPrefab;
    public Button button0;
    public Button button1;

    void Start()
    {
        //transform.position = waypointsList[wayPointIndex].transform.position;
        Button zeroButton = button0.GetComponent<Button>();
        Button oneButton = button1.GetComponent<Button>();
        zeroButton.interactable = true;
        zeroButton.onClick.AddListener(InstantiatePrefabZero);
        oneButton.onClick.AddListener(InstantiatePrefabOne);
        
    }

    void Update()
    {
        
    }

    int testArrayNumber()
    {


        return testNum;
    }

    void InstantiatePrefabZero()
    {
        Debug.Log("Jjee button 0 painettu!");
        
        //Path/object where images are instantiated 
        Transform imagePath = GameObject.FindWithTag("Path").transform;

        for (int i = 5; i >= loopNumber; i--)
        {
            wayPointIndex = i;
            Instantiate(kisu, waypointsList0[wayPointIndex].transform.position, Quaternion.identity, imagePath);
        }

        loopNumber--;
        
        //Disables butoon after loopnumber is 0.
        if (loopNumber < 0)
        {
            button0.interactable = false;
        }
    }

    void InstantiatePrefabOne()
    {
        Debug.Log("Jjee button 1 painettu!");

        //Path/object where images are instantiated 
        Transform imagePath = GameObject.FindWithTag("Path").transform;

        for (int i = 5; i >= loopNumber; i--)
        {
            wayPointIndex = i;
            Instantiate(kisu, waypointsList1[wayPointIndex].transform.position, Quaternion.identity, imagePath);
        }

        loopNumber--;

        //Disables button after loopnumber is 0.
        if (loopNumber < 0)
        {
            button0.interactable = false;
        }
    }
}
