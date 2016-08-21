using UnityEngine;
using System.Collections;

public class elf_gauge : MonoBehaviour 
{
    public float maxHealth = 100f;
    public float currentHealth;
    public float healthDownforTime = 5f;
    public Hashtable quest;
    public GameObject healthFill;
    float healthPercent;
    Vector3 healthBarSize;
    Vector3 healthBarMove;
    int damage;
    int healing;


    // Use this for initialization
    void Start () 
    {
        currentHealth = maxHealth;
        quest = new Hashtable();
	}
	
	// Update is called once per frame
	void Update () 
    {
        currentHealth -= Time.deltaTime * healthDownforTime;
        healthPercent = currentHealth / maxHealth;
        if (healthPercent < 0f)
        {
            healthPercent = 0f;
        }
        print(currentHealth);
        healthBarSize = new Vector3(currentHealth / 20, 0.3f, 0.1f);
        healthBarMove = new Vector3(-3f - (100 - currentHealth) / 40, 3.5f, -1f);
        healthFill.transform.localScale = healthBarSize;
        healthFill.transform.localPosition = transform.position + healthBarMove;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.GetComponent<Collider2D>().tag == "quest_item")
        {

        }
        if (col.GetComponent<Collider2D>().tag == "enemy")
        {
            damage = col.gameObject.GetComponent<enemy>().power;
            currentHealth -= (float)damage;
        }
    }
}
