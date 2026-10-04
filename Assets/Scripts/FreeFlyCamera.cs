using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif


/// Cámara libre para recorrer la escena.
/// WASD = moverse | Mouse = mirar | E / Q = subir / bajar
/// Shift = ir rápido | Esc = soltar el mouse | Clic izquierdo = volver a capturarlo

public class FreeFlyCamera : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 15f;
    public float fastMultiplier = 3f;

    [Header("Mouse")]
    public float lookSensitivity = 0.12f;
    public float minPitch = -85f;
    public float maxPitch = 85f;

    float yaw;
    float pitch;

    void Start()
    {
        Vector3 e = transform.eulerAngles;
        yaw = e.y;
        pitch = e.x > 180f ? e.x - 360f : e.x;
        LockCursor(true);
    }

    void Update()
    {
        Vector2 look = Vector2.zero;
        Vector3 move = Vector3.zero;
        bool fast = false;

#if ENABLE_INPUT_SYSTEM
        var kb = Keyboard.current;
        var mouse = Mouse.current;
        if (kb == null || mouse == null) return;

        look = mouse.delta.ReadValue();
        if (kb.wKey.isPressed) move.z += 1;
        if (kb.sKey.isPressed) move.z -= 1;
        if (kb.dKey.isPressed) move.x += 1;
        if (kb.aKey.isPressed) move.x -= 1;
        if (kb.eKey.isPressed) move.y += 1;
        if (kb.qKey.isPressed) move.y -= 1;
        fast = kb.leftShiftKey.isPressed;

        if (kb.escapeKey.wasPressedThisFrame) LockCursor(false);
        if (mouse.leftButton.wasPressedThisFrame) LockCursor(true);
#else
        look = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * 10f;
        move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        if (Input.GetKey(KeyCode.E)) move.y += 1;
        if (Input.GetKey(KeyCode.Q)) move.y -= 1;
        fast = Input.GetKey(KeyCode.LeftShift);

        if (Input.GetKeyDown(KeyCode.Escape)) LockCursor(false);
        if (Input.GetMouseButtonDown(0)) LockCursor(true);
#endif

        // Mirar solo si el mouse está capturado
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            yaw += look.x * lookSensitivity;
            pitch -= look.y * lookSensitivity;
            pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
            transform.rotation = Quaternion.Euler(pitch, yaw, 0f);
        }

        // Moverse
        float speed = moveSpeed * (fast ? fastMultiplier : 1f);
        Vector3 dir = transform.forward * move.z + transform.right * move.x + Vector3.up * move.y;
        if (dir.sqrMagnitude > 1f) dir.Normalize();
        transform.position += dir * speed * Time.deltaTime;
    }

    void LockCursor(bool locked)
    {
        Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !locked;
    }
}
