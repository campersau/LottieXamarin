using System;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace Airbnb.Lottie
{
	// @interface AnimationCompletionDelegate
	[DisableDefaultCtor]
	interface AnimationCompletionDelegate
	{
		// -(void)animationDidStop:(CAAnimation * _Nonnull)anim finished:(id)flag;
		[Export ("animationDidStop:finished:")]
		void AnimationDidStop (CAAnimation anim, NSObject flag);
	}

	// @interface AnimationContainer
	[DisableDefaultCtor]
	interface AnimationContainer
	{
		// @property (nonatomic) int currentFrame;
		[Export ("currentFrame")]
		int CurrentFrame { get; set; }

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// +(id)needsDisplayForKey:(id)key __attribute__((warn_unused_result));
		[Static]
		[Export ("needsDisplayForKey:")]
		NSObject NeedsDisplayForKey (NSObject key);

		// -(id<CAAction> _Nullable)actionForKey:(id)event __attribute__((warn_unused_result));
		[Export ("actionForKey:")]
		[return: NullAllowed]
		CAAction ActionForKey (NSObject @event);

		// -(void)display;
		[Export ("display")]
		void Display ();
	}

	// @interface AnimationSubview
	interface AnimationSubview
	{
		// -(instancetype _Nonnull)initWithFrame:(id)frameRect __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject frameRect);

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

		// @property (readonly, nonatomic) int wantsUpdateLayer;
		[Export ("wantsUpdateLayer")]
		int WantsUpdateLayer { get; }

		// @property (readonly, getter = isFlipped, nonatomic) int flipped;
		[Export ("flipped")]
		int Flipped { [Bind ("isFlipped")] get; }

		// -(void)layout;
		[Export ("layout")]
		void Layout ();

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();

		// -(instancetype _Nonnull)initWithFrame:(id)frameRect __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject frameRect);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder coder);
	}

	// @interface AnimationView : LottieView
	[BaseType (typeof(LottieView))]
	interface AnimationView
	{
		// @property (copy, nonatomic) int * _Nullable animationName;
		[NullAllowed, Export ("animationName", ArgumentSemantic.Copy)]
		unsafe int* AnimationName { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(id)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// @property (readonly, nonatomic) int intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		int IntrinsicContentSize { get; }

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();
	}

	// @interface CompositionLayer
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

	// @interface DebugLayer
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

	// @interface InvertedMatteLayer
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

		// -(void)drawInContext:(id)ctx;
		[Export ("drawInContext:")]
		void DrawInContext (NSObject ctx);
	}

	// @interface MaskContainerLayer
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

	// @interface Lottie_Swift_335
	interface Lottie_Swift_335
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int CGImage;
		[Field ("CGImage")]
		int CGImage { get; }
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

	// @interface ShapeContainerLayer
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

		// -(void)drawInContext:(id)ctx;
		[Export ("drawInContext:")]
		void DrawInContext (NSObject ctx);
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

	// @interface TextLayer
	interface TextLayer
	{
		// -(id<CAAction> _Nullable)actionForKey:(id)event __attribute__((warn_unused_result));
		[Export ("actionForKey:")]
		[return: NullAllowed]
		CAAction ActionForKey (NSObject @event);

		// -(void)drawInContext:(id)ctx;
		[Export ("drawInContext:")]
		void DrawInContext (NSObject ctx);

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
