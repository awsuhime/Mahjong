using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int player = 1;
    public bool myTurn;
    public GameObject UI;
    public GameObject blackout;
    private bool blackedOut;
    public Player opponent;
    private void Start()
    {
        if (player == 1)
        {
            Blackout();
        }
    }

    private void Update()
    {
        if (blackedOut && Input.GetKeyDown(KeyCode.Space))
        {
            startTurn();
        }
    }
    public void Blackout()
    {
        blackout.SetActive(true);
        blackedOut = true;
    }
    public void startTurn()
    {
        blackedOut = false;
        blackout.SetActive(false);
        myTurn = true;
        UI.SetActive(true);
    }

    public void endTurn()
    {
        UI.SetActive(false);
        myTurn = false;
        opponent.Blackout();
    }

}
