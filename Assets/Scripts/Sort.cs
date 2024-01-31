using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sort : MonoBehaviour
{
    public TMP_Text score;
    public int count;
     void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            var pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            var worldPos = Camera.main.ScreenToWorldPoint(pos);
            worldPos.z = 0;
            transform.position = worldPos;
            
        }

       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        ChangeText();

    }
    public void ChangeText()
    {
        count++;
        score.text = count.ToString();
    }
}