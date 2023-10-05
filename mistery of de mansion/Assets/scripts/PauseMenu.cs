using JetBrains.Annotations;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Canvas canvas; // Arraste o objeto Canvas desejado para este campo no Inspector.

    public Transform pauseMenu;
    void Update()
    {
        // Verifica se a tecla Esc foi pressionada.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.gameObject.activeSelf)
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
                }
            }
            public void ResumeGame()
            {
                pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
            }

        }

