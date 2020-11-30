using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RentalKendaraan_042.Models.Upload
{
    public static class IFormFileExtensions
    {
        public static string GetFilename(this IFormFile file)
        {
            return ContentDispositionHeaderValue.Parse(
                            file.ContentDisposition).FileName.ToString().Trim('"');
        }

        public static async Task<System.IO.MemoryStream> GetFilesStream(this IFormFile file)
        {
            System.IO.MemoryStream filestream = new System.IO.MemoryStream();
            return filestream;
        }
    }
}
