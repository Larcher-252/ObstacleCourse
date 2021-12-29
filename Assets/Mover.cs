using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(moveSpeed);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game zone.");
        Debug.Log("Use WASD to move the player.");
        Debug.Log("Have fun!");
    }

    void MovePlayer(float speed)
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed,
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, zValue);
    }
}
