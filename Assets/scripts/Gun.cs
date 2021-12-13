using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{ 
    [Header("Gun")]
    public TextMesh ammoDisplay;
    public int MaxAmmo = 6;
    public GameObject viewPoint;

    private int ammo;
    private Color defaultColour;
    public int Ammo { set { ammo = value; } get { return ammo; } }


    // Start is called before the first frame update
    void Start()
    {
        defaultColour = ammoDisplay.color;
        ammo = MaxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        //ammo control
        ammoDisplay.text = ammo.ToString();

        if (ammo <= 0)
        {
            ammo = 0;
            ammoDisplay.color = Color.red;
        }
        else
        { 
            ammoDisplay.color = defaultColour;
        }

        //shooting the gun
        if (Input.GetMouseButtonDown(0))
        { Shoot(); }
    }
    public void Shoot()
    {
        ammo--;
        RaycastHit hit;
        int layerMask = 1<<2;
        layerMask = ~layerMask;
        
        if (Physics.Raycast(viewPoint.transform.position, viewPoint.transform.forward, out hit, Mathf.Infinity, layerMask))
        {
            if (hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.gameObject.SetActive(false);
            }
            /*if (hit.collider.gameObject.GetComponent<GoombEnemy>()) {
                hit.collider.gameObject.GetComponent<GoombEnemy>().alive = false;
        } */
        }
    }
}
