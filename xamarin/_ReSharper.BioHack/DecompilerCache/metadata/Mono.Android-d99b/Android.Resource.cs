// Type: Android.Resource
// Assembly: Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\MonoAndroid\v2.3\Mono.Android.dll

using Android.Runtime;
using Java.Lang;
using System;

namespace Android
{
    [Register("android/R", DoNotGenerateAcw = true)]
    public sealed class Resource : Java.Lang.Object
    {
        [Register(".ctor", "()V", "")]
        public Resource();

        protected override IntPtr ThresholdClass { get; }
        protected override Type ThresholdType { get; }

        #region Nested type: Animation

        [Register("android/R$anim", DoNotGenerateAcw = true)]
        public sealed class Animation : Java.Lang.Object
        {
            [Register("accelerate_decelerate_interpolator")] public const int AccelerateDecelerateInterpolator =
                17432580;

            [Register("accelerate_interpolator")] public const int AccelerateInterpolator = 17432581;
            [Register("anticipate_interpolator")] public const int AnticipateInterpolator = 17432583;
            [Register("anticipate_overshoot_interpolator")] public const int AnticipateOvershootInterpolator = 17432585;
            [Register("bounce_interpolator")] public const int BounceInterpolator = 17432586;
            [Register("cycle_interpolator")] public const int CycleInterpolator = 17432588;
            [Register("decelerate_interpolator")] public const int DecelerateInterpolator = 17432582;
            [Register("fade_in")] public const int FadeIn = 17432576;
            [Register("fade_out")] public const int FadeOut = 17432577;
            [Register("linear_interpolator")] public const int LinearInterpolator = 17432587;
            [Register("overshoot_interpolator")] public const int OvershootInterpolator = 17432584;
            [Register("slide_in_left")] public const int SlideInLeft = 17432578;
            [Register("slide_out_right")] public const int SlideOutRight = 17432579;

            [Register(".ctor", "()V", "")]
            public Animation();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Array

        [Register("android/R$array", DoNotGenerateAcw = true)]
        public sealed class Array : Java.Lang.Object
        {
            [Register("emailAddressTypes")] public const int EmailAddressTypes = 17235968;
            [Register("imProtocols")] public const int ImProtocols = 17235969;
            [Register("organizationTypes")] public const int OrganizationTypes = 17235970;
            [Register("phoneTypes")] public const int PhoneTypes = 17235971;
            [Register("postalAddressTypes")] public const int PostalAddressTypes = 17235972;

            [Register(".ctor", "()V", "")]
            public Array();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Attribute

        [Register("android/R$attr", DoNotGenerateAcw = true)]
        public sealed class Attribute : Java.Lang.Object
        {
            [Register("absListViewStyle")] public const int AbsListViewStyle = 16842858;
            [Register("accountPreferences")] public const int AccountPreferences = 16843423;
            [Register("accountType")] public const int AccountType = 16843407;
            [Register("action")] public const int Action = 16842797;
            [Register("activityCloseEnterAnimation")] public const int ActivityCloseEnterAnimation = 16842938;
            [Register("activityCloseExitAnimation")] public const int ActivityCloseExitAnimation = 16842939;
            [Register("activityOpenEnterAnimation")] public const int ActivityOpenEnterAnimation = 16842936;
            [Register("activityOpenExitAnimation")] public const int ActivityOpenExitAnimation = 16842937;
            [Register("addStatesFromChildren")] public const int AddStatesFromChildren = 16842992;
            [Register("adjustViewBounds")] public const int AdjustViewBounds = 16843038;
            [Register("alertDialogStyle")] public const int AlertDialogStyle = 16842845;
            [Register("allowBackup")] public const int AllowBackup = 16843392;
            [Register("allowClearUserData")] public const int AllowClearUserData = 16842757;
            [Register("allowSingleTap")] public const int AllowSingleTap = 16843353;
            [Register("allowTaskReparenting")] public const int AllowTaskReparenting = 16843268;
            [Register("alphabeticShortcut")] public const int AlphabeticShortcut = 16843235;
            [Register("alwaysDrawnWithCache")] public const int AlwaysDrawnWithCache = 16842991;
            [Register("alwaysRetainTaskState")] public const int AlwaysRetainTaskState = 16843267;
            [Register("angle")] public const int Angle = 16843168;
            [Register("animateOnClick")] public const int AnimateOnClick = 16843356;
            [Register("animation")] public const int Animation = 16843213;
            [Register("animationCache")] public const int AnimationCache = 16842989;
            [Register("animationDuration")] public const int AnimationDuration = 16843026;
            [Register("animationOrder")] public const int AnimationOrder = 16843214;
            [Register("antialias")] public const int Antialias = 16843034;
            [Register("anyDensity")] public const int AnyDensity = 16843372;
            [Register("apiKey")] public const int ApiKey = 16843281;
            [Register("author")] public const int Author = 16843444;
            [Register("authorities")] public const int Authorities = 16842776;
            [Register("autoCompleteTextViewStyle")] public const int AutoCompleteTextViewStyle = 16842859;
            [Register("autoLink")] public const int AutoLink = 16842928;
            [Register("autoStart")] public const int AutoStart = 16843445;
            [Register("autoText")] [Obsolete("deprecated")] public const int AutoText = 16843114;
            [Register("autoUrlDetect")] public const int AutoUrlDetect = 16843404;
            [Register("background")] public const int Background = 16842964;
            [Register("backgroundDimAmount")] public const int BackgroundDimAmount = 16842802;
            [Register("backgroundDimEnabled")] public const int BackgroundDimEnabled = 16843295;
            [Register("backupAgent")] public const int BackupAgent = 16843391;
            [Register("baselineAlignBottom")] public const int BaselineAlignBottom = 16843042;
            [Register("baselineAligned")] public const int BaselineAligned = 16843046;
            [Register("baselineAlignedChildIndex")] public const int BaselineAlignedChildIndex = 16843047;
            [Register("bottom")] public const int Bottom = 16843184;
            [Register("bottomBright")] public const int BottomBright = 16842957;
            [Register("bottomDark")] public const int BottomDark = 16842953;
            [Register("bottomLeftRadius")] public const int BottomLeftRadius = 16843179;
            [Register("bottomMedium")] public const int BottomMedium = 16842958;
            [Register("bottomOffset")] public const int BottomOffset = 16843351;
            [Register("bottomRightRadius")] public const int BottomRightRadius = 16843180;
            [Register("bufferType")] public const int BufferType = 16843086;
            [Register("button")] public const int Button = 16843015;
            [Register("buttonStyle")] public const int ButtonStyle = 16842824;
            [Register("buttonStyleInset")] public const int ButtonStyleInset = 16842826;
            [Register("buttonStyleSmall")] public const int ButtonStyleSmall = 16842825;
            [Register("buttonStyleToggle")] public const int ButtonStyleToggle = 16842827;
            [Register("cacheColorHint")] public const int CacheColorHint = 16843009;
            [Register("candidatesTextStyleSpans")] public const int CandidatesTextStyleSpans = 16843312;
            [Register("capitalize")] [Obsolete("deprecated")] public const int Capitalize = 16843113;
            [Register("centerBright")] public const int CenterBright = 16842956;
            [Register("centerColor")] public const int CenterColor = 16843275;
            [Register("centerDark")] public const int CenterDark = 16842952;
            [Register("centerMedium")] public const int CenterMedium = 16842959;
            [Register("centerX")] public const int CenterX = 16843170;
            [Register("centerY")] public const int CenterY = 16843171;
            [Register("checkable")] public const int Checkable = 16843237;
            [Register("checkableBehavior")] public const int CheckableBehavior = 16843232;
            [Register("checkBoxPreferenceStyle")] public const int CheckBoxPreferenceStyle = 16842895;
            [Register("checkboxStyle")] public const int CheckboxStyle = 16842860;
            [Register("checked")] public const int Checked = 16843014;
            [Register("checkedButton")] public const int CheckedButton = 16843080;
            [Register("checkMark")] public const int CheckMark = 16843016;
            [Register("childDivider")] public const int ChildDivider = 16843025;
            [Register("childIndicator")] public const int ChildIndicator = 16843020;
            [Register("childIndicatorLeft")] public const int ChildIndicatorLeft = 16843023;
            [Register("childIndicatorRight")] public const int ChildIndicatorRight = 16843024;
            [Register("choiceMode")] public const int ChoiceMode = 16843051;
            [Register("clearTaskOnLaunch")] public const int ClearTaskOnLaunch = 16842773;
            [Register("clickable")] public const int Clickable = 16842981;
            [Register("clipChildren")] public const int ClipChildren = 16842986;
            [Register("clipOrientation")] public const int ClipOrientation = 16843274;
            [Register("clipToPadding")] public const int ClipToPadding = 16842987;
            [Register("codes")] public const int Codes = 16843330;
            [Register("collapseColumns")] public const int CollapseColumns = 16843083;
            [Register("color")] public const int Color = 16843173;
            [Register("colorBackground")] public const int ColorBackground = 16842801;
            [Register("colorBackgroundCacheHint")] public const int ColorBackgroundCacheHint = 16843435;
            [Register("colorForeground")] public const int ColorForeground = 16842800;
            [Register("colorForegroundInverse")] public const int ColorForegroundInverse = 16843270;
            [Register("columnDelay")] public const int ColumnDelay = 16843215;
            [Register("columnWidth")] public const int ColumnWidth = 16843031;
            [Register("completionHint")] public const int CompletionHint = 16843122;
            [Register("completionHintView")] public const int CompletionHintView = 16843123;
            [Register("completionThreshold")] public const int CompletionThreshold = 16843124;
            [Register("configChanges")] public const int ConfigChanges = 16842783;
            [Register("configure")] public const int Configure = 16843357;
            [Register("constantSize")] public const int ConstantSize = 16843158;
            [Register("content")] public const int Content = 16843355;
            [Register("contentAuthority")] public const int ContentAuthority = 16843408;
            [Register("contentDescription")] public const int ContentDescription = 16843379;
            [Register("cropToPadding")] public const int CropToPadding = 16843043;
            [Register("cursorVisible")] public const int CursorVisible = 16843090;
            [Register("cycles")] public const int Cycles = 16843220;
            [Register("dashGap")] public const int DashGap = 16843175;
            [Register("dashWidth")] public const int DashWidth = 16843174;
            [Register("data")] public const int Data = 16842798;
            [Register("debuggable")] public const int Debuggable = 16842767;
            [Register("defaultValue")] public const int DefaultValue = 16843245;
            [Register("delay")] public const int Delay = 16843212;
            [Register("dependency")] public const int Dependency = 16843244;
            [Register("descendantFocusability")] public const int DescendantFocusability = 16842993;
            [Register("description")] public const int Description = 16842784;
            [Register("detachWallpaper")] public const int DetachWallpaper = 16843430;
            [Register("detailColumn")] public const int DetailColumn = 16843427;
            [Register("detailSocialSummary")] public const int DetailSocialSummary = 16843428;
            [Register("dial")] public const int Dial = 16843010;
            [Register("dialogIcon")] public const int DialogIcon = 16843252;
            [Register("dialogLayout")] public const int DialogLayout = 16843255;
            [Register("dialogMessage")] public const int DialogMessage = 16843251;
            [Register("dialogPreferenceStyle")] public const int DialogPreferenceStyle = 16842897;
            [Register("dialogTitle")] public const int DialogTitle = 16843250;
            [Register("digits")] public const int Digits = 16843110;
            [Register("direction")] public const int Direction = 16843217;
            [Register("directionPriority")] public const int DirectionPriority = 16843218;
            [Register("disabledAlpha")] public const int DisabledAlpha = 16842803;
            [Register("disableDependentsState")] public const int DisableDependentsState = 16843249;
            [Register("dither")] public const int Dither = 16843036;
            [Register("divider")] public const int Divider = 16843049;
            [Register("dividerHeight")] public const int DividerHeight = 16843050;
            [Register("drawable")] public const int Drawable = 16843161;
            [Register("drawableBottom")] public const int DrawableBottom = 16843118;
            [Register("drawableLeft")] public const int DrawableLeft = 16843119;
            [Register("drawablePadding")] public const int DrawablePadding = 16843121;
            [Register("drawableRight")] public const int DrawableRight = 16843120;
            [Register("drawableTop")] public const int DrawableTop = 16843117;
            [Register("drawingCacheQuality")] public const int DrawingCacheQuality = 16842984;
            [Register("drawSelectorOnTop")] public const int DrawSelectorOnTop = 16843004;
            [Register("dropDownAnchor")] public const int DropDownAnchor = 16843363;
            [Register("dropDownHeight")] public const int DropDownHeight = 16843395;
            [Register("dropDownHintAppearance")] public const int DropDownHintAppearance = 16842888;
            [Register("dropDownHorizontalOffset")] public const int DropDownHorizontalOffset = 16843436;
            [Register("dropDownItemStyle")] public const int DropDownItemStyle = 16842886;
            [Register("dropDownListViewStyle")] public const int DropDownListViewStyle = 16842861;
            [Register("dropDownSelector")] public const int DropDownSelector = 16843125;
            [Register("dropDownVerticalOffset")] public const int DropDownVerticalOffset = 16843437;
            [Register("dropDownWidth")] public const int DropDownWidth = 16843362;
            [Register("duplicateParentState")] public const int DuplicateParentState = 16842985;
            [Register("duration")] public const int Duration = 16843160;
            [Register("editable")] [Obsolete("deprecated")] public const int Editable = 16843115;
            [Register("editorExtras")] public const int EditorExtras = 16843300;
            [Register("editTextPreferenceStyle")] public const int EditTextPreferenceStyle = 16842898;
            [Register("editTextStyle")] public const int EditTextStyle = 16842862;
            [Register("ellipsize")] public const int Ellipsize = 16842923;
            [Register("ems")] public const int Ems = 16843096;
            [Obsolete("deprecated")] [Register("enabled")] public const int Enabled = 16842766;
            [Register("endColor")] public const int EndColor = 16843166;
            [Register("endYear")] public const int EndYear = 16843133;
            [Register("entries")] public const int Entries = 16842930;
            [Register("entryValues")] public const int EntryValues = 16843256;
            [Register("eventsInterceptionEnabled")] public const int EventsInterceptionEnabled = 16843389;
            [Register("excludeFromRecents")] public const int ExcludeFromRecents = 16842775;

