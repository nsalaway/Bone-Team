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
        GameObject myLeftMaze = (GameObject)Instantiate(leftMazes[antenna], transform.position, Quaternion.identity);
        GameObject myRightMaze = (GameObject)Instantiate(rightMazes[eyes], transform.position, Quaternion.identity);
        myLeftMaze.transform.parent = transform;
        myRightMaze.transform.parent = transform;
        myLeftMaze.transform.localScale = new Vector3(1.253252f, 1.253252f, 1.253252f);
        myRightMaze.transform.localScale = new Vector3(1.253252f, 1.253252f, 1.253252f);
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
        Vector3 homeVector = new Vector3(-5.642f, 0, -5.642f);

        //instantiate and set all the locations
        GameObject myPlayer = (GameObject)Instantiate(player, transform.position, player.transform.rotation);
        myPlayer.transform.parent = transform;
        myPlayer.transform.localPosition = homeVector + adjustmentVector;

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

        GameObject myGoal = (GameObject)Instantiate(goal, transform.position, goal.transform.rotation);
        myGoal.transform.parent = transform;
        myGoal.transform.localPosition = homeVector + adjustmentVector;
    }

    void CreateUnits()
    {
        randX = Random.Range(-4, 6);
        randZ = Random.Range(-4, 6);

        Debug.Log("player at " + randX + ", " + randZ);
        Vector3 playerStartLocation = new Vector3(randX, 1, randZ);
		GameObject myPlayer = (GameObject)Instantiate(player, transform.position, player.transform.rotation);
        myPlayer.transform.parent = transform;
        //myPlayer.transform.localScale = new Vector3(.75f, .75f, .75f);
		myPlayer.transform.localPosition = playerStartLocation;


        randZ = Random.Range(-4, 6);
        if (randX < 0.5f)
        {
            randX = Random.Range(2, 6);

        }
        else
        {
            randX = Random.Range(-4, 1);
        }

        Debug.Log("goal at " + randX + ", " + randZ);

        Vector3 goalLocation = new Vector3(randX, 1, randZ);
		GameObject myGoal = (GameObject)Instantiate(goal, transform.position, goal.transform.rotation);
        myGoal.transform.parent = transform;
		myGoal.transform.localPosition = goalLocation;
    }

    void GetRobot()
    {
        eyes = OverallGameManagerErik.eyes;
        antenna = OverallGameManagerErik.antenna;
    }
}
