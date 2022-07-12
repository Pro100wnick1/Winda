using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H0 : MonoBehaviour
{
    public H0 human;
    // Start is called before the first frame update
    void Start()
    {
        human.enabled = false;
    }

    public void show()
    {
        // Turns the image on if it is off, and off if it is on.
        human.enabled = !human.enabled;
    }
}