            [Register("expandableListPreferredChildIndicatorLeft")] public const int
                ExpandableListPreferredChildIndicatorLeft = 16842834;

            [Register("expandableListPreferredChildIndicatorRight")] public const int
                ExpandableListPreferredChildIndicatorRight = 16842835;

            [Register("expandableListPreferredChildPaddingLeft")] public const int
                ExpandableListPreferredChildPaddingLeft = 16842831;

            [Register("expandableListPreferredItemIndicatorLeft")] public const int
                ExpandableListPreferredItemIndicatorLeft = 16842832;

            [Register("expandableListPreferredItemIndicatorRight")] public const int
                ExpandableListPreferredItemIndicatorRight = 16842833;

            [Register("expandableListPreferredItemPaddingLeft")] public const int ExpandableListPreferredItemPaddingLeft
                = 16842830;

            [Register("expandableListViewStyle")] public const int ExpandableListViewStyle = 16842863;
            [Register("expandableListViewWhiteStyle")] public const int ExpandableListViewWhiteStyle = 16843446;
            [Register("exported")] public const int Exported = 16842768;
            [Register("extraTension")] public const int ExtraTension = 16843371;
            [Register("factor")] public const int Factor = 16843219;
            [Register("fadeDuration")] public const int FadeDuration = 16843384;
            [Register("fadeEnabled")] public const int FadeEnabled = 16843390;
            [Register("fadeOffset")] public const int FadeOffset = 16843383;
            [Register("fadeScrollbars")] public const int FadeScrollbars = 16843434;
            [Register("fadingEdge")] public const int FadingEdge = 16842975;
            [Register("fadingEdgeLength")] public const int FadingEdgeLength = 16842976;
            [Register("fastScrollEnabled")] public const int FastScrollEnabled = 16843302;
            [Register("fillAfter")] public const int FillAfter = 16843197;
            [Register("fillBefore")] public const int FillBefore = 16843196;
            [Register("fillEnabled")] public const int FillEnabled = 16843343;
            [Register("fillViewport")] public const int FillViewport = 16843130;
            [Register("filter")] public const int Filter = 16843035;
            [Register("filterTouchesWhenObscured")] public const int FilterTouchesWhenObscured = 16843460;
            [Register("finishOnCloseSystemDialogs")] public const int FinishOnCloseSystemDialogs = 16843431;
            [Register("finishOnTaskLaunch")] public const int FinishOnTaskLaunch = 16842772;
            [Register("fitsSystemWindows")] public const int FitsSystemWindows = 16842973;
            [Register("flipInterval")] public const int FlipInterval = 16843129;
            [Register("focusable")] public const int Focusable = 16842970;
            [Register("focusableInTouchMode")] public const int FocusableInTouchMode = 16842971;
            [Register("footerDividersEnabled")] public const int FooterDividersEnabled = 16843311;
            [Register("foreground")] public const int Foreground = 16843017;
            [Register("foregroundGravity")] public const int ForegroundGravity = 16843264;
            [Register("format")] public const int Format = 16843013;
            [Register("freezesText")] public const int FreezesText = 16843116;
            [Register("fromAlpha")] public const int FromAlpha = 16843210;
            [Register("fromDegrees")] public const int FromDegrees = 16843187;
            [Register("fromXDelta")] public const int FromXDelta = 16843206;
            [Register("fromXScale")] public const int FromXScale = 16843202;
            [Register("fromYDelta")] public const int FromYDelta = 16843208;
            [Register("fromYScale")] public const int FromYScale = 16843204;
            [Register("fullBright")] public const int FullBright = 16842954;
            [Register("fullDark")] public const int FullDark = 16842950;
            [Register("functionalTest")] public const int FunctionalTest = 16842787;
            [Register("galleryItemBackground")] public const int GalleryItemBackground = 16842828;
            [Register("galleryStyle")] public const int GalleryStyle = 16842864;
            [Register("gestureColor")] public const int GestureColor = 16843381;
            [Register("gestureStrokeAngleThreshold")] public const int GestureStrokeAngleThreshold = 16843388;
            [Register("gestureStrokeLengthThreshold")] public const int GestureStrokeLengthThreshold = 16843386;
            [Register("gestureStrokeSquarenessThreshold")] public const int GestureStrokeSquarenessThreshold = 16843387;
            [Register("gestureStrokeType")] public const int GestureStrokeType = 16843385;
            [Register("gestureStrokeWidth")] public const int GestureStrokeWidth = 16843380;
            [Register("glEsVersion")] public const int GlEsVersion = 16843393;
            [Register("gradientRadius")] public const int GradientRadius = 16843172;
            [Register("grantUriPermissions")] public const int GrantUriPermissions = 16842779;
            [Register("gravity")] public const int Gravity = 16842927;
            [Register("gridViewStyle")] public const int GridViewStyle = 16842865;
            [Register("groupIndicator")] public const int GroupIndicator = 16843019;
            [Register("hand_hour")] public const int HandHour = 16843011;
            [Register("hand_minute")] public const int HandMinute = 16843012;
            [Register("handle")] public const int ChildHandle = 16843354;
            [Register("handleProfiling")] public const int HandleProfiling = 16842786;
            [Register("hapticFeedbackEnabled")] public const int HapticFeedbackEnabled = 16843358;
            [Register("hasCode")] public const int HasCode = 16842764;
            [Register("headerBackground")] public const int HeaderBackground = 16843055;
            [Register("headerDividersEnabled")] public const int HeaderDividersEnabled = 16843310;
            [Register("height")] public const int Height = 16843093;
            [Register("hint")] public const int Hint = 16843088;
            [Register("horizontalDivider")] public const int HorizontalDivider = 16843053;
            [Register("horizontalGap")] public const int HorizontalGap = 16843327;
            [Register("horizontalSpacing")] public const int HorizontalSpacing = 16843028;
            [Register("host")] public const int Host = 16842792;
            [Register("icon")] public const int Icon = 16842754;
            [Register("iconPreview")] public const int IconPreview = 16843337;
            [Register("id")] public const int Id = 16842960;
            [Register("ignoreGravity")] public const int IgnoreGravity = 16843263;
            [Register("imageButtonStyle")] public const int ImageButtonStyle = 16842866;
            [Register("imageWellStyle")] public const int ImageWellStyle = 16842867;
            [Register("imeActionId")] public const int ImeActionId = 16843366;
            [Register("imeActionLabel")] public const int ImeActionLabel = 16843365;
            [Register("imeExtractEnterAnimation")] public const int ImeExtractEnterAnimation = 16843368;
            [Register("imeExtractExitAnimation")] public const int ImeExtractExitAnimation = 16843369;
            [Register("imeFullscreenBackground")] public const int ImeFullScreenBackground = 16843308;
            [Register("imeOptions")] public const int ImeOptions = 16843364;
            [Register("inAnimation")] public const int InAnimation = 16843127;
            [Register("includeFontPadding")] public const int IncludeFontPadding = 16843103;
            [Register("includeInGlobalSearch")] public const int IncludeInGlobalSearch = 16843374;
            [Register("indeterminate")] public const int Indeterminate = 16843065;
            [Register("indeterminateBehavior")] public const int IndeterminateBehavior = 16843070;
            [Register("indeterminateDrawable")] public const int IndeterminateDrawable = 16843067;
            [Register("indeterminateDuration")] public const int IndeterminateDuration = 16843069;
            [Register("indeterminateOnly")] public const int IndeterminateOnly = 16843066;
            [Register("indicatorLeft")] public const int IndicatorLeft = 16843021;
            [Register("indicatorRight")] public const int IndicatorRight = 16843022;
            [Register("inflatedId")] public const int InflatedId = 16842995;
            [Register("initialLayout")] public const int InitialLayout = 16843345;
            [Register("initOrder")] public const int InitOrder = 16842778;
            [Register("innerRadius")] public const int InnerRadius = 16843359;
            [Register("innerRadiusRatio")] public const int InnerRadiusRatio = 16843163;
            [Register("inputMethod")] [Obsolete("deprecated")] public const int InputMethod = 16843112;
            [Register("inputType")] public const int InputType = 16843296;
            [Register("insetBottom")] public const int InsetBottom = 16843194;
            [Register("insetLeft")] public const int InsetLeft = 16843191;
            [Register("insetRight")] public const int InsetRight = 16843192;
            [Register("insetTop")] public const int InsetTop = 16843193;
            [Register("installLocation")] public const int InstallLocation = 16843447;
            [Register("interpolator")] public const int Interpolator = 16843073;
            [Register("isDefault")] public const int IsDefault = 16843297;
            [Register("isIndicator")] public const int IsIndicator = 16843079;
            [Register("isModifier")] public const int IsModifier = 16843334;
            [Register("isRepeatable")] public const int IsRepeatable = 16843336;
            [Register("isScrollContainer")] public const int IsScrollContainer = 16843342;
            [Register("isSticky")] public const int IsSticky = 16843335;
            [Register("itemBackground")] public const int ItemBackground = 16843056;
            [Register("itemIconDisabledAlpha")] public const int ItemIconDisabledAlpha = 16843057;
            [Register("itemTextAppearance")] public const int ItemTextAppearance = 16843052;
            [Register("keepScreenOn")] public const int KeepScreenOn = 16843286;
            [Register("key")] public const int Key = 16843240;
            [Register("keyBackground")] public const int KeyBackground = 16843315;
            [Register("keyboardMode")] public const int KeyboardMode = 16843341;
            [Register("keycode")] public const int Keycode = 16842949;
            [Register("keyEdgeFlags")] public const int KeyEdgeFlags = 16843333;
            [Register("keyHeight")] public const int KeyHeight = 16843326;
            [Register("keyIcon")] public const int KeyIcon = 16843340;
            [Register("keyLabel")] public const int KeyLabel = 16843339;
            [Register("keyOutputText")] public const int KeyOutputText = 16843338;
            [Register("keyPreviewHeight")] public const int KeyPreviewHeight = 16843321;
            [Register("keyPreviewLayout")] public const int KeyPreviewLayout = 16843319;
            [Register("keyPreviewOffset")] public const int KeyPreviewOffset = 16843320;
            [Register("keyTextColor")] public const int KeyTextColor = 16843318;
            [Register("keyTextSize")] public const int KeyTextSize = 16843316;
            [Register("keyWidth")] public const int KeyWidth = 16843325;
            [Register("killAfterRestore")] public const int KillAfterRestore = 16843420;
            [Register("label")] public const int Label = 16842753;
            [Register("labelTextSize")] public const int LabelTextSize = 16843317;
            [Register("largeScreens")] public const int LargeScreens = 16843398;
            [Register("launchMode")] public const int LaunchMode = 16842781;
            [Register("layout")] public const int Layout = 16842994;
            [Register("layout_above")] public const int LayoutAbove = 16843140;
            [Register("layout_alignBaseline")] public const int LayoutAlignBaseline = 16843142;
            [Register("layout_alignBottom")] public const int LayoutAlignBottom = 16843146;
            [Register("layout_alignLeft")] public const int LayoutAlignLeft = 16843143;
            [Register("layout_alignParentBottom")] public const int LayoutAlignParentBottom = 16843150;
            [Register("layout_alignParentLeft")] public const int LayoutAlignParentLeft = 16843147;
            [Register("layout_alignParentRight")] public const int LayoutAlignParentRight = 16843149;
            [Register("layout_alignParentTop")] public const int LayoutAlignParentTop = 16843148;
            [Register("layout_alignRight")] public const int LayoutAlignRight = 16843145;
            [Register("layout_alignTop")] public const int LayoutAlignTop = 16843144;
            [Register("layout_alignWithParentIfMissing")] public const int LayoutAlignWithParentIfMissing = 16843154;
            [Register("layout_below")] public const int LayoutBelow = 16843141;
            [Register("layout_centerHorizontal")] public const int LayoutCenterHorizontal = 16843152;
            [Register("layout_centerInParent")] public const int LayoutCenterInParent = 16843151;
            [Register("layout_centerVertical")] public const int LayoutCenterVertical = 16843153;
            [Register("layout_column")] public const int LayoutColumn = 16843084;
            [Register("layout_gravity")] public const int LayoutGravity = 16842931;
            [Register("layout_height")] public const int LayoutHeight = 16842997;
            [Register("layout_margin")] public const int LayoutMargin = 16842998;
            [Register("layout_marginBottom")] public const int LayoutMarginBottom = 16843002;
            [Register("layout_marginLeft")] public const int LayoutMarginLeft = 16842999;
            [Register("layout_marginRight")] public const int LayoutMarginRight = 16843001;
            [Register("layout_marginTop")] public const int LayoutMarginTop = 16843000;
            [Register("layout_scale")] public const int LayoutScale = 16843155;
            [Register("layout_span")] public const int LayoutSpan = 16843085;
            [Register("layout_toLeftOf")] public const int LayoutToLeftOf = 16843138;
            [Register("layout_toRightOf")] public const int LayoutToRightOf = 16843139;
            [Register("layout_weight")] public const int LayoutWeight = 16843137;
            [Register("layout_width")] public const int LayoutWidth = 16842996;
            [Register("layout_x")] public const int LayoutX = 16843135;
            [Register("layout_y")] public const int LayoutY = 16843136;
            [Register("layoutAnimation")] public const int LayoutAnimation = 16842988;
            [Register("left")] public const int Left = 16843181;
            [Register("lines")] public const int Lines = 16843092;
            [Register("lineSpacingExtra")] public const int LineSpacingExtra = 16843287;
            [Register("lineSpacingMultiplier")] public const int LineSpacingMultiplier = 16843288;
            [Register("linksClickable")] public const int LinksClickable = 16842929;
            [Register("listChoiceIndicatorMultiple")] public const int ListChoiceIndicatorMultiple = 16843290;
            [Register("listChoiceIndicatorSingle")] public const int ListChoiceIndicatorSingle = 16843289;
            [Register("listDivider")] public const int ListDivider = 16843284;
            [Register("listPreferredItemHeight")] public const int ListPreferredItemHeight = 16842829;
            [Register("listSelector")] public const int ListSelector = 16843003;
            [Register("listSeparatorTextViewStyle")] public const int ListSeparatorTextViewStyle = 16843272;
            [Register("listViewStyle")] public const int ListViewStyle = 16842868;
            [Register("listViewWhiteStyle")] public const int ListViewWhiteStyle = 16842869;
            [Register("longClickable")] public const int LongClickable = 16842982;
            [Register("manageSpaceActivity")] public const int ManageSpaceActivity = 16842756;
            [Register("mapViewStyle")] public const int MapViewStyle = 16842890;
            [Register("marqueeRepeatLimit")] public const int MarqueeRepeatLimit = 16843293;
            [Register("max")] public const int Max = 16843062;
            [Register("maxEms")] public const int MaxEms = 16843095;
            [Register("maxHeight")] public const int MaxHeight = 16843040;
            [Register("maxItemsPerRow")] public const int MaxItemsPerRow = 16843060;
            [Register("maxLength")] public const int MaxLength = 16843104;
            [Register("maxLevel")] public const int MaxLevel = 16843186;
            [Register("maxLines")] public const int MaxLines = 16843091;
            [Register("maxRows")] public const int MaxRows = 16843059;
            [Register("maxSdkVersion")] public const int MaxSdkVersion = 16843377;
            [Register("maxWidth")] public const int MaxWidth = 16843039;
            [Register("measureAllChildren")] public const int MeasureAllChildren = 16843018;
            [Register("menuCategory")] public const int MenuCategory = 16843230;
            [Register("mimeType")] public const int MimeType = 16842790;
            [Register("minEms")] public const int MinEms = 16843098;
            [Register("minHeight")] public const int MinHeight = 16843072;
            [Register("minLevel")] public const int MinLevel = 16843185;
            [Register("minLines")] public const int MinLines = 16843094;
            [Register("minSdkVersion")] public const int MinSdkVersion = 16843276;
            [Register("minWidth")] public const int MinWidth = 16843071;
            [Register("mode")] public const int Mode = 16843134;
            [Register("moreIcon")] public const int MoreIcon = 16843061;
            [Register("multiprocess")] public const int Multiprocess = 16842771;
            [Register("name")] public const int Name = 16842755;
            [Register("negativeButtonText")] public const int NegativeButtonText = 16843254;
            [Register("nextFocusDown")] public const int NextFocusDown = 16842980;
            [Register("nextFocusLeft")] public const int NextFocusLeft = 16842977;
            [Register("nextFocusRight")] public const int NextFocusRight = 16842978;
            [Register("nextFocusUp")] public const int NextFocusUp = 16842979;
            [Register("noHistory")] public const int NoHistory = 16843309;
            [Register("normalScreens")] public const int NormalScreens = 16843397;
            [Register("numColumns")] public const int NumColumns = 16843032;
            [Register("numeric")] [Obsolete("deprecated")] public const int Numeric = 16843109;
            [Register("numericShortcut")] public const int NumericShortcut = 16843236;
            [Register("numStars")] public const int NumStars = 16843076;
            [Register("onClick")] public const int OnClick = 16843375;
            [Register("oneshot")] public const int Oneshot = 16843159;
            [Register("order")] public const int Order = 16843242;
            [Register("orderInCategory")] public const int OrderInCategory = 16843231;
            [Register("orderingFromXml")] public const int OrderingFromXml = 16843239;
            [Register("orientation")] public const int Orientation = 16842948;
            [Register("outAnimation")] public const int OutAnimation = 16843128;
            [Register("overScrollFooter")] public const int OverScrollFooter = 16843459;
            [Register("overScrollHeader")] public const int OverScrollHeader = 16843458;
            [Register("overScrollMode")] public const int OverScrollMode = 16843457;
            [Register("padding")] public const int Padding = 16842965;
            [Register("paddingBottom")] public const int PaddingBottom = 16842969;
            [Register("paddingLeft")] public const int PaddingLeft = 16842966;
            [Register("paddingRight")] public const int PaddingRight = 16842968;
            [Register("paddingTop")] public const int PaddingTop = 16842967;
            [Register("panelBackground")] public const int PanelBackground = 16842846;
            [Register("panelColorBackground")] public const int PanelColorBackground = 16842849;
            [Register("panelColorForeground")] public const int PanelColorForeground = 16842848;
            [Register("panelFullBackground")] public const int PanelFullBackground = 16842847;
            [Register("panelTextAppearance")] public const int PanelTextAppearance = 16842850;
            [Register("password")] [Obsolete("deprecated")] public const int Password = 16843100;
            [Register("path")] public const int Path = 16842794;
            [Register("pathPattern")] public const int PathPattern = 16842796;
            [Register("pathPrefix")] public const int PathPrefix = 16842795;
            [Register("permission")] public const int Permission = 16842758;
            [Register("permissionGroup")] public const int PermissionGroup = 16842762;
            [Register("persistent")] public const int Persistent = 16842765;
            [Register("persistentDrawingCache")] public const int PersistentDrawingCache = 16842990;
            [Register("phoneNumber")] [Obsolete("deprecated")] public const int PhoneNumber = 16843111;
            [Register("pivotX")] public const int PivotX = 16843189;
            [Register("pivotY")] public const int PivotY = 16843190;
            [Register("popupAnimationStyle")] public const int PopupAnimationStyle = 16843465;
            [Register("popupBackground")] public const int PopupBackground = 16843126;
            [Register("popupCharacters")] public const int PopupCharacters = 16843332;
            [Register("popupKeyboard")] public const int PopupKeyboard = 16843331;
            [Register("popupLayout")] public const int PopupLayout = 16843323;
            [Register("popupWindowStyle")] public const int PopupWindowStyle = 16842870;
            [Register("port")] public const int Port = 16842793;
            [Register("positiveButtonText")] public const int PositiveButtonText = 16843253;
            [Register("preferenceCategoryStyle")] public const int PreferenceCategoryStyle = 16842892;
            [Register("preferenceInformationStyle")] public const int PreferenceInformationStyle = 16842893;
            [Register("preferenceLayoutChild")] public const int PreferenceLayoutChild = 16842900;
            [Register("preferenceScreenStyle")] public const int PreferenceScreenStyle = 16842891;
            [Register("preferenceStyle")] public const int PreferenceStyle = 16842894;
            [Register("priority")] public const int Priority = 16842780;
            [Register("privateImeOptions")] public const int PrivateImeOptions = 16843299;
            [Register("process")] public const int Process = 16842769;
            [Register("progress")] public const int Progress = 16843063;
            [Register("progressBarStyle")] public const int ProgressBarStyle = 16842871;
            [Register("progressBarStyleHorizontal")] public const int ProgressBarStyleHorizontal = 16842872;
            [Register("progressBarStyleInverse")] public const int ProgressBarStyleInverse = 16843399;
            [Register("progressBarStyleLarge")] public const int ProgressBarStyleLarge = 16842874;
            [Register("progressBarStyleLargeInverse")] public const int ProgressBarStyleLargeInverse = 16843401;
            [Register("progressBarStyleSmall")] public const int ProgressBarStyleSmall = 16842873;
            [Register("progressBarStyleSmallInverse")] public const int ProgressBarStyleSmallInverse = 16843400;
            [Register("progressBarStyleSmallTitle")] public const int ProgressBarStyleSmallTitle = 16843279;
            [Register("progressDrawable")] public const int ProgressDrawable = 16843068;
            [Register("prompt")] public const int Prompt = 16843131;
            [Register("protectionLevel")] public const int ProtectionLevel = 16842761;
            [Register("queryActionMsg")] public const int QueryActionMsg = 16843227;
            [Register("queryAfterZeroResults")] public const int QueryAfterZeroResults = 16843394;

