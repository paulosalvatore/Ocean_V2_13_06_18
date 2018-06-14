using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour {

	public GameObject zumbiPrefab;
	public float delay = 2f;
	public float area = 2f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("GerarZumbi", delay, delay);
	}
	
	// Update is called once per frame
	void GerarZumbi () {
		GameObject zumbi = Instantiate (zumbiPrefab);

		Vector2 posicaoAleatoria = Random.insideUnitCircle * area;

		zumbi.transform.position = new Vector3 (
			posicaoAleatoria.x,
			0,
			posicaoAleatoria.y
		);
	}
}
