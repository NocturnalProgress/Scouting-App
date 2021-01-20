using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZXing;
using ZXing.Common;

public class GenerateQRCode : MonoBehaviour
{
    //Converts Json into a QR Code

    [SerializeField] private BarcodeFormat format = BarcodeFormat.QR_CODE;
    private int width;
    private int height;
    private RawImage cRawImage;

    public TMP_InputField teamNumberInputField;
    public TMP_InputField nameInputField;
    public AutonomousCounters autonomousCounters;
    public TeleOpCounters teleOpCounters;
    public GameObject data;
    public NotificationSystem notificationSystem;

    private void Start()
    {
        GameObject.Find("Data").GetComponent<Data>();
        cRawImage = GetComponent<RawImage>();
        width = Convert.ToInt32(cRawImage.rectTransform.rect.width);
        height = Convert.ToInt32(cRawImage.rectTransform.rect.height);
    }

    public void GenerateQRCodeButton()
    {
        cRawImage = GetComponent<RawImage>();
        // Generate the texture

        string json = data.GetComponent<Data>().SerializeToJson();

        Texture2D tex = GenerateBarcode(json, format, width, height);
        // Setup the RawImage
        cRawImage.texture = tex;
        cRawImage.rectTransform.sizeDelta = new Vector2(tex.width, tex.height);

        notificationSystem.FinishedGeneratingQRCode();
    }

    private Texture2D GenerateBarcode(string data, BarcodeFormat format, int width, int height)
    {
        // Generate the BitMatrix
        BitMatrix bitMatrix = new MultiFormatWriter()
            .encode(data, format, width, height);
        // Generate the pixel array
        Color[] pixels = new Color[bitMatrix.Width * bitMatrix.Height];
        int pos = 0;
        for (int y = 0; y < bitMatrix.Height; y++)
        {
            for (int x = 0; x < bitMatrix.Width; x++)
            {
                pixels[pos++] = bitMatrix[x, y] ? Color.black : Color.white;
            }
        }
        // Setup the texture
        Texture2D tex = new Texture2D(bitMatrix.Width, bitMatrix.Height);
        tex.SetPixels(pixels);
        tex.Apply();
        return tex;
    }
}