using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.E;
    public float interactionRange = 5f;

    private bool canEnterMiniGame = false;
    private Transform playerTransform;

    private void Start()
    {
        // Assuming the player object has a Player tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Check if the player can enter the mini-game and press the interact key
        if (canEnterMiniGame && Input.GetKeyDown(interactKey))
        {
            EnterMiniGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player is close to the mini-game entrance
        if (other.CompareTag("Player"))
        {
            canEnterMiniGame = true;

            // Show UI prompt or other indication to notify the player they can enter the mini-game
            Debug.Log("Press " + interactKey.ToString() + " to enter the mini-game.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the player has moved away from the mini-game entrance
        if (other.CompareTag("Player"))
        {
            canEnterMiniGame = false;

            // Hide UI prompt or other indication
        }
    }

    private void EnterMiniGame()
    {
        // Enter the mini-game or perform game-specific action
        Debug.Log("Entering mini-game.");
        // Add your mini-game logic here
    }

    private void OnDrawGizmosSelected()
    {
        // Visualize the interaction range in the scene view
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, interactionRange);
    }

    private void Updates()
    {
        // Check if the player can enter the mini-game and press the interact key within the interaction range
        if (canEnterMiniGame && Input.GetKeyDown(interactKey) && Vector3.Distance(playerTransform.position, transform.position) <= interactionRange)
        {
            EnterMiniGame();
        }
    }
}
