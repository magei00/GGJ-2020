using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Camera Camera;
    public Avatar Avatar;

    private InputMaster _inputMaster;

    void Awake() {
        _inputMaster = new InputMaster();

        _inputMaster.Core.Select.started += context => print("YOOO");
        _inputMaster.Core.Select.performed += context => {
            Select(Mouse.current.position.ReadValue());
        };
    }

    public void Select(Vector2 screenPos) {
        var ray = Camera.ScreenPointToRay(screenPos);
        var hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit.collider != null) {
            var item = hit.collider.gameObject.GetComponent<Item>();
            if (item != null) {
                Debug.Log("Hit item");
            }

            var patient = hit.collider.gameObject.GetComponent<Patient>();
            if (patient != null) {
                Debug.Log("Hit patient");
            }

            var bloodBank = hit.collider.gameObject.GetComponent<Bloodbank>();
            if (bloodBank != null) {
                Debug.Log("Hit bloodbank");
            }
        }
    }

    private void OnEnable() {
        _inputMaster.Enable();
    }

    private void OnDisable() {
        _inputMaster.Disable();
    }
}