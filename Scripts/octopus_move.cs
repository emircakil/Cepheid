
using UnityEngine;
using UnityEngine.SceneManagement;

public class octopus_move : MonoBehaviour
{

    public Transform octopus;
    public float moveSpeed = 1.5f;


    private void Start()
    {

    }
    private void Update()
    {

        octopus.Translate(new Vector2(0.5f, 0f) * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<octopus_move>().moveSpeed = 0f;
        SceneManager.LoadScene("SampleScene");
    }

}

