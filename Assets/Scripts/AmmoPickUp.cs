using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {
    
    private int _ammo;
    UIManager uiManager;

    private void Start()
    {
        uiManager = GameObject.FindWithTag("UI").GetComponent<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ammo"))
        {
            _ammo++;
            Destroy(col.gameObject);
            Debug.Log(_ammo);
            uiManager.SetAmmoText(_ammo);
        }
    }
}