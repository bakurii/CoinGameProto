using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { START, P1, P2, WIN, LOSE}

//https://www.youtube.com/watch?v=_1pz_ohupPs
//Tutorial video for turns.

public class Turns : MonoBehaviour
{
    public GameState state;
    public GameObject player1;
    void Start()
    {
        player1 = GameObject.Find("Player1Coins");
        state = GameState.START;
        SetupStart();
    }

    void Update()
    {
        
    }

    void SetupStart()
    {

        state = GameState.P1;
        Player1Turn();
    }

    void Player1Turn()
    {
        //Connection to Player1Coins script that has Coins on the board as a namespace.
        


    }
}
