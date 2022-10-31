namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbRequestSource : IWrappedWrappedJsObject
    {
        bool IsIdbObjectStore { get; }
        bool IsIdbIndex { get; }
        bool IsIdbCursor { get; }
        IWrappedIdbObjectStore? AsIdbObjectStore();
        IWrappedIdbIndex? AsIdbIndex();
        IWrappedIdbCursor? AsIdbCursor();
    }
}
