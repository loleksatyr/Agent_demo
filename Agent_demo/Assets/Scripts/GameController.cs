using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] int _agentNumber = 30;

    public static int _currentNumber = 0;

    [SerializeField] 
    [Range(2,10)]
    float _agenttime;

    [SerializeField] GameObject _agentPrefab;

    [SerializeField] GameObject _spawner;

    private float cooldownTimer;

    void Start()
    {
        
    }

    void Update()
    {
        if (_currentNumber <= 30)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer > 0) return;
            _agenttime = Random.Range(1f, 9f) + 1;
            cooldownTimer = _agenttime;
            CreateAgent();
        }
    }
    private void CreateAgent() {
        GameObject agent = Instantiate(_agentPrefab, _spawner.transform.position, Quaternion.identity) as GameObject;      
        _currentNumber++;
    }
}
