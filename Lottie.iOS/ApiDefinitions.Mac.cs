using System;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;

namespace Airbnb.Lottie
{
	// @interface AnimationCompletionDelegate : NSObject <CAAnimationDelegate>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface AnimationCompletionDelegate : ICAAnimationDelegate
	{
		// -(void)animationDidStop:(CAAnimation * _Nonnull)anim finished:(BOOL)flag;
		[Export ("animationDidStop:finished:")]
		void AnimationDidStop (CAAnimation anim, bool flag);
	}

	// @interface AnimationContainer : CALayer
	[BaseType (typeof(CALayer))]
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
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

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

	// @interface AnimationSubview
	interface AnimationSubview
	{
		// -(instancetype _Nonnull)initWithFrame:(NSRect)frameRect __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frameRect);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);
	}

	// @interface LottieView
	interface LottieView
	{
		// -(void)viewDidMoveToWindow;
		[Export ("viewDidMoveToWindow")]
		void ViewDidMoveToWindow ();

		// @property (readonly, nonatomic) BOOL wantsUpdateLayer;
		[Export ("wantsUpdateLayer")]
		bool WantsUpdateLayer { get; }

		// @property (readonly, getter = isFlipped, nonatomic) BOOL flipped;
		[Export ("flipped")]
		bool Flipped { [Bind ("isFlipped")] get; }

		// -(void)layout;
		[Export ("layout")]
		void Layout ();

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();

		// -(instancetype _Nonnull)initWithFrame:(NSRect)frameRect __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frameRect);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);
	}

	// @interface AnimationView : LottieView
	[BaseType (typeof(LottieView))]
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
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

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

	// @interface CompositionLayer : CALayer
	[BaseType (typeof(CALayer))]
	[DisableDefaultCtor]
	interface CompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface DebugLayer : CALayer
	[BaseType (typeof(CALayer))]
	[DisableDefaultCtor]
	interface DebugLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface ImageCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer))]
	interface ImageCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface InvertedMatteLayer : CALayer
	[BaseType (typeof(CALayer))]
	[DisableDefaultCtor]
	interface InvertedMatteLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(void)drawInContext:(CGContext _Nonnull)ctx;
		[Export ("drawInContext:")]
		unsafe void DrawInContext (CGContext* ctx);
	}

	// @interface MaskContainerLayer : CALayer
	[BaseType (typeof(CALayer))]
	[DisableDefaultCtor]
	interface MaskContainerLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface Lottie_Swift_335 (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_Lottie_Swift_335
	{
		// @property (readonly, nonatomic) CGImageRef _Nullable CGImage;
		[NullAllowed, Export ("CGImage")]
		unsafe CGImageRef* CGImage { }
	}

	// @interface NullCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer))]
	interface NullCompositionLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);
	}

	// @interface PreCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer))]
	interface PreCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface ShapeCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer))]
	interface ShapeCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface ShapeContainerLayer : CALayer
	[BaseType (typeof(CALayer))]
	interface ShapeContainerLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);
	}

	// @interface ShapeRenderLayer : ShapeContainerLayer
	[BaseType (typeof(ShapeContainerLayer))]
	[DisableDefaultCtor]
	interface ShapeRenderLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(void)drawInContext:(CGContext _Nonnull)ctx;
		[Export ("drawInContext:")]
		unsafe void DrawInContext (CGContext* ctx);
	}

	// @interface SolidCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer))]
	interface SolidCompositionLayer
	{
		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface TextCompositionLayer : CompositionLayer
	[BaseType (typeof(CompositionLayer))]
	interface TextCompositionLayer
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);
	}

	// @interface TextLayer : CALayer
	[BaseType (typeof(CALayer))]
	interface TextLayer
	{
		// -(id<CAAction> _Nullable)actionForKey:(NSString * _Nonnull)event __attribute__((warn_unused_result));
		[Export ("actionForKey:")]
		[return: NullAllowed]
		CAAction ActionForKey (string @event);

		// -(void)drawInContext:(CGContext _Nonnull)ctx;
		[Export ("drawInContext:")]
		unsafe void DrawInContext (CGContext* ctx);

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);
	}
}
