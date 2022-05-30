using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameState
{
    Start,
    GameOver,
    GameWin,
}
public class CharacterControl : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float slideDuration;
    public bool slideEnd = false;
    public int can = 3;
    public bool isFinish = false;
    private CharacterController controller;

    public int money;
    public int level;
    public CharacterController GetController(CharacterControl control)
    {
        if(controller == null)
        {
            controller = control.GetComponent<CharacterController>();
        }
        return controller;
    }

    bool toggle = false;

    void Start()
    {
        Time.timeScale = 1.2f;
        Screen.SetResolution(1080, 1920,true);
    }

    private void FixedUpdate()
    {
        //Increase Speed
        if (toggle)
        {
            toggle = false;
            if (forwardSpeed < maxSpeed)
                forwardSpeed += 0.1f * Time.fixedDeltaTime;
        }
        else
        {
            toggle = true;
            if (Time.timeScale < 2f)
                Time.timeScale += 0.005f * Time.fixedDeltaTime;
        }
    }

    private void Update()
    {
        level = SceneManagement.level;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            can--;
        }

        if(other.gameObject.tag == "Collectables")
        {
            money += 2;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Finish")
        {
            isFinish = true;
        }
    }

    public void Slide()
    {
        StartCoroutine(SlideCor());
    }

    IEnumerator SlideCor()
    {
        yield return new WaitForSeconds(0.25f / Time.timeScale);
        controller.center = new Vector3(0,0.5f,0);
        controller.height = 1f;
        yield return new WaitForSeconds((slideDuration - 0.25f) / Time.timeScale);
        controller.center = new Vector3(0, 1, 0);
        controller.height = 2f;
        slideEnd = true;
    }


    //public void SaveData()
    //{
    //    SaveSystem.SavePlayer(this);
    //}
    //public void LoadData()
    //{
    //    PlayerData data = SaveSystem.LoadPlayer();

    //    level = data.level;
    //    money = data.money;
    //}
}