            [Register("quickContactBadgeStyleSmallWindowLarge")] public const int QuickContactBadgeStyleSmallWindowLarge
                = 16843443;

            [Register("quickContactBadgeStyleSmallWindowMedium")] public const int
                QuickContactBadgeStyleSmallWindowMedium = 16843442;

            [Register("quickContactBadgeStyleSmallWindowSmall")] public const int QuickContactBadgeStyleSmallWindowSmall
                = 16843441;

            [Register("quickContactBadgeStyleWindowLarge")] public const int QuickContactBadgeStyleWindowLarge =
                16843440;

            [Register("quickContactBadgeStyleWindowMedium")] public const int QuickContactBadgeStyleWindowMedium =
                16843439;

            [Register("quickContactBadgeStyleWindowSmall")] public const int QuickContactBadgeStyleWindowSmall =
                16843438;

            [Register("radioButtonStyle")] public const int RadioButtonStyle = 16842878;
            [Register("radius")] public const int Radius = 16843176;
            [Register("rating")] public const int Rating = 16843077;
            [Register("ratingBarStyle")] public const int RatingBarStyle = 16842876;
            [Register("ratingBarStyleIndicator")] public const int RatingBarStyleIndicator = 16843280;
            [Register("ratingBarStyleSmall")] public const int RatingBarStyleSmall = 16842877;
            [Register("readPermission")] public const int ReadPermission = 16842759;
            [Register("repeatCount")] public const int RepeatCount = 16843199;
            [Register("repeatMode")] public const int RepeatMode = 16843200;
            [Register("reqFiveWayNav")] public const int ReqFiveWayNav = 16843314;
            [Register("reqHardKeyboard")] public const int ReqHardKeyboard = 16843305;
            [Register("reqKeyboardType")] public const int ReqKeyboardType = 16843304;
            [Register("reqNavigation")] public const int ReqNavigation = 16843306;
            [Register("reqTouchScreen")] public const int ReqTouchScreen = 16843303;
            [Register("required")] public const int Required = 16843406;
            [Register("resizeable")] public const int Resizeable = 16843405;
            [Register("resource")] public const int Resource = 16842789;
            [Register("restoreAnyVersion")] public const int RestoreAnyVersion = 16843450;
            [Register("restoreNeedsApplication")] public const int RestoreNeedsApplication = 16843421;
            [Register("right")] public const int Right = 16843183;
            [Register("ringtonePreferenceStyle")] public const int RingtonePreferenceStyle = 16842899;
            [Register("ringtoneType")] public const int RingtoneType = 16843257;
            [Register("rowDelay")] public const int RowDelay = 16843216;
            [Register("rowEdgeFlags")] public const int RowEdgeFlags = 16843329;
            [Register("rowHeight")] public const int RowHeight = 16843058;
            [Register("saveEnabled")] public const int SaveEnabled = 16842983;
            [Register("scaleGravity")] public const int ScaleGravity = 16843262;
            [Register("scaleHeight")] public const int ScaleHeight = 16843261;
            [Register("scaleType")] public const int ScaleType = 16843037;
            [Register("scaleWidth")] public const int ScaleWidth = 16843260;
            [Register("scheme")] public const int Scheme = 16842791;
            [Register("screenDensity")] public const int ScreenDensity = 16843467;
            [Register("screenOrientation")] public const int ScreenOrientation = 16842782;
            [Register("screenSize")] public const int ScreenSize = 16843466;

