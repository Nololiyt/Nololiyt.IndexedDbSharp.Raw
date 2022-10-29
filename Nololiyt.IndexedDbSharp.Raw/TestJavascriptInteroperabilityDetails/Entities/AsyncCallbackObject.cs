using Microsoft.JSInterop;

namespace TestJavascriptInteroperabilityDetails.Entities
{
    public sealed class AsyncCallbackObject<T> : IDisposable
    {
        private readonly Func<T, Task> action;
        public AsyncCallbackObject(Func<T, Task> action)
        {
            this.action = action;
            this.Object = DotNetObjectReference.Create(this);
        }
        public DotNetObjectReference<AsyncCallbackObject<T>> Object { get; }
        public string CallbackMethod => nameof(InvokeCallbackAsync);

        public void Dispose()
        {
            this.Object.Dispose();
        }

        [JSInvokable]
        public async Task InvokeCallbackAsync(T value)
        {
            await action(value);
        }
    }
}
