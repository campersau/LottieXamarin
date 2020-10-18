using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
//using Lottie;
using ObjCRuntime;
using UIKit;

namespace Airbnb.Lottie
{
	// @interface AnimatedControl : UIControl
	[BaseType (typeof(UIControl), Name = "_TtC6Lottie15AnimatedControl")]
	interface AnimatedControl
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
		[Export ("beginTrackingWithTouch:withEvent:")]
		bool BeginTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent @event);

		// -(BOOL)continueTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
		[Export ("continueTrackingWithTouch:withEvent:")]
		bool ContinueTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent @event);

		// -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
		[Export ("endTrackingWithTouch:withEvent:")]
		void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);

		// -(void)cancelTrackingWithEvent:(UIEvent * _Nullable)event;
		[Export ("cancelTrackingWithEvent:")]
		void CancelTrackingWithEvent ([NullAllowed] UIEvent @event);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }
	}

	// @interface AnimatedButton : AnimatedControl
	[BaseType (typeof(AnimatedControl), Name = "_TtC6Lottie14AnimatedButton")]
	interface AnimatedButton
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
		[Export ("beginTrackingWithTouch:withEvent:")]
		bool BeginTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent @event);

		// -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
		[Export ("endTrackingWithTouch:withEvent:")]
		void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);
	}

	// @interface AnimatedSwitch : AnimatedControl
	[BaseType (typeof(AnimatedControl), Name = "_TtC6Lottie14AnimatedSwitch")]
	interface AnimatedSwitch
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
		[Export ("endTrackingWithTouch:withEvent:")]
		void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);
	}

	// @interface AnimationCompletionDelegate : NSObject <CAAnimationDelegate>
	[BaseType (typeof(NSObject), Name = "_TtC6Lottie27AnimationCompletionDelegate")]
	[DisableDefaultCtor]
	interface AnimationCompletionDelegate : ICAAnimationDelegate
	{
		// -(void)animationDidStop:(CAAnimation * _Nonnull)anim finished:(BOOL)flag;
		[Export ("animationDidStop:finished:")]
		void AnimationDidStop (CAAnimation anim, bool flag);
	}

	// @interface AnimationContainer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie18AnimationContainer")]
	[DisableDefaultCtor]
	interface AnimationContainer
	{
		// @property (nonatomic) CGFloat currentFrame;
		[Export ("currentFrame")]
		nfloat CurrentFrame { get; set; }

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// +(BOOL)needsDisplayForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result));
		[Static]
		[Export ("needsDisplayForKey:")]
		bool NeedsDisplayForKey (string key);

		// -(id<CAAction> _Nullable)actionForKey:(NSString * _Nonnull)event __attribute__((warn_unused_result));
		[Export ("actionForKey:")]
		[return: NullAllowed]
		CAAction ActionForKey (string @event);

		// -(void)display;
		[Export ("display")]
		void Display ();
	}

	// @interface AnimationSubview : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Lottie16AnimationSubview")]
	interface AnimationSubview
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);*/
	}

	// @interface LottieView : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Lottie10LottieView")]
	interface LottieView
	{
		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// @property (nonatomic) UIViewContentMode contentMode;
		[Export ("contentMode", ArgumentSemantic.Assign)]
		UIViewContentMode ContentMode { get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);*/
	}

	// @interface AnimationView : LottieView
	[BaseType (typeof(LottieView), Name = "_TtC6Lottie13AnimationView")]
	interface AnimationView
	{
		// @property (copy, nonatomic) NSString * _Nullable animationName;
		[NullAllowed, Export ("animationName")]
		string AnimationName { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();
	}

	// @interface CompatibleAnimation : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Lottie19CompatibleAnimation")]
	[DisableDefaultCtor]
	interface CompatibleAnimation
	{
		// +(CompatibleAnimation * _Nonnull)named:(NSString * _Nonnull)name __attribute__((warn_unused_result));
		[Static]
		[Export ("named:")]
		CompatibleAnimation Named (string name);

		// +(CompatibleAnimation * _Nonnull)animationFromJSON:(NSDictionary * _Nonnull)animationJSON __attribute__((warn_unused_result));
		[Static]
		[Export ("animationFromJSON:")]
		CompatibleAnimation AnimationFromJSON (NSDictionary animationJSON);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name bundle:(NSBundle * _Nonnull)bundle __attribute__((objc_designated_initializer));
		[Export ("initWithName:bundle:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, NSBundle bundle);
	}

	// @interface CompatibleAnimationKeypath : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Lottie26CompatibleAnimationKeypath")]
	[DisableDefaultCtor]
	interface CompatibleAnimationKeypath
	{
		// -(instancetype _Nonnull)initWithKeypath:(NSString * _Nonnull)keypath __attribute__((objc_designated_initializer));
		[Export ("initWithKeypath:")]
		[DesignatedInitializer]
		IntPtr Constructor (string keypath);

		// -(instancetype _Nonnull)initWithKeys:(NSArray<NSString *> * _Nonnull)keys __attribute__((objc_designated_initializer));
		[Export ("initWithKeys:")]
		[DesignatedInitializer]
		IntPtr Constructor (string[] keys);
	}

	// @interface CompatibleAnimationView : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Lottie23CompatibleAnimationView")]
	interface CompatibleAnimationView
	{
		// -(instancetype _Nonnull)initWithCompatibleAnimation:(CompatibleAnimation * _Nonnull)compatibleAnimation __attribute__((objc_designated_initializer));
		[Export ("initWithCompatibleAnimation:")]
		[DesignatedInitializer]
		IntPtr Constructor (CompatibleAnimation compatibleAnimation);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// @property (nonatomic, strong) CompatibleAnimation * _Nullable compatibleAnimation;
		[NullAllowed, Export ("compatibleAnimation", ArgumentSemantic.Strong)]
		CompatibleAnimation CompatibleAnimation { get; set; }

		// @property (nonatomic) CGFloat loopAnimationCount;
		[Export ("loopAnimationCount")]
		nfloat LoopAnimationCount { get; set; }

		// @property (nonatomic) UIViewContentMode contentMode;
		[Export ("contentMode", ArgumentSemantic.Assign)]
		UIViewContentMode ContentMode { get; set; }

		// @property (nonatomic) BOOL shouldRasterizeWhenIdle;
		[Export ("shouldRasterizeWhenIdle")]
		bool ShouldRasterizeWhenIdle { get; set; }

		// @property (nonatomic) CGFloat currentProgress;
		[Export ("currentProgress")]
		nfloat CurrentProgress { get; set; }

		// @property (nonatomic) NSTimeInterval currentTime;
		[Export ("currentTime")]
		double CurrentTime { get; set; }

		// @property (nonatomic) CGFloat currentFrame;
		[Export ("currentFrame")]
		nfloat CurrentFrame { get; set; }

		// @property (readonly, nonatomic) CGFloat realtimeAnimationFrame;
		[Export ("realtimeAnimationFrame")]
		nfloat RealtimeAnimationFrame { get; }

		// @property (readonly, nonatomic) CGFloat realtimeAnimationProgress;
		[Export ("realtimeAnimationProgress")]
		nfloat RealtimeAnimationProgress { get; }

		// @property (nonatomic) CGFloat animationSpeed;
		[Export ("animationSpeed")]
		nfloat AnimationSpeed { get; set; }

		// @property (nonatomic) BOOL respectAnimationFrameRate;
		[Export ("respectAnimationFrameRate")]
		bool RespectAnimationFrameRate { get; set; }

		// @property (readonly, nonatomic) BOOL isAnimationPlaying;
		[Export ("isAnimationPlaying")]
		bool IsAnimationPlaying { get; }

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)playWithCompletion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playWithCompletion:")]
		void PlayWithCompletion ([NullAllowed] Action<bool> completion);

		// -(void)playFromProgress:(CGFloat)fromProgress toProgress:(CGFloat)toProgress completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playFromProgress:toProgress:completion:")]
		void PlayFromProgress (nfloat fromProgress, nfloat toProgress, [NullAllowed] Action<bool> completion);

		// -(void)playFromFrame:(CGFloat)fromFrame toFrame:(CGFloat)toFrame completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playFromFrame:toFrame:completion:")]
		void PlayFromFrame (nfloat fromFrame, nfloat toFrame, [NullAllowed] Action<bool> completion);

		// -(void)playFromMarker:(NSString * _Nonnull)fromMarker toMarker:(NSString * _Nonnull)toMarker completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playFromMarker:toMarker:completion:")]
		void PlayFromMarker (string fromMarker, string toMarker, [NullAllowed] Action<bool> completion);

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)reloadImages;
		[Export ("reloadImages")]
		void ReloadImages ();

		// -(void)forceDisplayUpdate;
		[Export ("forceDisplayUpdate")]
		void ForceDisplayUpdate ();

		// -(id _Nullable)getValueFor:(CompatibleAnimationKeypath * _Nonnull)keypath atFrame:(CGFloat)atFrame __attribute__((warn_unused_result));
		[Export ("getValueFor:atFrame:")]
		[return: NullAllowed]
		NSObject GetValueFor (CompatibleAnimationKeypath keypath, nfloat atFrame);

		// -(void)logHierarchyKeypaths;
		[Export ("logHierarchyKeypaths")]
		void LogHierarchyKeypaths ();

		// -(void)setColorValue:(UIColor * _Nonnull)color forKeypath:(CompatibleAnimationKeypath * _Nonnull)keypath;
		[Export ("setColorValue:forKeypath:")]
		void SetColorValue (UIColor color, CompatibleAnimationKeypath keypath);

		// -(UIColor * _Nullable)getColorValueFor:(CompatibleAnimationKeypath * _Nonnull)keypath atFrame:(CGFloat)atFrame __attribute__((warn_unused_result));
		[Export ("getColorValueFor:atFrame:")]
		[return: NullAllowed]
		UIColor GetColorValueFor (CompatibleAnimationKeypath keypath, nfloat atFrame);

		// -(void)addSubview:(AnimationSubview * _Nonnull)subview forLayerAt:(CompatibleAnimationKeypath * _Nonnull)keypath;
		[Export ("addSubview:forLayerAt:")]
		void AddSubview (AnimationSubview subview, CompatibleAnimationKeypath keypath);

		// -(CGRect)convertWithRect:(CGRect)rect toLayerAt:(CompatibleAnimationKeypath * _Nullable)keypath __attribute__((warn_unused_result));
		[Export ("convertWithRect:toLayerAt:")]
		CGRect ConvertWithRect (CGRect rect, [NullAllowed] CompatibleAnimationKeypath keypath);

		// -(CGPoint)convertWithPoint:(CGPoint)point toLayerAt:(CompatibleAnimationKeypath * _Nullable)keypath __attribute__((warn_unused_result));
		[Export ("convertWithPoint:toLayerAt:")]
		CGPoint ConvertWithPoint (CGPoint point, [NullAllowed] CompatibleAnimationKeypath keypath);

		// -(CGFloat)progressTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result));
		[Export ("progressTimeForMarker:")]
		nfloat ProgressTimeForMarker (string named);

		// -(CGFloat)frameTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result));
		[Export ("frameTimeForMarker:")]
		nfloat FrameTimeForMarker (string named);
	}

	// @interface CompositionLayer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie16CompositionLayer")]
	[DisableDefaultCtor]
	interface CompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface DebugLayer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie10DebugLayer")]
	[DisableDefaultCtor]
	interface DebugLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface ImageCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer), Name = "_TtC6Lottie21ImageCompositionLayer")]
	interface ImageCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface InvertedMatteLayer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie18InvertedMatteLayer")]
	[DisableDefaultCtor]
	interface InvertedMatteLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(void)drawInContext:(CGContextRef _Nonnull)ctx;
		[Export ("drawInContext:")]
		unsafe void DrawInContext (CGContext ctx);
	}

	// @interface MaskContainerLayer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie18MaskContainerLayer")]
	[DisableDefaultCtor]
	interface MaskContainerLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface NullCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer), Name = "_TtC6Lottie20NullCompositionLayer")]
	interface NullCompositionLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);
	}

	// @interface PreCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer), Name = "_TtC6Lottie19PreCompositionLayer")]
	interface PreCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface ShapeCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer), Name = "_TtC6Lottie21ShapeCompositionLayer")]
	interface ShapeCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface ShapeContainerLayer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie19ShapeContainerLayer")]
	interface ShapeContainerLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);
	}

	// @interface ShapeRenderLayer : ShapeContainerLayer
	[BaseType (typeof(ShapeContainerLayer), Name = "_TtC6Lottie16ShapeRenderLayer")]
	[DisableDefaultCtor]
	interface ShapeRenderLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(void)drawInContext:(CGContextRef _Nonnull)ctx;
		[Export ("drawInContext:")]
		unsafe void DrawInContext (CGContext ctx);
	}

	// @interface SolidCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer), Name = "_TtC6Lottie21SolidCompositionLayer")]
	interface SolidCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/
	}

	// @interface TextCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer), Name = "_TtC6Lottie20TextCompositionLayer")]
	interface TextCompositionLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);*/

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);
	}

	// @interface TextLayer : CALayer
	[BaseType (typeof(CALayer), Name = "_TtC6Lottie9TextLayer")]
	interface TextLayer
	{
		// -(id<CAAction> _Nullable)actionForKey:(NSString * _Nonnull)event __attribute__((warn_unused_result));
		[Export ("actionForKey:")]
		[return: NullAllowed]
		CAAction ActionForKey (string @event);

		// -(void)drawInContext:(CGContextRef _Nonnull)ctx;
		[Export ("drawInContext:")]
		unsafe void DrawInContext (CGContext ctx);

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		/*[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);*/
	}
}
