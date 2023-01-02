using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    public GameObject sunPrefab;

    public Animator animator;

    public float readyTime;

    private int SunNum;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > readyTime)
        {
            animator.SetBool("Ready", true);
        }
    }

    public void BornSunOver()
    {
        BornSun();
        animator.SetBool("Ready", false);
        timer = 0;
    }

    public void BornSun()
    {
        GameObject sunNew = Instantiate(sunPrefab);
        SunNum += 1;
        float randomX;

    }
}
