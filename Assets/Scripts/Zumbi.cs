using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

	private GameObject jogador;

	public float velocidade = 0.35f;
	public float delayAndar = 1f;
	private bool andando = false;
	private bool morto = false;

	public Rigidbody rb;
	private Animator animator;

	// Use this for initialization
	void Start () {
		jogador = GameObject.FindGameObjectWithTag ("Player");
		transform.LookAt (jogador.transform);

		Invoke ("Andar", delayAndar);

		animator = GetComponent<Animator> ();
	}

	void Andar () {
		andando = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (andando) {
			rb.velocity = transform.forward * velocidade;
		}
	}

	void OnTriggerEnter (Collider colisor) {
		if (!morto && colisor.CompareTag("Projétil")) {
			Destroy (colisor.gameObject);
			Matar ();
		}
	}

	void Matar ()
	{
		andando = false;
		animator.SetTrigger ("Die");
		morto = true;
	}
}
