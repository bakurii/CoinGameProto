using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsOnTheBoard : MonoBehaviour
{
    [SerializeField]
    Transform[] waypointsList;


    //public float movementSpeed = 2f;
    public int wayPointIndex = 5;
    private int loopNumber = 5;

    public int testNum = 0;

    public Image kisu;
    public Transform playerPrefab;
    public Button button0;
    public Button button1;

    void Start()
    {
        //transform.position = waypointsList[wayPointIndex].transform.position;
        Button zeroButton = button0.GetComponent<Button>();
        Button oneButton = button1.GetComponent<Button>();
        zeroButton.onClick.AddListener(InstantiatePrefab);
        oneButton.onClick.AddListener(InstantiatePrefab);
        
    }

    void Update()
    {
        
    }

    int testArrayNumber()
    {


        return testNum;
    }

    void InstantiatePrefab()
    {
        Debug.Log("Jjee button painettu!");

        Transform imagePath = GameObject.FindWithTag("Path").transform;

        for (int i = 5; i >= loopNumber; i--)
        {
            wayPointIndex = i;
            Instantiate(kisu, waypointsList[wayPointIndex].transform.position, Quaternion.identity, imagePath);
        }

        loopNumber--;
    }


}
