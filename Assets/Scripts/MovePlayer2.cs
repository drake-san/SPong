using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    private void Update()
    {
        Move();
    }


    public void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.5f, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.5f, 0, Space.World);
        }
    }
}
