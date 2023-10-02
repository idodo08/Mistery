using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string nombreDeEscenaDestino = "Escena2";

    // Método para cambiar de escena cuando se presione un botón
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeEscenaDestino);
    }
}

