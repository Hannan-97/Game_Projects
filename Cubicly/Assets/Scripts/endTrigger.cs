using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager manager;
    void OnTriggerEnter()
    {
        manager.levelComplete();

        
    }
}
