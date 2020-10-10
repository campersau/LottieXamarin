using System;
using System.IO;
using Airbnb.Lottie;
using Foundation;

namespace Lottie.Forms.Platforms.Ios
{
    public static class AnimationViewExtensions
    {
        public static CompatibleAnimation GetAnimation(this AnimationView animationView)
        {
            if (animationView == null)
                throw new ArgumentNullException(nameof(animationView));

            var animation = animationView.Animation;

            CompatibleAnimation composition = null;
            switch (animationView.AnimationSource)
            {
                case AnimationSource.AssetOrBundle:
                    if (animation is string bundleAnimation)
                    {
                        var index = bundleAnimation.LastIndexOf(".json", StringComparison.OrdinalIgnoreCase);
                        if (index == bundleAnimation.Length - 5)
                        {
                            bundleAnimation = bundleAnimation.Substring(0, index);
                        }

                        if (!string.IsNullOrEmpty(animationView.ImageAssetsFolder))
                            composition = new CompatibleAnimation(bundleAnimation, NSBundle.FromPath(animationView.ImageAssetsFolder));
                        else
                            composition = CompatibleAnimation.Named(bundleAnimation);
                    }
                    break;
                case AnimationSource.Url:
                    if (animation is string stringAnimation)
                        composition = CompatibleAnimation.Named(stringAnimation);
                    break;
                case AnimationSource.Json:
                    if (animation is string jsonAnimation)
                    {
                        NSData objectData = NSData.FromString(jsonAnimation);
                        NSDictionary jsonData = (NSDictionary)NSJsonSerialization.Deserialize(objectData, NSJsonReadingOptions.MutableContainers, out _);
                        composition = CompatibleAnimation.AnimationFromJSON(jsonData);
                    }
                    else if (animation is NSDictionary dictAnimation)
                        composition = CompatibleAnimation.AnimationFromJSON(dictAnimation);
                    break;
                case AnimationSource.Stream:
                    composition = animationView.GetAnimation(animation);
                    break;
                case AnimationSource.EmbeddedResource:
                    composition = animationView.GetAnimation(animationView.GetStreamFromAssembly());
                    break;
                default:
                    break;
            }
            return composition;
        }

        public static CompatibleAnimation GetAnimation(this AnimationView animationView, object animation)
        {
            if (animationView == null)
                throw new ArgumentNullException(nameof(animationView));

            CompatibleAnimation composition = null;
            switch (animation)
            {
                case string stringAnimation:

                    //TODO: check if json
                    //animationView.SetAnimationFromJson(stringAnimation);
                    //TODO: check if url
                    //animationView.SetAnimationFromUrl(stringAnimation);

                    composition = CompatibleAnimation.Named(stringAnimation);
                    break;
                case Stream streamAnimation:
                    using (StreamReader reader = new StreamReader(streamAnimation))
                    {
                        string json = reader.ReadToEnd();
                        NSData objectData = NSData.FromString(json);
                        NSDictionary jsonData = (NSDictionary)NSJsonSerialization.Deserialize(objectData, NSJsonReadingOptions.MutableContainers, out _);
                        composition = CompatibleAnimation.AnimationFromJSON(jsonData);
                    }
                    break;
                case null:
                    composition = null;
                    break;
                default:
                    break;
            }
            return composition;
        }
    }
}
