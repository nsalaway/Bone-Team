﻿using UnityEngine;
using System.Collections;

public class RobotGenerator : MonoBehaviour {
	//okay, so do this for arms, eyes, antenna, and possibly heads(include mouths with this and blush, place eyes in same place.
	//and bodies, for porn and junk. 
	//that's fifteen. 
	//nine are necessary right now (antenna, heads, 
	//generating an antenna should always 

	//list of arms
//	public GameObject Arm1;
	//public GameObject Arm2;
	//public GameObject Arm3;

	//list of eyes (be sure to split this into right eye left eye, tag them, etc, to ensure best results when doing expressions)

	public GameObject Eyes1;
	public GameObject Eyes2;
	public GameObject Eyes3;
	MeshRenderer eye1Renderer;

	//list of antennas
	public GameObject Antenna1;
	public GameObject Antenna2;
	public GameObject Antenna3;

	//list of heads (blush marks and such for variety). 
	public GameObject Robot1;
	public GameObject Robot2;
	public GameObject Robot3;





	// Use this for initialization
	void Start () {


		//eyeball generator
		//int eyeNumber = Random.Range (1, 4);

		if (OverallGameManagerErik.eyes==0) {
			Debug.Log ("it was one");

			foreach (MeshRenderer eye1Renderer in Eyes1.GetComponentsInChildren<MeshRenderer>()) {
				eye1Renderer.enabled = true;
			}

			foreach (MeshRenderer eye2Renderer in Eyes2.GetComponentsInChildren<MeshRenderer>()) {
				eye2Renderer.enabled = false;
			}

			foreach (MeshRenderer eye3Renderer in Eyes3.GetComponentsInChildren<MeshRenderer>()) {
				eye3Renderer.enabled = false;
			}

		} else if (OverallGameManagerErik.eyes == 1) {

			foreach (MeshRenderer eye1Renderer in Eyes1.GetComponentsInChildren<MeshRenderer>()) {
				eye1Renderer.enabled = false;
			}

			foreach (MeshRenderer eye2Renderer in Eyes2.GetComponentsInChildren<MeshRenderer>()) {
				eye2Renderer.enabled = true;
			}

			foreach (MeshRenderer eye3Renderer in Eyes3.GetComponentsInChildren<MeshRenderer>()) {
				eye3Renderer.enabled = false;
			}
			Debug.Log ("it was two");

		} else if (OverallGameManagerErik.eyes == 2) {

			foreach (MeshRenderer eye1Renderer in Eyes1.GetComponentsInChildren<MeshRenderer>()) {
				eye1Renderer.enabled = false;
			}

			foreach (MeshRenderer eye2Renderer in Eyes2.GetComponentsInChildren<MeshRenderer>()) {
				eye2Renderer.enabled = false;
			}

			foreach (MeshRenderer eye3Renderer in Eyes3.GetComponentsInChildren<MeshRenderer>()) {
				eye3Renderer.enabled = true;
			}
			Debug.Log ("Three");
		}




		//antenna generator
		//int antennaNumber = Random.Range (1, 4);
		if (OverallGameManagerErik.antenna == 0) {
			Debug.Log ("it was one");
			//this section makes the antenna disappear
			foreach (MeshRenderer antenna1Renderer in Antenna1.GetComponentsInChildren<MeshRenderer>()) {
				antenna1Renderer.enabled = true;
			}

			foreach (MeshRenderer antenna2Renderer in Antenna2.GetComponentsInChildren<MeshRenderer>()) {
				antenna2Renderer.enabled = false;
			}

			foreach (MeshRenderer antenna3Renderer in Antenna3.GetComponentsInChildren<MeshRenderer>()) {
				antenna3Renderer.enabled = false;
			}


		} else if (OverallGameManagerErik.antenna == 1) {
			Debug.Log ("it was two");
			//this section makes the antenna disappear
			foreach (MeshRenderer antenna1Renderer in Antenna1.GetComponentsInChildren<MeshRenderer>()) {
				antenna1Renderer.enabled = false;
			}

			foreach (MeshRenderer antenna2Renderer in Antenna2.GetComponentsInChildren<MeshRenderer>()) {
				antenna2Renderer.enabled = true;
			}

			foreach (MeshRenderer antenna3Renderer in Antenna3.GetComponentsInChildren<MeshRenderer>()) {
				antenna3Renderer.enabled = false;
			}
		} else if (OverallGameManagerErik.antenna == 2) {
			Debug.Log ("Three");
			//this section makes the antenna disappear
			foreach (MeshRenderer antenna1Renderer in Antenna1.GetComponentsInChildren<MeshRenderer>()) {
				antenna1Renderer.enabled = false;
			}

			foreach (MeshRenderer antenna2Renderer in Antenna2.GetComponentsInChildren<MeshRenderer>()) {
				antenna2Renderer.enabled = false;
			}

			foreach (MeshRenderer antenna3Renderer in Antenna3.GetComponentsInChildren<MeshRenderer>()) {
				antenna3Renderer.enabled = true;
			}
		}





		//robot generator
		int robotNumber = Random.Range (1, 4);
		if (robotNumber == 1) {
			Debug.Log ("it was one");

			//this section makes the heads disappear
			foreach (MeshRenderer robot1Renderer in Robot1.GetComponentsInChildren<MeshRenderer>()) {
				robot1Renderer.enabled = true;
			}

			foreach (MeshRenderer robot2Renderer in Robot2.GetComponentsInChildren<MeshRenderer>()) {
				robot2Renderer.enabled = false;
			}

			foreach (MeshRenderer robot3Renderer in Robot3.GetComponentsInChildren<MeshRenderer>()) {
				robot3Renderer.enabled = false;
			}


		} else if (robotNumber == 2) {
			Debug.Log ("it was two");

				//this section makes the heads disappear
				foreach (MeshRenderer robot1Renderer in Robot1.GetComponentsInChildren<MeshRenderer>()) {
					robot1Renderer.enabled = false;
				}

				foreach (MeshRenderer robot2Renderer in Robot2.GetComponentsInChildren<MeshRenderer>()) {
					robot2Renderer.enabled = true;
				}

			foreach (MeshRenderer robot3Renderer in Robot3.GetComponentsInChildren<MeshRenderer>()) {
				robot3Renderer.enabled = false;
			}
		} else if (robotNumber == 3) {
			Debug.Log ("Three");

					//this section makes the heads disappear
					foreach (MeshRenderer robot1Renderer in Robot1.GetComponentsInChildren<MeshRenderer>()) {
						robot1Renderer.enabled = false;
					}

					foreach (MeshRenderer robot2Renderer in Robot2.GetComponentsInChildren<MeshRenderer>()) {
						robot2Renderer.enabled = false;
					}

					foreach (MeshRenderer robot3Renderer in Robot3.GetComponentsInChildren<MeshRenderer>()) {
						robot3Renderer.enabled = true;
		}





		}




















	}
	
	// Update is called once per frame
	void Update () {

	}
}