            [Register("scrollbarAlwaysDrawHorizontalTrack")] public const int ScrollbarAlwaysDrawHorizontalTrack =
                16842856;

            [Register("scrollbarAlwaysDrawVerticalTrack")] public const int ScrollbarAlwaysDrawVerticalTrack = 16842857;
            [Register("scrollbarDefaultDelayBeforeFade")] public const int ScrollbarDefaultDelayBeforeFade = 16843433;
            [Register("scrollbarFadeDuration")] public const int ScrollbarFadeDuration = 16843432;
            [Register("scrollbars")] public const int Scrollbars = 16842974;
            [Register("scrollbarSize")] public const int ScrollbarSize = 16842851;
            [Register("scrollbarStyle")] public const int ScrollbarStyle = 16842879;
            [Register("scrollbarThumbHorizontal")] public const int ScrollbarThumbHorizontal = 16842852;
            [Register("scrollbarThumbVertical")] public const int ScrollbarThumbVertical = 16842853;
            [Register("scrollbarTrackHorizontal")] public const int ScrollbarTrackHorizontal = 16842854;
            [Register("scrollbarTrackVertical")] public const int ScrollbarTrackVertical = 16842855;
            [Register("scrollHorizontally")] public const int ScrollHorizontally = 16843099;
            [Register("scrollingCache")] public const int ScrollingCache = 16843006;
            [Register("scrollViewStyle")] public const int ScrollViewStyle = 16842880;
            [Register("scrollX")] public const int ScrollX = 16842962;
            [Register("scrollY")] public const int ScrollY = 16842963;
            [Register("searchButtonText")] [Obsolete("deprecated")] public const int SearchButtonText = 16843269;
            [Register("searchMode")] public const int SearchMode = 16843221;
            [Register("searchSettingsDescription")] public const int SearchSettingsDescription = 16843402;
            [Register("searchSuggestAuthority")] public const int SearchSuggestAuthority = 16843222;
            [Register("searchSuggestIntentAction")] public const int SearchSuggestIntentAction = 16843225;
            [Register("searchSuggestIntentData")] public const int SearchSuggestIntentData = 16843226;
            [Register("searchSuggestPath")] public const int SearchSuggestPath = 16843223;
            [Register("searchSuggestSelection")] public const int SearchSuggestSelection = 16843224;
            [Register("searchSuggestThreshold")] public const int SearchSuggestThreshold = 16843373;
            [Register("secondaryProgress")] public const int SecondaryProgress = 16843064;
            [Register("seekBarStyle")] public const int SeekBarStyle = 16842875;
            [Register("selectable")] public const int Selectable = 16843238;
            [Register("selectAllOnFocus")] public const int SelectAllOnFocus = 16843102;
            [Register("settingsActivity")] public const int SettingsActivity = 16843301;
            [Register("shadowColor")] public const int ShadowColor = 16843105;
            [Register("shadowDx")] public const int ShadowDx = 16843106;
            [Register("shadowDy")] public const int ShadowDy = 16843107;
            [Register("shadowRadius")] public const int ShadowRadius = 16843108;
            [Register("shape")] public const int Shape = 16843162;
            [Register("sharedUserId")] public const int SharedUserId = 16842763;
            [Register("sharedUserLabel")] public const int SharedUserLabel = 16843361;
            [Register("shareInterpolator")] public const int ShareInterpolator = 16843195;
            [Register("shouldDisableView")] public const int ShouldDisableView = 16843246;
            [Register("showDefault")] public const int ShowDefault = 16843258;
            [Register("showSilent")] public const int ShowSilent = 16843259;
            [Register("shrinkColumns")] public const int ShrinkColumns = 16843082;
            [Obsolete("deprecated")] [Register("singleLine")] public const int SingleLine = 16843101;
            [Register("smallIcon")] public const int SmallIcon = 16843422;
            [Register("smallScreens")] public const int SmallScreens = 16843396;
            [Register("smoothScrollbar")] public const int SmoothScrollbar = 16843313;
            [Register("soundEffectsEnabled")] public const int SoundEffectsEnabled = 16843285;
            [Register("spacing")] public const int Spacing = 16843027;
            [Register("spinnerDropDownItemStyle")] public const int SpinnerDropDownItemStyle = 16842887;
            [Register("spinnerItemStyle")] public const int SpinnerItemStyle = 16842889;
            [Register("spinnerStyle")] public const int SpinnerStyle = 16842881;
            [Register("src")] public const int Src = 16843033;
            [Register("stackFromBottom")] public const int StackFromBottom = 16843005;
            [Register("starStyle")] public const int StarStyle = 16842882;
            [Register("startColor")] public const int StartColor = 16843165;
            [Register("startOffset")] public const int StartOffset = 16843198;
            [Register("startYear")] public const int StartYear = 16843132;
            [Register("state_above_anchor")] public const int StateAboveAnchor = 16842922;
            [Register("state_active")] public const int StateActive = 16842914;
            [Register("state_checkable")] public const int StateCheckable = 16842911;
            [Register("state_checked")] public const int StateChecked = 16842912;
            [Register("state_empty")] public const int StateEmpty = 16842921;
            [Register("state_enabled")] public const int StateEnabled = 16842910;
            [Register("state_expanded")] public const int StateExpanded = 16842920;
            [Register("state_first")] public const int StateFirst = 16842916;
            [Register("state_focused")] public const int StateFocused = 16842908;
            [Register("state_last")] public const int StateLast = 16842918;
            [Register("state_long_pressable")] public const int StateLongPressable = 16843324;
            [Register("state_middle")] public const int StateMiddle = 16842917;
            [Register("state_pressed")] public const int StatePressed = 16842919;
            [Register("state_selected")] public const int StateSelected = 16842913;
            [Register("state_single")] public const int StateSingle = 16842915;
            [Register("state_window_focused")] public const int StateWindowFocused = 16842909;
            [Register("stateNotNeeded")] public const int StateNotNeeded = 16842774;
            [Register("stepSize")] public const int StepSize = 16843078;
            [Register("streamType")] public const int StreamType = 16843273;
            [Register("stretchColumns")] public const int StretchColumns = 16843081;
            [Register("stretchMode")] public const int StretchMode = 16843030;
            [Register("suggestActionMsg")] public const int SuggestActionMsg = 16843228;
            [Register("suggestActionMsgColumn")] public const int SuggestActionMsgColumn = 16843229;
            [Register("summary")] public const int Summary = 16843241;
            [Register("summaryColumn")] public const int SummaryColumn = 16843426;
            [Register("summaryOff")] public const int SummaryOff = 16843248;
            [Register("summaryOn")] public const int SummaryOn = 16843247;
            [Register("supportsUploading")] public const int SupportsUploading = 16843419;
            [Register("syncable")] public const int Syncable = 16842777;
            [Register("tabStripEnabled")] public const int TabStripEnabled = 16843453;
            [Register("tabStripLeft")] public const int TabStripLeft = 16843451;
            [Register("tabStripRight")] public const int TabStripRight = 16843452;
            [Register("tabWidgetStyle")] public const int TabWidgetStyle = 16842883;
            [Register("tag")] public const int Tag = 16842961;
            [Register("targetActivity")] public const int TargetActivity = 16843266;
            [Register("targetClass")] public const int TargetClass = 16842799;
            [Register("targetPackage")] public const int TargetPackage = 16842785;
            [Register("targetSdkVersion")] public const int TargetSdkVersion = 16843376;
            [Register("taskAffinity")] public const int TaskAffinity = 16842770;
            [Register("taskCloseEnterAnimation")] public const int TaskCloseEnterAnimation = 16842942;
            [Register("taskCloseExitAnimation")] public const int TaskCloseExitAnimation = 16842943;
            [Register("taskOpenEnterAnimation")] public const int TaskOpenEnterAnimation = 16842940;
            [Register("taskOpenExitAnimation")] public const int TaskOpenExitAnimation = 16842941;
            [Register("taskToBackEnterAnimation")] public const int TaskToBackEnterAnimation = 16842946;
            [Register("taskToBackExitAnimation")] public const int TaskToBackExitAnimation = 16842947;
            [Register("taskToFrontEnterAnimation")] public const int TaskToFrontEnterAnimation = 16842944;
            [Register("taskToFrontExitAnimation")] public const int TaskToFrontExitAnimation = 16842945;
            [Register("tension")] public const int Tension = 16843370;
            [Register("testOnly")] public const int TestOnly = 16843378;
            [Register("text")] public const int Text = 16843087;
            [Register("textAppearance")] public const int TextAppearance = 16842804;
            [Register("textAppearanceButton")] public const int TextAppearanceButton = 16843271;
            [Register("textAppearanceInverse")] public const int TextAppearanceInverse = 16842805;
            [Register("textAppearanceLarge")] public const int TextAppearanceLarge = 16842816;
            [Register("textAppearanceLargeInverse")] public const int TextAppearanceLargeInverse = 16842819;
            [Register("textAppearanceMedium")] public const int TextAppearanceMedium = 16842817;
            [Register("textAppearanceMediumInverse")] public const int TextAppearanceMediumInverse = 16842820;

