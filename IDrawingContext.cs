using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteUI
{
    public interface IDrawingContext
    {
        Rectangle ContextRect { get; }
        void DrawEllipse(Color brush, Pen pen, Vector2 center, double radiusX, double radiusY);
        //void DrawEllipse(Brush brush, Pen pen, Vector2 center, AnimationClock centerAnimations, double radiusX, AnimationClock radiusXAnimations, double radiusY, AnimationClock radiusYAnimations);
        void DrawGeometry(Color brush, string path, float x, float y);
        //void DrawGlyphRun(Brush foregroundBrush, GlyphRun glyphRun);
        void DrawImage(System.IO.Stream imageSource, Rectangle rectangle);
        void DrawImage(string imageSource, Rectangle rectangle);
        //void DrawImage(IImage imageSource, Rect rectangle, AnimationClock rectangleAnimations);
        //void DrawLine(Pen pen, Vector2 point0, AnimationClock point0Animations, Vector2 point1, AnimationClock point1Animations);
        void DrawLine(Pen pen, Vector2 point0, Vector2 point1);
        void DrawRectangle(Color brush, Pen pen, Rectangle rectangle);
        void DrawOutLineRectangle(Color brush, Pen pen, Rectangle rectangle);
        //void DrawRectangle(Brush brush, Pen pen, Rect rectangle, AnimationClock rectangleAnimations);
        //void DrawRoundedRectangle(Brush brush, Pen pen, Rect rectangle, AnimationClock rectangleAnimations, double radiusX, AnimationClock radiusXAnimations, double radiusY, AnimationClock radiusYAnimations);
        void DrawRoundedRectangle(Color color, Pen pen, Rectangle rectangle, Thickness cornerRadius);
        void DrawText(string text, float fontSize, Color color, Vector2 origin, string fontName = "微软雅黑");
        //void DrawText(FormattedText formattedText, Vector2 origin);
        //void DrawVideo(MediaPlayer player, Rect rectangle);
        //void DrawVideo(MediaPlayer player, Rect rectangle, AnimationClock rectangleAnimations);
        //void PushClip(Geometry clipGeometry);
        //[Obsolete("BitmapEffects are deprecated and no longer function.  Consider using Effects where appropriate instead.")]
        //void PushEffect(BitmapEffect effect, BitmapEffectInput effectInput);
        //void PushGuidelineSet(GuidelineSet guidelines);
        //void PushOpacity(double opacity);
        //void PushOpacity(double opacity, AnimationClock opacityAnimations);
        //void PushOpacityMask(Brush opacityMask);
        //void PushTransform(Transform transform);
    }
}
