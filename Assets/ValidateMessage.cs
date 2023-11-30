using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ValidateMessage : MonoBehaviour
{
    [SerializeField] List<Text> messageElements = new List<Text>();
    [SerializeField] GameObject messagePrefab = null;
    [SerializeField] GameObject Player = null;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Validate()
    {
        string message = "";
        for (int i = 0; i < messageElements.Count; i++)
        {
            message += messageElements[i].text + ";";
        }

        GameObject newMessage = Instantiate(messagePrefab);
        newMessage.transform.position = Player.transform.position;

        newMessage.GetComponent<Dialog>().SetOneLineDialog(message);
        UnityEngine.Debug.Log(message);
    }

}
