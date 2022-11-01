using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    [SerializeField] private float cubeTimeLife = 5f;
    
    private float _speed;
    private Vector3 _endPos;
    
    private void Update()
    {
        transform.position = Vector3.Slerp(transform.position, _endPos, Time.deltaTime * _speed);
        Destroy(gameObject, cubeTimeLife);
    }
    
    public void SetCubeMoving(float speed, Vector3 endPos)
    {
        _speed = speed;
        _endPos = endPos;
    }
}
