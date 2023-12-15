using UnityEngine;

namespace Game.Sources.Player
{
    public class PlayerAnimations : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private void Update()
        {
            // дивлячись на те куди нажимає гравець a/d ми повертаємо спрайт в ту сторону та включаємо анімацію бігу
            var horizontalInput = Input.GetAxis("Horizontal");
            
            _animator.SetBool("IsRunning", horizontalInput != 0);
            gameObject.transform.localScale = new Vector3(horizontalInput < 0 ? 0.6f : -0.6f, 0.6f, 0.6f);
        }
    }
}