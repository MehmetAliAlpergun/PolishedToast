using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace PolishedToast_Xamarin
{
    public class PolishedToast
    {
        public static Toast Warning(Context context, string message)
        {
            return Warning(context, message, ToastLength.Short, true);
        }

        public static Toast Warning(Context context, string message, ToastLength duration)
        {
            return Warning(context, message, duration, true);
        }

        public static Toast Warning(Context context, string message, ToastLength duration, bool withIcon)
        {
            return Create(context, message, Resource.Drawable.ic_error_outline_white_48dp, Colors.Warning, duration, withIcon, true);
        }


        public static Toast Info(Context context, string message)
        {
            return Info(context, message, ToastLength.Short, true);
        }


        public static Toast Info(Context context, string message, ToastLength duration)
        {
            return Info(context, message, duration, true);
        }


        public static Toast Info(Context context, string message, ToastLength duration, bool withIcon)
        {
            return Create(context, message, Resource.Drawable.ic_info_outline_white_48dp, Colors.Info, duration, withIcon, true);
        }


        public static Toast Success(Context context, string message)
        {
            return Success(context, message, ToastLength.Short, true);
        }


        public static Toast Success(Context context, string message, ToastLength duration)
        {
            return Success(context, message, duration, true);
        }


        public static Toast Success(Context context, string message, ToastLength duration, bool withIcon)
        {
            return Create(context, message, Resource.Drawable.ic_check_white_48dp, Colors.Success, duration, withIcon, true);
        }


        public static Toast Error(Context context, string message)
        {
            return Error(context, message, ToastLength.Short, true);
        }


        public static Toast Error(Context context, string message, ToastLength duration)
        {
            return Error(context, message, duration, true);
        }


        public static Toast Error(Context context, string message, ToastLength duration, bool withIcon)
        {
            return Create(context, message, Resource.Drawable.ic_clear_white_48dp, Colors.Error, duration, withIcon, true);
        }

        public static Toast Create(Context context, string message)
        {
            return Create(context, message, 0, Colors.Grey, ToastLength.Short, false, true);
        }


        public static Toast Create(Context context, string message, ToastLength duration)
        {
            return Create(context, message, 0, Colors.Grey, duration, false, true);
        }

        private static Toast Create(Context context, string message, int iconId, ToastLength duration, bool withIcon)
        {
            return Create(context, message, iconId,"", duration, withIcon, false);
        }

        private static Toast Create(Context context, string message, int iconId, string tintColor, ToastLength duration, bool withIcon, bool shouldTint)
        {
            return Create(context, message, Utils.GetDrawable(context, iconId), tintColor, duration, withIcon, shouldTint);
        }

        private static Toast Create(Context context, string message, Drawable icon, string tintColor, ToastLength duration, bool withIcon, bool shouldTint)
        {
            Toast currentToast = new Toast(context);
            View toastLayout = LayoutInflater.FromContext(context).Inflate(Resource.Layout.ToastLayout, null);
            ImageView toastIcon = toastLayout.FindViewById<ImageView>(Resource.Id.ImageViewToast);
            TextView toastTextView = toastLayout.FindViewById<TextView>(Resource.Id.TextViewToast);
            Drawable drawableFrame;

            if (shouldTint)
                drawableFrame = Utils.Tint9PatchDrawableFrame(context, tintColor);
            else
                drawableFrame = Utils.GetDrawable(context, Resource.Drawable.toast_frame);

            Utils.SetBackground(toastLayout, drawableFrame);

            if (withIcon)
            {
                if (icon == null)
                {
                    throw new ArgumentNullException("Icon is null");
                }

                icon = Utils.TintIcon(icon, Colors.DefaulText);

                Utils.SetBackground(toastIcon, icon);
            }
            else
            {
                toastIcon.Visibility = ViewStates.Gone;
            }

            toastTextView.SetTextColor(Color.ParseColor(Colors.DefaulText));
            toastTextView.Text = message;
            toastTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 16);

            currentToast.View = toastLayout;
            currentToast.Duration = duration;
            return currentToast;
        }

        private class Utils
        {
            public static Drawable TintIcon(Drawable drawable, string tintColor)
            {
                Color color = Color.ParseColor(tintColor);

                drawable.SetColorFilter(color, PorterDuff.Mode.SrcIn);
                return drawable;
            }

            public static Drawable Tint9PatchDrawableFrame(Context context, string tintColor)
            {
                NinePatchDrawable toastDrawable = (NinePatchDrawable)GetDrawable(context, Resource.Drawable.toast_frame);
                return TintIcon(toastDrawable, tintColor);
            }

            public static void SetBackground(View view, Drawable drawable)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean)
                    view.Background = drawable;
                else
                    view.SetBackgroundDrawable(drawable);
            }

            public static Drawable GetDrawable(Context context, int id)
            {
                if(id == 0)
                {
                    return null;
                }

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    return context.GetDrawable(id);
                else
                    return context.Resources.GetDrawable(id);
            }
        }

        private class Colors
        {
            public static readonly string Error = "#F44336";
            public static readonly string Success = "#4CAF50";
            public static readonly string Info = "#2196F3";
            public static readonly string Grey = "#9E9E9E";
            public static readonly string Warning = "#FFC107";
            public static readonly string DefaulText = "#FFFFFF";
        }
    }
}