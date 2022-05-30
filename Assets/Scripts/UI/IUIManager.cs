using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIManager 
{
    public Animator GetCharacterAnim { get; }

    public void UpdateState();
    public void UpdatePanel();
    public void Buy();
}
