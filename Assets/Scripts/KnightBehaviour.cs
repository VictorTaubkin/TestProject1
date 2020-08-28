using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightBehaviour : MonoBehaviour
{
    public Text greetings;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float dist;
        transform.LookAt(player.transform.position);
        dist = Vector3.Distance(transform.position, player.transform.position);
        if(dist>2)
            greetings.text = "Distance: "+Mathf.RoundToInt(dist);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedKnight")
        {
            greetings.text = "Hello, I am Iron Knight.\nWho are you?";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RedKnight")
        {
            greetings.text = "";
        }

    }
}
