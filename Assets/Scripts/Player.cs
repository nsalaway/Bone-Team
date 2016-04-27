using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    int counter = 0;
    public AudioSource[] goodSounds = new AudioSource[4];
    public AudioSource tick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit mouseRayHit = new RaycastHit();



        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(mouseRay, out mouseRayHit, 1000f))
            {


        
                switch (mouseRayHit.collider.tag)
                {
                    case "Up":
                        tick.Play();
                        Ray upRay = new Ray(transform.position, Vector3.forward);
                        RaycastHit upRayInfo;
                        if (Physics.Raycast(upRay, out upRayInfo, 1))
                        {
                            if (upRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.forward;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.forward;
                            GoodSound();
                        }
                        break;


                    case "Down":
                        tick.Play();
                        Ray downRay = new Ray(transform.position, Vector3.back);
                        RaycastHit downRayInfo;
                        if (Physics.Raycast(downRay, out downRayInfo, 1))
                        {
                            if (downRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.back;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.back;
                            GoodSound();
                        }
                        break;


                    case "Left":
                        tick.Play();
                        Ray leftRay = new Ray(transform.position, Vector3.left);
                        RaycastHit leftRayInfo;
                        if (Physics.Raycast(leftRay, out leftRayInfo, 1))
                        {
                            if (leftRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.left;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.left;
                            GoodSound();
                        }
                        break;


                    case "Right":
                        tick.Play();
                        Ray rightRay = new Ray(transform.position, Vector3.right);
                        RaycastHit rightRayInfo;
                        if (Physics.Raycast(rightRay, out rightRayInfo, 1))
                        {
                            if (rightRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.right;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.right;
                            GoodSound();
                        }
                        break;
                }
            }
        }

    }

    void GoodSound()
    {
        int randomizer = Random.Range(0, 2);
        if (randomizer == 0)
        {
            randomizer = Random.Range(0, 4);
            goodSounds[randomizer].Play();
        }
    }


}
