using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MoveBall : MonoBehaviour
{
    public int speed;
    public Transform[] wayPoints;
    public AudioClip clip;
    public AudioSource source;

    private Transform target;
    private int destPoint = 0;

    private void Start()
    {
        target = wayPoints[Random.Range(0,15)];
    }


    private void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            SceneManager.LoadScene("Credits");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            destPoint = (destPoint + 1) % wayPoints.Length;
            target = wayPoints[destPoint];
            source.PlayOneShot(clip);
            StartCoroutine(SpeedUp());
        }
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(15f);
        speed++;
    }

}
