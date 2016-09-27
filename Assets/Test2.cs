using UnityEngine;
using System.Collections;

public class Boss
{

    public int mp = 53;


    public void Magic(int M)
    {
        if ( this.mp >= M)
        {
            this.mp -= M;
            Debug.Log("魔法攻撃をした。残りmpは" + mp);
        }

        else
        {
            Debug.Log("MPが足りない！");
        }
        
        
    }
}

    


public class Test2 : MonoBehaviour
{
    int Mpoint = 5;

    void Start()
    {
        Boss lastboss = new Boss();

        
        
        
     
    for(int i = 0; i <11; i++)
            {
                lastboss.Magic(Mpoint);
            }

    
       
        }
     
            
        
    

    void Update()
    {

    }
}
    
        

    
