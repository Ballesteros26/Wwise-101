using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameParameterOnPlayerMove : MonoBehaviour
{
    public AK.Wwise.RTPC GameParameter;
    public float updateFrequencySeconds = 0.5f;
    private GameObject player;
    private Vector3 cachedPlayerPosition; 
    private void Start()
    {
        player = PlayerManager.Instance.player;
        cachedPlayerPosition = player.transform.position;
        StartCoroutine(SetGameParameter());
    }

    IEnumerator SetGameParameter() {

        while (true)
        {
            if (cachedPlayerPosition != player.transform.position ) 
            {
                GameParameter.SetGlobalValue(Vector3.Distance(player.transform.position, this.transform.position));
                cachedPlayerPosition = player.transform.position;
            }
            
            yield return new WaitForSeconds(updateFrequencySeconds);
        }
    }
}
