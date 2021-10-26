using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCaster : MonoBehaviour
{
    [SerializeField] private string m_triggerButton;
    [SerializeField] private GameObject m_basicSpell;
    [SerializeField] private Transform m_spellSpawn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(m_triggerButton))
        {
            GameObject go = Instantiate(m_basicSpell, m_spellSpawn.position, m_spellSpawn.rotation);
            Destroy(go, 3);
        }
    }
}









/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCaster : MonoBehaviour
{
    [SerializeField] private string m_triggerButton;
    [SerializeField] private GameObject m_basicSpell;
    [SerializeField] private Transform m_spellSpawn;


    [SerializeField] private float m_coolDown;
    private float m_currentTime;


    // Update is called once per frame
    void Update()
    {
        m_currentTime += Time.deltaTime;

        if(Input.GetButtonDown(m_triggerButton) && m_currentTime > m_coolDown)
        {
            GameObject go = Instantiate(m_basicSpell, m_spellSpawn.position, m_spellSpawn.rotation);
            Destroy(go, 3);
            m_currentTime = 0;
        }
    }
}
*/