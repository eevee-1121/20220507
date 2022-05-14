using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField]
    private int a;

    [SerializeField]
    private string txt;

    [SerializeField]
    private int b;

    [SerializeField]
    private int index;


    // Start is called before the first frame update
    void Start()
    {
        Inint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inint()
    {
        Debug.Log($"index={index}");
        //printf("%d", 0);

    }
}
