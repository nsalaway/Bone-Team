using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    int counter = 0;
    //Vector3 moveRight = new Vector3(0.62016666666666666666666666666665f, 0, 0);
    //Vector3 moveLeft = new Vector3(-0.62016666666666666666666666666665f, 0, 0);
    //Vector3 moveUp = new Vector3(0, 0, 0.6262777777777777777777777777778f);
    //Vector3 moveDown = new Vector3(0, 0, -0.6262777777777777777777777777778f);
    Vector3 moveRight = new Vector3(1.2403333333333333333333333333333f, 0, 0);
    Vector3 moveLeft = new Vector3(-1.2403333333333333333333333333333f, 0, 0);
    Vector3 moveUp = new Vector3(0, 0, 1.2525555555555555555555555555556f);
    Vector3 moveDown = new Vector3(0, 0, -1.2525555555555555555555555555556f);

	public AudioSource soundManager;
	public AudioClip clickSound;

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

                        if (Physics.Raycast(upRay, out upRayInfo, .65f))
                        {
                            if (upRayInfo.collider.tag == "Goal")
                            {
								soundManager.PlayOneShot (clickSound, 0.7f);
                                transform.localPosition = transform.localPosition + moveUp;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
								soundManager.PlayOneShot (clickSound, 0.7f);
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.localPosition = transform.localPosition + moveUp;
							soundManager.PlayOneShot (clickSound, 0.7f);
                        }
                        break;


                    case "Down":
                        Ray downRay = new Ray(transform.position, Vector3.back);
                        RaycastHit downRayInfo;
                        if (Physics.Raycast(downRay, out downRayInfo, .65f))
                        {
                            if (downRayInfo.collider.tag == "Goal")
                            {
								soundManager.PlayOneShot (clickSound, 0.7f);
                                transform.localPosition = transform.localPosition + moveDown;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
								soundManager.PlayOneShot (clickSound, 0.7f);
                                Debug.Log("Wall!");
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.localPosition = transform.localPosition + moveDown;
							soundManager.PlayOneShot (clickSound, 0.7f);
                        }
                        break;


                    case "Left":
                        Ray leftRay = new Ray(transform.position, Vector3.left);
                        RaycastHit leftRayInfo;
                        if (Physics.Raycast(leftRay, out leftRayInfo, .65f))
                        {
                            if (leftRayInfo.collider.tag == "Goal")
                            {
								soundManager.PlayOneShot (clickSound, 0.7f);
                                transform.localPosition = transform.localPosition + moveLeft;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
								soundManager.PlayOneShot (clickSound, 0.7f);
                                Debug.Log("Wall!");
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.localPosition = transform.localPosition + moveLeft;
							soundManager.PlayOneShot (clickSound, 0.7f);
                        }
                        break;


                    case "Right":
                        Ray rightRay = new Ray(transform.position, moveRight);
                        RaycastHit rightRayInfo;
                        if (Physics.Raycast(rightRay, out rightRayInfo, .65f))
                        {
                            if (rightRayInfo.collider.tag == "Goal")
                            {
								soundManager.PlayOneShot (clickSound, 0.7f);
                                transform.localPosition = transform.localPosition + Vector3.right;
                                Debug.Log("You Win!");
                                OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
                                //tell game manager the game was won
                                //destroy maze
                            }
                            else
                            {
                                counter++;
								soundManager.PlayOneShot (clickSound, 0.7f);
                                Debug.Log("Wall!");
                                OverallGameManagerErik.MadeError();
                            }
                        }

                        else
                        {
                            transform.localPosition = transform.localPosition + moveRight;
							soundManager.PlayOneShot (clickSound, 0.7f);
                        }
                        break;
                }
            }
        }

    }
}
