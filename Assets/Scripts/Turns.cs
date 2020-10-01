using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { START, P1, P2, WIN, LOSE}

//https://www.youtube.com/watch?v=_1pz_ohupPs
//Tutorial video for turns.

public class Turns : MonoBehaviour
{
    public GameState state;

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.START;
        SetupStart();
    }

    // Update is called once per frame
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

    }
}
