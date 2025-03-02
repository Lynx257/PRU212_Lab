using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public float minAngle = -60f;
    public float maxAngle = 60f;

    void Update()
    {
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        angle = Mathf.Clamp(angle, minAngle, maxAngle);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
