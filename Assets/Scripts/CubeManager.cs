using TMPro;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private float _startTimeSpawn;
    [SerializeField] private float _distance;
    [SerializeField] private float _speed;
    
    [SerializeField] private TMP_InputField _distanceTMP;
    [SerializeField] private TMP_InputField _timeTMP;
    [SerializeField] private TMP_InputField _speedTMP;
    
    [SerializeField] private GameObject prefabCube;
    
    private float _timeSpawn;
    
    void Start()
    {
        ShowUI();
        _timeSpawn = _startTimeSpawn;
    }

    void FixedUpdate()
    {
        if (_timeSpawn > 0)
        {
            _timeSpawn -= Time.deltaTime;
        }
        else
        {
            _timeSpawn = _startTimeSpawn;
            SpawnCube();
        }
    }
    
    private void SpawnCube()
    {
        GameObject spawn = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
        Vector2 startPos = Vector2.up * _distance;
        Vector3 endPos = new Vector3(startPos.x, 0, startPos.y);
        spawn.GetComponent<CubeMoving>().SetCubeMoving(_speed, endPos);
    }
    
    private void ShowUI()
    {
        _distanceTMP.text = "";
        _timeTMP.text = "";
        _speedTMP.text = "";
        _distanceTMP.placeholder.GetComponent<TextMeshProUGUI>().text = "default: " + _distance;
        _timeTMP.placeholder.GetComponent<TextMeshProUGUI>().text = "default: " + _startTimeSpawn;
        _speedTMP.placeholder.GetComponent<TextMeshProUGUI>().text = "default: " + _speed;
    }
    
    public void SetDistance(string distance)
    {
        if (!distance.Equals(""))
        {
            _distance = float.Parse(distance);
        }
    }    
    
    public void SetTime(string time)
    {
        if (!time.Equals(""))
        {
            _startTimeSpawn = float.Parse(time);
        }
    }
    
    public void SetSpeed(string speed)
    {
        if (!speed.Equals(""))
        {
            _speed = float.Parse(speed);
        }
    }
}
