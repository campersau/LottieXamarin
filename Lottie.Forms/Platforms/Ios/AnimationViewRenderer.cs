﻿using System.ComponentModel;
using Airbnb.Lottie;
using Foundation;
using Lottie.Forms;
using Lottie.Forms.Platforms.Ios;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Lottie.Forms.AnimationView), typeof(AnimationViewRenderer)), Xamarin.Forms.Internals.Preserve(AllMembers = true)]

namespace Lottie.Forms.Platforms.Ios
{
    public class AnimationViewRenderer : ViewRenderer<Lottie.Forms.AnimationView, CompatibleAnimationView>
    {
        private CompatibleAnimationView _animationView;
        private UITapGestureRecognizer _gestureRecognizer;
        private int repeatCount = 1;

        protected override void OnElementChanged(ElementChangedEventArgs<Lottie.Forms.AnimationView> e)
        {
            base.OnElementChanged(e);

            if (e == null)
                return;

            if (e.OldElement != null)
            {
                CleanupResources();
            }

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    _animationView = new CompatibleAnimationView()
                    {
                        AutoresizingMask = UIViewAutoresizing.All,
                        ContentMode = UIViewContentMode.ScaleAspectFit,
                        //LoopAnimation = e.NewElement.RepeatMode == RepeatMode.Infinite,
                        AnimationSpeed = e.NewElement.Speed,
                        CurrentProgress = e.NewElement.Progress,
                        //CompletionBlock = _animationCompletionBlock
                    };

                    _animationView.CompatibleAnimation = e.NewElement.GetAnimation();

                    e.NewElement.PlayCommand = new Command(() =>
                    {
                        _animationView.PlayWithCompletion(AnimationCompletionBlock);
                        e.NewElement.InvokePlayAnimation();
                    });
                    e.NewElement.PauseCommand = new Command(() =>
                    {
                        _animationView.Pause();
                        e.NewElement.InvokePauseAnimation();
                    });
                    e.NewElement.ResumeCommand = new Command(() =>
                    {
                        _animationView.PlayWithCompletion(AnimationCompletionBlock);
                        e.NewElement.InvokeResumeAnimation();
                    });
                    e.NewElement.StopCommand = new Command(() =>
                    {
                        _animationView.Stop();
                        e.NewElement.InvokeStopAnimation();
                    });
                    e.NewElement.ClickCommand = new Command(() =>
                    {
                        //_animationView.Click();
                        //e.NewElement.InvokeClick();
                    });

                    e.NewElement.PlayMinAndMaxFrameCommand = new Command((object paramter) =>
                    {
                        if (paramter is (int minFrame, int maxFrame))
                            _animationView.PlayFromFrame(minFrame, maxFrame, AnimationCompletionBlock);
                    });
                    e.NewElement.PlayMinAndMaxProgressCommand = new Command((object paramter) =>
                    {
                        if (paramter is (float minProgress, float maxProgress))
                            _animationView.PlayFromProgress(minProgress, maxProgress, AnimationCompletionBlock);
                    });
                    //e.NewElement.ReverseAnimationSpeedCommand = new Command(() => _animationView.AutoReverseAnimation = !_animationView.AutoReverseAnimation);

                    //_animationView.CacheEnable = e.NewElement.CacheComposition;
                    //_animationView.SetFallbackResource(e.NewElement.FallbackResource.);
                    //_animationView.Composition = e.NewElement.Composition;

                    //TODO: makes animation stop with current default values
                    //_animationView.SetMinFrame(e.NewElement.MinFrame);
                    //_animationView.SetMinProgress(e.NewElement.MinProgress);
                    //_animationView.SetMaxFrame(e.NewElement.MaxFrame);
                    //_animationView.SetMaxProgress(e.NewElement.MaxProgress);

                    _animationView.AnimationSpeed = e.NewElement.Speed;
                    //_animationView.LoopAnimation = e.NewElement.RepeatMode == RepeatMode.Infinite;
                    //_animationView.RepeatCount = e.NewElement.RepeatCount;
                    //if (!string.IsNullOrEmpty(e.NewElement.ImageAssetsFolder))
                    //    _animationView.ImageAssetsFolder = e.NewElement.ImageAssetsFolder;
                    _animationView.ContentScaleFactor = e.NewElement.Scale;
                    //_animationView.Frame = e.NewElement.Frame;
                    _animationView.CurrentProgress = e.NewElement.Progress;

                    _gestureRecognizer = new UITapGestureRecognizer(e.NewElement.InvokeClick);
                    _animationView.AddGestureRecognizer(_gestureRecognizer);

                    SetNativeControl(_animationView);
                    SetNeedsLayout();

                    if (e.NewElement.AutoPlay || e.NewElement.IsAnimating)
                        _animationView.PlayWithCompletion(AnimationCompletionBlock);

                    //e.NewElement.Duration = TimeSpan.FromMilliseconds(_animationView.AnimationDuration);
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_animationView == null || Element == null || e == null)
                return;

