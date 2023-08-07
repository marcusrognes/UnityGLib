using UnityEngine;
using UnityEngine.InputSystem;

namespace GLib.Player
{
    public class Player2DMovementBehaviour : MonoBehaviour
    {
        public float speed = 5f;

        private Vector2 _lastInput;

        private Rigidbody2D _rb;
        // Start is called before the first frame update
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            _rb.velocity =_lastInput * speed;
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _lastInput = context.ReadValue<Vector2>();
        }
    }
}
