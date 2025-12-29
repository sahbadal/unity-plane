
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float verticalSpeed = 10f;
    public float rotationSpeed = 40f;

    public GameObject gameOverText;
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * verticalInput * verticalSpeed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(-verticalInput * rotationSpeed, 0, 0);

        //transform.Rotate(Vector3.right * -verticalInput * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle") && !isGameOver)
        {
            isGameOver = true;
            Time.timeScale = 0f;
            gameOverText.SetActive(true);

            StartCoroutine(RestartAfterDelay());
        }
    }

    IEnumerator RestartAfterDelay()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
