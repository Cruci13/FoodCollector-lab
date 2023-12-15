using UnityEngine;

// на обєкті гравця вішаємо скрипт та добавляємо компонент Rigidbody2D і колайдер
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0f);

        _rigidbody.velocity = new Vector2(movement.x * _speed, _rigidbody.velocity.y);
    }
}
