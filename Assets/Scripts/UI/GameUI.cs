using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : UIManager
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject hearts;
    [SerializeField] private Image heartImg1, heartImg2, heartImg3,heartImg4;
    CharacterControl control;
    private void Awake()
    {
        control = FindObjectOfType<CharacterControl>();
        if (!MainMenu.isBuy)
        {
            Destroy(heartImg4);
        }else
        {
            control.can = 4;
        }
    }
    public override void UpdatePanel()
    {
        UpdateLife(control.can);

        scoreText.text = "Score :" + control.money;
        Debug.Log(control.can);
    }
    public override void UpdateState()
    {
        if (GetCharacterAnim.GetBool("running"))
        {
            scoreText.gameObject.SetActive(true);   
            hearts.SetActive(true);

        }
        else if (GetCharacterAnim.GetBool("win"))
        {
            scoreText.gameObject.SetActive(false);
            hearts.SetActive(false);
        }
        else if (GetCharacterAnim.GetBool("lose"))
        {
            scoreText.gameObject.SetActive(false);
            hearts.SetActive(false);
        }
    }
    void UpdateLife(int life)
    {
        if (life == 3)
            Destroy(heartImg4);
        else if (life == 2)
            Destroy(heartImg1);
        else if (life == 1)
            Destroy(heartImg2);
        else if (life == 0)
            Destroy(heartImg3);
    }
}
