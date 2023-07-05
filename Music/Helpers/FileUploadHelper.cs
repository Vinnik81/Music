namespace Music.Helpers
{
   static public class FileUploadHelper
    {
        static public async Task<string> UploadPreviewAsync(IFormFile Preview)
        {
            if (Preview != null)
            {
                var fileNameMusic = $"{Guid.NewGuid()}{Path.GetExtension(Preview.FileName)}";
                using var fsm = new FileStream(@$"wwwroot/uploads/{fileNameMusic}", FileMode.Create);
                await Preview.CopyToAsync(fsm);
                return @$"/uploads/{fileNameMusic}";
            }
            throw new Exception("File was not uploaded!");
        }

        static public async Task<string> UploadCover_mediumAsync(IFormFile Cover_medium)
        {
            if (Cover_medium != null)
            {
                var fileNameImage = $"{Guid.NewGuid()}{Path.GetExtension(Cover_medium.FileName)}";
                using var fsi = new FileStream($@"wwwroot/uploads/{fileNameImage}", FileMode.Create);
                await Cover_medium.CopyToAsync(fsi);
                return $@"/uploads/{fileNameImage}";
            }
            else
            {
                var fileNameImage = "istockphoto.jpg";
                var sourcePath = $@"wwwroot/images/{fileNameImage}";
                var destinationPath = $@"wwwroot/uploads/{fileNameImage}";
                if (!File.Exists(destinationPath))
                {
                    File.Copy(sourcePath, destinationPath);
                }
                return $@"/uploads/{fileNameImage}";
            }
            //throw new Exception("File Image was not uploaded!");
        }
    }
}
