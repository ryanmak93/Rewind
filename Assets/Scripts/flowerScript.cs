using UnityEngine;
using System.Collections;

public class flowerScript : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorTexturedefault;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Use this for initialization


    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(cursorTexturedefault, Vector2.zero, cursorMode);
    }

    char xpos = 'r';

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var colName = other.gameObject.name;
        //print ("NAME: " + other.gameObject.name);
        if (colName == "RightWing")
        {

            Destroy(transform.gameObject);
        }
        if (colName == "LeftWing")
        {

            Destroy(transform.gameObject);
        }


    }

    void OnMouseUp()


    {


        //print ("flowr pos:" + x + "," + y + "," + z);
        Vector3 start = transform.position;
        print(transform.position.x);
        if (xpos == 'r')
        {
            Vector3 dest = new Vector3(-100.0f, 8.6f, 0.0f);
            transform.position = Vector3.Lerp(start, dest, (Time.deltaTime));
            xpos = 'l';
            GameObject gameObj = GameObject.Find("OpenWindowLeft(Clone)");
            if (gameObj.name != null)
            {
                print("Herarchy change");
                transform.gameObject.layer = 2;
                transform.GetComponent<Rigidbody2D>().isKinematic = true;
            }



        }
        else if (xpos == 'l')
        {
            Vector3 dest = new Vector3(110.0f, 8.6f, 0.0f);
            transform.position = Vector3.Lerp(start, dest, (Time.deltaTime));
            xpos = 'r';
            GameObject gameObj = GameObject.Find("OpenWindowRight(Clone)");
            if (gameObj.name != null)
            {
                print("Herarchy change");
                transform.gameObject.layer = 2;
                transform.GetComponent<Rigidbody2D>().isKinematic = true;
            }

        }
        //print ("flowr pos:" + x + "," + y + "," + z);


    }
}
