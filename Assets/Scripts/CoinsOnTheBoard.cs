using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsOnTheBoard : MonoBehaviour
{
    public Transform[] wayPoints1 = new Transform[6];
    public int wayPointIndex = 0;

    public Image kisu;
    public Transform playerPrefab;
    public Button testButton;

    void Start()
    {

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
        Instantiate(kisu);
    }


}
