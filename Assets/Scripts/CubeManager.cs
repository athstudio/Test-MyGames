using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private float startTimeSpawn;
    [SerializeField] private float distance;
    [SerializeField] private float speed;
    
    [SerializeField] private GameObject prefabCube;
    
    private float _timeSpawn;
    
    void Start()
    {
        _timeSpawn = startTimeSpawn;
    }

    void FixedUpdate()
    {
        if (_timeSpawn > 0)
        {
            _timeSpawn -= Time.deltaTime;
        }
        else
        {
            _timeSpawn = startTimeSpawn;
            SpawnCube();
        }
    }
    
    private void SpawnCube()
    {
        GameObject spawn = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
        Vector2 startPos = Vector2.up * distance;
        Vector3 endPos = new Vector3(startPos.x, 0, startPos.y);
        // add script CubeMoving
    }
}
