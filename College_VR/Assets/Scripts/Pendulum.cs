using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Pendulum : MonoBehaviour
{
    public float dt;
    public float m = 1;
    public float g = 9.81f;
    public float theta = Mathf.PI / 4;
    private Vector f = new Vector();
    private Vector a = new Vector();
    private Vector v = new Vector();
    private Vector pos = new Vector();
    private GameObject root;

    // Start is called before the first frame update
    void Start()
    {
        dt = Time.deltaTime;
        Debug.Log("I'm a live");
    }

    // Update is called once per frame
    void Update()
    {
        f = m * g * (float) Mathf.Sin(theta) * (~f);
        a = f / m;
        v = a * dt + v;
        pos = v * dt + pos;
        root.transform.position = new Vector3(pos.getX(),pos.getY(),pos.getZ());
    }
}
