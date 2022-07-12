using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** State based agent with behavior tree for determining action
 * 
 * TO DOs:
 * 1. Initial population seeding using rabbit manager
 * 2. Movement engine (how does the rabbit move/interact with physics
 * 3. Collider perceptron (food, rabbit, tree, fox detection)
 * 4. Food behavior
 * 5. Nest behavior
 * 
 * Movement:
 * 
 * Rabbits have an accelleration and decelleration
 * Rabbits have a top speed
 * Rabbits move in cardinal directions towards objectives
 * 
 */

public class Rabbit : MonoBehaviour
{
    float maxSpeed;
    float currentSpeed;
    float acceleration;
    Vector3 movementDirection;


    // Start is called before the first frame update
    void Start()
    {
        this.maxSpeed = 10f;
        this.acceleration = 0.1f;
        this.currentSpeed = 0f;
        this.movementDirection = Vector3.up;

    }

    // Update is called once per frame
    void Update()
    {
        this.Move();
    }

    // Move the rabbit in a given direction.
    void Move() 
    {
        if (currentSpeed >= maxSpeed)
        {
            transform.Translate(this.movementDirection * this.maxSpeed * Time.deltaTime);
            this.currentSpeed = this.maxSpeed;
            //Move at max speed
        }
        else 
        {
            transform.Translate(this.movementDirection * (this.currentSpeed + this.acceleration) * Time.deltaTime);
            this.currentSpeed += (this.acceleration * Time.deltaTime);
            //Accelerate to max speed
        }
    
    }

}
