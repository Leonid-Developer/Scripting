using UnityEngine;
public class Destroy : MonoBehaviour
{
    public GameObject destroy_obj;

    private void Start()
    {
        //Destroy(destroy_obj);
        Destroy(gameObject);
    }
}
