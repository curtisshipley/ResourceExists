using System;
using System.IO;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace ResourceExists.Droid
{
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
}
