using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera Camera;

    private InputMaster _inputMaster;

    void Awake() {
        _inputMaster = new InputMaster();

        _inputMaster.Core.Select.performed += context => Select(context.ReadValue<Vector2>());
    }

    public void Select(Vector2 screenPos) {
        var hit = Physics2D.Raycast(Camera.ScreenToWorldPoint(screenPos), Vector2.zero);

        if (hit.collider != null) {
            
        }
    }

    private void OnEnable() {
        _inputMaster.Enable();
    }

    private void OnDisable() {
        _inputMaster.Disable();
    }
}