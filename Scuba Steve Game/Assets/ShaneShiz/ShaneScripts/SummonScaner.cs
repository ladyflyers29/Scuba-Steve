using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonScaner : MonoBehaviour
{

    public GameObject m_Projectile;    // this is a reference to your projectile prefab
    public Transform m_SpawnTransform;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
        Destroy(gameObject);
    }
}
