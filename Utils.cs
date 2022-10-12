using System.Text;

namespace ConvertPDF
{
    public class Utils
    {
        public static string ConvertToBase64(Stream stream)
        {
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                bytes = memoryStream.ToArray();
            }

            return Convert.ToBase64String(bytes);
            //return new MemoryStream(Encoding.UTF8.GetBytes(base64));
        }
    }
}
