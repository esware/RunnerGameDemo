using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour,IUIManager
{
    public static int money=0;
    [SerializeField] Animator characterAnim;

    public Animator GetCharacterAnim { get => characterAnim;}

    private void Update()
    {
        UpdateState();
        UpdatePanel();
    }

    public virtual void UpdateState()
    {
    }
    public virtual void UpdatePanel()
    {

    }
    public virtual void Buy()
    {

    }

}
