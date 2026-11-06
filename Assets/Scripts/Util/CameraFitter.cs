using UnityEngine;
[RequireComponent(typeof(Camera))]
public class CameraFitter : MonoBehaviour
{
    [SerializeField] float worldWidth = 16f;
    [SerializeField] float worldHeight = 9f;
    [SerializeField] float margin = 0.4f;
    Camera cam;
    void Awake() { cam = GetComponent<Camera>(); }

    void LateUpdate()
    {
        float needW = worldWidth + margin * 2f;
        float needH = worldHeight + margin * 2f;
        float sizeByHeight = needH * 0.5f;
        float sizeByWidth = needW * 0.5f / cam.aspect;
        cam.orthographicSize = Mathf.Max(sizeByHeight, sizeByWidth);
        cam.transform.position = new Vector3(0f, 0f, -10f);
    }
}