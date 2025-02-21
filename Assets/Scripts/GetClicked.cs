using UnityEngine;
using UnityEngine.InputSystem;

public class GetClicked : MonoBehaviour
{   
    void Update () {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            CastRay(mousePosition);
        }

        if (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            CastRay(touchPosition);
        }
    }

    void CastRay(Vector2 clickPos) {
        Ray ray = Camera.main.ScreenPointToRay(clickPos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitGameObject = hit.collider.gameObject;
            DoSomethingOnClick click = hitGameObject.GetComponent<DoSomethingOnClick>();
            if (click != null) {
                click.InvokeEvent();
            }
        }
    }

}
