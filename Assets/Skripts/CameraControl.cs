using UnityEngine;

public class CameraControl : MonoBehaviour
{
   [SerializeField] Transform player;
    [SerializeField] float sensetyCam = 5;
    Transform cameraTransform;
    Vector3 deltaPosCam;
    Vector3 target;
    void Start()
    {
        cameraTransform = transform;
        deltaPosCam = cameraTransform.position - player.position;
        deltaPosCam.z = -10;
    }

    
    void Update()
    {
        target = player.transform.position + deltaPosCam;
        target.y = -0.5f;
        cameraTransform.position = Vector3.MoveTowards(cameraTransform.position, target, Time.deltaTime * sensetyCam);
    }
}
/*[SerializeField]
private float speed = 2f;
[SerializeField]
private Transform target;

private void Awake()
{
    if(!target) target = FindObjectOfType<Player>().transform;
}

private void Update() 
{
    Vector3 position = target.position; position.z = -10f;
    transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
}
}*/
     
   

   /*[SerializeField] private Transform player;
     private Vector3 pos;

    private void Awake()
    {
        if (!player)
            player = FindObjectOfType<Player>().transform;
    }
    private void Update()
    {
        pos = player.position;
        pos.z = -10f;
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}*/

/*[SerializeField] float sensetyCam = 5;
    [SerializeField] Transform player;
    Transform cameraTransform;
    Vector3 deltaPosCam;
    Vector3 target;
   
    public void InitCam(Transform playerTransform)
    {
        player = playerTransform;
        cameraTransform = transform;
        deltaPosCam = cameraTransform.position - player.position;
        deltaPosCam.z = -10;
    }

    
    void FixedUpdate()
    {
        target = player.transform.position + deltaPosCam;
        
        cameraTransform.position = Vector3.Lerp(cameraTransform.position, target, Time.deltaTime * sensetyCam);
    }*/
     /*[SerializeField] Transform player;
    [SerializeField] float sensetyCam = 5;
    Transform cameraTransform;
    Vector3 deltaPosCam;
    Vector3 target;

    void Start()
    {
        cameraTransform = transform;
        deltaPosCam = cameraTransform.position - player.position;
        deltaPosCam.z = -10;
    }

    void FixedUpdate()
    {
        target = player.transform.position + deltaPosCam;
        cameraTransform.position = Vector3.Lerp(cameraTransform.position, target, Time.deltaTime * sensetyCam);
    }
}*/