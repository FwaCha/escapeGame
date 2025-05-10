using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


public class playerController : MonoBehaviour
{
    [SerializeField]float playerSpeed = 5;
    [SerializeField]float secondTime = 0;
    void Move()
    {
        var h =Input.GetAxis("Horizontal");
        var v =Input.GetAxis("Vertical");
        var input = new Vector3(h ,v);
        //斜めに動かしたい時のコード
        //transform.position += input.normalized*playerSpeed*Time.deltaTime;
        if(h != 0)
        {
            transform.position += new Vector3(h ,0)*playerSpeed;
        }else if(v != 0)
        {
            transform.position += new Vector3(0 ,v)*playerSpeed;
        }
    }

    private IEnumerator Loop(float second) {
    while (true) {
        yield return new WaitForSeconds(second);
        Move();
    }
}
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loop(secondTime));
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
