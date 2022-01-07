using System.Threading.Tasks;
using UnityEngine;

public class TubeTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BirdMove>())
        {
        }
    }
}
