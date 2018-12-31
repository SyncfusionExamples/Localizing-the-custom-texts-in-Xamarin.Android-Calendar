using Android.App;
using Android.Widget;
using Android.OS;
using Com.Syncfusion.Calendar;
using Java.Util;
using Android.Graphics;

namespace LocalizingCustomText
{
    [Activity(Label = "LocalizingCustomText", MainLauncher = true)]
    public class MainActivity : Activity
    {
        SfCalendar calendar;
        CalendarEventCollection calendarInlineEvents;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            calendar = new SfCalendar(this);
            calendarInlineEvents = new CalendarEventCollection();
            calendar.ShowEventsInline = true;

            calendar.Locale = new Locale("fr");

            Calendar currentDate = Calendar.Instance;
            Calendar startTime = (Calendar)currentDate.Clone();

            startTime.Set(
                currentDate.Get(CalendarField.Year),
                currentDate.Get(CalendarField.Month),
                currentDate.Get(CalendarField.DayOfMonth), 10, 0, 0);

            Calendar endTime = (Calendar)currentDate.Clone();

            endTime.Set(
                currentDate.Get(CalendarField.Year),
                currentDate.Get(CalendarField.Month),
                currentDate.Get(CalendarField.DayOfMonth), 12, 0, 0);



            CalendarInlineEvent calendarInlineEvent = new CalendarInlineEvent();
            calendarInlineEvent.StartTime = startTime;
            calendarInlineEvent.EndTime = endTime;
            calendarInlineEvent.Subject = "Meeting";
            calendarInlineEvent.Color = Color.Blue;
            calendarInlineEvent.IsAllDay = true;

            calendarInlineEvents.Add(calendarInlineEvent);

            calendar.DataSource = calendarInlineEvents;

            SetContentView(calendar);
        }
    }
}