            [Register("textAppearanceSearchResultSubtitle")] public const int TextAppearanceSearchResultSubtitle =
                16843424;

            [Register("textAppearanceSearchResultTitle")] public const int TextAppearanceSearchResultTitle = 16843425;
            [Register("textAppearanceSmall")] public const int TextAppearanceSmall = 16842818;
            [Register("textAppearanceSmallInverse")] public const int TextAppearanceSmallInverse = 16842821;
            [Register("textCheckMark")] public const int TextCheckMark = 16842822;
            [Register("textCheckMarkInverse")] public const int TextCheckMarkInverse = 16842823;
            [Register("textColor")] public const int TextColor = 16842904;
            [Register("textColorHighlight")] public const int TextColorHighlight = 16842905;
            [Register("textColorHint")] public const int TextColorHint = 16842906;
            [Register("textColorHintInverse")] public const int TextColorHintInverse = 16842815;
            [Register("textColorLink")] public const int TextColorLink = 16842907;
            [Register("textColorPrimary")] public const int TextColorPrimary = 16842806;
            [Register("textColorPrimaryDisableOnly")] public const int TextColorPrimaryDisableOnly = 16842807;
            [Register("textColorPrimaryInverse")] public const int TextColorPrimaryInverse = 16842809;

            [Register("textColorPrimaryInverseDisableOnly")] public const int TextColorPrimaryInverseDisableOnly =
                16843403;

            [Register("textColorPrimaryInverseNoDisable")] public const int TextColorPrimaryInverseNoDisable = 16842813;
            [Register("textColorPrimaryNoDisable")] public const int TextColorPrimaryNoDisable = 16842811;
            [Register("textColorSecondary")] public const int TextColorSecondary = 16842808;
            [Register("textColorSecondaryInverse")] public const int TextColorSecondaryInverse = 16842810;

            [Register("textColorSecondaryInverseNoDisable")] public const int TextColorSecondaryInverseNoDisable =
                16842814;

            [Register("textColorSecondaryNoDisable")] public const int TextColorSecondaryNoDisable = 16842812;
            [Register("textColorTertiary")] public const int TextColorTertiary = 16843282;
            [Register("textColorTertiaryInverse")] public const int TextColorTertiaryInverse = 16843283;
            [Register("textFilterEnabled")] public const int TextFilterEnabled = 16843007;
            [Register("textOff")] public const int TextOff = 16843045;
            [Register("textOn")] public const int TextOn = 16843044;
            [Register("textScaleX")] public const int TextScaleX = 16843089;
            [Register("textSelectHandle")] public const int TextSelectHandle = 16843463;
            [Register("textSelectHandleLeft")] public const int TextSelectHandleLeft = 16843461;
            [Register("textSelectHandleRight")] public const int TextSelectHandleRight = 16843462;
            [Register("textSelectHandleWindowStyle")] public const int TextSelectHandleWindowStyle = 16843464;
            [Register("textSize")] public const int TextSize = 16842901;
            [Register("textStyle")] public const int TextStyle = 16842903;
            [Register("textViewStyle")] public const int TextViewStyle = 16842884;
            [Register("theme")] public const int Theme = 16842752;
            [Register("thickness")] public const int Thickness = 16843360;
            [Register("thicknessRatio")] public const int ThicknessRatio = 16843164;
            [Register("thumb")] public const int Thumb = 16843074;
            [Register("thumbnail")] public const int Thumbnail = 16843429;
            [Register("thumbOffset")] public const int ThumbOffset = 16843075;
            [Register("tileMode")] public const int TileMode = 16843265;
            [Register("tint")] public const int Tint = 16843041;
            [Register("title")] public const int Title = 16843233;
            [Register("titleCondensed")] public const int TitleCondensed = 16843234;
            [Register("toAlpha")] public const int ToAlpha = 16843211;
            [Register("toDegrees")] public const int ToDegrees = 16843188;
            [Register("top")] public const int Top = 16843182;
            [Register("topBright")] public const int TopBright = 16842955;
            [Register("topDark")] public const int TopDark = 16842951;
            [Register("topLeftRadius")] public const int TopLeftRadius = 16843177;
            [Register("topOffset")] public const int TopOffset = 16843352;
            [Register("topRightRadius")] public const int TopRightRadius = 16843178;
            [Register("toXDelta")] public const int ToXDelta = 16843207;
            [Register("toXScale")] public const int ToXScale = 16843203;
            [Register("toYDelta")] public const int ToYDelta = 16843209;
            [Register("toYScale")] public const int ToYScale = 16843205;
            [Register("transcriptMode")] public const int TranscriptMode = 16843008;
            [Register("type")] public const int Type = 16843169;
            [Register("typeface")] public const int Typeface = 16842902;
            [Register("uncertainGestureColor")] public const int UncertainGestureColor = 16843382;
            [Register("unselectedAlpha")] public const int UnselectedAlpha = 16843278;
            [Register("updatePeriodMillis")] public const int UpdatePeriodMillis = 16843344;
            [Register("useLevel")] public const int UseLevel = 16843167;
            [Register("userVisible")] public const int UserVisible = 16843409;
            [Register("value")] public const int Value = 16842788;
            [Register("variablePadding")] public const int VariablePadding = 16843157;
            [Register("versionCode")] public const int VersionCode = 16843291;
            [Register("versionName")] public const int VersionName = 16843292;
            [Register("verticalCorrection")] public const int VerticalCorrection = 16843322;
            [Register("verticalDivider")] public const int VerticalDivider = 16843054;
            [Register("verticalGap")] public const int VerticalGap = 16843328;
            [Register("verticalSpacing")] public const int VerticalSpacing = 16843029;
            [Register("visibility")] public const int Visibility = 16842972;
            [Register("visible")] public const int Visible = 16843156;
            [Register("vmSafeMode")] public const int VmSafeMode = 16843448;
            [Register("voiceLanguage")] public const int VoiceLanguage = 16843349;
            [Register("voiceLanguageModel")] public const int VoiceLanguageModel = 16843347;
            [Register("voiceMaxResults")] public const int VoiceMaxResults = 16843350;
            [Register("voicePromptText")] public const int VoicePromptText = 16843348;
            [Register("voiceSearchMode")] public const int VoiceSearchMode = 16843346;
            [Register("wallpaperCloseEnterAnimation")] public const int WallpaperCloseEnterAnimation = 16843413;
            [Register("wallpaperCloseExitAnimation")] public const int WallpaperCloseExitAnimation = 16843414;

            [Register("wallpaperIntraCloseEnterAnimation")] public const int WallpaperIntraCloseEnterAnimation =
                16843417;

            [Register("wallpaperIntraCloseExitAnimation")] public const int WallpaperIntraCloseExitAnimation = 16843418;
            [Register("wallpaperIntraOpenEnterAnimation")] public const int WallpaperIntraOpenEnterAnimation = 16843415;
            [Register("wallpaperIntraOpenExitAnimation")] public const int WallpaperIntraOpenExitAnimation = 16843416;
            [Register("wallpaperOpenEnterAnimation")] public const int WallpaperOpenEnterAnimation = 16843411;
            [Register("wallpaperOpenExitAnimation")] public const int WallpaperOpenExitAnimation = 16843412;
            [Register("webTextViewStyle")] public const int WebTextViewStyle = 16843449;
            [Register("webViewStyle")] public const int WebViewStyle = 16842885;
            [Register("weightSum")] public const int WeightSum = 16843048;
            [Register("widgetLayout")] public const int WidgetLayout = 16843243;
            [Register("width")] public const int Width = 16843097;
            [Register("windowAnimationStyle")] public const int WindowAnimationStyle = 16842926;
            [Register("windowBackground")] public const int WindowBackground = 16842836;
            [Register("windowContentOverlay")] public const int WindowContentOverlay = 16842841;
            [Register("windowDisablePreview")] public const int WindowDisablePreview = 16843298;
            [Register("windowEnterAnimation")] public const int WindowEnterAnimation = 16842932;
            [Register("windowExitAnimation")] public const int WindowExitAnimation = 16842933;
            [Register("windowFrame")] public const int WindowFrame = 16842837;
            [Register("windowFullscreen")] public const int WindowFullScreen = 16843277;
            [Register("windowHideAnimation")] public const int WindowHideAnimation = 16842935;
            [Register("windowIsFloating")] public const int WindowIsFloating = 16842839;
            [Register("windowIsTranslucent")] public const int WindowIsTranslucent = 16842840;
            [Register("windowNoDisplay")] public const int WindowNoDisplay = 16843294;
            [Register("windowNoTitle")] public const int WindowNoTitle = 16842838;
            [Register("windowShowAnimation")] public const int WindowShowAnimation = 16842934;
            [Register("windowShowWallpaper")] public const int WindowShowWallpaper = 16843410;
            [Register("windowSoftInputMode")] public const int WindowSoftInputMode = 16843307;
            [Register("windowTitleBackgroundStyle")] public const int WindowTitleBackgroundStyle = 16842844;
            [Register("windowTitleSize")] public const int WindowTitleSize = 16842842;
            [Register("windowTitleStyle")] public const int WindowTitleStyle = 16842843;
            [Register("writePermission")] public const int WritePermission = 16842760;
            [Register("x")] public const int X = 16842924;
            [Register("xlargeScreens")] public const int XlargeScreens = 16843455;
            [Register("y")] public const int Y = 16842925;
            [Register("yesNoPreferenceStyle")] public const int YesNoPreferenceStyle = 16842896;
            [Register("zAdjustment")] public const int ZAdjustment = 16843201;

            [Register(".ctor", "()V", "")]
            public Attribute();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Boolean

        [Register("android/R$bool", DoNotGenerateAcw = true)]
        public sealed class Boolean : Java.Lang.Object
        {
            [Register(".ctor", "()V", "")]
            public Boolean();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Color

