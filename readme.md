
#### This is an example of cross platform image resource detection. It uses an abstract interface defined in the shared library, and platform specific implementations for Android and iOS.

The abstract interface looks like this:

    public interface IDrawableManager
    {
        bool DoesImageExist(string path);
    }



On Android `Resources.GetIdentifier` can be used to return the resource id for the base name of the image, or `0` if it doesn't exist. The implementation for Android looks like this:

    public class DroidDrawableManager : IDrawableManager
    {
        public bool DoesImageExist(string image)
        {
            var context = Android.App.Application.Context;
            var resources = context.Resources;
            var name = Path.GetFileNameWithoutExtension(image);
            int resourceId = resources.GetIdentifier(name, "drawable", context.PackageName);

            return resourceId != 0;
        }
    }

On iOS `NSFileManager.DefaultManager.FileExists` can be used to detect the image. The iOS implementation looks like this:

    public class IOsDrawableManager : IDrawableManager
    {
        public bool DoesImageExist(string image)
        {
            return Foundation.NSFileManager.DefaultManager.FileExists(image);
        }
    }

A shared singleton, or IoC library can be used to hold the correct instantation of the platform specific implementation.