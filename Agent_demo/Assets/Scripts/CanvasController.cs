using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] Text _agentNumber;
    [SerializeField] Text _thisEnemyHelth;
    [SerializeField] GameObject _agentUI;
    public static bool ShowController = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _agentUI.SetActive(ShowController);
        _agentNumber.text = GameController._currentNumber.ToString();
        _thisEnemyHelth.text = AgentController.currentHealth.ToString();
        
    }
}