        [Register("android/R$color", DoNotGenerateAcw = true)]
        public sealed class Color : Java.Lang.Object
        {
            [Register("background_dark")] public const int BackgroundDark = 17170446;
            [Register("background_light")] public const int BackgroundLight = 17170447;
            [Register("black")] public const int Black = 17170444;
            [Register("darker_gray")] public const int DarkerGray = 17170432;
            [Register("primary_text_dark")] public const int PrimaryTextDark = 17170433;
            [Register("primary_text_dark_nodisable")] public const int PrimaryTextDarkNoDisable = 17170434;
            [Register("primary_text_light")] public const int PrimaryTextLight = 17170435;
            [Register("primary_text_light_nodisable")] public const int PrimaryTextLightNoDisable = 17170436;
            [Register("secondary_text_dark")] public const int SecondaryTextDark = 17170437;
            [Register("secondary_text_dark_nodisable")] public const int SecondaryTextDarkNoDisable = 17170438;
            [Register("secondary_text_light")] public const int SecondaryTextLight = 17170439;
            [Register("secondary_text_light_nodisable")] public const int SecondaryTextLightNoDisable = 17170440;
            [Register("tab_indicator_text")] public const int TabIndicatorText = 17170441;
            [Register("tertiary_text_dark")] public const int TertiaryTextDark = 17170448;
            [Register("tertiary_text_light")] public const int TertiaryTextLight = 17170449;
            [Register("transparent")] public const int Transparent = 17170445;
            [Register("white")] public const int White = 17170443;
            [Register("widget_edittext_dark")] public const int WidgetEditTextDark = 17170442;

            [Register(".ctor", "()V", "")]
            public Color();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Dimension

        [Register("android/R$dimen", DoNotGenerateAcw = true)]
        public sealed class Dimension : Java.Lang.Object
        {
            [Register("app_icon_size")] public const int AppIconSize = 17104896;
            [Register("thumbnail_height")] public const int ThumbnailHeight = 17104897;
            [Register("thumbnail_width")] public const int ThumbnailWidth = 17104898;

            [Register(".ctor", "()V", "")]
            public Dimension();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Drawable

        [Register("android/R$drawable", DoNotGenerateAcw = true)]
        public sealed class Drawable : Java.Lang.Object
        {
            [Register("alert_dark_frame")] public const int AlertDarkFrame = 17301504;
            [Register("alert_light_frame")] public const int AlertLightFrame = 17301505;
            [Register("arrow_down_float")] public const int ArrowDownFloat = 17301506;
            [Register("arrow_up_float")] public const int ArrowUpFloat = 17301507;
            [Register("bottom_bar")] public const int BottomBar = 17301658;
            [Register("btn_default")] public const int ButtonDefault = 17301508;
            [Register("btn_default_small")] public const int ButtonDefaultSmall = 17301509;
            [Register("btn_dialog")] public const int ButtonDialog = 17301527;
            [Register("btn_dropdown")] public const int ButtonDropDown = 17301510;
            [Register("btn_minus")] public const int ButtonMinus = 17301511;
            [Register("btn_plus")] public const int ButtonPlus = 17301512;
            [Register("btn_radio")] public const int ButtonRadio = 17301513;
            [Register("btn_star")] public const int ButtonStar = 17301514;
            [Register("btn_star_big_off")] public const int ButtonStarBigOff = 17301515;
            [Register("btn_star_big_on")] public const int ButtonStarBigOn = 17301516;
            [Register("button_onoff_indicator_off")] public const int ButtonOnoffIndicatorOff = 17301518;
            [Register("button_onoff_indicator_on")] public const int ButtonOnoffIndicatorOn = 17301517;
            [Register("checkbox_off_background")] public const int CheckboxOffBackground = 17301519;
            [Register("checkbox_on_background")] public const int CheckboxOnBackground = 17301520;
            [Register("dark_header")] public const int DarkHeader = 17301669;
            [Register("dialog_frame")] public const int DialogFrame = 17301521;
            [Register("divider_horizontal_bright")] public const int DividerHorizontalBright = 17301522;
            [Register("divider_horizontal_dark")] public const int DividerHorizontalDark = 17301524;
            [Register("divider_horizontal_dim_dark")] public const int DividerHorizontalDimDark = 17301525;
            [Register("divider_horizontal_textfield")] public const int DividerHorizontalTextfield = 17301523;
            [Register("edit_text")] public const int EditText = 17301526;
            [Register("editbox_background")] public const int EditBoxBackground = 17301528;
            [Register("editbox_background_normal")] public const int EditBoxBackgroundNormal = 17301529;
            [Register("editbox_dropdown_dark_frame")] public const int EditBoxDropDownDarkFrame = 17301530;
            [Register("editbox_dropdown_light_frame")] public const int EditBoxDropDownLightFrame = 17301531;
            [Register("gallery_thumb")] public const int GalleryThumb = 17301532;
            [Register("ic_btn_speak_now")] public const int IcButtonSpeakNow = 17301668;
            [Register("ic_delete")] public const int IcDelete = 17301533;
            [Register("ic_dialog_alert")] public const int IcDialogAlert = 17301543;
            [Register("ic_dialog_dialer")] public const int IcDialogDialer = 17301544;
            [Register("ic_dialog_email")] public const int IcDialogEmail = 17301545;
            [Register("ic_dialog_info")] public const int IcDialogInfo = 17301659;
            [Register("ic_dialog_map")] public const int IcDialogMap = 17301546;
            [Register("ic_input_add")] public const int IcInputAdd = 17301547;
            [Register("ic_input_delete")] public const int IcInputDelete = 17301548;
            [Register("ic_input_get")] public const int IcInputGet = 17301549;
            [Register("ic_lock_idle_alarm")] public const int IcLockIdleAlarm = 17301550;
            [Register("ic_lock_idle_charging")] public const int IcLockIdleCharging = 17301534;
            [Register("ic_lock_idle_lock")] public const int IcLockIdleLock = 17301535;
            [Register("ic_lock_idle_low_battery")] public const int IcLockIdleLowBattery = 17301536;
            [Register("ic_lock_lock")] public const int IcLockLock = 17301551;
            [Register("ic_lock_power_off")] public const int IcLockPowerOff = 17301552;
            [Register("ic_lock_silent_mode")] public const int IcLockSilentMode = 17301553;
            [Register("ic_lock_silent_mode_off")] public const int IcLockSilentModeOff = 17301554;
            [Register("ic_media_ff")] public const int IcMediaFf = 17301537;
            [Register("ic_media_next")] public const int IcMediaNext = 17301538;
            [Register("ic_media_pause")] public const int IcMediaPause = 17301539;
            [Register("ic_media_play")] public const int IcMediaPlay = 17301540;
            [Register("ic_media_previous")] public const int IcMediaPrevious = 17301541;
            [Register("ic_media_rew")] public const int IcMediaRew = 17301542;
            [Register("ic_menu_add")] public const int IcMenuAdd = 17301555;
            [Register("ic_menu_agenda")] public const int IcMenuAgenda = 17301556;
            [Register("ic_menu_always_landscape_portrait")] public const int IcMenuAlwaysLandscapePortrait = 17301557;
            [Register("ic_menu_call")] public const int IcMenuCall = 17301558;
            [Register("ic_menu_camera")] public const int IcMenuCamera = 17301559;
            [Register("ic_menu_close_clear_cancel")] public const int IcMenuCloseClearCancel = 17301560;
            [Register("ic_menu_compass")] public const int IcMenuCompass = 17301561;
            [Register("ic_menu_crop")] public const int IcMenuCrop = 17301562;
            [Register("ic_menu_day")] public const int IcMenuDay = 17301563;
            [Register("ic_menu_delete")] public const int IcMenuDelete = 17301564;
            [Register("ic_menu_directions")] public const int IcMenuDirections = 17301565;
            [Register("ic_menu_edit")] public const int IcMenuEdit = 17301566;
            [Register("ic_menu_gallery")] public const int IcMenuGallery = 17301567;
            [Register("ic_menu_help")] public const int IcMenuHelp = 17301568;
            [Register("ic_menu_info_details")] public const int IcMenuInfoDetails = 17301569;
            [Register("ic_menu_manage")] public const int IcMenuManage = 17301570;
            [Register("ic_menu_mapmode")] public const int IcMenuMapmode = 17301571;
            [Register("ic_menu_month")] public const int IcMenuMonth = 17301572;
            [Register("ic_menu_more")] public const int IcMenuMore = 17301573;
            [Register("ic_menu_my_calendar")] public const int IcMenuMyCalendar = 17301574;
            [Register("ic_menu_mylocation")] public const int IcMenuMyLocation = 17301575;
            [Register("ic_menu_myplaces")] public const int IcMenuMyPlaces = 17301576;
            [Register("ic_menu_preferences")] public const int IcMenuPreferences = 17301577;
            [Register("ic_menu_recent_history")] public const int IcMenuRecentHistory = 17301578;
            [Register("ic_menu_report_image")] public const int IcMenuReportImage = 17301579;
            [Register("ic_menu_revert")] public const int IcMenuRevert = 17301580;
            [Register("ic_menu_rotate")] public const int IcMenuRotate = 17301581;
            [Register("ic_menu_save")] public const int IcMenuSave = 17301582;
            [Register("ic_menu_search")] public const int IcMenuSearch = 17301583;
            [Register("ic_menu_send")] public const int IcMenuSend = 17301584;
            [Register("ic_menu_set_as")] public const int IcMenuSetAs = 17301585;
            [Register("ic_menu_share")] public const int IcMenuShare = 17301586;
            [Register("ic_menu_slideshow")] public const int IcMenuSlideshow = 17301587;
            [Register("ic_menu_sort_alphabetically")] public const int IcMenuSortAlphabetically = 17301660;
            [Register("ic_menu_sort_by_size")] public const int IcMenuSortBySize = 17301661;
            [Register("ic_menu_today")] public const int IcMenuToday = 17301588;
            [Register("ic_menu_upload")] public const int IcMenuUpload = 17301589;
            [Register("ic_menu_upload_you_tube")] public const int IcMenuUploadYouTube = 17301590;
            [Register("ic_menu_view")] public const int IcMenuView = 17301591;
            [Register("ic_menu_week")] public const int IcMenuWeek = 17301592;
            [Register("ic_menu_zoom")] public const int IcMenuZoom = 17301593;
            [Register("ic_notification_clear_all")] public const int IcNotificationClearAll = 17301594;
            [Register("ic_notification_overlay")] public const int IcNotificationOverlay = 17301595;
            [Register("ic_partial_secure")] public const int IcPartialSecure = 17301596;
            [Register("ic_popup_disk_full")] public const int IcPopupDiskFull = 17301597;
            [Register("ic_popup_reminder")] public const int IcPopupReminder = 17301598;
            [Register("ic_popup_sync")] public const int IcPopupSync = 17301599;
            [Register("ic_search_category_default")] public const int IcSearchCategoryDefault = 17301600;
            [Register("ic_secure")] public const int IcSecure = 17301601;
            [Register("list_selector_background")] public const int ListSelectorBackground = 17301602;
            [Register("menu_frame")] public const int MenuFrame = 17301603;
            [Register("menu_full_frame")] public const int MenuFullFrame = 17301604;
            [Register("menuitem_background")] public const int MenuitemBackground = 17301605;
            [Register("picture_frame")] public const int PictureFrame = 17301606;
            [Register("presence_audio_away")] public const int PresenceAudioAway = 17301679;
            [Register("presence_audio_busy")] public const int PresenceAudioBusy = 17301680;
            [Register("presence_audio_online")] public const int PresenceAudioOnline = 17301681;
            [Register("presence_away")] public const int PresenceAway = 17301607;
            [Register("presence_busy")] public const int PresenceBusy = 17301608;
            [Register("presence_invisible")] public const int PresenceInvisible = 17301609;
            [Register("presence_offline")] public const int PresenceOffline = 17301610;
            [Register("presence_online")] public const int PresenceOnline = 17301611;
            [Register("presence_video_away")] public const int PresenceVideoAway = 17301676;
            [Register("presence_video_busy")] public const int PresenceVideoBusy = 17301677;
            [Register("presence_video_online")] public const int PresenceVideoOnline = 17301678;
            [Register("progress_horizontal")] public const int ProgressHorizontal = 17301612;
            [Register("progress_indeterminate_horizontal")] public const int ProgressIndeterminateHorizontal = 17301613;
            [Register("radiobutton_off_background")] public const int RadiobuttonOffBackground = 17301614;
            [Register("radiobutton_on_background")] public const int RadiobuttonOnBackground = 17301615;
            [Register("screen_background_dark")] public const int ScreenBackgroundDark = 17301656;
            [Register("screen_background_dark_transparent")] public const int ScreenBackgroundDarkTransparent = 17301673;
            [Register("screen_background_light")] public const int ScreenBackgroundLight = 17301657;

