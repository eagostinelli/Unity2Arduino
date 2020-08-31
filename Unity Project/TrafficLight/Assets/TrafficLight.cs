using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class TrafficLight : MonoBehaviour
{
    // PUT here your port name 
    public static SerialPort sp = new SerialPort("/dev/tty.usbmodemxxxxxx", 9600);
    
    // Start is called before the first frame update
    void Start()
    {
        OpenConnection();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenConnection()
    {
        if (sp!=null)
        {
            if(sp.IsOpen)
            {
                sp.Close();
                print("Closing port, because it's already open");
            }
            else
            {
                sp.Open();
                sp.ReadTimeout = 100;
                print("port open");
            }
        }
        else 
        {
            if(sp.IsOpen)
            {
                print("port is already open");
            }
            else{
                print("port == null");
            }
        }
        
    } 

    void OnApplicationQuit()
    {
        sp.Close();
    }


    public static void sendYellow(){
        sp.Write("y");
    }
    public static void sendGreen(){
        sp.Write("g");
    }
    public static void sendRed(){
        sp.Write("r");
    }

}
