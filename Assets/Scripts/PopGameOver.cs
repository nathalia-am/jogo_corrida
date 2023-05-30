using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopGameOver : MonoBehaviour {

// Declaro las variables y todos los objetos que voy a utilizar

	public Image BGpop;
	public Image imgPop;
	public Button botonReiniciar;
	public Text metrosRecorridos;
	public GameObject popGameOverGO;
	public Image imagenFundido;
	public Cronometro cronometroScript;
	public GameObject musicaJuego;
	public AudioClip musicaGameOver;
	public GameObject Coche;



	// Use this for initialization
	void Start () {

		popGameOverGO.SetActive(false);
	
	}

	public void ActivoGameOver()
	{
		musicaJuego.GetComponent<AudioSource>().clip = musicaGameOver;
		musicaJuego.GetComponent<AudioSource>().Play();
		botonReiniciar.gameObject.SetActive(true);
		BGpop.CrossFadeAlpha(1,0.3f,false);
		imgPop.CrossFadeAlpha(1,0.3f,false);
		metrosRecorridos.CrossFadeAlpha(1,0.3f,false);
		metrosRecorridos.text = "Has recorrido "+ ((int)cronometroScript.distancia).ToString() + " mts";
		Coche.GetComponent<AudioSource>().Stop();
	}

	public void ReiniciarJuego()
	{
		imagenFundido.CrossFadeAlpha(1,0.5f,false);
		StartCoroutine(CargoEscena());
	}

	IEnumerator CargoEscena()
	{
		yield return new WaitForSeconds(1);
		Application.LoadLevel("Intro");
	}

}