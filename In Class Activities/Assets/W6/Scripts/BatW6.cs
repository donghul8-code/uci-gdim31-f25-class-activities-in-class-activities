using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    
    private bool _ischasing;
    private Transform _playerTransform;
    [SerializeField] private float _speed;
    private void Update()
    {
        if (_ischasing)
        {
            transform.position = Vector2.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
        }
    }

    public void Startchasing(Transform playerTransform)
    {
        _ischasing = true;
        _playerTransform = playerTransform;
    }

    public void Stopchasing()
    {
        _ischasing = false; 
    }
}
