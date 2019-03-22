using Android.App.Job;
using Android.Content;

namespace DdfGuide.Android
{
    /// <summary>
    /// As mentioned in microsoft docs:
    /// https://docs.microsoft.com/en-us/xamarin/android/platform/android-job-scheduler
    /// </summary>
    public static class JobSchedulerHelpers
    {
        public static JobInfo.Builder CreateJobBuilderUsingJobId<T>(this Context context, int jobId) where T : JobService
        {
            var javaClass = Java.Lang.Class.FromType(typeof(T));
            var componentName = new ComponentName(context, javaClass);
            return new JobInfo.Builder(jobId, componentName);
        }
    }
}