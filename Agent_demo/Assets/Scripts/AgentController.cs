using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    [SerializeField] int MoveSpeed;
    [SerializeField] int Health = 3;
    [SerializeField] float number;
    public static int currentHealth;
    void Start()
    {
        MoveSpeed = 4;
        number = Random.Range(-10f, 10f);
        transform.Rotate(0, number, 0, Space.Self);
    }


    void Update()
    {
        checkedges();
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        if (Health <=0) {
            Destroy(gameObject);
        }
    }
    private void checkedges()
    {
        
        bool edge = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1);
        if (edge == false)
        {
            number = Random.Range(-10f, 10f);
            transform.Rotate(0, number, 0, Space.Self);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Agent") {
            Health--;
        }
    }
    public void OnMouseDown()
    {
        currentHealth = Health;
        CanvasController.ShowController = true;
    }
    public int GetHealth() {
        return Health;
    }

}
