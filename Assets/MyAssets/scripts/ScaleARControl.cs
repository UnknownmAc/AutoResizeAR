using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleARControl : MonoBehaviour {
	public GameObject chair;
	public GameObject table;
	public GameObject lamp;
	public GameObject cabinet;
	public GameObject chairDescText;

	private bool chairButtonClicked = false;
	private bool tableButtonClicked = false;
	private bool lampButtonClicked = false;
	private bool cabinetButtonClicked = false;

	private int frames = 0;


	// Use this for initialization
	void Start () {
		chair.SetActive (false);
		lamp.SetActive (false);
		cabinet.SetActive (false);
		table.SetActive (false);
		chairDescText.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		chair.SetActive (chairButtonClicked);
		lamp.SetActive (lampButtonClicked);
		cabinet.SetActive (cabinetButtonClicked);
		table.SetActive (tableButtonClicked);

		if(frames >= 250)
			chairDescText.SetActive (true);
		frames++;
	}

	public void HandleIncreaseScale() {
		table.transform.localScale += new Vector3 (0.1F, 0.1F, 0.1F);
		chair.transform.localScale += new Vector3 (0.1F, 0.1F, 0.1F);
		lamp.transform.localScale += new Vector3 (0.1F, 0.1F, 0.1F);
		chair.transform.Translate (0.0f, 0.0f, 0.001f, Space.World);
		table.transform.Translate (0.0f, 0.0f, 0.001f, Space.World);
		lamp.transform.Translate (0.03f, 0.05f, 0.0f, Space.World);
	}

	public void HandleDecreaseScale() {
		table.transform.localScale -= new Vector3 (0.1F, 0.1F, 0.1F);
		chair.transform.localScale -= new Vector3 (0.1F, 0.1F, 0.1F);
		lamp.transform.localScale -= new Vector3 (0.1F, 0.1F, 0.1F);
		chair.transform.Translate (0.0f, 0.0f, -0.001f, Space.World);
		table.transform.Translate (0.0f, 0.0f, -0.001f, Space.World);
		lamp.transform.Translate (-0.03f, -0.05f, 0.0f, Space.World);
	}

	public void HandlePlaceChair() {
		chairButtonClicked = true;
		chair.SetActive (true);
	}

	public void HandlePlaceTable(){
		tableButtonClicked = true;
		table.SetActive (true);
	}

	public void HandlePlaceLamp(){
		lampButtonClicked = true;
		lamp.SetActive (true);
	}

	public void HandlePlaceCabinet(){
		cabinetButtonClicked = true;
		cabinet.SetActive (true);
	}
}
