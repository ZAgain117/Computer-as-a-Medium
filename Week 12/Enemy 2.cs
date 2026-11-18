using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public GameObject deathText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
    }

    void Death()
    {
        if (enemyHealth <= 0)
        {
            StartCoroutine(LastWords());
        }
    }

    public IEnumerator LastWords()
    {
        deathText.SetActive(true);
        yield return new WaitForSeconds(3);
        deathText.SetActive(false);
        Destroy(gameObject); 

    }



}
