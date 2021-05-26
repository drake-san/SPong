using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private void Update()
    {
            Move();
    }


    public void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.5f, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.5f, 0, Space.World);
        }
    }

    
}
