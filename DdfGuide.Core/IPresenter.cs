namespace DdfGuide.Core
{
    public interface IPresenter<out TView, in TModel> where TView : IView
    {
        TView GetView();
        void SetModel(TModel model);
    }
}
