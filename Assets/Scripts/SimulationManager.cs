using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationManager : MonoBehaviour
{
    //Timer Setup
    public float fixedDeltaTime; 
    public float timeScale; //Ratio of realtime to simulation time
    public float time; //Time elapsed since start of simulation
    public Text timerText; //UI element for observing time in simulation

    public GameObject grasslandFloor;
    public BoxCollider grasslandFloorCol;

    // Simulation Settings [TODO: Add in enum for different types of distributions for objects]
    public float numTrees = 100;
    public float numShrubs = 100; 

    public float minXBound;
    public float maxXBound;
    public float minYBound;
    public float maxYBound;

    void Awake() 
    {
        //Instantiate Timer with a scalar. 1f is real time, 0f is paused, 2f is double.
        this.fixedDeltaTime = Time.fixedDeltaTime;
        this.time = 0f;
        this.SetTimeScale(1f);
        print("Starting Simulation. Time scale to: " + this.timeScale);

        this.minXBound = this.grasslandFloorCol.bounds.min.x;
        this.maxXBound = this.grasslandFloorCol.bounds.max.x;
        this.minYBound = this.grasslandFloorCol.bounds.min.y;
        this.maxYBound = this.grasslandFloorCol.bounds.max.y;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.time = Time.time;
        this.timerText.text = this.CurrentTimeToString();
    }

    void SetTimeScale(float timeScale) 
    {
        Time.timeScale = timeScale;
        this.timeScale = timeScale;
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Helper method to format raw timer from unity to a human-readable value
    string CurrentTimeToString() 
    {
        TimeSpan time = TimeSpan.FromSeconds(this.time);
        return (time.ToString("d':'hh':'mm':'ss"));
    }
}
