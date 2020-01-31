using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputMaster _inputMaster;

    void Awake() {
        _inputMaster = new InputMaster();

        _inputMaster.Core.Select.performed += context => Select(context.ReadValue<Vector2>());
    }

    public void Select(Vector2 screenPos) {

    }

    private void OnEnable() {
        _inputMaster.Enable();
    }

    private void OnDisable() {
        _inputMaster.Disable();
    }
}