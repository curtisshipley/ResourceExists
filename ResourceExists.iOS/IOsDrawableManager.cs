using System;
namespace ResourceExists.iOS
{
    public class IOsDrawableManager : IDrawableManager
    {
        public bool DoesImageExist(string image)
        {
            return Foundation.NSFileManager.DefaultManager.FileExists(image);
        }
    }
}
