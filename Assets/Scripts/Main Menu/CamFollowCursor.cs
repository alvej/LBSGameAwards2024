using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowCursor : MonoBehaviour
{
    public float sensitivity;
    public float maxMovement; // Så mkt den kan röra sig

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {

        Vector2 screenPosition = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);

        Vector2 normalizedPosition = (screenPosition * 2) - Vector2.one;

        float targetX = Mathf.Clamp(normalizedPosition.x * sensitivity, -maxMovement, maxMovement);
        float targetY = Mathf.Clamp(normalizedPosition.y * sensitivity, -maxMovement, maxMovement);

        Vector3 targetPosition = new Vector3(initialPosition.x + targetX, initialPosition.y + targetY, initialPosition.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * sensitivity);
    }
}
