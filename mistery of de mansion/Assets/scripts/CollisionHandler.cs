using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject panel; // Refer�ncia ao painel que ser� aberto

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica se o jogador entrou na �rea
        {
            panel.SetActive(true); // Abre o painel
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica se o jogador saiu da �rea
        {
            panel.SetActive(false); // Fecha o painel
        }
    }
}