using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcDialogue : MonoBehaviour
{
    public string[] dialogueNPC;
    public int dialogueIndex;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public Text nameNpc;
    public Image imageNpc;
    public Sprite spriteNpc;

    public bool readyToSpeak;
    public bool starDialogue;
    private object collision;
    private bool startDialogue;

    Player player;
    private string letter;
    private object dialogueNpc;

    // Start is called before the first frame update
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && readyToSpeak)
        {
            if (!startDialogue)
            {
                player.speed = 0;
                StartDialogue();
            }
            else if (dialogueText.text == dialogueNpc.dialogueIndex) ;
            {

            }
        }
    }

    void StartDialogue()
    {
        nameNpc.text = "Marcos"; 
        imageNpc.sprite = spriteNpc;
        startDialogue = true;
        dialogueIndex = 0;
        dialoguePanel.SetActive(true);
        StartCoroutine(ShowDialogue());
    }
    IEnumerator ShowDialogue()
    {
        dialogueText.text = "";
        foreach (char letter in dialogueNPC[dialogueIndex]) ;
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
         {
            player = collision.GetComponent<Player>();
            readyToSpeak = true;
        }  
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = false;
        }
    }
}
