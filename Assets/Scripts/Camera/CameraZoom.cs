using UnityEngine;

public class CameraZoom : MonoBehaviour {

    private Camera mainCamera;

    private Vector3 lastPanPosition;
    private int PanFingerId;

    private bool wasZoomingLastFrame;
    private Vector2[] lastZoomPositions;

    private static readonly float ZoomSpeedTouch = 0.1f;
    private static readonly float[] ZoomBounds = new float[] { 20f, 120f };

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.touchCount != 2) {
            wasZoomingLastFrame = false;
            return;
        }

        Vector2[] newPositions = new Vector2[] { Input.GetTouch(0).position, Input.GetTouch(1).position };

        if (!wasZoomingLastFrame)
        {
            lastZoomPositions = newPositions;
            wasZoomingLastFrame = true;
        }
        else
        {
            // Zooom based on the distance between the new positions compared to the
            // distance between the previous positions

            float newDistance = Vector2.Distance(newPositions[0], newPositions[1]);
            float oldDistance = Vector2.Distance(lastZoomPositions[0], lastZoomPositions[1]);
            float offset = newDistance - oldDistance;

            ZoomCamera(offset, ZoomSpeedTouch);
        }       
    }

    void ZoomCamera(float offset, float speed)
    {
        if (offset == 0)
            return;

        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView - (offset * speed), ZoomBounds[0], ZoomBounds[1]);

    }



}
