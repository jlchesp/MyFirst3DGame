using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Debug.Log("El juego ha comenzado");
    }

    // Update is called once per frame
    void Update() {

    }
    
    /*Método que se llama automáticamente cuando otro collider
    entra en contacto con el que tiene asignado este script*/
    private void OnTriggerEnter(Collider otherCollider) {

        if(otherCollider.CompareTag("Player")) { //Condicional que recoge el tag asignado al jugador
            Debug.Log("Algo ha colisionado con la moneda");
            Destroy(gameObject); //Destruye el gameObject que tiene asignado este script
        }
    }
    
}
