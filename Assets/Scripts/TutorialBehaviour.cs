using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialBehaviour : MonoBehaviour
{

    [SerializeField]
    private Text healthPrompt;
    private bool hasHealthPromptBeen = false;

    [SerializeField]
    private Text scorePrompt;
    private bool hasScorePromptBeen = false;

    [SerializeField]
    private Text defencePrompt;
    private bool hasDefencePromptBeen = false;

    [SerializeField]
    private Text mainPrompt;
    private bool hasMainPromptBeen = false;

    // Start is called before the first frame update
    void Start()
    {
        mainPrompt.text = "READY? GO";
        StartCoroutine(waiter());
        EventSystem.current.onEnemyKilledIncreaseScore += activateScorePrompt;
        EventSystem.current.onPlayerHitTakeALife += activateHealthPrompt;
        EventSystem.current.onDefenceHit += activateDefencePrompt;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        mainPrompt.text = "";
        scorePrompt.text = "";
        healthPrompt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateScorePrompt()
    {
        if (hasScorePromptBeen == false)
        {
            scorePrompt.text = "Each kill increases your score!";
            StartCoroutine(waiter());
            hasScorePromptBeen = true;
        }

    }

    public void activateHealthPrompt()
    {
        if (hasHealthPromptBeen == false)
        {
            healthPrompt.text = "<- Keep an eye on your health!";
            StartCoroutine(waiter());
            hasHealthPromptBeen = true;
        }
    }

    public void activateDefencePrompt()
    {
        if (hasDefencePromptBeen == false)
        {
            defencePrompt.text = "Rona bullets can't go through the defences!";
            StartCoroutine(waiter());
            hasDefencePromptBeen = true;
        }
    }
}
