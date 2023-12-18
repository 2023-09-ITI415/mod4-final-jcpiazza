using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{

    public float amplitude = .2f; // How much the collectible moves up and down
    public float speed = 1.0f; // Speed of the movement

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position; // Store the initial position of the collectible
    }

    void Update()
    {
        // Calculate the new position based on sine wave to create the up and down movement
        Vector3 newPosition = initialPosition + Vector3.up * Mathf.Sin(Time.time * speed) * amplitude;

        // Update the collectible's position
        transform.position = newPosition;
    }
}
