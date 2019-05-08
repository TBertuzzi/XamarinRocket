using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace XamarinRocket.Views
{
    public partial class XamarinRocket8Page : ContentPage
    {
        SKPaintSurfaceEventArgs args;
        ProgressHelpers progressHelpers = new ProgressHelpers();
        readonly int exercicioDiario = 20;
        readonly int exercicioMensal = 340;
        readonly int meta = 900;

        public XamarinRocket8Page()
        {
            InitializeComponent();

            InitiateProgressUpdate();
        }

        void OnCanvasViewPaintSurfaceAsync(object sender, SKPaintSurfaceEventArgs args1)

        {
            args = args1;
            DrawGaugeAsync();

        }

        async void SwitchToggledAsync(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            await InitiateProgressUpdate();
        }


        void SliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (canvas != null)
            {
                canvas.InvalidateSurface();
            }
        }

        async Task AnimateProgress(int progress)
        {
            sw_listToggle.IsEnabled = false;
            sweepAngleSlider.Value = 1;

            for (int i = 0; i < progress; i = i + 5)
            {
                sweepAngleSlider.Value = i;
                await Task.Delay(3);
            }

            sweepAngleSlider.Value = progress;
            sw_listToggle.IsEnabled = true;

        }

        async Task InitiateProgressUpdate()
        {
            if (sw_listToggle.IsToggled)
            {
                await AnimateProgress(progressHelpers.GetSweepAngle(meta, exercicioMensal));
            }
            else
            {
                await AnimateProgress(progressHelpers.GetSweepAngle(meta / 30, exercicioDiario));
            }
        }

        public void DrawGaugeAsync()
        {
            int uPadding = 150;
            int side = 500;
            int radialGaugeWidth = 25;

            int lineSize1 = 220;
            int lineSize2 = 70;
            int lineSize3 = 80;

            int lineHeight1 = 100;
            int lineHeight2 = 200;
            int lineHeight3 = 300;

            float startAngle = -220;
            float sweepAngle = 260;

            try
            {
            
                SKImageInfo info = args.Info;
                SKSurface surface = args.Surface;
                SKCanvas canvas = surface.Canvas;
                progressHelpers.SetDevice(info.Height, info.Width);
                canvas.Clear();

                float upperPading = progressHelpers.GetFactoredHeight(uPadding);

                int Xc = info.Width / 2;
                float Yc = progressHelpers.GetFactoredHeight(side);


                int X1 = (int)(Xc - Yc);
                int Y1 = (int)(Yc - Yc + upperPading);


                int X2 = (int)(Xc + Yc);
                int Y2 = (int)(Yc + Yc + upperPading);

                SKPaint paint1 = new SKPaint
                {
                    Style = SKPaintStyle.Stroke,
                    Color = Color.FromHex("#e0dfdf").ToSKColor(),                   
                    StrokeWidth = progressHelpers.GetFactoredWidth(radialGaugeWidth),
                    StrokeCap = SKStrokeCap.Round                                  
                };


                SKPaint paint2 = new SKPaint
                {
                    Style = SKPaintStyle.Stroke,
                    Color = Color.FromHex("#05c782").ToSKColor(),                   
                    StrokeWidth = progressHelpers.GetFactoredWidth(radialGaugeWidth), 
                    StrokeCap = SKStrokeCap.Round                                   
                };


                SKRect rect = new SKRect(X1, Y1, X2, Y2);

                SKPath path1 = new SKPath();
                path1.AddArc(rect, startAngle, sweepAngle);
                canvas.DrawPath(path1, paint1);

                SKPath path2 = new SKPath();
                path2.AddArc(rect, startAngle, (float)sweepAngleSlider.Value);
                canvas.DrawPath(path2, paint2);

                using (SKPaint skPaint = new SKPaint())
                {
                    skPaint.Style = SKPaintStyle.Fill;
                    skPaint.IsAntialias = true;
                    skPaint.Color = SKColor.Parse("#676a69");
                    skPaint.TextAlign = SKTextAlign.Center;
                    skPaint.TextSize = progressHelpers.GetFactoredHeight(lineSize1);
                    skPaint.Typeface = SKTypeface.FromFamilyName(
                                        "Arial",
                                        SKFontStyleWeight.Bold,
                                        SKFontStyleWidth.Normal,
                                        SKFontStyleSlant.Upright);

                    if (sw_listToggle.IsToggled)
                    {
                        canvas.DrawText(exercicioMensal + "", Xc, Yc + progressHelpers.GetFactoredHeight(lineHeight1), skPaint);
                    }
                    else
                    {
                        canvas.DrawText(exercicioDiario + "", Xc, Yc + progressHelpers.GetFactoredHeight(lineHeight1), skPaint);
                    }
                }

                using (SKPaint skPaint = new SKPaint())
                {
                    skPaint.Style = SKPaintStyle.Fill;
                    skPaint.IsAntialias = true;
                    skPaint.Color = SKColor.Parse("#676a69");
                    skPaint.TextAlign = SKTextAlign.Center;
                    skPaint.TextSize = progressHelpers.GetFactoredHeight(lineSize2);
                    canvas.DrawText("Minutos", Xc, Yc + progressHelpers.GetFactoredHeight(lineHeight2), skPaint);
                }

                using (SKPaint skPaint = new SKPaint())
                {
                    skPaint.Style = SKPaintStyle.Fill;
                    skPaint.IsAntialias = true;
                    skPaint.Color = SKColor.Parse("#e2797a");
                    skPaint.TextAlign = SKTextAlign.Center;
                    skPaint.TextSize = progressHelpers.GetFactoredHeight(lineSize3);

                    if (sw_listToggle.IsToggled)
                    {
                        canvas.DrawText("Meta " + meta + " Min", Xc, Yc + progressHelpers.GetFactoredHeight(lineHeight3), skPaint);
                    }
                    else
                    {
                        canvas.DrawText("Meta " + meta / 30 + " Min", Xc, Yc + progressHelpers.GetFactoredHeight(lineHeight3), skPaint);
                    }
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
        }

    }
}
