using UnityEngine;

public class AtivarDesativarPainel : MonoBehaviour
{
    public GameObject painelAtivarDesativar; // O painel que você deseja ativar/desativar
    private bool painelAtivado = false; // Estado do painel

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !painelAtivado)
        {
            painelAtivarDesativar.SetActive(true); // Ativa o painel quando o jogador encosta no objeto
            painelAtivado = true; // Define o estado do painel como ativado
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && painelAtivado)
        {
            painelAtivarDesativar.SetActive(false); // Desativa o painel quando o jogador sai do objeto
            painelAtivado = false; // Define o estado do painel como desativado
        }
    }
}
