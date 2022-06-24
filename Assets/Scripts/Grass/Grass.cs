using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    //Time constants
    public float changeInterval; //determines how often grass changes.
    public float nextTime;

    //Prefab Reference
    public Grass grassPrefab;

    //Simulation references
    public SimulationManager simulationManager;

    //Growth Details
    public float minHeight; //smallest height the grass can be
    public float maxHeight; //largest height the grass can be
    public float minRadius; //smallest the radius of grass can be
    public float maxRadius; //largest the radius of grass can be
    public float verticalGrowthRate; //how quickly the grass grows vertically
    public float horizontalGrowthRate; //how quickly the diameter of the grass increases

    //Reproduction Details
    public float reproductionRate; //rate at which a grass object reproduces/attempts to reproduce
    public float reproductionRadius; //radius that a new grass object can be created as a child of this one
    public float requireParents; //requires more than one grass within a radius to produce children
    public float pollinationRadius; //how far apart parents can be if parents are required

    //Stats
    public float currentEnergy; //the total volume of grass that can be eaten and converted to energy. Determines health of plant.

    void Awake() 
    {
        //Update grass every second
        this.changeInterval = 1f;
        this.nextTime = 0f; 

        //TODO: Cleanup, this is for testing
        this.maxHeight = 3f;
        this.maxRadius = 2f;
        this.horizontalGrowthRate = 0.1f;
        this.verticalGrowthRate = 0.1f;
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Every second, check for changes
        if (Time.time >= this.nextTime) 
        {
            this.GrowHorizontal();
            this.GrowVertical();

            this.nextTime += this.changeInterval;
        }
    }

    //Grow the grass vertically until it hits the limit
    void GrowVertical() 
    {
        if (this.transform.localScale.y <= this.maxHeight) 
        {
            this.transform.localScale += new Vector3(0f, this.verticalGrowthRate, 0f);
        }
    }

    //Grow the grass horizontally. Represents the grass 
    void GrowHorizontal() 
    {
        if (this.transform.localScale.x <= this.maxRadius || this.transform.localScale.z <= this.maxRadius) 
        {
            this.transform.localScale += new Vector3(this.horizontalGrowthRate, 0f, this.horizontalGrowthRate);
        }
    }

    //Create a new grass instance somewhere nearby. TODO: Parent implementation?
    Grass Reproduce() 
    {
        return null;
    }
}
