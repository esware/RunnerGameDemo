using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : UIManager
{
    public Text levelText, moneyText;
    [SerializeField] private CharacterControl control;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject store;
    [SerializeField] private Text walletText;
    [SerializeField] private Text info;
    public static bool isBuy = false;

    private void Awake()
    {
        control = FindObjectOfType<CharacterControl>();
    }
    public override void UpdatePanel()
    {
        levelText.text = "Your Level :"+control.level.ToString();
        moneyText.text = "Your Money :"+money.ToString()+" $";
        walletText.text = "Your Money :" + money.ToString() + " $";
        Debug.Log("main menu");
    }

    public void Store()
    {
        mainMenu.SetActive(false);
        store.SetActive(true);
    }

    public override void Buy()
    {
        if(money >= 100)
        {
            money -= 100;
            info.text = "purchase successful";
            control.can = 4;
            isBuy = true;
        }
        else
        {
            info.text = "your money is not enough";
        }
    }

    public void Exit()
    {
        mainMenu.SetActive(true);
        store.SetActive(false);
    }
}
