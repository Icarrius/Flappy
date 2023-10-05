using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveSpeed;

    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive) 
        {
            return;
        }

        rb.velocity = new Vector3(0, rb.velocity.y, moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isAlive)
        {
            StartCoroutine(RestartLevel());
        }

        isAlive = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("SampleScene");
    }
}