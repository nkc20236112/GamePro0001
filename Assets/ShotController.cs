using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float speed;//’e‚ÌƒXƒs[ƒh

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // ƒV[ƒ“ã‚ÌƒIƒuƒWƒFƒNƒg‚ÆÚG‚µ‚½‚Æ‚«‚Ìˆ—
    private void OnTriggerEnter2D(Collider2D col)
    {
        // “G‚¾‚Á‚½‚ç
        if (col.gameObject.tag == "Enemy")
        {
            // ‚Ô‚Â‚©‚Á‚½‘ŠŽè‚ð”j‰ó
            Destroy(col.gameObject);

            // ’e‚ð”j‰ó
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;//¶‚©‚ç‰E‚É’e‚ðˆÚ“®

        //‰æ–Ê‰E‘¤‚ÉÁ‚¦‚½‚ç’e‚ðíœ
        if (transform.position.x >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
