using UnityEngine;
using UnityEngine.EventSystems;

public class CameraForwardUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public GameObject mainCamera;
    bool _pressed = false;
    public float moveSpeed;

    public void OnPointerDown(PointerEventData eventData)
    {
        _pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _pressed = false;
    }

    void Update()
    {
        if (!_pressed)
            return;

        mainCamera.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);
    }

}
