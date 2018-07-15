using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentences;
    private Queue<string> npcname;
    private Queue<bool> containsResponse;
    private Queue<string> responses;

    public Text nameText;
    public Text dialogueText;
    public Animator animator;


    // Use this for initialization
    void Start () {
        sentences = new Queue<string>();
        npcname = new Queue<string>();
        containsResponse = new Queue<bool>();
        responses = new Queue<string>();
	}
	
    public void StartDialogue (Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);
        foreach (string name in dialogue.name)
        {
            npcname.Enqueue(name);
        }
        foreach (bool isResponse in dialogue.isResponse)
        {
            containsResponse.Enqueue(isResponse);
        }
        foreach (string response in dialogue.responses)
        {
            responses.Enqueue(response);
        }
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    
    public void DisplayNextSentence ()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        string name = npcname.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence, name));
    }
    IEnumerator TypeSentence (string sentence, string name)
    {
        AudioSource dialougeFX = GetComponentInParent<AudioSource>();
        nameText.text = name;
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            yield return new WaitForSeconds(.025f);
            dialogueText.text += letter;
            if (animator.GetBool("IsOpen"))
            {
                dialougeFX.Play();
            }
            yield return null;
        }
    }
    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}