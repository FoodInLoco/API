namespace FoodInLoco.Application.Helpers
{
    public static class QRCodeService
    {
        public static string GenerateQRCodeBytes(string content)
        {
            string apiUrl = $"https://chart.googleapis.com/chart?cht=qr&chs=300x300&chl={content}";

            using (var httpClient = new HttpClient())
            {
                byte[] imageData = httpClient.GetAsync(new Uri(apiUrl)).Result.Content.ReadAsByteArrayAsync().Result;
                string base64String = Convert.ToBase64String(imageData);

                return base64String;
            }
        }
    }
}
