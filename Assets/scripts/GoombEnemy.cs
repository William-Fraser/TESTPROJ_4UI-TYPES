using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombEnemy : MonoBehaviour
{
    [HideInInspector]
    public bool alive = true; // checked for on gun hit
    [Range(-1, 1)]
    public int direciton = 1;
    public float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!alive) gameObject.SetActive(false);
        gameObject.transform.Translate(direciton * speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            direciton *= -1;
        }
    }
}
