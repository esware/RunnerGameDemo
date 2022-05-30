using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    Vector3 distance;
    CharacterControl controller;
    public GameObject camera2;

    [SerializeField] private float smooth;

    private void Awake()
    {
        controller = FindObjectOfType<CharacterControl>();
        distance = transform.position - controller.transform.position;

    }

    private void Update()
    {
        Vector3 cameraPos = distance + controller.transform.position;
        transform.position = Vector3.Lerp(transform.position, cameraPos, smooth * Time.deltaTime);
        if (controller.isFinish)
        {
            camera2.SetActive(true);
            camera2.transform.position = transform.position;
            gameObject.SetActive(false);
        }

    }
}
