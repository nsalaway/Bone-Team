using UnityEngine;
using System.Collections;

public class First_Negatives : MonoBehaviour {

	//***PUBLIC OBJECTS FOR EYE 0
	//the eyes that must be turned off and on.   
	public GameObject openLeft;
	public GameObject closedLeft;
	public GameObject openRight;
	public GameObject closedRight;


	//materials
	public Material blueMaterial;
	public Material whiteMaterial;
	public Material darkBlue;
	public Material darkerBlue;
	public Material darkestBlue;
	public Material blackMaterial;
	public Material pinkMaterial;
    public Material superPinkMaterial;

    //eye0 hierarchy
    public GameObject bottomLeft;
	public GameObject bottomRight;

	public GameObject secondLeft;
	public GameObject secondRight;

	public GameObject thirdLeft;
	public GameObject thirdRight;

	public GameObject fourthLeft;
	public GameObject fourthRight;

	public GameObject fifthLeft;
	public GameObject fifthRight;

	public GameObject heartLeft;
	public GameObject heartRight;

	public float duration = 0.2f;

	//public MeshRenderer heartRenderer;
	//***END PUBLIC OBJECTS FOR EYE 0





	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 1 (visor)****

	public GameObject visor;
	public Material badReaction;
	public Material frownyFace;
    public Material defaultMaterial;

    //****END OBJECTS FOR EYE 1.


    //***THE FOLLOWING ARE FOR PUBLIC OBJECTS WITH EYE 2

    public GameObject startX;
	public GameObject otherX;

	public GameObject startO;
	public GameObject otherO;

	public GameObject left1;
	public GameObject left2;
	public GameObject left3;


	public GameObject right1;
	public GameObject right2;
	public GameObject right3;

	// END OBJECTS FOR EYE 2

	// Use this for initialization
	void Start () {

		
		
	
	
	}






    public void badAnimationStart(int myEye)
    {
        if (myEye == 0)
        {
            Debug.Log("the right eye");
            StartCoroutine(BlueScreened());
        }
        else if (myEye == 1)
        {
            StartCoroutine(bad1Animation());
        }
        else if (myEye == 2)
        {
            StartCoroutine(bad2Animation());
        }
    }








    //COROUTINE ANIMATION FOR EYE 0
    public IEnumerator BlueScreened(){


        foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>())
        {
            closedLeftRenderer.enabled = true;
        }

        foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>())
        {
            openLeftRenderer.enabled = false;
        }
        foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>())
        {
            openRightRenderer.enabled = false;
        }

        foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>())
        {
            closedRightRenderer.enabled = true;
        }


        yield return new WaitForSeconds (0.5f);
			foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>()) {
				closedLeftRenderer.enabled = false;
			}

			foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>()) {
				openLeftRenderer.enabled = true;
			}

			//this replaces the closed right eye with an open right eye. 
			foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>()) {
				openRightRenderer.enabled = true;
			}

			foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>()) {
				closedRightRenderer.enabled = false;
			}


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

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = whiteMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = whiteMaterial;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			heartRight.GetComponent<MeshRenderer> ().material = darkBlue;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fourthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			heartRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			thirdRight.GetComponent<MeshRenderer> ().material = darkBlue;

			fourthLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			fourthRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			heartRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			secondRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			thirdLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			thirdRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			secondRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blueMaterial;


			yield return new WaitForSeconds (0.5f);

			bottomLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.5f);

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

			heartLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			yield return new WaitForSeconds (0.5f);

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.5f);

			heartLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			yield return new WaitForSeconds (0.5f);

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (1f);
			bottomLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			secondRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			thirdLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			thirdRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

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

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);
			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fourthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

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

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

        yield return new WaitForSeconds(0.3f);

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


        thirdLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
        thirdRight.GetComponent<MeshRenderer>().material = pinkMaterial;

        heartLeft.GetComponent<MeshRenderer>().material = pinkMaterial;
        heartRight.GetComponent<MeshRenderer>().material = pinkMaterial;

        yield return null;

    }

	//END COROUTINE FOR EYE 0





	public IEnumerator bad1Animation (){

        visor.GetComponent<MeshRenderer>().material = badReaction;

        visor.GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(0f, -0.03f);
        visor.GetComponent<MeshRenderer>().material.mainTextureScale = new Vector2(-9.33f, -2.89f);

        yield return new WaitForSeconds (0.3f);

			visor.GetComponent<MeshRenderer> ().material = frownyFace;

			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0f, -0.2f);
				visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (29.66f, 1.5f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.3f, -0.2f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.6f, -0.2f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.9f, -0.2f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (1.2f, -0.2f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (1.5f, -0.2f);

        yield return new WaitForSeconds(0.3f);

        visor.GetComponent<MeshRenderer>().material = defaultMaterial;
        visor.GetComponent<MeshRenderer>().material.mainTextureScale = new Vector2(-5.51f, -1f);

        yield return null;


    }



    public IEnumerator bad2Animation()
    {

        foreach (MeshRenderer otherXRenderer in otherX.GetComponentsInChildren<MeshRenderer>())
        {
            otherXRenderer.enabled = true;
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
            startORenderer.enabled = false;


            //startX.GetComponent<MeshRenderer> ().material = blackMaterial;
            //otherX.GetComponent<MeshRenderer> ().material = blackMaterial;

          

            left1.GetComponent<MeshRenderer>().material = blackMaterial;
            right1.GetComponent<MeshRenderer>().material = blackMaterial;

            left3.GetComponent<MeshRenderer>().material = blackMaterial;
            right3.GetComponent<MeshRenderer>().material = blackMaterial;


            yield return new WaitForSeconds(1f);




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

            foreach (MeshRenderer startOrRenderer in startO.GetComponentsInChildren<MeshRenderer>())
            {
                startOrRenderer.enabled = true;

            }


            left2.GetComponent<MeshRenderer>().material = pinkMaterial;
            right2.GetComponent<MeshRenderer>().material = pinkMaterial;

            left3.GetComponent<MeshRenderer>().material = pinkMaterial;
            right3.GetComponent<MeshRenderer>().material = pinkMaterial;

            left1.GetComponent<MeshRenderer>().material = superPinkMaterial;
            right1.GetComponent<MeshRenderer>().material = superPinkMaterial;

            yield return null;  

        }



    }


}
