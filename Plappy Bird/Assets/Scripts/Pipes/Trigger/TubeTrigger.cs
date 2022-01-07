using System.Threading.Tasks;
using UnityEngine;

public class TubeTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) //ToDo
    {
        if (other.gameObject.GetComponent<BirdMovement>())
        {
        }
    }
}
