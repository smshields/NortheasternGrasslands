using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
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
    public float reproductionRadius; //radius that a new grass object can be created as a child of this one
    public float requireParents; //requires more than one grass within a radius to produce children
    public float pollinationRadius; //how far apart parents can be if parents are required

    //Stats
    public float currentEnergy; //the total volume of grass that can be eaten and converted to energy. Determines health of plant.

    void Awake() 
    { 
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
