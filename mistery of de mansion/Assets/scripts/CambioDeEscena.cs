using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string nombreDeEscenaDestino = "Escena2";

    // M�todo para cambiar de escena cuando se presione un bot�n
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeEscenaDestino);
    }
}

