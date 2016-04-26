using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    int counter = 0;

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
                        Ray upRay = new Ray(transform.position, Vector3.forward);
                        RaycastHit upRayInfo;
                        if (Physics.Raycast(upRay, out upRayInfo, 1))
                        {
                            if (upRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.forward;
                                Debug.Log("You Win!");
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.forward;
                        }
                        break;


                    case "Down":
                        Ray downRay = new Ray(transform.position, Vector3.back);
                        RaycastHit downRayInfo;
                        if (Physics.Raycast(downRay, out downRayInfo, 1))
                        {
                            if (downRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.back;
                                Debug.Log("You Win!");
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.back;
                        }
                        break;


                    case "Left":
                        Ray leftRay = new Ray(transform.position, Vector3.left);
                        RaycastHit leftRayInfo;
                        if (Physics.Raycast(leftRay, out leftRayInfo, 1))
                        {
                            if (leftRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.left;
                                Debug.Log("You Win!");
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.left;
                        }
                        break;


                    case "Right":
                        Ray rightRay = new Ray(transform.position, Vector3.right);
                        RaycastHit rightRayInfo;
                        if (Physics.Raycast(rightRay, out rightRayInfo, 1))
                        {
                            if (rightRayInfo.collider.tag == "Goal")
                            {
                                transform.position = transform.position + Vector3.right;
                                Debug.Log("You Win!");
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
                                Debug.Log("Wall!");
                            }
                        }

                        else
                        {
                            transform.position = transform.position + Vector3.right;
                        }
                        break;
                }
            }
        }

        if (counter >= 3)
        {
            //tell game manager game was lost
            //destroy maze
        }

    }

    /*void OnCollisionEnter(Collision coll)
    {
        Debug.Log("hey");
        if (coll.gameObject.tag == "Goal")
        {
            //tell game manager the game was won
            //destroy maze
            Debug.Log("YOU WIN!");
        }
    }*/
}