            if (e.PropertyName == AnimationView.AnimationProperty.PropertyName)
            {
                //CleanupResources();
                _animationView.CompatibleAnimation = Element.GetAnimation();

                if (Element.AutoPlay || Element.IsAnimating)
                    _animationView.PlayWithCompletion(AnimationCompletionBlock);
            }

            //if (e.PropertyName == AnimationView.CacheCompositionProperty.PropertyName)
            //    _animationView.CacheEnable = Element.CacheComposition;

            //_animationView.SetFallbackResource(e.NewElement.FallbackResource.);
            //_animationView.Composition = e.NewElement.Composition;

            //if (e.PropertyName == AnimationView.MinFrameProperty.PropertyName)
            //    _animationView.SetMinFrame(Element.MinFrame);

            //if (e.PropertyName == AnimationView.MinProgressProperty.PropertyName)
            //    _animationView.SetMinProgress(Element.MinProgress);

            //if (e.PropertyName == AnimationView.MaxFrameProperty.PropertyName)
            //    _animationView.SetMaxFrame(Element.MaxFrame);

            //if (e.PropertyName == AnimationView.MaxProgressProperty.PropertyName)
            //    _animationView.SetMaxProgress(Element.MaxProgress);

            if (e.PropertyName == AnimationView.SpeedProperty.PropertyName)
                _animationView.AnimationSpeed = Element.Speed;

            //if (e.PropertyName == AnimationView.RepeatModeProperty.PropertyName)
            //    _animationView.LoopAnimation = Element.RepeatMode == RepeatMode.Infinite;

            //if (e.PropertyName == AnimationView.RepeatCountProperty.PropertyName)
            //    _animationView.RepeatCount = Element.RepeatCount;

            //if (e.PropertyName == AnimationView.ImageAssetsFolderProperty.PropertyName && !string.IsNullOrEmpty(Element.ImageAssetsFolder))
            //    _animationView.ImageAssetsFolder = Element.ImageAssetsFolder;

            //if (e.PropertyName == AnimationView.ScaleProperty.PropertyName)
            //    _animationView.Scale = Element.Scale;

            //if (e.PropertyName == AnimationView.FrameProperty.PropertyName)
            //    _animationView.Frame = Element.Frame;

            if (e.PropertyName == AnimationView.ProgressProperty.PropertyName)
                _animationView.CurrentProgress = Element.Progress;

            base.OnElementPropertyChanged(sender, e);
        }

        private void AnimationCompletionBlock(bool animationFinished)
        {
            if (animationFinished)
            {
                Element?.InvokeFinishedAnimation();
                if (Element.RepeatMode == RepeatMode.Infinite)
                {
                    Element.InvokeRepeatAnimation();
                    _animationView.PlayWithCompletion(AnimationCompletionBlock);
                }
                else if (Element.RepeatMode == RepeatMode.Restart && repeatCount < Element.RepeatCount)
                {
                    repeatCount++;
                    Element.InvokeRepeatAnimation();
                    _animationView.PlayWithCompletion(AnimationCompletionBlock);
                }
                else if (Element.RepeatMode == RepeatMode.Restart && repeatCount == Element.RepeatCount)
                {
                    repeatCount = 1;
                }
            }
        }

        private void CleanupResources()
        {
            repeatCount = 1;

            if (_gestureRecognizer != null)
            {
                _animationView?.RemoveGestureRecognizer(_gestureRecognizer);
                _gestureRecognizer.Dispose();
                _gestureRecognizer = null;
            }

            if (_animationView != null)
            {
                _animationView.RemoveFromSuperview();
                _animationView.Dispose();
                _animationView = null;
            }
        }
    }
}
