using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionSuccses : UIManager
{
    [SerializeField] private Text scoreText =null;
    [SerializeField] private Text missionText=null;
    [SerializeField] private GameObject menuButton=null;
    [SerializeField] private CharacterControl control;
    bool isDone = true;
    public override void UpdatePanel()
    {
        scoreText.text = "Score:" + control.money + "$";
        missionText.text = "Mission Succsesful :)";
    }

    public override void UpdateState()
    {
        if (GetCharacterAnim.GetBool("win"))
        {
            scoreText.gameObject.SetActive(true);
            missionText.gameObject.SetActive(true);
            menuButton.SetActive(true);
            if (isDone)
            {
                money += control.money;
                isDone = false;
                MainMenu.isBuy = false;
            }

            Debug.Log("money"+money);
        }
    }
}
