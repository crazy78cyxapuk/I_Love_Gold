using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private Transform leftBorder, rightBorder;

    private bool isMove = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isMove)
        {
            MoveChest();
        }
    }

    private void OnMouseDown()
    {
        isMove = true;
    }

    private void OnMouseUp()
    {
        isMove = false;
    }

    private void MoveChest()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePosition.x > leftBorder.position.x && mousePosition.x < rightBorder.position.x)
        {

            if (transform.position.x < mousePosition.x)
            {
                spriteRenderer.flipX = false;
            }
            else if (transform.position.x > mousePosition.x)
            {
                spriteRenderer.flipX = true;
            }

            transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
        }
    }
}