            [Register("screen_background_light_transparent")] public const int ScreenBackgroundLightTransparent =
                17301674;

            [Register("spinner_background")] public const int SpinnerBackground = 17301616;
            [Register("spinner_dropdown_background")] public const int SpinnerDropDownBackground = 17301617;
            [Register("star_big_off")] public const int StarBigOff = 17301619;
            [Register("star_big_on")] public const int StarBigOn = 17301618;
            [Register("star_off")] public const int StarOff = 17301621;
            [Register("star_on")] public const int StarOn = 17301620;
            [Register("stat_notify_call_mute")] public const int StatNotifyCallMute = 17301622;
            [Register("stat_notify_chat")] public const int StatNotifyChat = 17301623;
            [Register("stat_notify_error")] public const int StatNotifyError = 17301624;
            [Register("stat_notify_missed_call")] public const int StatNotifyMissedCall = 17301631;
            [Register("stat_notify_more")] public const int StatNotifyMore = 17301625;
            [Register("stat_notify_sdcard")] public const int StatNotifySdCard = 17301626;
            [Register("stat_notify_sdcard_prepare")] public const int StatNotifySdcardPrepare = 17301675;
            [Register("stat_notify_sdcard_usb")] public const int StatNotifySdCardUsb = 17301627;
            [Register("stat_notify_sync")] public const int StatNotifySync = 17301628;
            [Register("stat_notify_sync_noanim")] public const int StatNotifySyncNoAnim = 17301629;
            [Register("stat_notify_voicemail")] public const int StatNotifyVoicemail = 17301630;
            [Register("stat_sys_data_bluetooth")] public const int StatSysDataBluetooth = 17301632;
            [Register("stat_sys_download")] public const int StatSysDownload = 17301633;
            [Register("stat_sys_download_done")] public const int StatSysDownloadDone = 17301634;
            [Register("stat_sys_headset")] public const int StatSysHeadset = 17301635;
            [Register("stat_sys_phone_call")] public const int StatSysPhoneCall = 17301636;
            [Register("stat_sys_phone_call_forward")] public const int StatSysPhoneCallForward = 17301637;
            [Register("stat_sys_phone_call_on_hold")] public const int StatSysPhoneCallOnHold = 17301638;
            [Register("stat_sys_speakerphone")] public const int StatSysSpeakerphone = 17301639;
            [Register("stat_sys_upload")] public const int StatSysUpload = 17301640;
            [Register("stat_sys_upload_done")] public const int StatSysUploadDone = 17301641;
            [Register("stat_sys_vp_phone_call")] public const int StatSysVpPhoneCall = 17301671;
            [Register("stat_sys_vp_phone_call_on_hold")] public const int StatSysVpPhoneCallOnHold = 17301672;
            [Register("stat_sys_warning")] public const int StatSysWarning = 17301642;
            [Register("status_bar_item_app_background")] public const int StatusBarItemAppBackground = 17301643;
            [Register("status_bar_item_background")] public const int StatusBarItemBackground = 17301644;
            [Register("sym_action_call")] public const int SymActionCall = 17301645;
            [Register("sym_action_chat")] public const int SymActionChat = 17301646;
            [Register("sym_action_email")] public const int SymActionEmail = 17301647;
            [Register("sym_call_incoming")] public const int SymCallIncoming = 17301648;
            [Register("sym_call_missed")] public const int SymCallMissed = 17301649;
            [Register("sym_call_outgoing")] public const int SymCallOutgoing = 17301650;
            [Register("sym_contact_card")] public const int SymContactCard = 17301652;
            [Register("sym_def_app_icon")] public const int SymDefAppIcon = 17301651;
            [Register("title_bar")] public const int TitleBar = 17301653;
            [Register("title_bar_tall")] public const int TitleBarTall = 17301670;
            [Register("toast_frame")] public const int ToastFrame = 17301654;
            [Register("zoom_plate")] public const int ZoomPlate = 17301655;

            [Register(".ctor", "()V", "")]
            public Drawable();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Id

        [Register("android/R$id", DoNotGenerateAcw = true)]
        public sealed class Id : Java.Lang.Object
        {
            [Register("addToDictionary")] public const int AddToDictionary = 16908330;
            [Register("background")] public const int Background = 16908288;
            [Register("button1")] public const int Button1 = 16908313;
            [Register("button2")] public const int Button2 = 16908314;
            [Register("button3")] public const int Button3 = 16908315;
            [Register("candidatesArea")] public const int CandidatesArea = 16908317;
            [Register("checkbox")] public const int Checkbox = 16908289;
            [Register("closeButton")] public const int CloseButton = 16908327;
            [Register("content")] public const int Content = 16908290;
            [Register("copy")] public const int Copy = 16908321;
            [Register("copyUrl")] public const int CopyUrl = 16908323;
            [Register("custom")] public const int Custom = 16908331;
            [Register("cut")] public const int Cut = 16908320;
            [Register("edit")] public const int Edit = 16908291;
            [Register("empty")] public const int Empty = 16908292;
            [Register("extractArea")] public const int ExtractArea = 16908316;
            [Register("hint")] public const int Hint = 16908293;
            [Register("icon")] public const int Icon = 16908294;
            [Register("icon1")] public const int Icon1 = 16908295;
            [Register("icon2")] public const int Icon2 = 16908296;
            [Register("input")] public const int Input = 16908297;
            [Register("inputArea")] public const int InputArea = 16908318;
            [Register("inputExtractEditText")] public const int InputExtractEditText = 16908325;
            [Register("keyboardView")] public const int KeyboardView = 16908326;
            [Register("list")] public const int List = 16908298;
            [Register("message")] public const int Message = 16908299;
            [Register("paste")] public const int Paste = 16908322;
            [Register("primary")] public const int Primary = 16908300;
            [Register("progress")] public const int Progress = 16908301;
            [Register("secondaryProgress")] public const int SecondaryProgress = 16908303;
            [Register("selectAll")] public const int SelectAll = 16908319;
            [Register("selectedIcon")] public const int SelectedIcon = 16908302;
            [Register("startSelectingText")] public const int StartSelectingText = 16908328;
            [Register("stopSelectingText")] public const int StopSelectingText = 16908329;
            [Register("summary")] public const int Summary = 16908304;
            [Register("switchInputMethod")] public const int SwitchInputMethod = 16908324;
            [Register("tabcontent")] public const int TabContent = 16908305;
            [Register("tabhost")] public const int TabHost = 16908306;
            [Register("tabs")] public const int Tabs = 16908307;
            [Register("text1")] public const int Text1 = 16908308;
            [Register("text2")] public const int Text2 = 16908309;
            [Register("title")] public const int Title = 16908310;
            [Register("toggle")] public const int Toggle = 16908311;
            [Register("widget_frame")] public const int WidgetFrame = 16908312;

            [Register(".ctor", "()V", "")]
            public Id();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Integer

        [Register("android/R$integer", DoNotGenerateAcw = true)]
        public sealed class Integer : Java.Lang.Object
        {
            [Register("config_longAnimTime")] public const int ConfigLongAnimTime = 17694722;
            [Register("config_mediumAnimTime")] public const int ConfigMediumAnimTime = 17694721;
            [Register("config_shortAnimTime")] public const int ConfigShortAnimTime = 17694720;

            [Register(".ctor", "()V", "")]
            public Integer();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Layout

        [Register("android/R$layout", DoNotGenerateAcw = true)]
        public sealed class Layout : Java.Lang.Object
        {
            [Register("activity_list_item")] public const int ActivityListItem = 17367040;
            [Register("browser_link_context_header")] public const int BrowserLinkContextHeader = 17367054;
            [Register("expandable_list_content")] public const int ExpandableListContent = 17367041;
            [Register("preference_category")] public const int PreferenceCategory = 17367042;
            [Register("select_dialog_item")] public const int SelectDialogItem = 17367057;
            [Register("select_dialog_multichoice")] public const int SelectDialogMultiChoice = 17367059;
            [Register("select_dialog_singlechoice")] public const int SelectDialogSingleChoice = 17367058;
            [Register("simple_dropdown_item_1line")] public const int SimpleDropDownItem1Line = 17367050;
            [Register("simple_expandable_list_item_1")] public const int SimpleExpandableListItem1 = 17367046;
            [Register("simple_expandable_list_item_2")] public const int SimpleExpandableListItem2 = 17367047;
            [Register("simple_gallery_item")] public const int SimpleGalleryItem = 17367051;
            [Register("simple_list_item_1")] public const int SimpleListItem1 = 17367043;
            [Register("simple_list_item_2")] public const int SimpleListItem2 = 17367044;
            [Register("simple_list_item_checked")] public const int SimpleListItemChecked = 17367045;
            [Register("simple_list_item_multiple_choice")] public const int SimpleListItemMultipleChoice = 17367056;
            [Register("simple_list_item_single_choice")] public const int SimpleListItemSingleChoice = 17367055;
            [Register("simple_spinner_dropdown_item")] public const int SimpleSpinnerDropDownItem = 17367049;
            [Register("simple_spinner_item")] public const int SimpleSpinnerItem = 17367048;
            [Register("test_list_item")] public const int TestListItem = 17367052;
            [Register("two_line_list_item")] public const int TwoLineListItem = 17367053;

            [Register(".ctor", "()V", "")]
            public Layout();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Plurals

        [Register("android/R$plurals", DoNotGenerateAcw = true)]
        public sealed class Plurals : Java.Lang.Object
        {
            [Register(".ctor", "()V", "")]
            public Plurals();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Raw

        [Register("android/R$raw", DoNotGenerateAcw = true)]
        public sealed class Raw : Java.Lang.Object
        {
            [Register(".ctor", "()V", "")]
            public Raw();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: String

        [Register("android/R$string", DoNotGenerateAcw = true)]
        public sealed class String : Java.Lang.Object
        {
            [Register("cancel")] public const int Cancel = 17039360;
            [Register("copy")] public const int Copy = 17039361;
            [Register("copyUrl")] public const int CopyUrl = 17039362;
            [Register("cut")] public const int Cut = 17039363;
            [Register("defaultMsisdnAlphaTag")] public const int DefaultMsisdnAlphaTag = 17039365;
            [Register("defaultVoiceMailAlphaTag")] public const int DefaultVoiceMailAlphaTag = 17039364;
            [Register("dialog_alert_title")] public const int DialogAlertTitle = 17039380;
            [Register("emptyPhoneNumber")] public const int EmptyPhoneNumber = 17039366;
            [Register("httpErrorBadUrl")] public const int HttpErrorBadUrl = 17039367;
            [Register("httpErrorUnsupportedScheme")] public const int HttpErrorUnsupportedScheme = 17039368;
            [Register("no")] public const int No = 17039369;
            [Register("ok")] public const int Ok = 17039370;
            [Register("paste")] public const int Paste = 17039371;
            [Register("search_go")] public const int SearchGo = 17039372;
            [Register("selectAll")] public const int SelectAll = 17039373;
            [Register("unknownName")] public const int UnknownName = 17039374;
            [Register("untitled")] public const int Untitled = 17039375;
            [Register("VideoView_error_button")] public const int VideoViewErrorButton = 17039376;

