using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start : UIManager
{
    [SerializeField] private Text startText;

    public override void UpdatePanel()
    {
        startText.text = "Tap to Start";
    }

    public override void UpdateState()
    {
        if (GetCharacterAnim.GetBool("running"))
        {
            startText.gameObject.SetActive(false);
        }
    }
}