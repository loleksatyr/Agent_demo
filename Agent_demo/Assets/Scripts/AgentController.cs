using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    [SerializeField] int MoveSpeed;
    [SerializeField] int Health;
    [SerializeField] float number;
    void Start()
    {
        MoveSpeed = 4;
        Health = 3;
        number = Random.Range(-15f, 15f);
        transform.Rotate(0, number, 0, Space.Self);
    }


    void Update()
    {
        checkedges();
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
    private void checkedges()
    {
        bool edge = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 2);
        if (edge == false)
        {
            transform.Rotate(0, number, 0, Space.Self);
        }
    }
}
