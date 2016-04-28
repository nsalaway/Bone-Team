using UnityEngine;
using System.Collections;

public class MazeLogic : MonoBehaviour {

    public int modifierOne;
    public int modifierTwo;
    public int modifierThree;

    int randX = 1, randZ;

    public GameObject player;
    public GameObject goal;

    public GameObject[] leftMazes = new GameObject[3];
    public GameObject[] rightMazes = new GameObject[3];

    // Use this for initialization
    void Start () {
        OverallGameManagerErik.isGameActive = true;
        CreateMaze();
        CreateUnits();
    }
	
	// Update is called once per frame
	void Update () {

	}



    void CreateMaze()
    {
        GameObject myLeftMaze = (GameObject)Instantiate(leftMazes[modifierOne], transform.position, Quaternion.identity);
        GameObject myRightMaze = (GameObject)Instantiate(rightMazes[modifierTwo], transform.position, Quaternion.identity);
        myLeftMaze.transform.parent = transform;
        myRightMaze.transform.parent = transform;
    }

    void CreateUnits()
    {
        randX = Random.Range(-4, 6);
        randZ = Random.Range(-4, 6);

        Vector3 playerStartLocation = new Vector3(randX, 1, randZ);
        GameObject myPlayer = (GameObject)Instantiate(player, playerStartLocation, Quaternion.identity);
        myPlayer.transform.parent = transform;


        randZ = Random.Range(-4, 6);
        if (randX < 0.5f)
        {
            randX = Random.Range(2, 6);

        }
        else
        {
            randX = Random.Range(-4, 1);
        }

        Vector3 goalLocation = new Vector3(randX, 1, randZ);
        GameObject myGoal = (GameObject)Instantiate(goal, goalLocation, Quaternion.identity);
        myGoal.transform.parent = transform;
    }
}
