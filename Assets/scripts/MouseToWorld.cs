using UnityEngine;

public class MouseToWorld : MonoBehaviour
{
    public Transform ObjToChangePos;
    private void Start()
    {
        if (ObjToChangePos == null) {

            ObjToChangePos = transform;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Click izquierdo
        {
            Vector3 mouseScreenPos = Input.mousePosition;

            // Importante: en 2D necesitamos definir la distancia a la cámara
            mouseScreenPos.z = Mathf.Abs(Camera.main.transform.position.z);

            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

            Debug.Log("Posición en mundo: " + mouseWorldPos);
            ObjToChangePos.position = mouseWorldPos;

        }
    }
}