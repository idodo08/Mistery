using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject panel; // Referência ao painel que será aberto

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica se o jogador entrou na área
        {
            panel.SetActive(true); // Abre o painel
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica se o jogador saiu da área
        {
            panel.SetActive(false); // Fecha o painel
        }
    }
}