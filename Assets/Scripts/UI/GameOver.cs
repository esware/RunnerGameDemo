using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : UIManager
{
    [SerializeField] private Text ScoreText = null;
    [SerializeField] private Text GameOverText = null;
    [SerializeField] private GameObject Buttons = null;
    [SerializeField] private CharacterControl control;
    public override void UpdatePanel()
    {
        ScoreText.text = "Your Score :" + control.money;
        GameOverText.text = "Game Over";
    }

    public override void UpdateState()
    {
        if (GetCharacterAnim.GetBool("lose"))
        {
            ScoreText.gameObject.SetActive(true);
            GameOverText.gameObject.SetActive(true);
            Buttons.SetActive(true);
            MainMenu.isBuy = false;

        }
    }
}
