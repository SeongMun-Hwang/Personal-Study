using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera playerCamera;
    public RenderTexture renderTexture;
    public Renderer quadRenderer;

    public float scrollPower = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        renderTexture = new RenderTexture(1024, 768, 16); // 적절한 해상도로 RenderTexture를 생성
        playerCamera.targetTexture = renderTexture;
        quadRenderer.material.mainTexture = renderTexture;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(TakePhoto());
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0)
        {
            playerCamera.fieldOfView += scrollPower;
        }
        else if (scroll < 0)
        {
            playerCamera.fieldOfView -= scrollPower;
        }
    }
    IEnumerator TakePhoto()
    {
        yield return new WaitForEndOfFrame(); // 현재 프레임 렌더링이 끝나기를 기다림

        RenderTexture.active = renderTexture; // RenderTexture를 활성화
        Texture2D screenImage = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
        screenImage.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        screenImage.Apply();
        RenderTexture.active = null; // RenderTexture 활성화 해제

        byte[] imageBytes = screenImage.EncodeToPNG(); // 이미지를 PNG 형식으로 인코딩
        string filename = "Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
        System.IO.File.WriteAllBytes(filename, imageBytes); // 파일로 저장
        Debug.Log("Screenshot saved to " + filename);

        Destroy(screenImage); // 사용 후 Texture2D 객체 해제
    }
}
