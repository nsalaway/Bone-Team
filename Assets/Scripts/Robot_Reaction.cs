using UnityEngine;
using System.Collections;

public class Robot_Reaction : MonoBehaviour {


	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 0 (hearts)****
	//turned off for testing
	public GameObject closedRight;
	public GameObject openRight;

    public GameObject closedLeft, openLeft;

    
	//materials
	public  Material pinkMaterial;
	public  Material blackMaterial;
	public  Material superPinkMaterial;
	public  Material reallySuperPinkMaterial;

	//eye1 hierarchy
	public  GameObject bottomLeft;
	public  GameObject bottomRight;

	public  GameObject secondLeft;
	public  GameObject secondRight;

	public  GameObject thirdLeft;
	public  GameObject thirdRight;

	public  GameObject fourthLeft;
	public  GameObject fourthRight;

	public  GameObject fifthLeft;
	public  GameObject fifthRight;

	public  GameObject heartLeft;
	public  GameObject heartRight;

	//****END OBJECTS FOR EYE 0.****



	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 1 (visor)****

	public GameObject visor;
	public Material winkyFace;
    public Material defaultMaterial;
	public Material goodReaction;

	//****END OBJECTS FOR EYE 1.



	//***THE FOLLOWING ARE FOR PUBLIC OBJECTS WITH EYE 2

	public GameObject startX;
	public GameObject otherX;

	public GameObject startO;
	public GameObject otherO;

	// END OBJECTS FOR EYE 2




	// Use this for initialization
	void Start () {


	}













    //ANIMATION IF EYE == 0 





    public void eyeAnimationStart(int myEye)
    {
        if (myEye == 0)
        {
            StartCoroutine(eye0Animation());
        }
        else if (myEye == 1)
        {
            StartCoroutine(eye1Animation());
        }
        else if (myEye == 2)
        {
            StartCoroutine(eye2Animation());
        }
    }








    public IEnumerator eye0Animation(){

 

            foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>())
            {
                closedLeftRenderer.enabled = false;
            }

            foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>())
            {
                openLeftRenderer.enabled = true;
            }

            //this replaces the closed right eye with an open right eye. 
            foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>())
            {
                openRightRenderer.enabled = true;
            }

            foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>())
            {
                closedRightRenderer.enabled = false;
            }



            bottomLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
            bottomRight.GetComponent<MeshRenderer>().material = pinkMaterial;

            secondLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
            secondRight.GetComponent<MeshRenderer>().material = pinkMaterial;

            thirdLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
            thirdRight.GetComponent<MeshRenderer>().material = pinkMaterial;

            fourthLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
            fourthRight.GetComponent<MeshRenderer>().material = pinkMaterial;

            fifthLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
            fifthRight.GetComponent<MeshRenderer>().material = pinkMaterial;

            heartLeft.GetComponent<MeshRenderer>().material = superPinkMaterial;
            heartRight.GetComponent<MeshRenderer>().material = superPinkMaterial;



            yield return new WaitForSeconds (0.5f);
		
            	bottomLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		bottomRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		thirdRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		fourthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		fourthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		fifthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		fifthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		heartLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
		heartRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			//layer 1
			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			//layer 2
			yield return new WaitForSeconds (0.5f);

			bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;


			//layer 3

			yield return new WaitForSeconds (0.5f);
			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			//layer 4

			yield return new WaitForSeconds (0.5f);
			bottomLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			//layer 5

			yield return new WaitForSeconds (0.5f);
			bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;
        yield return new WaitForSeconds(0.5f);

        foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>())
        {
            closedLeftRenderer.enabled = false;
        }

        foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>())
        {
            openLeftRenderer.enabled = true;
        }

        //this replaces the closed right eye with an open right eye. 
        foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>())
        {
            openRightRenderer.enabled = false;
        }

        foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>())
        {
            closedRightRenderer.enabled = true;
        }


        bottomLeft.GetComponent<MeshRenderer>().material = blackMaterial;
        bottomRight.GetComponent<MeshRenderer>().material = blackMaterial;

        secondLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
        secondRight.GetComponent<MeshRenderer>().material = pinkMaterial;

        thirdLeft.GetComponent<MeshRenderer>().material = blackMaterial;
        thirdRight.GetComponent<MeshRenderer>().material = blackMaterial;

        fourthLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
        fourthRight.GetComponent<MeshRenderer>().material = pinkMaterial;

        fifthLeft.GetComponent<MeshRenderer>().material = blackMaterial;
        fifthRight.GetComponent<MeshRenderer>().material = blackMaterial;

        heartLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
        heartRight.GetComponent<MeshRenderer>().material = pinkMaterial;



        yield return null;
        
			
	}

    //END 














    public IEnumerator eye1Animation (){


			visor.GetComponent<MeshRenderer> ().material = winkyFace;
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (30.4f, 3f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.3f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.6f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.9f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.2f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.5f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.8f, 0f);

            yield return new WaitForSeconds(0.3f);

            visor.GetComponent<MeshRenderer>().material = defaultMaterial;
            visor.GetComponent<MeshRenderer>().material.mainTextureScale = new Vector2(-5.51f, -1f);

            yield return null;
	
	}




    public IEnumerator eye2Animation()
    {


        foreach (MeshRenderer otherXRenderer in otherX.GetComponentsInChildren<MeshRenderer>())
        {
            otherXRenderer.enabled = true;
        }

        foreach (MeshRenderer otherORenderer in otherO.GetComponentsInChildren<MeshRenderer>())
        {
            otherORenderer.enabled = true;
        }

        foreach (MeshRenderer startXRenderer in startX.GetComponentsInChildren<MeshRenderer>())
        {
            startXRenderer.enabled = false;
        }

        foreach (MeshRenderer startORenderer in startO.GetComponentsInChildren<MeshRenderer>())
        {
            startORenderer.enabled = false;
        }
        yield return new WaitForSeconds(0.5f);

        foreach (MeshRenderer otherXRenderer in otherX.GetComponentsInChildren<MeshRenderer>())
        {
            otherXRenderer.enabled = false;
        }

        foreach (MeshRenderer otherORenderer in otherO.GetComponentsInChildren<MeshRenderer>())
        {
            otherORenderer.enabled = false;
        }

        foreach (MeshRenderer startXRenderer in startX.GetComponentsInChildren<MeshRenderer>())
        {
            startXRenderer.enabled = true;
        }

        foreach (MeshRenderer startORenderer in startO.GetComponentsInChildren<MeshRenderer>())
        {
            startORenderer.enabled = true;
        }

        yield return new WaitForSeconds(0.5f);

        foreach (MeshRenderer otherXRenderer in otherX.GetComponentsInChildren<MeshRenderer>())
        {
            otherXRenderer.enabled = true;
        }

        foreach (MeshRenderer otherORenderer in otherO.GetComponentsInChildren<MeshRenderer>())
        {
            otherORenderer.enabled = true;
        }

        foreach (MeshRenderer startXRenderer in startX.GetComponentsInChildren<MeshRenderer>())
        {
            startXRenderer.enabled = false;
        }

        foreach (MeshRenderer startORenderer in startO.GetComponentsInChildren<MeshRenderer>())
        {
            startORenderer.enabled = false;
        }

        yield return new WaitForSeconds(0.5f);

        foreach (MeshRenderer otherXRenderer in otherX.GetComponentsInChildren<MeshRenderer>())
        {
            otherXRenderer.enabled = false;
        }

        foreach (MeshRenderer otherORenderer in otherO.GetComponentsInChildren<MeshRenderer>())
        {
            otherORenderer.enabled = false;
        }

        foreach (MeshRenderer startXRenderer in startX.GetComponentsInChildren<MeshRenderer>())
        {
            startXRenderer.enabled = true;
        }

        foreach (MeshRenderer startORenderer in startO.GetComponentsInChildren<MeshRenderer>())
        {
            startORenderer.enabled = true;

        }

        yield return null;
    }





    }
