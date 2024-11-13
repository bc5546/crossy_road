using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveTime = 0.4f;
    public float moveDistance = 1f;
    private Vector3 curPos;
    public bool isKeyCanceled=true;
    public Transform chick = null;

    // Start is called before the first frame update
    void Start()
    {
        curPos = transform.position;
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector3 input = context.ReadValue<Vector3>();
        if (input.magnitude > 1) { return; }


        if (context.performed&&isKeyCanceled)
        {
            Moving(transform.position + input * moveDistance);
            Rotate(input * moveDistance);
            isKeyCanceled = false;
        }
        if (input.magnitude == 0)
        {
            isKeyCanceled=true;
        }
    }

    void Moving(Vector3 pos)
    {
        LeanTween.move(this.gameObject, pos, moveTime);
    }

    void Rotate(Vector3 pos)
    {
        chick.rotation = Quaternion.Euler(270, pos.x * 90, 0);
    }
}
