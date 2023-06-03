using QRCoder;

namespace FoodInLoco.Application.Helpers
{
    public static class QRCodeService
    {
        public static string GenerateQRCodeBytes(string content)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new Base64QRCode(qrCodeData);

            string base64String = qrCode.GetGraphic(20);

            return base64String;
        }
    }
}
