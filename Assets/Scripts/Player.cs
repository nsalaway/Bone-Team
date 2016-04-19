using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Ray moveRay = new Ray(transform.position, Vector3.forward);
            RaycastHit raycastInfo;
            if (Physics.Raycast(moveRay, out raycastInfo, 1))
            {
                if (raycastInfo.collider.tag == "Goal")
                {
                    transform.position = transform.position + Vector3.forward;
                    Debug.Log("You Win!");
                }
                else
                {
                    Debug.Log("Wall!");
                }
            }

            else
            {
                transform.position = transform.position + Vector3.forward;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Ray moveRay = new Ray(transform.position, Vector3.back);
            RaycastHit raycastInfo;
            if (Physics.Raycast(moveRay, out raycastInfo, 1))
            {
                if (raycastInfo.collider.tag == "Goal")
                {
                    transform.position = transform.position + Vector3.back;
                    Debug.Log("You Win!");
                }
                else
                {
                    Debug.Log("Wall!");
                }
            }

            else
            {
                transform.position = transform.position + Vector3.back;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Ray moveRay = new Ray(transform.position, Vector3.left);
            RaycastHit raycastInfo;
            if (Physics.Raycast(moveRay, out raycastInfo, 1))
            {
                if (raycastInfo.collider.tag == "Goal")
                {
                    transform.position = transform.position + Vector3.left;
                    Debug.Log("You Win!");
                }
                else
                {
                    Debug.Log("Wall!");
                }
            }

            else
            {
                transform.position = transform.position + Vector3.left;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Ray moveRay = new Ray(transform.position, Vector3.right);
            RaycastHit raycastInfo;
            if (Physics.Raycast(moveRay, out raycastInfo, 1))
            {
                if (raycastInfo.collider.tag == "Goal")
                {
                    transform.position = transform.position + Vector3.right;
                    Debug.Log("You Win!");
                }
                else
                {
                    Debug.Log("Wall!");
                }
            }

            else
            {
                transform.position = transform.position + Vector3.right;
            }
        }


    }

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("hey");
        if (coll.gameObject.tag == "Goal")
        {
            Debug.Log("YOU WIN!");
        }
    }
}
