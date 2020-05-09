using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
    public Text debugText;

    //protected const string MEDIA_STORE_IMAGE_MEDIA = "android.provider.MediaStore$Images$Media";
    //protected static AndroidJavaObject m_Activity;

    public void TakeAShot()
	{
        StartCoroutine(TakeScreenshotAndSave());
    }


    IEnumerator TakeScreenshotAndSave()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();
        NativeGallery.RequestPermission();
        NativeGallery.OpenSettings();
        // Save the screenshot to Gallery/Photos
        Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, "GalleryTest", "Image.png"));
     
        debugText.text = "Permission result: " + NativeGallery.SaveImageToGallery(ss, "GalleryTest", "Image.png");
        // To avoid memory leaks
        Destroy(ss);
    }

 

}