            [Register("VideoView_error_text_invalid_progressive_playback")] public const int
                VideoViewErrorTextInvalidProgressivePlayback = 17039381;

            [Register("VideoView_error_text_unknown")] public const int VideoViewErrorTextUnknown = 17039377;
            [Register("VideoView_error_title")] public const int VideoViewErrorTitle = 17039378;
            [Register("yes")] public const int Yes = 17039379;

            [Register(".ctor", "()V", "")]
            public String();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Style

        [Register("android/R$style", DoNotGenerateAcw = true)]
        public sealed class Style : Java.Lang.Object
        {
            [Register("Animation")] public const int Animation = 16973824;
            [Register("Animation_Activity")] public const int AnimationActivity = 16973825;
            [Register("Animation_Dialog")] public const int AnimationDialog = 16973826;
            [Register("Animation_InputMethod")] public const int AnimationInputMethod = 16973910;
            [Register("Animation_Toast")] public const int AnimationToast = 16973828;
            [Register("Animation_Translucent")] public const int AnimationTranslucent = 16973827;
            [Register("MediaButton")] public const int MediaButton = 16973879;
            [Register("MediaButton_Ffwd")] public const int MediaButtonFfwd = 16973883;
            [Register("MediaButton_Next")] public const int MediaButtonNext = 16973881;
            [Register("MediaButton_Pause")] public const int MediaButtonPause = 16973885;
            [Register("MediaButton_Play")] public const int MediaButtonPlay = 16973882;
            [Register("MediaButton_Previous")] public const int MediaButtonPrevious = 16973880;
            [Register("MediaButton_Rew")] public const int MediaButtonRew = 16973884;
            [Register("TextAppearance")] public const int TextAppearance = 16973886;
            [Register("TextAppearance_DialogWindowTitle")] public const int TextAppearanceDialogWindowTitle = 16973889;
            [Register("TextAppearance_Inverse")] public const int TextAppearanceInverse = 16973887;
            [Register("TextAppearance_Large")] public const int TextAppearanceLarge = 16973890;
            [Register("TextAppearance_Large_Inverse")] public const int TextAppearanceLargeInverse = 16973891;
            [Register("TextAppearance_Medium")] public const int TextAppearanceMedium = 16973892;
            [Register("TextAppearance_Medium_Inverse")] public const int TextAppearanceMediumInverse = 16973893;
            [Register("TextAppearance_Small")] public const int TextAppearanceSmall = 16973894;
            [Register("TextAppearance_Small_Inverse")] public const int TextAppearanceSmallInverse = 16973895;

            [Register("TextAppearance_StatusBar_EventContent")] public const int TextAppearanceStatusBarEventContent =
                16973927;

            [Register("TextAppearance_StatusBar_EventContent_Title")] public const int
                TextAppearanceStatusBarEventContentTitle = 16973928;

            [Register("TextAppearance_StatusBar_Icon")] public const int TextAppearanceStatusBarIcon = 16973926;
            [Register("TextAppearance_StatusBar_Title")] public const int TextAppearanceStatusBarTitle = 16973925;
            [Register("TextAppearance_Theme")] public const int TextAppearanceTheme = 16973888;
            [Register("TextAppearance_Theme_Dialog")] public const int TextAppearanceThemeDialog = 16973896;
            [Register("TextAppearance_Widget")] public const int TextAppearanceWidget = 16973897;
            [Register("TextAppearance_Widget_Button")] public const int TextAppearanceWidgetButton = 16973898;

            [Register("TextAppearance_Widget_DropDownHint")] public const int TextAppearanceWidgetDropDownHint =
                16973904;

            [Register("TextAppearance_Widget_DropDownItem")] public const int TextAppearanceWidgetDropDownItem =
                16973905;

            [Register("TextAppearance_Widget_EditText")] public const int TextAppearanceWidgetEditText = 16973900;

            [Register("TextAppearance_Widget_IconMenu_Item")] public const int TextAppearanceWidgetIconMenuItem =
                16973899;

            [Register("TextAppearance_Widget_TabWidget")] public const int TextAppearanceWidgetTabWidget = 16973901;
            [Register("TextAppearance_Widget_TextView")] public const int TextAppearanceWidgetTextView = 16973902;

            [Register("TextAppearance_Widget_TextView_PopupMenu")] public const int
                TextAppearanceWidgetTextViewPopupMenu = 16973903;

            [Register("TextAppearance_Widget_TextView_SpinnerItem")] public const int
                TextAppearanceWidgetTextViewSpinnerItem = 16973906;

            [Register("TextAppearance_WindowTitle")] public const int TextAppearanceWindowTitle = 16973907;
            [Register("Theme")] public const int Theme = 16973829;
            [Register("Theme_Black")] public const int ThemeBlack = 16973832;
            [Register("Theme_Black_NoTitleBar")] public const int ThemeBlackNoTitleBar = 16973833;
            [Register("Theme_Black_NoTitleBar_Fullscreen")] public const int ThemeBlackNoTitleBarFullScreen = 16973834;
            [Register("Theme_Dialog")] public const int ThemeDialog = 16973835;
            [Register("Theme_InputMethod")] public const int ThemeInputMethod = 16973908;
            [Register("Theme_Light")] public const int ThemeLight = 16973836;
            [Register("Theme_Light_NoTitleBar")] public const int ThemeLightNoTitleBar = 16973837;
            [Register("Theme_Light_NoTitleBar_Fullscreen")] public const int ThemeLightNoTitleBarFullScreen = 16973838;
            [Register("Theme_Light_Panel")] public const int ThemeLightPanel = 16973914;
            [Register("Theme_Light_WallpaperSettings")] public const int ThemeLightWallpaperSettings = 16973922;
            [Register("Theme_NoDisplay")] public const int ThemeNoDisplay = 16973909;
            [Register("Theme_NoTitleBar")] public const int ThemeNoTitleBar = 16973830;
            [Register("Theme_NoTitleBar_Fullscreen")] public const int ThemeNoTitleBarFullScreen = 16973831;
            [Register("Theme_Panel")] public const int ThemePanel = 16973913;
            [Register("Theme_Translucent")] public const int ThemeTranslucent = 16973839;
            [Register("Theme_Translucent_NoTitleBar")] public const int ThemeTranslucentNoTitleBar = 16973840;

            [Register("Theme_Translucent_NoTitleBar_Fullscreen")] public const int ThemeTranslucentNoTitleBarFullScreen
                = 16973841;

            [Register("Theme_Wallpaper")] public const int ThemeWallpaper = 16973918;
            [Register("Theme_Wallpaper_NoTitleBar")] public const int ThemeWallpaperNoTitleBar = 16973919;

            [Register("Theme_Wallpaper_NoTitleBar_Fullscreen")] public const int ThemeWallpaperNoTitleBarFullscreen =
                16973920;

            [Register("Theme_WallpaperSettings")] public const int ThemeWallpaperSettings = 16973921;
            [Register("Widget")] public const int Widget = 16973842;
            [Register("Widget_AbsListView")] public const int WidgetAbsListView = 16973843;
            [Register("Widget_AutoCompleteTextView")] public const int WidgetAutoCompleteTextView = 16973863;
            [Register("Widget_Button")] public const int WidgetButton = 16973844;
            [Register("Widget_Button_Inset")] public const int WidgetButtonInset = 16973845;
            [Register("Widget_Button_Small")] public const int WidgetButtonSmall = 16973846;
            [Register("Widget_Button_Toggle")] public const int WidgetButtonToggle = 16973847;
            [Register("Widget_CompoundButton")] public const int WidgetCompoundButton = 16973848;
            [Register("Widget_CompoundButton_CheckBox")] public const int WidgetCompoundButtonCheckBox = 16973849;
            [Register("Widget_CompoundButton_RadioButton")] public const int WidgetCompoundButtonRadioButton = 16973850;
            [Register("Widget_CompoundButton_Star")] public const int WidgetCompoundButtonStar = 16973851;
            [Register("Widget_DropDownItem")] public const int WidgetDropDownItem = 16973867;
            [Register("Widget_DropDownItem_Spinner")] public const int WidgetDropDownItemSpinner = 16973868;
            [Register("Widget_EditText")] public const int WidgetEditText = 16973859;
            [Register("Widget_ExpandableListView")] public const int WidgetExpandableListView = 16973860;
            [Register("Widget_Gallery")] public const int WidgetGallery = 16973877;
            [Register("Widget_GridView")] public const int WidgetGridView = 16973874;
            [Register("Widget_ImageButton")] public const int WidgetImageButton = 16973862;
            [Register("Widget_ImageWell")] public const int WidgetImageWell = 16973861;
            [Register("Widget_KeyboardView")] public const int WidgetKeyboardView = 16973911;
            [Register("Widget_ListView")] public const int WidgetListView = 16973870;
            [Register("Widget_ListView_DropDown")] public const int WidgetListViewDropDown = 16973872;
            [Register("Widget_ListView_Menu")] public const int WidgetListViewMenu = 16973873;
            [Register("Widget_ListView_White")] public const int WidgetListViewWhite = 16973871;
            [Register("Widget_PopupWindow")] public const int WidgetPopupWindow = 16973878;
            [Register("Widget_ProgressBar")] public const int WidgetProgressBar = 16973852;
            [Register("Widget_ProgressBar_Horizontal")] public const int WidgetProgressBarHorizontal = 16973855;
            [Register("Widget_ProgressBar_Inverse")] public const int WidgetProgressBarInverse = 16973915;
            [Register("Widget_ProgressBar_Large")] public const int WidgetProgressBarLarge = 16973853;
            [Register("Widget_ProgressBar_Large_Inverse")] public const int WidgetProgressBarLargeInverse = 16973916;
            [Register("Widget_ProgressBar_Small")] public const int WidgetProgressBarSmall = 16973854;
            [Register("Widget_ProgressBar_Small_Inverse")] public const int WidgetProgressBarSmallInverse = 16973917;
            [Register("Widget_RatingBar")] public const int WidgetRatingBar = 16973857;
            [Register("Widget_ScrollView")] public const int WidgetScrollView = 16973869;
            [Register("Widget_SeekBar")] public const int WidgetSeekBar = 16973856;
            [Register("Widget_Spinner")] public const int WidgetSpinner = 16973864;
            [Register("Widget_TabWidget")] public const int WidgetTabWidget = 16973876;
            [Register("Widget_TextView")] public const int WidgetTextView = 16973858;
            [Register("Widget_TextView_PopupMenu")] public const int WidgetTextViewPopupMenu = 16973865;
            [Register("Widget_TextView_SpinnerItem")] public const int WidgetTextViewSpinnerItem = 16973866;
            [Register("Widget_WebView")] public const int WidgetWebView = 16973875;

            [Register(".ctor", "()V", "")]
            public Style();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion

        #region Nested type: Xml

        [Register("android/R$xml", DoNotGenerateAcw = true)]
        public sealed class Xml : Java.Lang.Object
        {
            [Register(".ctor", "()V", "")]
            public Xml();

            protected override IntPtr ThresholdClass { get; }
            protected override Type ThresholdType { get; }
        }

        #endregion
    }
}
