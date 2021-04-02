using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace Com.EsewaSDK 
{
    // @interface UIDocumentInteractionController : NSObject <UIActionSheetDelegate>
    [NoTV, iOS(3, 2)]
    [BaseType(typeof(NSObject))]
    interface UIDocumentInteractionController : IUIActionSheetDelegate
    {
        // +(UIDocumentInteractionController * _Nonnull)interactionControllerWithURL:(NSURL * _Nonnull)url;
        [Static]
        [Export("interactionControllerWithURL:")]
        UIDocumentInteractionController InteractionControllerWithURL(NSUrl url);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        UIDocumentInteractionControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<UIDocumentInteractionControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (strong) NSURL * _Nullable URL;
        [NullAllowed, Export("URL", ArgumentSemantic.Strong)]
        NSUrl URL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable UTI;
        [NullAllowed, Export("UTI")]
        string UTI { get; set; }

        // @property (copy) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (readonly, nonatomic) NSArray<UIImage *> * _Nonnull icons;
        [Export("icons")]
        UIImage[] Icons { get; }

        // @property (nonatomic, strong) id _Nullable annotation;
        [NullAllowed, Export("annotation", ArgumentSemantic.Strong)]
        NSObject Annotation { get; set; }

        // -(BOOL)presentOptionsMenuFromRect:(CGRect)rect inView:(UIView * _Nonnull)view animated:(BOOL)animated;
        [Export("presentOptionsMenuFromRect:inView:animated:")]
        bool PresentOptionsMenuFromRect(CGRect rect, UIView view, bool animated);

        // -(BOOL)presentOptionsMenuFromBarButtonItem:(UIBarButtonItem * _Nonnull)item animated:(BOOL)animated;
        [Export("presentOptionsMenuFromBarButtonItem:animated:")]
        bool PresentOptionsMenuFromBarButtonItem(UIBarButtonItem item, bool animated);

        // -(BOOL)presentPreviewAnimated:(BOOL)animated;
        [Export("presentPreviewAnimated:")]
        bool PresentPreviewAnimated(bool animated);

        // -(BOOL)presentOpenInMenuFromRect:(CGRect)rect inView:(UIView * _Nonnull)view animated:(BOOL)animated;
        [Export("presentOpenInMenuFromRect:inView:animated:")]
        bool PresentOpenInMenuFromRect(CGRect rect, UIView view, bool animated);

        // -(BOOL)presentOpenInMenuFromBarButtonItem:(UIBarButtonItem * _Nonnull)item animated:(BOOL)animated;
        [Export("presentOpenInMenuFromBarButtonItem:animated:")]
        bool PresentOpenInMenuFromBarButtonItem(UIBarButtonItem item, bool animated);

        // -(void)dismissPreviewAnimated:(BOOL)animated;
        [Export("dismissPreviewAnimated:")]
        void DismissPreviewAnimated(bool animated);

        // -(void)dismissMenuAnimated:(BOOL)animated;
        [Export("dismissMenuAnimated:")]
        void DismissMenuAnimated(bool animated);

        // @property (readonly, nonatomic) NSArray<__kindof UIGestureRecognizer *> * _Nonnull gestureRecognizers;
        [Export("gestureRecognizers")]
        UIGestureRecognizer[] GestureRecognizers { get; }
    }

    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. VisualStudio auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {

    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see https://aka.ms/ios-binding
    //
}

