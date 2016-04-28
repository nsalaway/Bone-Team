﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PickerManagerCode : MonoBehaviour {
    public GameObject blueBox;
    public GameObject tealBox;
    public GameObject greenBox;
    public GameObject greyBox;
    public GameObject redBox;
    public GameObject pinkBox;
    public GameObject orangeBox;
    public GameObject yellowBox;
    public GameObject enterBox;
    
    private bool isClickedBlue = false;
    private bool isClickedTeal = false;
    private bool isClickedGreen = false;
    private bool isClickedGrey = false;
    private bool isClickedRed = false;
    private bool isClickedPink = false;
    private bool isClickedOrange = false;
    private bool isClickedYellow = false;

    private bool finalizeAnswere = false;

    private int State;
    private int Model;

	bool isLoaded = false;

    // Use this for initialization
    void Start()
    {
        OverallGameManagerErik.isGameActive = true;
        //DECLARE THE PUZZLE STATE AND ROBOT NUMBER
        State = Random.Range(1, 7);
   

        //iNSTANTIATE THE REQUIRED GAME OBJECTS FOR EACH STATE
        if (State == 1)
        {
            //(instantiate code for State here)
			spawnBlue();
			spawnTeal();
			spawnGreen ();
			spawnGrey ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

        }
        if (State == 2)
        {
            //(instantiate code for State here)
			spawnBlue();
			spawnTeal();
			spawnGrey ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

        }
        if (State == 3)
        {
            //(instantiate code for State here)
			spawnBlue();
			spawnTeal();
			spawnGreen ();
			spawnGrey ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

        }
        if (State == 4)
        {
            //(instantiate code for State here)
			spawnBlue();
			spawnGreen ();
			spawnGrey ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();

        }
        if (State == 5)
        {
            //(instantiate code for State here)
			spawnBlue();
			spawnTeal();
			spawnGreen ();
			spawnGrey ();
			spawnRed ();
			spawnYellow ();

        }
        if (State == 6)
        {
            //(instantiate code for State here)
			spawnBlue();
			spawnTeal();
			spawnRed ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

        }


        transform.Rotate(90, 0, 0);
    }

    //yOU WIN FUNCTION
	void YouWin()
    {
        Debug.Log("Congrats you win");
        OverallGameManagerErik.PuzzleWon(this.gameObject);
    }

    //YOU LOSE FUNCTION
    void YouLose()
    {
        //Debug.Log("Failure");
        OverallGameManagerErik.MadeError();
    isClickedBlue = false;
    isClickedTeal = false;
    isClickedGreen = false;
    isClickedGrey = false;
    isClickedRed = false;
    isClickedPink = false;
    isClickedOrange = false;
    isClickedYellow = false;
    finalizeAnswere = false;

}


    // Update is called once per frame
    void Update () {
		if (!isLoaded)
		{
			Model = OverallGameManagerErik.antenna;
			//Debug.Log("Model" + Model);
			isLoaded = true;
		}


        //(Add raycast to check fo the tag of each object and set their state to true here)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHitInfo = new RaycastHit();

        //IF THE MOUSE CLICKS OVER AN OBJECT CHECK THE TAG AND ACTIVATE THE OBJECT
        if (Physics.Raycast(ray, out rayHitInfo, 1000f) && (Input.GetMouseButtonDown(0)))
        {
         if(rayHitInfo.collider.tag == "BlueBox")
            {
                isClickedBlue = !isClickedBlue;
                Debug.Log("Blue clicked");
            }
            if (rayHitInfo.collider.tag == "TealBox")
            {
                isClickedTeal = !isClickedTeal;
                Debug.Log("Teal clicked");
            }
            if (rayHitInfo.collider.tag == "GreenBox")
            {
                isClickedGreen = !isClickedGreen;
                Debug.Log("Green clicked");
            }
            if (rayHitInfo.collider.tag == "GreyBox")
            {
                isClickedGrey = !isClickedGrey;
                Debug.Log("Grey clicked");
            }
            if (rayHitInfo.collider.tag == "RedBox")
            {
                isClickedRed = !isClickedRed;
                Debug.Log("Red clicked");
            }
            if (rayHitInfo.collider.tag == "PinkBox")
            {
                isClickedPink = !isClickedPink;
                Debug.Log("Pink clicked");
            }
            if (rayHitInfo.collider.tag == "OrangeBox")
            {
                isClickedOrange = !isClickedOrange;
                Debug.Log("Orange clicked");
            }
            if (rayHitInfo.collider.tag == "YellowBox")
            {
                isClickedYellow = !isClickedYellow;
                Debug.Log("Yellow clicked");
            }
            if (rayHitInfo.collider.tag == "EnterBox")
            {
                finalizeAnswere = true;
            }

        }
        //ANSWERES AND DECLARING WIN/LOSE FOR EACH GAME STATE
        if (State == 1)
        {
            
            if (Model == 0 || Model == 1)
            {
                if (finalizeAnswere ==true)
                {
                    if (isClickedPink == true && isClickedGreen == true && isClickedBlue == false && isClickedGrey == false && isClickedOrange == false && isClickedRed == false && isClickedTeal == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }
            else if (Model == 2)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedTeal == true && isClickedOrange == true && isClickedBlue == false && isClickedGrey == false && isClickedPink == false && isClickedRed == false && isClickedGreen == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }

        }
        if (State == 2)
        {

            if (Model == 0 || Model == 1)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedOrange == true && isClickedYellow == true && isClickedBlue == false && isClickedTeal == false && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false)
                    {
                        YouWin();
                    }
                    else {YouLose(); }
                }
            }
            else if (Model == 2)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedTeal == true && isClickedOrange == true && isClickedBlue == false && isClickedGreen == false && isClickedGrey== false && isClickedRed == false && isClickedPink == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }

        }
        if (State == 3)
        {

            if (Model == 0 || Model == 2)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedPink == true && isClickedGrey == true && isClickedBlue == false && isClickedTeal == false && isClickedGreen == false && isClickedRed == false && isClickedOrange == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }
            else if (Model == 1)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedTeal == true && isClickedBlue == true && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false && isClickedOrange == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }

        }
        if (State == 4)
        {

            if (Model == 0 || Model == 1)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedPink == true && isClickedGreen == true && isClickedBlue == false && isClickedTeal == false && isClickedGrey == false && isClickedRed == false && isClickedOrange == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }
            else if (Model == 2)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedRed == true && isClickedBlue == true && isClickedTeal == false && isClickedGreen == false && isClickedGrey == false && isClickedPink == false && isClickedOrange == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }

        }
        if (State == 5)
        {

            if (Model == 0 || Model == 2)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedRed == true && isClickedYellow == true && isClickedBlue == false && isClickedTeal == false && isClickedGreen == false && isClickedGrey == false && isClickedPink == false && isClickedOrange == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }
            else if (Model ==1)
            {
                if (finalizeAnswere == true)
                {
                    if (isClickedTeal == true && isClickedBlue == true && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedOrange == false && isClickedPink == false && isClickedYellow == false)
                    {
                        YouWin();
                    }
                    else { YouLose(); }
                }
            }

        }
        if (State == 6)
        {

            if (finalizeAnswere == true)
            {
                    if (isClickedTeal == true && isClickedOrange == true && isClickedBlue == false && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false && isClickedYellow == false)
                    {
                        YouWin();
                }
                    else { YouLose(); }
                }
        }

    }

	void spawnBlue()
	{
		GameObject myButton = (GameObject)Instantiate(blueBox, new Vector3(-2f, 4f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
	}
	void spawnTeal()
	{
        GameObject myButton = (GameObject)Instantiate(tealBox, new Vector3(-2f, 2f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }
	void spawnGreen()
	{
        GameObject myButton = (GameObject)Instantiate(greenBox, new Vector3(-2f, 0f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }
	void spawnGrey()
	{
        GameObject myButton = (GameObject)Instantiate(greyBox, new Vector3(-2f, -2f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }
	void spawnRed()
	{
        GameObject myButton = (GameObject)Instantiate(redBox, new Vector3(0f, 4f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }
	void spawnPink()
	{
        GameObject myButton = (GameObject)Instantiate(pinkBox, new Vector3(0f, 2f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }
	void spawnOrange()
	{
        GameObject myButton = (GameObject)Instantiate(orangeBox, new Vector3(0f, 0f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }
	void spawnYellow()
	{
        GameObject myButton = (GameObject)Instantiate(yellowBox, new Vector3(0f, -2f, 0f), gameObject.transform.rotation);
        myButton.transform.parent = transform;
    }









}
