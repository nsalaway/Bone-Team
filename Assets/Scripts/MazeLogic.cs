using UnityEngine;
using System.Collections;

public class MazeLogic : MonoBehaviour {

    int antenna;
    int eyes;

    int randX = 1, randZ;

    public GameObject player;
    public GameObject goal;

    public GameObject[] leftMazes = new GameObject[3];
    public GameObject[] rightMazes = new GameObject[3];

    // Use this for initialization
    void Start () {
        OverallGameManagerErik.isGameActive = true;
        GetRobot();
        CreateMaze();
        //CreateUnits();
        NewCreateUnits();
    }
	
	// Update is called once per frame
	void Update () {

	}



    void CreateMaze()
    {
        leftMazes[antenna].SetActive(true);
        rightMazes[eyes].SetActive(true);
    }

    void NewCreateUnits()
    {
        //these are the distances between centers of the grid
        float xInterval = 1.2403333333333333333333333333333f;
        float zInterval = 1.2525555555555555555555555555556f;

        //these randomize the spawn point of player
        int xRandomizer = Random.Range(0, 10);
        int ZRandomizer = Random.Range(0, 10);

        //player start at the bottom left corner. this vector is added to that position to create the new spawn location
        Vector3 adjustmentVector = new Vector3(xInterval * xRandomizer, 0, zInterval * ZRandomizer);

        //the start location, to be adjusted by the above vector

        //instantiate and set all the locations
     
        player.transform.localPosition += adjustmentVector;

        //do it again for the goal, but x position must be on opposite side of maze from player
        if (xRandomizer > 4)
        {
            xRandomizer = Random.Range(0, 5);
        }
        else
        {
            xRandomizer = Random.Range(5, 10);
        }
        
        ZRandomizer = Random.Range(0, 10);
        adjustmentVector = new Vector3(xInterval * xRandomizer, 0, zInterval * ZRandomizer);

        goal.transform.localPosition += adjustmentVector;
    }

    void GetRobot()
    {
        eyes = OverallGameManagerErik.eyes;
        antenna = OverallGameManagerErik.antenna;
    }
}
