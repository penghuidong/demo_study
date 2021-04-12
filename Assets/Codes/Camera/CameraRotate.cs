using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float speed = 7.0f;
    public Transform player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Debug.Log("player Transform is null");
            return;
        }

        transform.position = player.position + offset;

        /* solution 1 ----------------------- begin
 
        float mx = Input.GetAxis("Mouse X");
        float my = -Input.GetAxis("Mouse Y");   // 这里为啥要去负

        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Translate(Vector3.left * speed * mx * Time.deltaTime);
            transform.Translate(Vector3.up * speed * my * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.RotateAround(player.transform.position, Vector3.up, mx * speed);
            transform.RotateAround(player.transform.position, transform.right, my * speed);
        }
        // solution 1 ----------------------- end  
        */

        // solution 2 ------------------------- begin
        // button 值为 0 表示左按钮，1 表示右按钮，2 表示中间按钮。按下鼠标按钮时返回 true，释放时返回 false。
        if ( Input.GetMouseButton(0) )
        {
            Debug.Log("Mouse Button 0");
            Vector3 pos = transform.position;
            Vector3 rot = transform.eulerAngles;  // 欧拉角

            //围绕原点旋转，也可以将Vector3.zero改为 target.position,就是围绕观察对象旋转
            transform.RotateAround(player.position, Vector3.up, Input.GetAxis("Mouse X") * speed);
            transform.RotateAround(player.position, Vector3.left, Input.GetAxis("Mouse Y") * speed);

            float x = transform.eulerAngles.x;
            float y = transform.eulerAngles.y;

            //控制移动范围
            if (x < 20 || x > 45 || y < 0 || y > 40)
            {
                transform.position = pos;
                transform.eulerAngles = rot;
            }

            offset = transform.position - player.position;
        }
        // Solution 2 -----------------------------------end
    }
}


