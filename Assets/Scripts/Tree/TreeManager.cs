using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Tree manager determines the:
 * 1. Parameterized ranges of tree attributes
 * 2. Distribution of trees across the map
 * 3. Manages runtime creation/management of trees
 * 
 * TODO: we can probably refactor this eventually
 */

public class TreeManager : MonoBehaviour
{
    //Simulation Manager reference
    public SimulationManager simulationManager;
    //TODO: Distribution type affects how trees are distributed
    enum DistributionType { Random }

    public Tree treePrefab; //prefab used to generate trees
    public float numTrees; //total number of trees used in simulation

    // Start is called before the first frame update
    void Start()
    {
        this.numTrees = this.simulationManager.numTrees;

        //TODO: Chose distribution type by enum
        for(float i = numTrees; i > 0; i--) 
        {
            //TODO: fix Z number hardcoding
            Tree tree = Instantiate
                (
                treePrefab, 
                new Vector3
                    (
                    Random.Range(this.simulationManager.minXBound, this.simulationManager.maxXBound),
                    Random.Range(this.simulationManager.minYBound, this.simulationManager.maxYBound),
                    1f
                    ), 
                Quaternion.identity
                );
            tree.transform.SetParent(this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
