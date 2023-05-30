using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LimiteCarreteras : MonoBehaviour {

// Declaro las variables y todos los objetos que voy a utilizar
	public MotorCarreteras motorCarreterasScript;

	public void OnTriggerEnter2D ( Collider2D cInfo)
	{
		//si el objeto con el que choca se llama limite calles
		if (cInfo.gameObject.tag == "LimiteCalles")
		{
			Destroy(cInfo.transform.parent.gameObject);
            Debug.Log("Acinou o objeto.");
			motorCarreterasScript.CreaCalles();
		}
	}


}
