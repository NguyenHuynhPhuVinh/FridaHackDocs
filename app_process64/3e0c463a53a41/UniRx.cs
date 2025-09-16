class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x78cfe60*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x78cff54*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UniRx
{
    class WebRequestExtensions
    {
        static /*0x3830a9c*/ System.IObservable<TResult> AbortableDeferredAsyncRequest<TResult>(System.Func<System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end, System.Net.WebRequest request);
        static /*0x78cff5c*/ System.IObservable<System.Net.WebResponse> GetResponseAsObservable(System.Net.WebRequest request);
        static /*0x78d0024*/ System.IObservable<System.Net.HttpWebResponse> GetResponseAsObservable(System.Net.HttpWebRequest request);
        static /*0x78d0150*/ System.IObservable<System.IO.Stream> GetRequestStreamAsObservable(System.Net.WebRequest request);

        class <>c__DisplayClass0_0<TResult>
        {
            /*0x0*/ System.Func<System.AsyncCallback, object, System.IAsyncResult> begin;
            /*0x0*/ System.Func<System.IAsyncResult, TResult> end;
            /*0x0*/ System.Net.WebRequest request;

            /*0x380cb08*/ <>c__DisplayClass0_0();
            /*0x380bb68*/ System.IDisposable <AbortableDeferredAsyncRequest>b__0(System.IObserver<TResult> observer);
        }

        class <>c__DisplayClass0_<TResult>
        {
            /*0x0*/ int isCompleted;
            /*0x0*/ System.IDisposable subscription;
            /*0x0*/ UniRx.WebRequestExtensions.<>c__DisplayClass0_0<TResult> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass0_();
            /*0x3907c14*/ TResult <AbortableDeferredAsyncRequest>b__1(System.IAsyncResult ar);
            /*0x380cb08*/ void <AbortableDeferredAsyncRequest>b__2();
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Net.HttpWebRequest request;

            /*0x78d0148*/ <>c__DisplayClass2_0();
            /*0x78d0218*/ System.Net.HttpWebResponse <GetResponseAsObservable>b__0(System.IAsyncResult ar);
        }
    }

    class BooleanDisposable : System.IDisposable, UniRx.ICancelable
    {
        /*0x10*/ bool <IsDisposed>k__BackingField;

        /*0x78d02c4*/ BooleanDisposable();
        /*0x78d02cc*/ BooleanDisposable(bool isDisposed);
        /*0x78d02b0*/ bool get_IsDisposed();
        /*0x78d02b8*/ void set_IsDisposed(bool value);
        /*0x78d02f8*/ void Dispose();
    }

    class CancellationDisposable : UniRx.ICancelable, System.IDisposable
    {
        /*0x10*/ System.Threading.CancellationTokenSource _cts;

        /*0x78d0310*/ CancellationDisposable(System.Threading.CancellationTokenSource cts);
        /*0x78d038c*/ CancellationDisposable();
        /*0x78d03e8*/ System.Threading.CancellationToken get_Token();
        /*0x78d0404*/ void Dispose();
        /*0x78d0420*/ bool get_IsDisposed();
    }

    class CompositeDisposable : System.Collections.Generic.ICollection<System.IDisposable>, System.Collections.Generic.IEnumerable<System.IDisposable>, System.Collections.IEnumerable, System.IDisposable, UniRx.ICancelable
    {
        static int SHRINK_THRESHOLD = 64;
        /*0x10*/ object _gate;
        /*0x18*/ bool _disposed;
        /*0x20*/ System.Collections.Generic.List<System.IDisposable> _disposables;
        /*0x28*/ int _count;

        /*0x78d043c*/ CompositeDisposable();
        /*0x78d04fc*/ CompositeDisposable(int capacity);
        /*0x78d0610*/ CompositeDisposable(System.IDisposable[] disposables);
        /*0x78d074c*/ CompositeDisposable(System.Collections.Generic.IEnumerable<System.IDisposable> disposables);
        /*0x78d0888*/ int get_Count();
        /*0x78d0890*/ void Add(System.IDisposable item);
        /*0x78d0ae4*/ bool Remove(System.IDisposable item);
        /*0x78d0fcc*/ void Dispose();
        /*0x78d11f4*/ void Clear();
        /*0x78d13f0*/ bool Contains(System.IDisposable item);
        /*0x78d154c*/ void CopyTo(System.IDisposable[] array, int arrayIndex);
        /*0x78d1900*/ bool get_IsReadOnly();
        /*0x78d1908*/ System.Collections.Generic.IEnumerator<System.IDisposable> GetEnumerator();
        /*0x78d1c20*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x78d1c24*/ bool get_IsDisposed();
    }

    class DictionaryDisposable<TKey, TValue> : System.IDisposable, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    {
        /*0x0*/ bool isDisposed;
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> inner;

        /*0x380cb08*/ DictionaryDisposable();
        /*0x380d83c*/ DictionaryDisposable(System.Collections.Generic.IEqualityComparer<TKey> comparer);
        /*0x3907c14*/ TValue get_Item(TKey key);
        /*0x3907c14*/ void set_Item(TKey key, TValue value);
        /*0x380b6a0*/ int get_Count();
        /*0x380b9e8*/ System.Collections.Generic.Dictionary.KeyCollection<TKey, TValue> get_Keys();
        /*0x380b9e8*/ System.Collections.Generic.Dictionary.ValueCollection<TKey, TValue> get_Values();
        /*0x3907c14*/ void Add(TKey key, TValue value);
        /*0x380cb08*/ void Clear();
        /*0x3907c14*/ bool Remove(TKey key);
        /*0x3907c14*/ bool ContainsKey(TKey key);
        /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
        /*0x3907c14*/ System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetEnumerator();
        /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
        /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
        /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
        void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        /*0x380d83c*/ void OnDeserialization(object sender);
        /*0x3907c14*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
        /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
        /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
        /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
        /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
        /*0x380cb08*/ void Dispose();
    }

    class Disposable
    {
        static /*0x0*/ System.IDisposable Empty;

        static /*0x78d1cc4*/ Disposable();
        static /*0x78d1c2c*/ System.IDisposable Create(System.Action disposeAction);
        static /*0x3907c14*/ System.IDisposable CreateWithState<TState>(TState state, System.Action<TState> disposeAction);

        class EmptyDisposable : System.IDisposable
        {
            static /*0x0*/ UniRx.Disposable.EmptyDisposable Singleton;

            static /*0x78d1d50*/ EmptyDisposable();
            /*0x78d1d44*/ EmptyDisposable();
            /*0x78d1d4c*/ void Dispose();
        }

        class AnonymousDisposable : System.IDisposable
        {
            /*0x10*/ bool isDisposed;
            /*0x18*/ System.Action dispose;

            /*0x78d1c94*/ AnonymousDisposable(System.Action dispose);
            /*0x78d1db8*/ void Dispose();
        }

        class AnonymousDisposable<T> : System.IDisposable
        {
            /*0x0*/ bool isDisposed;
            /*0x0*/ T state;
            /*0x0*/ System.Action<T> dispose;

            /*0x3907c14*/ AnonymousDisposable(T state, System.Action<T> dispose);
            /*0x380cb08*/ void Dispose();
        }
    }

    class DisposableExtensions
    {
        static /*0x3907c14*/ T AddTo<T>(T disposable, System.Collections.Generic.ICollection<System.IDisposable> container);
        static /*0x3907c14*/ T AddTo<T>(T disposable, UnityEngine.GameObject gameObject);
        static /*0x78d1df4*/ System.Collections.IEnumerator MonitorTriggerHealth(UniRx.Triggers.ObservableDestroyTrigger trigger, UnityEngine.GameObject targetGameObject);
        static /*0x3907c14*/ T AddTo<T>(T disposable, UnityEngine.Component gameObjectComponent);
        static /*0x3907c14*/ T AddTo<T>(T disposable, System.Collections.Generic.ICollection<System.IDisposable> container, UnityEngine.GameObject gameObject);
        static /*0x3907c14*/ T AddTo<T>(T disposable, System.Collections.Generic.ICollection<System.IDisposable> container, UnityEngine.Component gameObjectComponent);

        class <MonitorTriggerHealth>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UniRx.Triggers.ObservableDestroyTrigger trigger;
            /*0x28*/ UnityEngine.GameObject targetGameObject;

            /*0x78d1e7c*/ <MonitorTriggerHealth>d__2(int <>1__state);
            /*0x78d1ea4*/ void System.IDisposable.Dispose();
            /*0x78d1ea8*/ bool MoveNext();
            /*0x78d1f74*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78d1f7c*/ void System.Collections.IEnumerator.Reset();
            /*0x78d1fb4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    interface ICancelable : System.IDisposable
    {
        /*0x380b128*/ bool get_IsDisposed();
    }

    class MultipleAssignmentDisposable : System.IDisposable, UniRx.ICancelable
    {
        static /*0x0*/ UniRx.BooleanDisposable True;
        /*0x10*/ object gate;
        /*0x18*/ System.IDisposable current;

        static /*0x78d2628*/ MultipleAssignmentDisposable();
        /*0x78d25bc*/ MultipleAssignmentDisposable();
        /*0x78d1fbc*/ bool get_IsDisposed();
        /*0x78d20d0*/ System.IDisposable get_Disposable();
        /*0x78d2218*/ void set_Disposable(System.IDisposable value);
        /*0x78d23e8*/ void Dispose();
    }

    class RefCountDisposable : UniRx.ICancelable, System.IDisposable
    {
        /*0x10*/ object _gate;
        /*0x18*/ System.IDisposable _disposable;
        /*0x20*/ bool _isPrimaryDisposed;
        /*0x24*/ int _count;

        /*0x78d26ac*/ RefCountDisposable(System.IDisposable disposable);
        /*0x78d278c*/ bool get_IsDisposed();
        /*0x78d279c*/ System.IDisposable GetDisposable();
        /*0x78d2970*/ void Dispose();
        /*0x78d2b08*/ void Release();

        class InnerDisposable : System.IDisposable
        {
            /*0x10*/ UniRx.RefCountDisposable _parent;
            /*0x18*/ object parentLock;

            /*0x78d28e8*/ InnerDisposable(UniRx.RefCountDisposable parent);
            /*0x78d2cc4*/ void Dispose();
        }
    }

    class Observable
    {
        static /*0x0*/ System.TimeSpan InfiniteTimeSpan;
        static /*0x8*/ System.Collections.Generic.HashSet<System.Type> YieldInstructionTypes;

        static /*0x78d5bac*/ Observable();
        static /*0x3830700*/ System.IObservable<T> AddRef<T>(System.IObservable<T> xs, UniRx.RefCountDisposable r);
        static /*0x3830700*/ System.IObservable<TSource> Scan<TSource>(System.IObservable<TSource> source, System.Func<TSource, TSource, TSource> accumulator);
        static /*0x3907c14*/ System.IObservable<TAccumulate> Scan<TSource, TAccumulate>(System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator);
        static /*0x3830700*/ System.IObservable<TSource> Aggregate<TSource>(System.IObservable<TSource> source, System.Func<TSource, TSource, TSource> accumulator);
        static /*0x3907c14*/ System.IObservable<TAccumulate> Aggregate<TSource, TAccumulate>(System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator);
        static /*0x3907c14*/ System.IObservable<TResult> Aggregate<TSource, TAccumulate, TResult>(System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator, System.Func<TAccumulate, TResult> resultSelector);
        static /*0x382eaf0*/ UniRx.AsyncSubject<TSource> GetAwaiter<TSource>(System.IObservable<TSource> source);
        static /*0x382eaf0*/ UniRx.AsyncSubject<TSource> GetAwaiter<TSource>(UniRx.IConnectableObservable<TSource> source);
        static /*0x382fdd8*/ UniRx.AsyncSubject<TSource> GetAwaiter<TSource>(System.IObservable<TSource> source, System.Threading.CancellationToken cancellationToken);
        static /*0x382fdd8*/ UniRx.AsyncSubject<TSource> GetAwaiter<TSource>(UniRx.IConnectableObservable<TSource> source, System.Threading.CancellationToken cancellationToken);
        static /*0x382fdd8*/ UniRx.AsyncSubject<TSource> RunAsync<TSource>(System.IObservable<TSource> source, System.Threading.CancellationToken cancellationToken);
        static /*0x382fdd8*/ UniRx.AsyncSubject<TSource> RunAsync<TSource>(UniRx.IConnectableObservable<TSource> source, System.Threading.CancellationToken cancellationToken);
        static /*0x382fdd8*/ UniRx.AsyncSubject<T> Cancel<T>(UniRx.AsyncSubject<T> subject, System.Threading.CancellationToken cancellationToken);
        static void RegisterCancelation<T>(UniRx.AsyncSubject<T> subject, System.IDisposable subscription, System.Threading.CancellationToken token);
        static /*0x3830700*/ UniRx.IConnectableObservable<T> Multicast<T>(System.IObservable<T> source, UniRx.ISubject<T> subject);
        static /*0x382eaf0*/ UniRx.IConnectableObservable<T> Publish<T>(System.IObservable<T> source);
        static /*0x3907c14*/ UniRx.IConnectableObservable<T> Publish<T>(System.IObservable<T> source, T initialValue);
        static /*0x382eaf0*/ UniRx.IConnectableObservable<T> PublishLast<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source);
        static /*0x3830700*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source, UniRx.IScheduler scheduler);
        static /*0x38301ec*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source, int bufferSize);
        static /*0x383030c*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source, int bufferSize, UniRx.IScheduler scheduler);
        static /*0x3831670*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source, System.TimeSpan window);
        static /*0x3907c14*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source, System.TimeSpan window, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ UniRx.IConnectableObservable<T> Replay<T>(System.IObservable<T> source, int bufferSize, System.TimeSpan window, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<T> RefCount<T>(UniRx.IConnectableObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<T> Share<T>(System.IObservable<T> source);
        static /*0x3907c14*/ T Wait<T>(System.IObservable<T> source);
        static /*0x3907c14*/ T Wait<T>(System.IObservable<T> source, System.TimeSpan timeout);
        static /*0x3830700*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> CombineSources<T>(System.IObservable<T> first, System.IObservable<T> seconds);
        static /*0x382eaf0*/ System.IObservable<TSource> Concat<TSource>(System.IObservable<TSource> sources);
        static /*0x382eaf0*/ System.IObservable<TSource> Concat<TSource>(System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources);
        static /*0x382eaf0*/ System.IObservable<TSource> Concat<TSource>(System.IObservable<System.IObservable<TSource>> sources);
        static /*0x3830700*/ System.IObservable<TSource> Concat<TSource>(System.IObservable<TSource> first, System.IObservable<TSource> seconds);
        static /*0x382eaf0*/ System.IObservable<TSource> Merge<TSource>(System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources);
        static /*0x3830700*/ System.IObservable<TSource> Merge<TSource>(System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, UniRx.IScheduler scheduler);
        static /*0x38301ec*/ System.IObservable<TSource> Merge<TSource>(System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, int maxConcurrent);
        static /*0x383030c*/ System.IObservable<TSource> Merge<TSource>(System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, int maxConcurrent, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<TSource> Merge<TSource>(System.IObservable<TSource> sources);
        static /*0x3830700*/ System.IObservable<TSource> Merge<TSource>(UniRx.IScheduler scheduler, System.IObservable<TSource> sources);
        static /*0x3830700*/ System.IObservable<T> Merge<T>(System.IObservable<T> first, System.IObservable<T> seconds);
        static /*0x3830a9c*/ System.IObservable<T> Merge<T>(System.IObservable<T> first, System.IObservable<T> second, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<T> Merge<T>(System.IObservable<System.IObservable<T>> sources);
        static /*0x38301ec*/ System.IObservable<T> Merge<T>(System.IObservable<System.IObservable<T>> sources, int maxConcurrent);
        static /*0x3830a9c*/ System.IObservable<TResult> Zip<TLeft, TRight, TResult>(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<T>> Zip<T>(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<T>> Zip<T>(System.IObservable<T> sources);
        static /*0x3830bec*/ System.IObservable<TR> Zip<T1, T2, T3, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, UniRx.Operators.ZipFunc<T1, T2, T3, TR> resultSelector);
        static /*0x3830cb0*/ System.IObservable<TR> Zip<T1, T2, T3, T4, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, UniRx.Operators.ZipFunc<T1, T2, T3, T4, TR> resultSelector);
        static /*0x3830ce8*/ System.IObservable<TR> Zip<T1, T2, T3, T4, T5, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, TR> resultSelector);
        static /*0x3830d24*/ System.IObservable<TR> Zip<T1, T2, T3, T4, T5, T6, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector);
        static /*0x3830d60*/ System.IObservable<TR> Zip<T1, T2, T3, T4, T5, T6, T7, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, System.IObservable<T7> source7, UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector);
        static /*0x3830a9c*/ System.IObservable<TResult> CombineLatest<TLeft, TRight, TResult>(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<T>> CombineLatest<T>(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<TSource>> CombineLatest<TSource>(System.IObservable<TSource> sources);
        static /*0x3830bec*/ System.IObservable<TR> CombineLatest<T1, T2, T3, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, UniRx.Operators.CombineLatestFunc<T1, T2, T3, TR> resultSelector);
        static /*0x3830cb0*/ System.IObservable<TR> CombineLatest<T1, T2, T3, T4, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector);
        static /*0x3830ce8*/ System.IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector);
        static /*0x3830d24*/ System.IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, T6, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector);
        static /*0x3830d60*/ System.IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, T6, T7, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, System.IObservable<T7> source7, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector);
        static /*0x3830a9c*/ System.IObservable<TResult> ZipLatest<TLeft, TRight, TResult>(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<T>> ZipLatest<T>(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<TSource>> ZipLatest<TSource>(System.IObservable<TSource> sources);
        static /*0x3830bec*/ System.IObservable<TR> ZipLatest<T1, T2, T3, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, UniRx.Operators.ZipLatestFunc<T1, T2, T3, TR> resultSelector);
        static /*0x3830cb0*/ System.IObservable<TR> ZipLatest<T1, T2, T3, T4, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, TR> resultSelector);
        static /*0x3830ce8*/ System.IObservable<TR> ZipLatest<T1, T2, T3, T4, T5, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector);
        static /*0x3830d24*/ System.IObservable<TR> ZipLatest<T1, T2, T3, T4, T5, T6, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector);
        static /*0x3830d60*/ System.IObservable<TR> ZipLatest<T1, T2, T3, T4, T5, T6, T7, TR>(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, System.IObservable<T7> source7, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector);
        static /*0x382eaf0*/ System.IObservable<T> Switch<T>(System.IObservable<System.IObservable<T>> sources);
        static /*0x3830a9c*/ System.IObservable<TResult> WithLatestFrom<TLeft, TRight, TResult>(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
        static /*0x382eaf0*/ System.IObservable<T[]> WhenAll<T>(System.IObservable<T> sources);
        static /*0x78d2da8*/ System.IObservable<UniRx.Unit> WhenAll(System.IObservable<UniRx.Unit> sources);
        static /*0x382eaf0*/ System.IObservable<T[]> WhenAll<T>(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
        static /*0x78d2e80*/ System.IObservable<UniRx.Unit> WhenAll(System.Collections.Generic.IEnumerable<System.IObservable<UniRx.Unit>> sources);
        static /*0x3907c14*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, T value);
        static /*0x3830700*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, System.Func<T> valueFactory);
        static /*0x3830700*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, T[] values);
        static /*0x3830700*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, System.Collections.Generic.IEnumerable<T> values);
        static /*0x3907c14*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, UniRx.IScheduler scheduler, T value);
        static /*0x3830a9c*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, UniRx.IScheduler scheduler, System.Collections.Generic.IEnumerable<T> values);
        static /*0x3830a9c*/ System.IObservable<T> StartWith<T>(System.IObservable<T> source, UniRx.IScheduler scheduler, T[] values);
        static /*0x382eaf0*/ System.IObservable<T> Synchronize<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> Synchronize<T>(System.IObservable<T> source, object gate);
        static /*0x3830700*/ System.IObservable<T> ObserveOn<T>(System.IObservable<T> source, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<T> SubscribeOn<T>(System.IObservable<T> source, UniRx.IScheduler scheduler);
        static /*0x3831670*/ System.IObservable<T> DelaySubscription<T>(System.IObservable<T> source, System.TimeSpan dueTime);
        static /*0x3907c14*/ System.IObservable<T> DelaySubscription<T>(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> DelaySubscription<T>(System.IObservable<T> source, System.DateTimeOffset dueTime);
        static /*0x3907c14*/ System.IObservable<T> DelaySubscription<T>(System.IObservable<T> source, System.DateTimeOffset dueTime, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<T> Amb<T>(System.IObservable<T> sources);
        static /*0x382eaf0*/ System.IObservable<T> Amb<T>(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
        static /*0x3830700*/ System.IObservable<T> Amb<T>(System.IObservable<T> source, System.IObservable<T> second);
        static /*0x382eaf0*/ System.IObservable<T> AsObservable<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<T> ToObservable<T>(System.Collections.Generic.IEnumerable<T> source);
        static /*0x3830700*/ System.IObservable<T> ToObservable<T>(System.Collections.Generic.IEnumerable<T> source, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<TResult> Cast<TSource, TResult>(System.IObservable<TSource> source);
        static /*0x3907c14*/ System.IObservable<TResult> Cast<TSource, TResult>(System.IObservable<TSource> source, TResult witness);
        static /*0x382eaf0*/ System.IObservable<TResult> OfType<TSource, TResult>(System.IObservable<TSource> source);
        static /*0x3907c14*/ System.IObservable<TResult> OfType<TSource, TResult>(System.IObservable<TSource> source, TResult witness);
        static /*0x382eaf0*/ System.IObservable<UniRx.Unit> AsUnitObservable<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<UniRx.Unit> AsSingleUnitObservable<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<T> Create<T>(System.Func<System.IObserver<T>, System.IDisposable> subscribe);
        static /*0x382fccc*/ System.IObservable<T> Create<T>(System.Func<System.IObserver<T>, System.IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread);
        static /*0x3907c14*/ System.IObservable<T> CreateWithState<T, TState>(TState state, System.Func<TState, System.IObserver<T>, System.IDisposable> subscribe);
        static /*0x3907c14*/ System.IObservable<T> CreateWithState<T, TState>(TState state, System.Func<TState, System.IObserver<T>, System.IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread);
        static /*0x382eaf0*/ System.IObservable<T> CreateSafe<T>(System.Func<System.IObserver<T>, System.IDisposable> subscribe);
        static /*0x382fccc*/ System.IObservable<T> CreateSafe<T>(System.Func<System.IObserver<T>, System.IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread);
        static /*0x382dee4*/ System.IObservable<T> Empty<T>();
        static /*0x382eaf0*/ System.IObservable<T> Empty<T>(UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> Empty<T>(T witness);
        static /*0x3907c14*/ System.IObservable<T> Empty<T>(UniRx.IScheduler scheduler, T witness);
        static /*0x382dee4*/ System.IObservable<T> Never<T>();
        static /*0x3907c14*/ System.IObservable<T> Never<T>(T witness);
        static /*0x3907c14*/ System.IObservable<T> Return<T>(T value);
        static /*0x3907c14*/ System.IObservable<T> Return<T>(T value, UniRx.IScheduler scheduler);
        static /*0x78d2f38*/ System.IObservable<UniRx.Unit> Return(UniRx.Unit value);
        static /*0x78d2f90*/ System.IObservable<bool> Return(bool value);
        static /*0x78d302c*/ System.IObservable<int> Return(int value);
        static /*0x78d3084*/ System.IObservable<UniRx.Unit> ReturnUnit();
        static /*0x382eaf0*/ System.IObservable<T> Throw<T>(System.Exception error);
        static /*0x3907c14*/ System.IObservable<T> Throw<T>(System.Exception error, T witness);
        static /*0x3830700*/ System.IObservable<T> Throw<T>(System.Exception error, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> Throw<T>(System.Exception error, UniRx.IScheduler scheduler, T witness);
        static /*0x78d30dc*/ System.IObservable<int> Range(int start, int count);
        static /*0x78d31e8*/ System.IObservable<int> Range(int start, int count, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> Repeat<T>(T value);
        static /*0x3907c14*/ System.IObservable<T> Repeat<T>(T value, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> Repeat<T>(T value, int repeatCount);
        static /*0x3907c14*/ System.IObservable<T> Repeat<T>(T value, int repeatCount, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<T> Repeat<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> RepeatInfinite<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<T> RepeatSafe<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<T> Defer<T>(System.Func<System.IObservable<T>> observableFactory);
        static /*0x382eaf0*/ System.IObservable<T> Start<T>(System.Func<T> function);
        static /*0x3831670*/ System.IObservable<T> Start<T>(System.Func<T> function, System.TimeSpan timeSpan);
        static /*0x3830700*/ System.IObservable<T> Start<T>(System.Func<T> function, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> Start<T>(System.Func<T> function, System.TimeSpan timeSpan, UniRx.IScheduler scheduler);
        static /*0x78d325c*/ System.IObservable<UniRx.Unit> Start(System.Action action);
        static /*0x78d3384*/ System.IObservable<UniRx.Unit> Start(System.Action action, System.TimeSpan timeSpan);
        static /*0x78d344c*/ System.IObservable<UniRx.Unit> Start(System.Action action, UniRx.IScheduler scheduler);
        static /*0x78d34d4*/ System.IObservable<UniRx.Unit> Start(System.Action action, System.TimeSpan timeSpan, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.Func<System.IObservable<T>> ToAsync<T>(System.Func<T> function);
        static /*0x3830700*/ System.Func<System.IObservable<T>> ToAsync<T>(System.Func<T> function, UniRx.IScheduler scheduler);
        static /*0x78d3594*/ System.Func<System.IObservable<UniRx.Unit>> ToAsync(System.Action action);
        static /*0x78d35f8*/ System.Func<System.IObservable<UniRx.Unit>> ToAsync(System.Action action, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<TR> Select<T, TR>(System.IObservable<T> source, System.Func<T, TR> selector);
        static /*0x3830700*/ System.IObservable<TR> Select<T, TR>(System.IObservable<T> source, System.Func<T, int, TR> selector);
        static /*0x3830700*/ System.IObservable<T> Where<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x3830700*/ System.IObservable<T> Where<T>(System.IObservable<T> source, System.Func<T, int, bool> predicate);
        static /*0x3830700*/ System.IObservable<TR> ContinueWith<T, TR>(System.IObservable<T> source, System.IObservable<TR> other);
        static /*0x3830700*/ System.IObservable<TR> ContinueWith<T, TR>(System.IObservable<T> source, System.Func<T, System.IObservable<TR>> selector);
        static /*0x3830700*/ System.IObservable<TR> SelectMany<T, TR>(System.IObservable<T> source, System.IObservable<TR> other);
        static /*0x3830700*/ System.IObservable<TR> SelectMany<T, TR>(System.IObservable<T> source, System.Func<T, System.IObservable<TR>> selector);
        static /*0x3830700*/ System.IObservable<TResult> SelectMany<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TResult>> selector);
        static /*0x3830a9c*/ System.IObservable<TR> SelectMany<T, TC, TR>(System.IObservable<T> source, System.Func<T, System.IObservable<TC>> collectionSelector, System.Func<T, TC, TR> resultSelector);
        static /*0x3830a9c*/ System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector);
        static /*0x3830700*/ System.IObservable<TResult> SelectMany<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector);
        static /*0x3830700*/ System.IObservable<TResult> SelectMany<TSource, TResult>(System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>> selector);
        static /*0x3830a9c*/ System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector);
        static /*0x3830a9c*/ System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector);
        static /*0x382eaf0*/ System.IObservable<T[]> ToArray<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<T>> ToList<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> Do<T>(System.IObservable<T> source, System.IObserver<T> observer);
        static /*0x3830700*/ System.IObservable<T> Do<T>(System.IObservable<T> source, System.Action<T> onNext);
        static /*0x3830a9c*/ System.IObservable<T> Do<T>(System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError);
        static /*0x3830a9c*/ System.IObservable<T> Do<T>(System.IObservable<T> source, System.Action<T> onNext, System.Action onCompleted);
        static /*0x3830bec*/ System.IObservable<T> Do<T>(System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
        static /*0x3830700*/ System.IObservable<T> DoOnError<T>(System.IObservable<T> source, System.Action<System.Exception> onError);
        static /*0x3830700*/ System.IObservable<T> DoOnCompleted<T>(System.IObservable<T> source, System.Action onCompleted);
        static /*0x3830700*/ System.IObservable<T> DoOnTerminate<T>(System.IObservable<T> source, System.Action onTerminate);
        static /*0x3830700*/ System.IObservable<T> DoOnSubscribe<T>(System.IObservable<T> source, System.Action onSubscribe);
        static /*0x3830700*/ System.IObservable<T> DoOnCancel<T>(System.IObservable<T> source, System.Action onCancel);
        static /*0x382eaf0*/ System.IObservable<UniRx.Notification<T>> Materialize<T>(System.IObservable<T> source);
        static /*0x382eaf0*/ System.IObservable<T> Dematerialize<T>(System.IObservable<UniRx.Notification<T>> source);
        static /*0x382eaf0*/ System.IObservable<T> DefaultIfEmpty<T>(System.IObservable<T> source);
        static /*0x3907c14*/ System.IObservable<T> DefaultIfEmpty<T>(System.IObservable<T> source, T defaultValue);
        static /*0x382eaf0*/ System.IObservable<TSource> Distinct<TSource>(System.IObservable<TSource> source);
        static /*0x3830700*/ System.IObservable<TSource> Distinct<TSource>(System.IObservable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer);
        static /*0x3830700*/ System.IObservable<TSource> Distinct<TSource, TKey>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector);
        static /*0x3830a9c*/ System.IObservable<TSource> Distinct<TSource, TKey>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        static /*0x382eaf0*/ System.IObservable<T> DistinctUntilChanged<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> DistinctUntilChanged<T>(System.IObservable<T> source, System.Collections.Generic.IEqualityComparer<T> comparer);
        static /*0x3830700*/ System.IObservable<T> DistinctUntilChanged<T, TKey>(System.IObservable<T> source, System.Func<T, TKey> keySelector);
        static /*0x3830a9c*/ System.IObservable<T> DistinctUntilChanged<T, TKey>(System.IObservable<T> source, System.Func<T, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        static /*0x382eaf0*/ System.IObservable<T> IgnoreElements<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<UniRx.Unit> ForEachAsync<T>(System.IObservable<T> source, System.Action<T> onNext);
        static /*0x3830700*/ System.IObservable<UniRx.Unit> ForEachAsync<T>(System.IObservable<T> source, System.Action<T, int> onNext);
        static /*0x3830700*/ System.IObservable<T> Finally<T>(System.IObservable<T> source, System.Action finallyAction);
        static /*0x3830700*/ System.IObservable<T> Catch<T, TException>(System.IObservable<T> source, System.Func<TException, System.IObservable<T>> errorHandler);
        static /*0x382eaf0*/ System.IObservable<TSource> Catch<TSource>(System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources);
        static /*0x382eaf0*/ System.IObservable<TSource> CatchIgnore<TSource>(System.IObservable<TSource> source);
        static /*0x3830700*/ System.IObservable<TSource> CatchIgnore<TSource, TException>(System.IObservable<TSource> source, System.Action<TException> errorAction);
        static /*0x382eaf0*/ System.IObservable<TSource> Retry<TSource>(System.IObservable<TSource> source);
        static /*0x38301ec*/ System.IObservable<TSource> Retry<TSource>(System.IObservable<TSource> source, int retryCount);
        static /*0x382eaf0*/ System.IObservable<TSource> OnErrorRetry<TSource>(System.IObservable<TSource> source);
        static /*0x3830700*/ System.IObservable<TSource> OnErrorRetry<TSource, TException>(System.IObservable<TSource> source, System.Action<TException> onError);
        static /*0x3907c14*/ System.IObservable<TSource> OnErrorRetry<TSource, TException>(System.IObservable<TSource> source, System.Action<TException> onError, System.TimeSpan delay);
        static /*0x383094c*/ System.IObservable<TSource> OnErrorRetry<TSource, TException>(System.IObservable<TSource> source, System.Action<TException> onError, int retryCount);
        static /*0x3907c14*/ System.IObservable<TSource> OnErrorRetry<TSource, TException>(System.IObservable<TSource> source, System.Action<TException> onError, int retryCount, System.TimeSpan delay);
        static /*0x3907c14*/ System.IObservable<TSource> OnErrorRetry<TSource, TException>(System.IObservable<TSource> source, System.Action<TException> onError, int retryCount, System.TimeSpan delay, UniRx.IScheduler delayScheduler);
        static /*0x3830a9c*/ System.IObservable<UniRx.EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(System.Func<System.EventHandler<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler);
        static /*0x3830a9c*/ System.IObservable<UniRx.Unit> FromEvent<TDelegate>(System.Func<System.Action, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler);
        static /*0x3830a9c*/ System.IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(System.Func<System.Action<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler);
        static /*0x78d36d0*/ System.IObservable<UniRx.Unit> FromEvent(System.Action<System.Action> addHandler, System.Action<System.Action> removeHandler);
        static /*0x3830700*/ System.IObservable<T> FromEvent<T>(System.Action<System.Action<T>> addHandler, System.Action<System.Action<T>> removeHandler);
        static /*0x3830700*/ System.Func<System.IObservable<TResult>> FromAsyncPattern<TResult>(System.Func<System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end);
        static /*0x3830700*/ System.Func<T1, System.IObservable<TResult>> FromAsyncPattern<T1, TResult>(System.Func<T1, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end);
        static /*0x3830700*/ System.Func<T1, T2, System.IObservable<TResult>> FromAsyncPattern<T1, T2, TResult>(System.Func<T1, T2, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end);
        static /*0x78d373c*/ System.Func<System.IObservable<UniRx.Unit>> FromAsyncPattern(System.Func<System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end);
        static /*0x3830700*/ System.Func<T1, System.IObservable<UniRx.Unit>> FromAsyncPattern<T1>(System.Func<T1, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end);
        static /*0x3830700*/ System.Func<T1, T2, System.IObservable<UniRx.Unit>> FromAsyncPattern<T1, T2>(System.Func<T1, T2, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end);
        static /*0x38301ec*/ System.IObservable<T> Take<T>(System.IObservable<T> source, int count);
        static /*0x3831670*/ System.IObservable<T> Take<T>(System.IObservable<T> source, System.TimeSpan duration);
        static /*0x3907c14*/ System.IObservable<T> Take<T>(System.IObservable<T> source, System.TimeSpan duration, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<T> TakeWhile<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x3830700*/ System.IObservable<T> TakeWhile<T>(System.IObservable<T> source, System.Func<T, int, bool> predicate);
        static /*0x3830700*/ System.IObservable<T> TakeUntil<T, TOther>(System.IObservable<T> source, System.IObservable<TOther> other);
        static /*0x38301ec*/ System.IObservable<T> TakeLast<T>(System.IObservable<T> source, int count);
        static /*0x3831670*/ System.IObservable<T> TakeLast<T>(System.IObservable<T> source, System.TimeSpan duration);
        static /*0x3907c14*/ System.IObservable<T> TakeLast<T>(System.IObservable<T> source, System.TimeSpan duration, UniRx.IScheduler scheduler);
        static /*0x38301ec*/ System.IObservable<T> Skip<T>(System.IObservable<T> source, int count);
        static /*0x3831670*/ System.IObservable<T> Skip<T>(System.IObservable<T> source, System.TimeSpan duration);
        static /*0x3907c14*/ System.IObservable<T> Skip<T>(System.IObservable<T> source, System.TimeSpan duration, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<T> SkipWhile<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x3830700*/ System.IObservable<T> SkipWhile<T>(System.IObservable<T> source, System.Func<T, int, bool> predicate);
        static /*0x3830700*/ System.IObservable<T> SkipUntil<T, TOther>(System.IObservable<T> source, System.IObservable<TOther> other);
        static /*0x38301ec*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, int count);
        static /*0x3830278*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, int count, int skip);
        static /*0x3831670*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, System.TimeSpan timeSpan);
        static /*0x3907c14*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, System.TimeSpan timeSpan, UniRx.IScheduler scheduler);
        static /*0x38316ac*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, System.TimeSpan timeSpan, int count);
        static /*0x3907c14*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, System.TimeSpan timeSpan, int count, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, System.TimeSpan timeSpan, System.TimeSpan timeShift);
        static /*0x3907c14*/ System.IObservable<System.Collections.Generic.IList<T>> Buffer<T>(System.IObservable<T> source, System.TimeSpan timeSpan, System.TimeSpan timeShift, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource, TWindowBoundary>(System.IObservable<TSource> source, System.IObservable<TWindowBoundary> windowBoundaries);
        static /*0x382eaf0*/ System.IObservable<UniRx.Pair<T>> Pairwise<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<TR> Pairwise<T, TR>(System.IObservable<T> source, System.Func<T, T, TR> selector);
        static /*0x382eaf0*/ System.IObservable<T> Last<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> Last<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x382eaf0*/ System.IObservable<T> LastOrDefault<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> LastOrDefault<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x382eaf0*/ System.IObservable<T> First<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> First<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x382eaf0*/ System.IObservable<T> FirstOrDefault<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> FirstOrDefault<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x382eaf0*/ System.IObservable<T> Single<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> Single<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x382eaf0*/ System.IObservable<T> SingleOrDefault<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IObservable<T> SingleOrDefault<T>(System.IObservable<T> source, System.Func<T, bool> predicate);
        static /*0x3830700*/ System.IObservable<UniRx.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector);
        static /*0x3830a9c*/ System.IObservable<UniRx.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        static /*0x3830a9c*/ System.IObservable<UniRx.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector);
        static /*0x3830bec*/ System.IObservable<UniRx.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        static /*0x383094c*/ System.IObservable<UniRx.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, int capacity);
        static /*0x3907c14*/ System.IObservable<UniRx.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        static /*0x3830ba4*/ System.IObservable<UniRx.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, int capacity);
        static /*0x3907c14*/ System.IObservable<UniRx.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        static /*0x78d384c*/ System.IObservable<long> Interval(System.TimeSpan period);
        static /*0x78d3988*/ System.IObservable<long> Interval(System.TimeSpan period, UniRx.IScheduler scheduler);
        static /*0x78d3a28*/ System.IObservable<long> Timer(System.TimeSpan dueTime);
        static /*0x78d3a9c*/ System.IObservable<long> Timer(System.DateTimeOffset dueTime);
        static /*0x78d3b20*/ System.IObservable<long> Timer(System.TimeSpan dueTime, System.TimeSpan period);
        static /*0x78d3bcc*/ System.IObservable<long> Timer(System.DateTimeOffset dueTime, System.TimeSpan period);
        static /*0x78d3c88*/ System.IObservable<long> Timer(System.TimeSpan dueTime, UniRx.IScheduler scheduler);
        static /*0x78d3cfc*/ System.IObservable<long> Timer(System.DateTimeOffset dueTime, UniRx.IScheduler scheduler);
        static /*0x78d3d78*/ System.IObservable<long> Timer(System.TimeSpan dueTime, System.TimeSpan period, UniRx.IScheduler scheduler);
        static /*0x78d3e24*/ System.IObservable<long> Timer(System.DateTimeOffset dueTime, System.TimeSpan period, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<UniRx.Timestamped<TSource>> Timestamp<TSource>(System.IObservable<TSource> source);
        static /*0x3830700*/ System.IObservable<UniRx.Timestamped<TSource>> Timestamp<TSource>(System.IObservable<TSource> source, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.IObservable<UniRx.TimeInterval<TSource>> TimeInterval<TSource>(System.IObservable<TSource> source);
        static /*0x3830700*/ System.IObservable<UniRx.TimeInterval<TSource>> TimeInterval<TSource>(System.IObservable<TSource> source, UniRx.IScheduler scheduler);
        static /*0x3831670*/ System.IObservable<T> Delay<T>(System.IObservable<T> source, System.TimeSpan dueTime);
        static /*0x3907c14*/ System.IObservable<TSource> Delay<TSource>(System.IObservable<TSource> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
        static /*0x3831670*/ System.IObservable<T> Sample<T>(System.IObservable<T> source, System.TimeSpan interval);
        static /*0x3907c14*/ System.IObservable<T> Sample<T>(System.IObservable<T> source, System.TimeSpan interval, UniRx.IScheduler scheduler);
        static /*0x3831670*/ System.IObservable<TSource> Throttle<TSource>(System.IObservable<TSource> source, System.TimeSpan dueTime);
        static /*0x3907c14*/ System.IObservable<TSource> Throttle<TSource>(System.IObservable<TSource> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
        static /*0x3831670*/ System.IObservable<TSource> ThrottleFirst<TSource>(System.IObservable<TSource> source, System.TimeSpan dueTime);
        static /*0x3907c14*/ System.IObservable<TSource> ThrottleFirst<TSource>(System.IObservable<TSource> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
        static /*0x3831670*/ System.IObservable<T> Timeout<T>(System.IObservable<T> source, System.TimeSpan dueTime);
        static /*0x3907c14*/ System.IObservable<T> Timeout<T>(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
        static /*0x3907c14*/ System.IObservable<T> Timeout<T>(System.IObservable<T> source, System.DateTimeOffset dueTime);
        static /*0x3907c14*/ System.IObservable<T> Timeout<T>(System.IObservable<T> source, System.DateTimeOffset dueTime, UniRx.IScheduler scheduler);
        static /*0x78d3ed8*/ System.IObservable<UniRx.Unit> FromCoroutine(System.Func<System.Collections.IEnumerator> coroutine, bool publishEveryYield);
        static /*0x78d3fec*/ System.IObservable<UniRx.Unit> FromCoroutine(System.Func<System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine, bool publishEveryYield);
        static /*0x78d4100*/ System.IObservable<UniRx.Unit> FromMicroCoroutine(System.Func<System.Collections.IEnumerator> coroutine, bool publishEveryYield, UniRx.FrameCountType frameCountType);
        static /*0x78d4224*/ System.IObservable<UniRx.Unit> FromMicroCoroutine(System.Func<System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine, bool publishEveryYield, UniRx.FrameCountType frameCountType);
        static /*0x78d4348*/ System.Collections.IEnumerator WrapEnumerator(System.Collections.IEnumerator enumerator, System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken, bool publishEveryYield);
        static /*0x382fccc*/ System.IObservable<T> FromCoroutineValue<T>(System.Func<System.Collections.IEnumerator> coroutine, bool nullAsNextUpdate);
        static /*0x382fccc*/ System.IObservable<T> FromCoroutineValue<T>(System.Func<System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine, bool nullAsNextUpdate);
        static /*0x3907c14*/ System.Collections.IEnumerator WrapEnumeratorYieldValue<T>(System.Collections.IEnumerator enumerator, System.IObserver<T> observer, System.Threading.CancellationToken cancellationToken, bool nullAsNextUpdate);
        static /*0x382eaf0*/ System.IObservable<T> FromCoroutine<T>(System.Func<System.IObserver<T>, System.Collections.IEnumerator> coroutine);
        static /*0x38301ec*/ System.IObservable<T> FromMicroCoroutine<T>(System.Func<System.IObserver<T>, System.Collections.IEnumerator> coroutine, UniRx.FrameCountType frameCountType);
        static /*0x38307c0*/ System.Collections.IEnumerator WrapToCancellableEnumerator<T>(System.Collections.IEnumerator enumerator, System.IObserver<T> observer, System.Threading.CancellationToken cancellationToken);
        static /*0x382eaf0*/ System.IObservable<T> FromCoroutine<T>(System.Func<System.IObserver<T>, System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine);
        static /*0x38301ec*/ System.IObservable<T> FromMicroCoroutine<T>(System.Func<System.IObserver<T>, System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine, UniRx.FrameCountType frameCountType);
        static /*0x3830734*/ System.IObservable<UniRx.Unit> SelectMany<T>(System.IObservable<T> source, System.Collections.IEnumerator coroutine, bool publishEveryYield);
        static /*0x3830734*/ System.IObservable<UniRx.Unit> SelectMany<T>(System.IObservable<T> source, System.Func<System.Collections.IEnumerator> selector, bool publishEveryYield);
        static /*0x3830700*/ System.IObservable<UniRx.Unit> SelectMany<T>(System.IObservable<T> source, System.Func<T, System.Collections.IEnumerator> selector);
        static /*0x78d4420*/ System.IObservable<UniRx.Unit> ToObservable(System.Collections.IEnumerator coroutine, bool publishEveryYield);
        static /*0x78d4534*/ UniRx.ObservableYieldInstruction<UniRx.Unit> ToYieldInstruction(System.Collections.IEnumerator coroutine);
        static /*0x78d45a8*/ UniRx.ObservableYieldInstruction<UniRx.Unit> ToYieldInstruction(System.Collections.IEnumerator coroutine, bool throwOnError);
        static /*0x78d462c*/ UniRx.ObservableYieldInstruction<UniRx.Unit> ToYieldInstruction(System.Collections.IEnumerator coroutine, System.Threading.CancellationToken cancellationToken);
        static /*0x78d46b0*/ UniRx.ObservableYieldInstruction<UniRx.Unit> ToYieldInstruction(System.Collections.IEnumerator coroutine, bool throwOnError, System.Threading.CancellationToken cancellationToken);
        static /*0x78d473c*/ System.IObservable<long> EveryUpdate();
        static /*0x78d4854*/ System.IObservable<long> EveryFixedUpdate();
        static /*0x78d496c*/ System.IObservable<long> EveryEndOfFrame();
        static /*0x78d4a84*/ System.Collections.IEnumerator EveryCycleCore(System.IObserver<long> observer, System.Threading.CancellationToken cancellationToken);
        static /*0x78d4b34*/ System.IObservable<long> EveryGameObjectUpdate();
        static /*0x78d4d54*/ System.IObservable<long> EveryLateUpdate();
        static /*0x78d4f74*/ System.IObservable<long> EveryAfterUpdate();
        static /*0x78d5088*/ System.IObservable<UniRx.Unit> NextFrame(UniRx.FrameCountType frameCountType);
        static /*0x78d51a4*/ System.Collections.IEnumerator NextFrameCore(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellation);
        static /*0x78d5254*/ System.IObservable<long> IntervalFrame(int intervalFrameCount, UniRx.FrameCountType frameCountType);
        static /*0x78d53b4*/ System.IObservable<long> TimerFrame(int dueTimeFrameCount, UniRx.FrameCountType frameCountType);
        static /*0x78d52bc*/ System.IObservable<long> TimerFrame(int dueTimeFrameCount, int periodFrameCount, UniRx.FrameCountType frameCountType);
        static /*0x78d54b8*/ System.Collections.IEnumerator TimerFrameCore(System.IObserver<long> observer, int dueTimeFrameCount, System.Threading.CancellationToken cancel);
        static /*0x78d5570*/ System.Collections.IEnumerator TimerFrameCore(System.IObserver<long> observer, int dueTimeFrameCount, int periodFrameCount, System.Threading.CancellationToken cancel);
        static /*0x3830278*/ System.IObservable<T> DelayFrame<T>(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x3830700*/ System.IObservable<T> Sample<T, T2>(System.IObservable<T> source, System.IObservable<T2> sampler);
        static /*0x3830278*/ System.IObservable<T> SampleFrame<T>(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x3830278*/ System.IObservable<TSource> ThrottleFrame<TSource>(System.IObservable<TSource> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x3830278*/ System.IObservable<TSource> ThrottleFirstFrame<TSource>(System.IObservable<TSource> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x3830278*/ System.IObservable<T> TimeoutFrame<T>(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x3830278*/ System.IObservable<T> DelayFrameSubscription<T>(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x382eaf0*/ UniRx.ObservableYieldInstruction<T> ToYieldInstruction<T>(System.IObservable<T> source);
        static /*0x382fdd8*/ UniRx.ObservableYieldInstruction<T> ToYieldInstruction<T>(System.IObservable<T> source, System.Threading.CancellationToken cancel);
        static /*0x382fccc*/ UniRx.ObservableYieldInstruction<T> ToYieldInstruction<T>(System.IObservable<T> source, bool throwOnError);
        static /*0x3907c14*/ UniRx.ObservableYieldInstruction<T> ToYieldInstruction<T>(System.IObservable<T> source, bool throwOnError, System.Threading.CancellationToken cancel);
        static /*0x382fdd8*/ System.Collections.IEnumerator ToAwaitableEnumerator<T>(System.IObservable<T> source, System.Threading.CancellationToken cancel);
        static /*0x38307c0*/ System.Collections.IEnumerator ToAwaitableEnumerator<T>(System.IObservable<T> source, System.Action<T> onResult, System.Threading.CancellationToken cancel);
        static /*0x38307c0*/ System.Collections.IEnumerator ToAwaitableEnumerator<T>(System.IObservable<T> source, System.Action<System.Exception> onError, System.Threading.CancellationToken cancel);
        static /*0x3830b60*/ System.Collections.IEnumerator ToAwaitableEnumerator<T>(System.IObservable<T> source, System.Action<T> onResult, System.Action<System.Exception> onError, System.Threading.CancellationToken cancel);
        static /*0x382fdd8*/ UnityEngine.Coroutine StartAsCoroutine<T>(System.IObservable<T> source, System.Threading.CancellationToken cancel);
        static /*0x38307c0*/ UnityEngine.Coroutine StartAsCoroutine<T>(System.IObservable<T> source, System.Action<T> onResult, System.Threading.CancellationToken cancel);
        static /*0x38307c0*/ UnityEngine.Coroutine StartAsCoroutine<T>(System.IObservable<T> source, System.Action<System.Exception> onError, System.Threading.CancellationToken cancel);
        static /*0x3830b60*/ UnityEngine.Coroutine StartAsCoroutine<T>(System.IObservable<T> source, System.Action<T> onResult, System.Action<System.Exception> onError, System.Threading.CancellationToken cancel);
        static /*0x382eaf0*/ System.IObservable<T> ObserveOnMainThread<T>(System.IObservable<T> source);
        static /*0x38301ec*/ System.IObservable<T> ObserveOnMainThread<T>(System.IObservable<T> source, UniRx.MainThreadDispatchType dispatchType);
        static /*0x382eaf0*/ System.IObservable<T> SubscribeOnMainThread<T>(System.IObservable<T> source);
        static /*0x78d5634*/ System.IObservable<bool> EveryApplicationPause();
        static /*0x78d579c*/ System.IObservable<bool> EveryApplicationFocus();
        static /*0x78d5904*/ System.IObservable<UniRx.Unit> OnceApplicationQuit();
        static /*0x3830700*/ System.IObservable<T> TakeUntilDestroy<T>(System.IObservable<T> source, UnityEngine.Component target);
        static /*0x3830700*/ System.IObservable<T> TakeUntilDestroy<T>(System.IObservable<T> source, UnityEngine.GameObject target);
        static /*0x3830700*/ System.IObservable<T> TakeUntilDisable<T>(System.IObservable<T> source, UnityEngine.Component target);
        static /*0x3830700*/ System.IObservable<T> TakeUntilDisable<T>(System.IObservable<T> source, UnityEngine.GameObject target);
        static /*0x3830700*/ System.IObservable<T> RepeatUntilDestroy<T>(System.IObservable<T> source, UnityEngine.GameObject target);
        static /*0x3830700*/ System.IObservable<T> RepeatUntilDestroy<T>(System.IObservable<T> source, UnityEngine.Component target);
        static /*0x3830700*/ System.IObservable<T> RepeatUntilDisable<T>(System.IObservable<T> source, UnityEngine.GameObject target);
        static /*0x3830700*/ System.IObservable<T> RepeatUntilDisable<T>(System.IObservable<T> source, UnityEngine.Component target);
        static /*0x3830a9c*/ System.IObservable<T> RepeatUntilCore<T>(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources, System.IObservable<UniRx.Unit> trigger, UnityEngine.GameObject lifeTimeChecker);
        static /*0x382eaf0*/ System.IObservable<UniRx.FrameInterval<T>> FrameInterval<T>(System.IObservable<T> source);
        static /*0x382fccc*/ System.IObservable<UniRx.TimeInterval<T>> FrameTimeInterval<T>(System.IObservable<T> source, bool ignoreTimeScale);
        static /*0x382eaf0*/ System.IObservable<System.Collections.Generic.IList<T>> BatchFrame<T>(System.IObservable<T> source);
        static /*0x3830278*/ System.IObservable<System.Collections.Generic.IList<T>> BatchFrame<T>(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
        static /*0x78d5a70*/ System.IObservable<UniRx.Unit> BatchFrame(System.IObservable<UniRx.Unit> source);
        static /*0x78d5acc*/ System.IObservable<UniRx.Unit> BatchFrame(System.IObservable<UniRx.Unit> source, int frameCount, UniRx.FrameCountType frameCountType);

        class ConnectableObservable<T> : UniRx.IConnectableObservable<T>, System.IObservable<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ UniRx.ISubject<T> subject;
            /*0x0*/ object gate;
            /*0x0*/ UniRx.Observable.ConnectableObservable.Connection<T> connection;

            /*0x380d93c*/ ConnectableObservable(System.IObservable<T> source, UniRx.ISubject<T> subject);
            /*0x380b9e8*/ System.IDisposable Connect();
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);

            class Connection<T> : System.IDisposable
            {
                /*0x0*/ UniRx.Observable.ConnectableObservable<T> parent;
                /*0x0*/ System.IDisposable subscription;

                /*0x380d93c*/ Connection(UniRx.Observable.ConnectableObservable<T> parent, System.IDisposable subscription);
                /*0x380cb08*/ void Dispose();
            }
        }

        class EveryAfterUpdateInvoker : System.Collections.IEnumerator
        {
            /*0x10*/ long count;
            /*0x18*/ System.IObserver<long> observer;
            /*0x20*/ System.Threading.CancellationToken cancellationToken;

            /*0x78d5ddc*/ EveryAfterUpdateInvoker(System.IObserver<long> observer, System.Threading.CancellationToken cancellationToken);
            /*0x78d5e28*/ bool MoveNext();
            /*0x78d5f30*/ object get_Current();
            /*0x78d5f38*/ void Reset();
        }

        class <>c
        {
            static /*0x0*/ UniRx.Observable.<> <>9;
            static /*0x8*/ System.Func<System.IObserver<long>, System.Threading.CancellationToken, System.Collections.IEnumerator> <>9__308_0;
            static /*0x10*/ System.Func<System.IObserver<long>, System.Threading.CancellationToken, System.Collections.IEnumerator> <>9__309_0;
            static /*0x18*/ System.Func<System.IObserver<long>, System.Threading.CancellationToken, System.Collections.IEnumerator> <>9__310_0;
            static /*0x20*/ System.Func<long, UniRx.Unit, long> <>9__312_0;
            static /*0x28*/ System.Func<long, UniRx.Unit, long> <>9__313_0;
            static /*0x30*/ System.Func<System.IObserver<long>, System.Threading.CancellationToken, System.Collections.IEnumerator> <>9__314_0;
            static /*0x38*/ System.Func<System.IObserver<UniRx.Unit>, System.Threading.CancellationToken, System.Collections.IEnumerator> <>9__315_0;

            static /*0x78d5f70*/ <>c();
            /*0x78d5fd8*/ <>c();
            /*0x78d5fe0*/ System.Collections.IEnumerator <EveryUpdate>b__308_0(System.IObserver<long> observer, System.Threading.CancellationToken cancellationToken);
            /*0x78d6044*/ System.Collections.IEnumerator <EveryFixedUpdate>b__309_0(System.IObserver<long> observer, System.Threading.CancellationToken cancellationToken);
            /*0x78d60a8*/ System.Collections.IEnumerator <EveryEndOfFrame>b__310_0(System.IObserver<long> observer, System.Threading.CancellationToken cancellationToken);
            /*0x78d610c*/ long <EveryGameObjectUpdate>b__312_0(long x, UniRx.Unit y);
            /*0x78d6114*/ long <EveryLateUpdate>b__313_0(long x, UniRx.Unit y);
            /*0x78d611c*/ System.Collections.IEnumerator <EveryAfterUpdate>b__314_0(System.IObserver<long> observer, System.Threading.CancellationToken cancellationToken);
            /*0x78d6184*/ System.Collections.IEnumerator <NextFrame>b__315_0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__342<T>
        {
            static /*0x0*/ UniRx.Observable.<>c__342<T> <>9;
            static /*0x0*/ System.Func<T, System.IObservable<long>> <>9__342_0;
            static /*0x0*/ System.Func<T, long, T> <>9__342_1;
            static /*0x0*/ System.Func<T, System.IObservable<long>> <>9__342_2;
            static /*0x0*/ System.Func<T, long, T> <>9__342_3;
            static /*0x0*/ System.Func<T, System.IObservable<UniRx.Unit>> <>9__342_4;
            static /*0x0*/ System.Func<T, UniRx.Unit, T> <>9__342_5;
            static /*0x0*/ System.Func<T, System.IObservable<UniRx.Unit>> <>9__342_6;
            static /*0x0*/ System.Func<T, UniRx.Unit, T> <>9__342_7;

            static /*0x38358cc*/ <>c__342();
            /*0x380cb08*/ <>c__342();
            /*0x3907c14*/ System.IObservable<long> <ObserveOnMainThread>b__342_0(T _);
            /*0x3907c14*/ T <ObserveOnMainThread>b__342_1(T x, long _);
            /*0x3907c14*/ System.IObservable<long> <ObserveOnMainThread>b__342_2(T _);
            /*0x3907c14*/ T <ObserveOnMainThread>b__342_3(T x, long _);
            /*0x3907c14*/ System.IObservable<UniRx.Unit> <ObserveOnMainThread>b__342_4(T _);
            /*0x3907c14*/ T <ObserveOnMainThread>b__342_5(T x, UniRx.Unit _);
            /*0x3907c14*/ System.IObservable<UniRx.Unit> <ObserveOnMainThread>b__342_6(T _);
            /*0x3907c14*/ T <ObserveOnMainThread>b__342_7(T x, UniRx.Unit _);
        }

        class <>c__DisplayClass0_0<T>
        {
            /*0x0*/ UniRx.RefCountDisposable r;
            /*0x0*/ System.IObservable<T> xs;

            /*0x380cb08*/ <>c__DisplayClass0_0();
            /*0x380bb68*/ System.IDisposable <AddRef>b__0(System.IObserver<T> observer);
        }

        class <>c__DisplayClass13_0<T>
        {
            /*0x0*/ System.IDisposable subscription;
            /*0x0*/ UniRx.AsyncSubject<T> subject;
            /*0x0*/ System.Threading.CancellationToken token;
            /*0x0*/ System.Threading.CancellationTokenRegistration ctr;

            /*0x380cb08*/ <>c__DisplayClass13_0();
            /*0x380cb08*/ void <RegisterCancelation>b__0();
            /*0x380d83c*/ void <RegisterCancelation>b__1(System.Exception _);
        }

        class <>c__DisplayClass142_0<T>
        {
            /*0x0*/ UniRx.IScheduler scheduler;
            /*0x0*/ System.Func<T> function;

            /*0x380cb08*/ <>c__DisplayClass142_0();
            /*0x380b9e8*/ System.IObservable<T> <ToAsync>b__0();
        }

        class <>c__DisplayClass142_<T>
        {
            /*0x0*/ UniRx.AsyncSubject<T> subject;
            /*0x0*/ UniRx.Observable.<>c__DisplayClass142_0<T> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass142_();
            /*0x380cb08*/ void <ToAsync>b__1();
        }

        class <>c__DisplayClass144_0
        {
            /*0x10*/ UniRx.IScheduler scheduler;
            /*0x18*/ System.Action action;

            /*0x78d36c8*/ <>c__DisplayClass144_0();
            /*0x78d61e8*/ System.IObservable<UniRx.Unit> <ToAsync>b__0();
        }

        class <>c__DisplayClass144_1
        {
            /*0x10*/ UniRx.AsyncSubject<UniRx.Unit> subject;
            /*0x18*/ UniRx.Observable.<> CS$<>8__locals1;

            /*0x78d63b8*/ <>c__DisplayClass144_1();
            /*0x78d63c0*/ void <ToAsync>b__1();
        }

        class <>c__DisplayClass150_0<T, TR>
        {
            /*0x0*/ System.IObservable<TR> other;

            /*0x380cb08*/ <>c__DisplayClass150_0();
            /*0x3907c14*/ System.IObservable<TR> <ContinueWith>b__0(T _);
        }

        class <>c__DisplayClass152_0<T, TR>
        {
            /*0x0*/ System.IObservable<TR> other;

            /*0x380cb08*/ <>c__DisplayClass152_0();
            /*0x3907c14*/ System.IObservable<TR> <SelectMany>b__0(T _);
        }

        class <>c__DisplayClass192_0<TSource, TException>
        {
            /*0x0*/ System.Action<TException> errorAction;

            /*0x380cb08*/ <>c__DisplayClass192_0();
            /*0x3907c14*/ System.IObservable<TSource> <CatchIgnore>b__0(TException ex);
        }

        class <>c__DisplayClass200_0<TSource, TException>
        {
            /*0x0*/ System.TimeSpan delay;
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Action<TException> onError;
            /*0x0*/ int retryCount;
            /*0x0*/ UniRx.IScheduler delayScheduler;

            /*0x380cb08*/ <>c__DisplayClass200_0();
            /*0x380b9e8*/ System.IObservable<TSource> <OnErrorRetry>b__0();
        }

        class <>c__DisplayClass200_1<TSource, TException>
        {
            /*0x0*/ int count;
            /*0x0*/ System.TimeSpan dueTime;
            /*0x0*/ System.IObservable<TSource> self;
            /*0x0*/ UniRx.Observable.<>c__DisplayClass200_0<TSource, TException> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass200_1();
            /*0x3907c14*/ System.IObservable<TSource> <OnErrorRetry>b__1(TException ex);
        }

        class <>c__DisplayClass206_0<TResult>
        {
            /*0x0*/ System.Func<System.AsyncCallback, object, System.IAsyncResult> begin;
            /*0x0*/ System.Func<System.IAsyncResult, TResult> end;

            /*0x380cb08*/ <>c__DisplayClass206_0();
            /*0x380b9e8*/ System.IObservable<TResult> <FromAsyncPattern>b__0();
        }

        class <>c__DisplayClass206_<TResult>
        {
            /*0x0*/ UniRx.AsyncSubject<TResult> subject;
            /*0x0*/ UniRx.Observable.<>c__DisplayClass206_0<TResult> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass206_();
            /*0x380d83c*/ void <FromAsyncPattern>b__1(System.IAsyncResult iar);
        }

        class <>c__DisplayClass207_0<T1, TResult>
        {
            /*0x0*/ System.Func<T1, System.AsyncCallback, object, System.IAsyncResult> begin;
            /*0x0*/ System.Func<System.IAsyncResult, TResult> end;

            /*0x380cb08*/ <>c__DisplayClass207_0();
            /*0x3907c14*/ System.IObservable<TResult> <FromAsyncPattern>b__0(T1 x);
        }

        class <>c__DisplayClass207_1<T1, TResult>
        {
            /*0x0*/ UniRx.AsyncSubject<TResult> subject;
            /*0x0*/ UniRx.Observable.<>c__DisplayClass207_0<T1, TResult> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass207_1();
            /*0x380d83c*/ void <FromAsyncPattern>b__1(System.IAsyncResult iar);
        }

        class <>c__DisplayClass208_0<T1, T2, TResult>
        {
            /*0x0*/ System.Func<T1, T2, System.AsyncCallback, object, System.IAsyncResult> begin;
            /*0x0*/ System.Func<System.IAsyncResult, TResult> end;

            /*0x380cb08*/ <>c__DisplayClass208_0();
            /*0x3907c14*/ System.IObservable<TResult> <FromAsyncPattern>b__0(T1 x, T2 y);
        }

        class <>c__DisplayClass208_1<T1, T2, TResult>
        {
            /*0x0*/ UniRx.AsyncSubject<TResult> subject;
            /*0x0*/ UniRx.Observable.<>c__DisplayClass208_0<T1, T2, TResult> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass208_1();
            /*0x380d83c*/ void <FromAsyncPattern>b__1(System.IAsyncResult iar);
        }

        class <>c__DisplayClass209_0
        {
            /*0x10*/ System.Action<System.IAsyncResult> end;

            /*0x78d3844*/ <>c__DisplayClass209_0();
            /*0x78d656c*/ UniRx.Unit <FromAsyncPattern>b__0(System.IAsyncResult iar);
        }

        class <>c__DisplayClass210_0<T1>
        {
            /*0x0*/ System.Action<System.IAsyncResult> end;

            /*0x380cb08*/ <>c__DisplayClass210_0();
            UniRx.Unit <FromAsyncPattern>b__0(System.IAsyncResult iar);
        }

        class <>c__DisplayClass211_0<T1, T2>
        {
            /*0x0*/ System.Action<System.IAsyncResult> end;

            /*0x380cb08*/ <>c__DisplayClass211_0();
            UniRx.Unit <FromAsyncPattern>b__0(System.IAsyncResult iar);
        }

        class <>c__DisplayClass287_0
        {
            /*0x10*/ System.Func<System.Collections.IEnumerator> coroutine;
            /*0x18*/ bool publishEveryYield;

            /*0x78d3fe4*/ <>c__DisplayClass287_0();
            /*0x78d661c*/ System.Collections.IEnumerator <FromCoroutine>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass288_0
        {
            /*0x10*/ System.Func<System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine;
            /*0x18*/ bool publishEveryYield;

            /*0x78d40f8*/ <>c__DisplayClass288_0();
            /*0x78d66b8*/ System.Collections.IEnumerator <FromCoroutine>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass289_0
        {
            /*0x10*/ System.Func<System.Collections.IEnumerator> coroutine;
            /*0x18*/ bool publishEveryYield;

            /*0x78d421c*/ <>c__DisplayClass289_0();
            /*0x78d6758*/ System.Collections.IEnumerator <FromMicroCoroutine>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass290_0
        {
            /*0x10*/ System.Func<System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine;
            /*0x18*/ bool publishEveryYield;

            /*0x78d4340*/ <>c__DisplayClass290_0();
            /*0x78d67f4*/ System.Collections.IEnumerator <FromMicroCoroutine>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass292_0<T>
        {
            /*0x0*/ System.Func<System.Collections.IEnumerator> coroutine;
            /*0x0*/ bool nullAsNextUpdate;

            /*0x380cb08*/ <>c__DisplayClass292_0();
            /*0x380bc30*/ System.Collections.IEnumerator <FromCoroutineValue>b__0(System.IObserver<T> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass293_0<T>
        {
            /*0x0*/ System.Func<System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine;
            /*0x0*/ bool nullAsNextUpdate;

            /*0x380cb08*/ <>c__DisplayClass293_0();
            /*0x380bc30*/ System.Collections.IEnumerator <FromCoroutineValue>b__0(System.IObserver<T> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass295_0<T>
        {
            /*0x0*/ System.Func<System.IObserver<T>, System.Collections.IEnumerator> coroutine;

            /*0x380cb08*/ <>c__DisplayClass295_0();
            /*0x380bc30*/ System.Collections.IEnumerator <FromCoroutine>b__0(System.IObserver<T> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass296_0<T>
        {
            /*0x0*/ System.Func<System.IObserver<T>, System.Collections.IEnumerator> coroutine;

            /*0x380cb08*/ <>c__DisplayClass296_0();
            /*0x380bc30*/ System.Collections.IEnumerator <FromMicroCoroutine>b__0(System.IObserver<T> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass300_0<T>
        {
            /*0x0*/ System.Collections.IEnumerator coroutine;

            /*0x380cb08*/ <>c__DisplayClass300_0();
            /*0x380b9e8*/ System.Collections.IEnumerator <SelectMany>b__0();
        }

        class <>c__DisplayClass301_0<T>
        {
            /*0x0*/ System.Func<System.Collections.IEnumerator> selector;

            /*0x380cb08*/ <>c__DisplayClass301_0();
            /*0x380b9e8*/ System.Collections.IEnumerator <SelectMany>b__0();
        }

        class <>c__DisplayClass302_0<T>
        {
            /*0x0*/ System.Func<T, System.Collections.IEnumerator> selector;

            /*0x380cb08*/ <>c__DisplayClass302_0();
            /*0x3907c14*/ System.IObservable<UniRx.Unit> <SelectMany>b__0(T x);
        }

        class <>c__DisplayClass302_<T>
        {
            /*0x0*/ T x;
            /*0x0*/ UniRx.Observable.<>c__DisplayClass302_0<T> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass302_();
            /*0x380b9e8*/ System.Collections.IEnumerator <SelectMany>b__1();
        }

        class <>c__DisplayClass303_0
        {
            /*0x10*/ System.Collections.IEnumerator coroutine;
            /*0x18*/ bool publishEveryYield;

            /*0x78d452c*/ <>c__DisplayClass303_0();
            /*0x78d6894*/ System.Collections.IEnumerator <ToObservable>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass318_0
        {
            /*0x10*/ int dueTimeFrameCount;

            /*0x78d54a8*/ <>c__DisplayClass318_0();
            /*0x78d6910*/ System.Collections.IEnumerator <TimerFrame>b__0(System.IObserver<long> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass319_0
        {
            /*0x10*/ int dueTimeFrameCount;
            /*0x14*/ int periodFrameCount;

            /*0x78d54b0*/ <>c__DisplayClass319_0();
            /*0x78d6980*/ System.Collections.IEnumerator <TimerFrame>b__0(System.IObserver<long> observer, System.Threading.CancellationToken cancellation);
        }

        class <CombineSources>d__29<T> : System.Collections.Generic.IEnumerable<System.IObservable<T>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.IObservable<T>>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.IObservable<T> <>2__current;
            /*0x0*/ int <>l__initialThreadId;
            /*0x0*/ System.IObservable<T> first;
            /*0x0*/ System.IObservable<T> <>3__first;
            /*0x0*/ System.IObservable<T> seconds;
            /*0x0*/ System.IObservable<T> <>3__seconds;
            /*0x0*/ int <i>5__2;

            /*0x380cffc*/ <CombineSources>d__29(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ System.IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <EveryCycleCore>d__311 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ System.Threading.CancellationToken cancellationToken;
            /*0x28*/ System.IObserver<long> observer;
            /*0x30*/ long <count>5__2;

            /*0x78d4b0c*/ <EveryCycleCore>d__311(int <>1__state);
            /*0x78d69f4*/ void System.IDisposable.Dispose();
            /*0x78d69f8*/ bool MoveNext();
            /*0x78d6b54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78d6b5c*/ void System.Collections.IEnumerator.Reset();
            /*0x78d6b94*/ object System.Collections.IEnumerator.get_Current();
        }

        class <NextFrameCore>d__316 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ System.Threading.CancellationToken cancellation;
            /*0x28*/ System.IObserver<UniRx.Unit> observer;

            /*0x78d522c*/ <NextFrameCore>d__316(int <>1__state);
            /*0x78d6b9c*/ void System.IDisposable.Dispose();
            /*0x78d6ba0*/ bool MoveNext();
            /*0x78d6d8c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78d6d94*/ void System.Collections.IEnumerator.Reset();
            /*0x78d6dcc*/ object System.Collections.IEnumerator.get_Current();
        }

        class <RepeatInfinite>d__130<T> : System.Collections.Generic.IEnumerable<System.IObservable<T>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.IObservable<T>>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.IObservable<T> <>2__current;
            /*0x0*/ int <>l__initialThreadId;
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObservable<T> <>3__source;

            /*0x380cffc*/ <RepeatInfinite>d__130(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ System.IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <TimerFrameCore>d__320 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int dueTimeFrameCount;
            /*0x28*/ System.IObserver<long> observer;
            /*0x30*/ System.Threading.CancellationToken cancel;
            /*0x38*/ int <currentFrame>5__2;

            /*0x78d5548*/ <TimerFrameCore>d__320(int <>1__state);
            /*0x78d6dd4*/ void System.IDisposable.Dispose();
            /*0x78d6dd8*/ bool MoveNext();
            /*0x78d6f8c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78d6f94*/ void System.Collections.IEnumerator.Reset();
            /*0x78d6fcc*/ object System.Collections.IEnumerator.get_Current();
        }

        class <TimerFrameCore>d__321 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int dueTimeFrameCount;
            /*0x24*/ int periodFrameCount;
            /*0x28*/ System.IObserver<long> observer;
            /*0x30*/ System.Threading.CancellationToken cancel;
            /*0x38*/ long <sendCount>5__2;
            /*0x40*/ int <currentFrame>5__3;

            /*0x78d560c*/ <TimerFrameCore>d__321(int <>1__state);
            /*0x78d6fd4*/ void System.IDisposable.Dispose();
            /*0x78d6fd8*/ bool MoveNext();
            /*0x78d7244*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78d724c*/ void System.Collections.IEnumerator.Reset();
            /*0x78d7284*/ object System.Collections.IEnumerator.get_Current();
        }

        class <ToAwaitableEnumerator>d__336<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Threading.CancellationToken cancel;
            /*0x0*/ System.Action<T> onResult;
            /*0x0*/ System.Action<System.Exception> onError;
            /*0x0*/ UniRx.ObservableYieldInstruction<T> <enumerator>5__2;
            /*0x0*/ System.Collections.Generic.IEnumerator<T> <e>5__3;

            /*0x380cffc*/ <ToAwaitableEnumerator>d__336(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <WrapEnumerator>d__291 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ System.Collections.IEnumerator enumerator;
            /*0x28*/ System.IObserver<UniRx.Unit> observer;
            /*0x30*/ bool publishEveryYield;
            /*0x38*/ System.Threading.CancellationToken cancellationToken;
            /*0x40*/ bool <hasNext>5__2;
            /*0x41*/ bool <raisedError>5__3;
            /*0x48*/ UniRx.ICustomYieldInstructionErrorHandler <customHandler>5__4;

            /*0x78d43f8*/ <WrapEnumerator>d__291(int <>1__state);
            /*0x78d728c*/ void System.IDisposable.Dispose();
            /*0x78d7290*/ bool MoveNext();
            /*0x78d7f70*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78d7f78*/ void System.Collections.IEnumerator.Reset();
            /*0x78d7fb0*/ object System.Collections.IEnumerator.get_Current();
        }

        class <WrapEnumeratorYieldValue>d__294<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ System.Collections.IEnumerator enumerator;
            /*0x0*/ System.IObserver<T> observer;
            /*0x0*/ bool nullAsNextUpdate;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ bool <hasNext>5__2;
            /*0x0*/ object <current>5__3;
            /*0x0*/ bool <raisedError>5__4;
            /*0x0*/ UniRx.ICustomYieldInstructionErrorHandler <customHandler>5__5;

            /*0x380cffc*/ <WrapEnumeratorYieldValue>d__294(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <WrapToCancellableEnumerator>d__297<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ System.Collections.IEnumerator enumerator;
            /*0x0*/ System.IObserver<T> observer;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ bool <hasNext>5__2;

            /*0x380cffc*/ <WrapToCancellableEnumerator>d__297(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class ScheduledDisposable : UniRx.ICancelable, System.IDisposable
    {
        /*0x10*/ UniRx.IScheduler scheduler;
        /*0x18*/ System.IDisposable disposable;
        /*0x20*/ int isDisposed;

        /*0x78d7fb8*/ ScheduledDisposable(UniRx.IScheduler scheduler, System.IDisposable disposable);
        /*0x78d8000*/ UniRx.IScheduler get_Scheduler();
        /*0x78d8008*/ System.IDisposable get_Disposable();
        /*0x78d8020*/ bool get_IsDisposed();
        /*0x78d8030*/ void Dispose();
        /*0x78d8124*/ void DisposeInner();
    }

    class SerialDisposable : System.IDisposable, UniRx.ICancelable
    {
        /*0x10*/ object gate;
        /*0x18*/ System.IDisposable current;
        /*0x20*/ bool disposed;

        /*0x78d8654*/ SerialDisposable();
        /*0x78d81e8*/ bool get_IsDisposed();
        /*0x78d82b4*/ System.IDisposable get_Disposable();
        /*0x78d82bc*/ void set_Disposable(System.IDisposable value);
        /*0x78d84c8*/ void Dispose();
    }

    class SingleAssignmentDisposable : System.IDisposable, UniRx.ICancelable
    {
        /*0x10*/ object gate;
        /*0x18*/ System.IDisposable current;
        /*0x20*/ bool disposed;

        /*0x78d8b24*/ SingleAssignmentDisposable();
        /*0x78d86c0*/ bool get_IsDisposed();
        /*0x78d878c*/ System.IDisposable get_Disposable();
        /*0x78d8794*/ void set_Disposable(System.IDisposable value);
        /*0x78d8998*/ void Dispose();
    }

    class StableCompositeDisposable : UniRx.ICancelable, System.IDisposable
    {
        static /*0x78d8b90*/ UniRx.ICancelable Create(System.IDisposable disposable1, System.IDisposable disposable2);
        static /*0x78d8cb4*/ UniRx.ICancelable Create(System.IDisposable disposable1, System.IDisposable disposable2, System.IDisposable disposable3);
        static /*0x78d8e2c*/ UniRx.ICancelable Create(System.IDisposable disposable1, System.IDisposable disposable2, System.IDisposable disposable3, System.IDisposable disposable4);
        static /*0x78d8fe8*/ UniRx.ICancelable Create(System.IDisposable[] disposables);
        static /*0x78d9090*/ UniRx.ICancelable CreateUnsafe(System.IDisposable[] disposables);
        static /*0x78d9124*/ UniRx.ICancelable Create(System.Collections.Generic.IEnumerable<System.IDisposable> disposables);
        /*0x78d92fc*/ StableCompositeDisposable();
        /*0x380cb08*/ void Dispose();
        /*0x380b128*/ bool get_IsDisposed();

        class Binary : UniRx.StableCompositeDisposable
        {
            /*0x10*/ int disposedCallCount;
            /*0x18*/ System.IDisposable _disposable1;
            /*0x20*/ System.IDisposable _disposable2;

            /*0x78d8c60*/ Binary(System.IDisposable disposable1, System.IDisposable disposable2);
            /*0x78d9304*/ bool get_IsDisposed();
            /*0x78d9314*/ void Dispose();
        }

        class Trinary : UniRx.StableCompositeDisposable
        {
            /*0x10*/ int disposedCallCount;
            /*0x18*/ System.IDisposable _disposable1;
            /*0x20*/ System.IDisposable _disposable2;
            /*0x28*/ System.IDisposable _disposable3;

            /*0x78d8db8*/ Trinary(System.IDisposable disposable1, System.IDisposable disposable2, System.IDisposable disposable3);
            /*0x78d9438*/ bool get_IsDisposed();
            /*0x78d9448*/ void Dispose();
        }

        class Quaternary : UniRx.StableCompositeDisposable
        {
            /*0x10*/ int disposedCallCount;
            /*0x18*/ System.IDisposable _disposable1;
            /*0x20*/ System.IDisposable _disposable2;
            /*0x28*/ System.IDisposable _disposable3;
            /*0x30*/ System.IDisposable _disposable4;

            /*0x78d8f5c*/ Quaternary(System.IDisposable disposable1, System.IDisposable disposable2, System.IDisposable disposable3, System.IDisposable disposable4);
            /*0x78d95d0*/ bool get_IsDisposed();
            /*0x78d95e0*/ void Dispose();
        }

        class NAry : UniRx.StableCompositeDisposable
        {
            /*0x10*/ int disposedCallCount;
            /*0x18*/ System.Collections.Generic.List<System.IDisposable> _disposables;

            /*0x78d908c*/ NAry(System.IDisposable[] disposables);
            /*0x78d91c8*/ NAry(System.Collections.Generic.IEnumerable<System.IDisposable> disposables);
            /*0x78d97cc*/ bool get_IsDisposed();
            /*0x78d97dc*/ void Dispose();
        }

        class NAryUnsafe : UniRx.StableCompositeDisposable
        {
            /*0x10*/ int disposedCallCount;
            /*0x18*/ System.IDisposable[] _disposables;

            /*0x78d90e8*/ NAryUnsafe(System.IDisposable[] disposables);
            /*0x78d99a4*/ bool get_IsDisposed();
            /*0x78d99b4*/ void Dispose();
        }
    }

    interface IEventPattern<TSender, TEventArgs>
    {
        /*0x3907c14*/ TSender get_Sender();
        /*0x3907c14*/ TEventArgs get_EventArgs();
    }

    class EventPattern<TEventArgs> : UniRx.EventPattern<object, TEventArgs>
    {
        /*0x3907c14*/ EventPattern(object sender, TEventArgs e);
    }

    class EventPattern<TSender, TEventArgs> : System.IEquatable<UniRx.EventPattern<TSender, TEventArgs>>, UniRx.IEventPattern<TSender, TEventArgs>
    {
        /*0x0*/ TSender <Sender>k__BackingField;
        /*0x0*/ TEventArgs <EventArgs>k__BackingField;

        static /*0x381cca4*/ bool op_Equality(UniRx.EventPattern<TSender, TEventArgs> first, UniRx.EventPattern<TSender, TEventArgs> second);
        static /*0x381cca4*/ bool op_Inequality(UniRx.EventPattern<TSender, TEventArgs> first, UniRx.EventPattern<TSender, TEventArgs> second);
        /*0x3907c14*/ EventPattern(TSender sender, TEventArgs e);
        /*0x3907c14*/ TSender get_Sender();
        /*0x3907c14*/ void set_Sender(TSender value);
        /*0x3907c14*/ TEventArgs get_EventArgs();
        /*0x3907c14*/ void set_EventArgs(TEventArgs value);
        /*0x380b2f0*/ bool Equals(UniRx.EventPattern<TSender, TEventArgs> other);
        /*0x380b2f0*/ bool Equals(object obj);
        /*0x380b6a0*/ int GetHashCode();
    }

    interface IObserver<TValue, TResult>
    {
        /*0x3907c14*/ TResult OnNext(TValue value);
        /*0x3907c14*/ TResult OnError(System.Exception exception);
        /*0x3907c14*/ TResult OnCompleted();
    }

    enum NotificationKind
    {
        OnNext = 0,
        OnError = 1,
        OnCompleted = 2,
    }

    class Notification<T> : System.IEquatable<UniRx.Notification<T>>
    {
        static /*0x381cca4*/ bool op_Equality(UniRx.Notification<T> left, UniRx.Notification<T> right);
        static /*0x381cca4*/ bool op_Inequality(UniRx.Notification<T> left, UniRx.Notification<T> right);
        /*0x380cb08*/ Notification();
        /*0x3907c14*/ T get_Value();
        /*0x380b128*/ bool get_HasValue();
        /*0x380b9e8*/ System.Exception get_Exception();
        /*0x380b6a0*/ UniRx.NotificationKind get_Kind();
        /*0x380b2f0*/ bool Equals(UniRx.Notification<T> other);
        /*0x380b2f0*/ bool Equals(object obj);
        /*0x380d83c*/ void Accept(System.IObserver<T> observer);
        /*0x3907c14*/ TResult Accept<TResult>(UniRx.IObserver<T, TResult> observer);
        /*0x380da4c*/ void Accept(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
        /*0x3907c14*/ TResult Accept<TResult>(System.Func<T, TResult> onNext, System.Func<System.Exception, TResult> onError, System.Func<TResult> onCompleted);
        /*0x380b9e8*/ System.IObservable<T> ToObservable();
        /*0x380bb68*/ System.IObservable<T> ToObservable(UniRx.IScheduler scheduler);

        class OnNextNotification<T> : UniRx.Notification<T>
        {
            /*0x0*/ T value;

            /*0x3907c14*/ OnNextNotification(T value);
            /*0x3907c14*/ T get_Value();
            /*0x380b9e8*/ System.Exception get_Exception();
            /*0x380b128*/ bool get_HasValue();
            /*0x380b6a0*/ UniRx.NotificationKind get_Kind();
            /*0x380b6a0*/ int GetHashCode();
            /*0x380b2f0*/ bool Equals(UniRx.Notification<T> other);
            /*0x380b9e8*/ string ToString();
            /*0x380d83c*/ void Accept(System.IObserver<T> observer);
            /*0x3907c14*/ TResult Accept<TResult>(UniRx.IObserver<T, TResult> observer);
            /*0x380da4c*/ void Accept(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ TResult Accept<TResult>(System.Func<T, TResult> onNext, System.Func<System.Exception, TResult> onError, System.Func<TResult> onCompleted);
        }

        class OnErrorNotification<T> : UniRx.Notification<T>
        {
            /*0x0*/ System.Exception exception;

            /*0x380d83c*/ OnErrorNotification(System.Exception exception);
            /*0x3907c14*/ T get_Value();
            /*0x380b9e8*/ System.Exception get_Exception();
            /*0x380b128*/ bool get_HasValue();
            /*0x380b6a0*/ UniRx.NotificationKind get_Kind();
            /*0x380b6a0*/ int GetHashCode();
            /*0x380b2f0*/ bool Equals(UniRx.Notification<T> other);
            /*0x380b9e8*/ string ToString();
            /*0x380d83c*/ void Accept(System.IObserver<T> observer);
            /*0x3907c14*/ TResult Accept<TResult>(UniRx.IObserver<T, TResult> observer);
            /*0x380da4c*/ void Accept(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ TResult Accept<TResult>(System.Func<T, TResult> onNext, System.Func<System.Exception, TResult> onError, System.Func<TResult> onCompleted);
        }

        class OnCompletedNotification<T> : UniRx.Notification<T>
        {
            /*0x380cb08*/ OnCompletedNotification();
            /*0x3907c14*/ T get_Value();
            /*0x380b9e8*/ System.Exception get_Exception();
            /*0x380b128*/ bool get_HasValue();
            /*0x380b6a0*/ UniRx.NotificationKind get_Kind();
            /*0x380b6a0*/ int GetHashCode();
            /*0x380b2f0*/ bool Equals(UniRx.Notification<T> other);
            /*0x380b9e8*/ string ToString();
            /*0x380d83c*/ void Accept(System.IObserver<T> observer);
            /*0x3907c14*/ TResult Accept<TResult>(UniRx.IObserver<T, TResult> observer);
            /*0x380da4c*/ void Accept(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ TResult Accept<TResult>(System.Func<T, TResult> onNext, System.Func<System.Exception, TResult> onError, System.Func<TResult> onCompleted);
        }

        class <>c__DisplayClass21_0<T>
        {
            /*0x0*/ UniRx.IScheduler scheduler;
            /*0x0*/ UniRx.Notification<T> <>4__this;

            /*0x380cb08*/ <>c__DisplayClass21_0();
            /*0x380bb68*/ System.IDisposable <ToObservable>b__0(System.IObserver<T> observer);
        }

        class <>c__DisplayClass21_<T>
        {
            /*0x0*/ System.IObserver<T> observer;
            /*0x0*/ UniRx.Notification.<>c__DisplayClass21_0<T> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass21_();
            /*0x380cb08*/ void <ToObservable>b__1();
        }
    }

    class Notification
    {
        static /*0x3907c14*/ UniRx.Notification<T> CreateOnNext<T>(T value);
        static /*0x382eaf0*/ UniRx.Notification<T> CreateOnError<T>(System.Exception error);
        static /*0x382dee4*/ UniRx.Notification<T> CreateOnCompleted<T>();
    }

    class BooleanNotifier : System.IObservable<bool>
    {
        /*0x10*/ UniRx.Subject<bool> boolTrigger;
        /*0x18*/ bool boolValue;

        /*0x78d9b1c*/ BooleanNotifier(bool initialValue);
        /*0x78d9ab8*/ bool get_Value();
        /*0x78d9ac0*/ void set_Value(bool value);
        /*0x78d9bb4*/ void TurnOn();
        /*0x78d9bc8*/ void TurnOff();
        /*0x78d9bdc*/ void SwitchValue();
        /*0x78d9bec*/ System.IDisposable Subscribe(System.IObserver<bool> observer);
    }

    enum CountChangedStatus
    {
        Increment = 0,
        Decrement = 1,
        Empty = 2,
        Max = 3,
    }

    class CountNotifier : System.IObservable<UniRx.CountChangedStatus>
    {
        /*0x10*/ object lockObject;
        /*0x18*/ UniRx.Subject<UniRx.CountChangedStatus> statusChanged;
        /*0x20*/ int max;
        /*0x24*/ int <Count>k__BackingField;

        /*0x78d9c5c*/ CountNotifier(int max);
        /*0x78d9c44*/ int get_Max();
        /*0x78d9c4c*/ int get_Count();
        /*0x78d9c54*/ void set_Count(int value);
        /*0x78d9d80*/ System.IDisposable Increment(int incrementCount);
        /*0x78da018*/ void Decrement(int decrementCount);
        /*0x78da19c*/ System.IDisposable Subscribe(System.IObserver<UniRx.CountChangedStatus> observer);

        class <>c__DisplayClass10_0
        {
            /*0x10*/ UniRx.CountNotifier <>4__this;
            /*0x18*/ int incrementCount;

            /*0x78da010*/ <>c__DisplayClass10_0();
            /*0x78da1f4*/ void <Increment>b__0();
        }
    }

    interface IMessagePublisher
    {
        /*0x3907c14*/ void Publish<T>(T message);
    }

    interface IMessageReceiver
    {
        /*0x380b9e8*/ System.IObservable<T> Receive<T>();
    }

    interface IMessageBroker : UniRx.IMessagePublisher, UniRx.IMessageReceiver
    {
    }

    interface IAsyncMessagePublisher
    {
        /*0x3907c14*/ System.IObservable<UniRx.Unit> PublishAsync<T>(T message);
    }

    interface IAsyncMessageReceiver
    {
        /*0x380bb68*/ System.IDisposable Subscribe<T>(System.Func<T, System.IObservable<UniRx.Unit>> asyncMessageReceiver);
    }

    interface IAsyncMessageBroker : UniRx.IAsyncMessagePublisher, UniRx.IAsyncMessageReceiver
    {
    }

    class MessageBroker : UniRx.IMessageBroker, UniRx.IMessagePublisher, UniRx.IMessageReceiver, System.IDisposable
    {
        static /*0x0*/ UniRx.IMessageBroker Default;
        /*0x10*/ bool isDisposed;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Type, object> notifiers;

        static /*0x78da3a4*/ MessageBroker();
        /*0x78da31c*/ MessageBroker();
        /*0x3907c14*/ void Publish<T>(T message);
        /*0x380b9e8*/ System.IObservable<T> Receive<T>();
        /*0x78da214*/ void Dispose();
    }

    class AsyncMessageBroker : UniRx.IAsyncMessageBroker, UniRx.IAsyncMessagePublisher, UniRx.IAsyncMessageReceiver, System.IDisposable
    {
        static /*0x0*/ UniRx.IAsyncMessageBroker Default;
        /*0x10*/ bool isDisposed;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Type, object> notifiers;

        static /*0x78da598*/ AsyncMessageBroker();
        /*0x78da510*/ AsyncMessageBroker();
        /*0x3907c14*/ System.IObservable<UniRx.Unit> PublishAsync<T>(T message);
        /*0x380bb68*/ System.IDisposable Subscribe<T>(System.Func<T, System.IObservable<UniRx.Unit>> asyncMessageReceiver);
        /*0x78da408*/ void Dispose();

        class Subscription<T> : System.IDisposable
        {
            /*0x0*/ UniRx.AsyncMessageBroker parent;
            /*0x0*/ System.Func<T, System.IObservable<UniRx.Unit>> asyncMessageReceiver;

            /*0x380d93c*/ Subscription(UniRx.AsyncMessageBroker parent, System.Func<T, System.IObservable<UniRx.Unit>> asyncMessageReceiver);
            /*0x380cb08*/ void Dispose();
        }
    }

    class ScheduledNotifier<T> : System.IObservable<T>, System.IProgress<T>
    {
        /*0x0*/ UniRx.IScheduler scheduler;
        /*0x0*/ UniRx.Subject<T> trigger;

        /*0x380cb08*/ ScheduledNotifier();
        /*0x380d83c*/ ScheduledNotifier(UniRx.IScheduler scheduler);
        /*0x3907c14*/ void Report(T value);
        /*0x3907c14*/ System.IDisposable Report(T value, System.TimeSpan dueTime);
        /*0x3907c14*/ System.IDisposable Report(T value, System.DateTimeOffset dueTime);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);

        class <>c__DisplayClass4_0<T>
        {
            /*0x0*/ UniRx.ScheduledNotifier<T> <>4__this;
            /*0x0*/ T value;

            /*0x380cb08*/ <>c__DisplayClass4_0();
            /*0x380cb08*/ void <Report>b__0();
        }

        class <>c__DisplayClass5_0<T>
        {
            /*0x0*/ UniRx.ScheduledNotifier<T> <>4__this;
            /*0x0*/ T value;

            /*0x380cb08*/ <>c__DisplayClass5_0();
            /*0x380cb08*/ void <Report>b__0();
        }

        class <>c__DisplayClass6_0<T>
        {
            /*0x0*/ UniRx.ScheduledNotifier<T> <>4__this;
            /*0x0*/ T value;

            /*0x380cb08*/ <>c__DisplayClass6_0();
            /*0x380cb08*/ void <Report>b__0();
        }
    }

    class Observer
    {
        static /*0x3830a9c*/ System.IObserver<T> CreateSubscribeObserver<T>(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
        static /*0x3907c14*/ System.IObserver<T> CreateSubscribeWithStateObserver<T, TState>(TState state, System.Action<T, TState> onNext, System.Action<System.Exception, TState> onError, System.Action<TState> onCompleted);
        static /*0x3907c14*/ System.IObserver<T> CreateSubscribeWithState2Observer<T, TState1, TState2>(TState1 state1, TState2 state2, System.Action<T, TState1, TState2> onNext, System.Action<System.Exception, TState1, TState2> onError, System.Action<TState1, TState2> onCompleted);
        static /*0x3907c14*/ System.IObserver<T> CreateSubscribeWithState3Observer<T, TState1, TState2, TState3>(TState1 state1, TState2 state2, TState3 state3, System.Action<T, TState1, TState2, TState3> onNext, System.Action<System.Exception, TState1, TState2, TState3> onError, System.Action<TState1, TState2, TState3> onCompleted);
        static /*0x382eaf0*/ System.IObserver<T> Create<T>(System.Action<T> onNext);
        static /*0x3830700*/ System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action<System.Exception> onError);
        static /*0x3830700*/ System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action onCompleted);
        static /*0x3830a9c*/ System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
        static /*0x3830700*/ System.IObserver<T> CreateAutoDetachObserver<T>(System.IObserver<T> observer, System.IDisposable disposable);

        class AnonymousObserver<T> : System.IObserver<T>
        {
            /*0x0*/ System.Action<T> onNext;
            /*0x0*/ System.Action<System.Exception> onError;
            /*0x0*/ System.Action onCompleted;
            /*0x0*/ int isStopped;

            /*0x380da4c*/ AnonymousObserver(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class EmptyOnNextAnonymousObserver<T> : System.IObserver<T>
        {
            /*0x0*/ System.Action<System.Exception> onError;
            /*0x0*/ System.Action onCompleted;
            /*0x0*/ int isStopped;

            /*0x380d93c*/ EmptyOnNextAnonymousObserver(System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class Subscribe<T> : System.IObserver<T>
        {
            /*0x0*/ System.Action<T> onNext;
            /*0x0*/ System.Action<System.Exception> onError;
            /*0x0*/ System.Action onCompleted;
            /*0x0*/ int isStopped;

            /*0x380da4c*/ Subscribe(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class Subscribe_<T> : System.IObserver<T>
        {
            /*0x0*/ System.Action<System.Exception> onError;
            /*0x0*/ System.Action onCompleted;
            /*0x0*/ int isStopped;

            /*0x380d93c*/ Subscribe_(System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class Subscribe<T, TState> : System.IObserver<T>
        {
            /*0x0*/ TState state;
            /*0x0*/ System.Action<T, TState> onNext;
            /*0x0*/ System.Action<System.Exception, TState> onError;
            /*0x0*/ System.Action<TState> onCompleted;
            /*0x0*/ int isStopped;

            /*0x3907c14*/ Subscribe(TState state, System.Action<T, TState> onNext, System.Action<System.Exception, TState> onError, System.Action<TState> onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class Subscribe<T, TState1, TState2> : System.IObserver<T>
        {
            /*0x0*/ TState1 state1;
            /*0x0*/ TState2 state2;
            /*0x0*/ System.Action<T, TState1, TState2> onNext;
            /*0x0*/ System.Action<System.Exception, TState1, TState2> onError;
            /*0x0*/ System.Action<TState1, TState2> onCompleted;
            /*0x0*/ int isStopped;

            /*0x3907c14*/ Subscribe(TState1 state1, TState2 state2, System.Action<T, TState1, TState2> onNext, System.Action<System.Exception, TState1, TState2> onError, System.Action<TState1, TState2> onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class Subscribe<T, TState1, TState2, TState3> : System.IObserver<T>
        {
            /*0x0*/ TState1 state1;
            /*0x0*/ TState2 state2;
            /*0x0*/ TState3 state3;
            /*0x0*/ System.Action<T, TState1, TState2, TState3> onNext;
            /*0x0*/ System.Action<System.Exception, TState1, TState2, TState3> onError;
            /*0x0*/ System.Action<TState1, TState2, TState3> onCompleted;
            /*0x0*/ int isStopped;

            /*0x3907c14*/ Subscribe(TState1 state1, TState2 state2, TState3 state3, System.Action<T, TState1, TState2, TState3> onNext, System.Action<System.Exception, TState1, TState2, TState3> onError, System.Action<TState1, TState2, TState3> onCompleted);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class AutoDetachObserver<T> : UniRx.Operators.OperatorObserverBase<T, T>
        {
            /*0x380d93c*/ AutoDetachObserver(System.IObserver<T> observer, System.IDisposable cancel);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }
    }

    class ObserverExtensions
    {
        static /*0x382eaf0*/ System.IObserver<T> Synchronize<T>(System.IObserver<T> observer);
        static /*0x3830700*/ System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, object gate);
    }

    class ObservableExtensions
    {
        static /*0x382eaf0*/ System.IDisposable Subscribe<T>(System.IObservable<T> source);
        static /*0x3830700*/ System.IDisposable Subscribe<T>(System.IObservable<T> source, System.Action<T> onNext);
        static /*0x3830a9c*/ System.IDisposable Subscribe<T>(System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError);
        static /*0x3830a9c*/ System.IDisposable Subscribe<T>(System.IObservable<T> source, System.Action<T> onNext, System.Action onCompleted);
        static /*0x3830bec*/ System.IDisposable Subscribe<T>(System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState<T, TState>(System.IObservable<T> source, TState state, System.Action<T, TState> onNext);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState<T, TState>(System.IObservable<T> source, TState state, System.Action<T, TState> onNext, System.Action<System.Exception, TState> onError);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState<T, TState>(System.IObservable<T> source, TState state, System.Action<T, TState> onNext, System.Action<TState> onCompleted);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState<T, TState>(System.IObservable<T> source, TState state, System.Action<T, TState> onNext, System.Action<System.Exception, TState> onError, System.Action<TState> onCompleted);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState2<T, TState1, TState2>(System.IObservable<T> source, TState1 state1, TState2 state2, System.Action<T, TState1, TState2> onNext);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState2<T, TState1, TState2>(System.IObservable<T> source, TState1 state1, TState2 state2, System.Action<T, TState1, TState2> onNext, System.Action<System.Exception, TState1, TState2> onError);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState2<T, TState1, TState2>(System.IObservable<T> source, TState1 state1, TState2 state2, System.Action<T, TState1, TState2> onNext, System.Action<TState1, TState2> onCompleted);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState2<T, TState1, TState2>(System.IObservable<T> source, TState1 state1, TState2 state2, System.Action<T, TState1, TState2> onNext, System.Action<System.Exception, TState1, TState2> onError, System.Action<TState1, TState2> onCompleted);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(System.IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, System.Action<T, TState1, TState2, TState3> onNext);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(System.IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, System.Action<T, TState1, TState2, TState3> onNext, System.Action<System.Exception, TState1, TState2, TState3> onError);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(System.IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, System.Action<T, TState1, TState2, TState3> onNext, System.Action<TState1, TState2, TState3> onCompleted);
        static /*0x3907c14*/ System.IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(System.IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, System.Action<T, TState1, TState2, TState3> onNext, System.Action<System.Exception, TState1, TState2, TState3> onError, System.Action<TState1, TState2, TState3> onCompleted);
    }

    class Stubs
    {
        static /*0x0*/ System.Action Nop;
        static /*0x8*/ System.Action<System.Exception> Throw;

        static /*0x78da5fc*/ Stubs();
        static /*0x382eaf0*/ System.IObservable<TSource> CatchIgnore<TSource>(System.Exception ex);

        class <>c
        {
            static /*0x0*/ UniRx.Stubs.<> <>9;

            static /*0x78da738*/ <>c();
            /*0x78da7a0*/ <>c();
            /*0x78da7a8*/ void <.cctor>b__3_0();
            /*0x78da7ac*/ void <.cctor>b__3_1(System.Exception ex);
        }
    }

    class Stubs<T>
    {
        static /*0x0*/ System.Action<T> Ignore;
        static /*0x0*/ System.Func<T, T> Identity;
        static /*0x0*/ System.Action<System.Exception, T> Throw;

        static /*0x38358cc*/ Stubs();

        class <>c<T>
        {
            static /*0x0*/ UniRx.Stubs.<>c<T> <>9;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            /*0x3907c14*/ void <.cctor>b__3_0(T t);
            /*0x3907c14*/ T <.cctor>b__3_1(T t);
            /*0x3907c14*/ void <.cctor>b__3_2(System.Exception ex, T _);
        }
    }

    class Stubs<T1, T2>
    {
        static /*0x0*/ System.Action<T1, T2> Ignore;
        static /*0x0*/ System.Action<System.Exception, T1, T2> Throw;

        static /*0x38358cc*/ Stubs();

        class <>c<T1, T2>
        {
            static /*0x0*/ UniRx.Stubs.<>c<T1, T2> <>9;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            /*0x3907c14*/ void <.cctor>b__2_0(T1 x, T2 y);
            /*0x3907c14*/ void <.cctor>b__2_1(System.Exception ex, T1 _, T2 __);
        }
    }

    class Stubs<T1, T2, T3>
    {
        static /*0x0*/ System.Action<T1, T2, T3> Ignore;
        static /*0x0*/ System.Action<System.Exception, T1, T2, T3> Throw;

        static /*0x38358cc*/ Stubs();

        class <>c<T1, T2, T3>
        {
            static /*0x0*/ UniRx.Stubs.<>c<T1, T2, T3> <>9;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            /*0x3907c14*/ void <.cctor>b__2_0(T1 x, T2 y, T3 z);
            /*0x3907c14*/ void <.cctor>b__2_1(System.Exception ex, T1 _, T2 __, T3 ___);
        }
    }

    struct Pair<T> : System.IEquatable<UniRx.Pair<T>>
    {
        /*0x0*/ T previous;
        /*0x0*/ T current;

        /*0x3907c14*/ Pair(T previous, T current);
        /*0x3907c14*/ T get_Previous();
        /*0x3907c14*/ T get_Current();
        /*0x380b6a0*/ int GetHashCode();
        /*0x380b2f0*/ bool Equals(object obj);
        /*0x3907c14*/ bool Equals(UniRx.Pair<T> other);
        /*0x380b9e8*/ string ToString();
    }

    class Scheduler
    {
        static /*0x0*/ UniRx.IScheduler CurrentThread;
        static /*0x8*/ UniRx.IScheduler Immediate;
        static /*0x10*/ UniRx.IScheduler ThreadPool;
        static /*0x18*/ UniRx.IScheduler mainThread;
        static /*0x20*/ UniRx.IScheduler mainThreadIgnoreTimeScale;
        static /*0x28*/ UniRx.IScheduler mainThreadFixedUpdate;
        static /*0x30*/ UniRx.IScheduler mainThreadEndOfFrame;

        static /*0x78db6c0*/ Scheduler();
        static /*0x78da7b8*/ bool get_IsCurrentThreadSchedulerScheduleRequired();
        static /*0x78da804*/ System.DateTimeOffset get_Now();
        static /*0x78da854*/ System.TimeSpan Normalize(System.TimeSpan timeSpan);
        static /*0x78da8e0*/ System.IDisposable Schedule(UniRx.IScheduler scheduler, System.DateTimeOffset dueTime, System.Action action);
        static /*0x78daa44*/ System.IDisposable Schedule(UniRx.IScheduler scheduler, System.Action<System.Action> action);
        static /*0x78dac54*/ System.IDisposable Schedule(UniRx.IScheduler scheduler, System.TimeSpan dueTime, System.Action<System.Action<System.TimeSpan>> action);
        static /*0x78dae74*/ System.IDisposable Schedule(UniRx.IScheduler scheduler, System.DateTimeOffset dueTime, System.Action<System.Action<System.DateTimeOffset>> action);
        static /*0x78db05c*/ void SetDefaultForUnity();
        static /*0x78db1f8*/ UniRx.IScheduler get_MainThread();
        static /*0x78db358*/ UniRx.IScheduler get_MainThreadIgnoreTimeScale();
        static /*0x78db4b8*/ UniRx.IScheduler get_MainThreadFixedUpdate();
        static /*0x78db5bc*/ UniRx.IScheduler get_MainThreadEndOfFrame();

        class CurrentThreadScheduler : UniRx.IScheduler
        {
            [ThreadStatic] static UniRx.InternalUtil.SchedulerQueue s_threadLocalQueue;
            [ThreadStatic] static System.Diagnostics.Stopwatch s_clock;

            static /*0x78db7d4*/ UniRx.InternalUtil.SchedulerQueue GetQueue();
            static /*0x78db81c*/ void SetQueue(UniRx.InternalUtil.SchedulerQueue newQueue);
            static /*0x78db874*/ System.TimeSpan get_Time();
            static /*0x78da7bc*/ bool get_IsScheduleRequired();
            /*0x78db7bc*/ CurrentThreadScheduler();
            /*0x78db92c*/ System.IDisposable Schedule(System.Action action);
            /*0x78db98c*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
            /*0x78dbd6c*/ System.DateTimeOffset get_Now();

            class Trampoline
            {
                static /*0x78dbc78*/ void Run(UniRx.InternalUtil.SchedulerQueue queue);
            }
        }

        class ImmediateScheduler : UniRx.IScheduler
        {
            /*0x78db7c4*/ ImmediateScheduler();
            /*0x78dbdb8*/ System.DateTimeOffset get_Now();
            /*0x78dbe04*/ System.IDisposable Schedule(System.Action action);
            /*0x78dbe78*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
        }

        class DefaultSchedulers
        {
            static /*0x0*/ UniRx.IScheduler constantTime;
            static /*0x8*/ UniRx.IScheduler tailRecursion;
            static /*0x10*/ UniRx.IScheduler iteration;
            static /*0x18*/ UniRx.IScheduler timeBasedOperations;
            static /*0x20*/ UniRx.IScheduler asyncConversions;

            static /*0x78dbf64*/ UniRx.IScheduler get_ConstantTimeOperations();
            static /*0x78dc000*/ void set_ConstantTimeOperations(UniRx.IScheduler value);
            static /*0x78dc058*/ UniRx.IScheduler get_TailRecursion();
            static /*0x78dc0f0*/ void set_TailRecursion(UniRx.IScheduler value);
            static /*0x78d3150*/ UniRx.IScheduler get_Iteration();
            static /*0x78dc140*/ void set_Iteration(UniRx.IScheduler value);
            static /*0x78d38f4*/ UniRx.IScheduler get_TimeBasedOperations();
            static /*0x78dc190*/ void set_TimeBasedOperations(UniRx.IScheduler value);
            static /*0x78d32ec*/ UniRx.IScheduler get_AsyncConversions();
            static /*0x78dc1e0*/ void set_AsyncConversions(UniRx.IScheduler value);
            static /*0x78dc230*/ void SetDotNetCompatible();
        }

        class ThreadPoolScheduler : UniRx.IScheduler, UniRx.ISchedulerPeriodic
        {
            /*0x78db7cc*/ ThreadPoolScheduler();
            /*0x78dc3d0*/ System.DateTimeOffset get_Now();
            /*0x78dc41c*/ System.IDisposable Schedule(System.Action action);
            /*0x78dc528*/ System.IDisposable Schedule(System.DateTimeOffset dueTime, System.Action action);
            /*0x78dc5b4*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
            /*0x78dc940*/ System.IDisposable SchedulePeriodic(System.TimeSpan period, System.Action action);
            /*0x3907c14*/ void ScheduleQueueing<T>(UniRx.ICancelable cancel, T state, System.Action<T> action);

            class Timer : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.HashSet<System.Threading.Timer> s_timers;
                /*0x10*/ UniRx.SingleAssignmentDisposable _disposable;
                /*0x18*/ System.Action _action;
                /*0x20*/ System.Threading.Timer _timer;
                /*0x28*/ bool _hasAdded;
                /*0x29*/ bool _hasRemoved;

                static /*0x78dcea0*/ Timer();
                /*0x78dc61c*/ Timer(System.TimeSpan dueTime, System.Action action);
                /*0x78dcbf0*/ void Tick(object state);
                /*0x78dccac*/ void Unroot();
                /*0x78dce88*/ void Dispose();
            }

            class PeriodicTimer : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.HashSet<System.Threading.Timer> s_timers;
                /*0x10*/ System.Action _action;
                /*0x18*/ System.Threading.Timer _timer;
                /*0x20*/ UniRx.InternalUtil.AsyncLock _gate;

                static /*0x78dd19c*/ PeriodicTimer();
                /*0x78dc9a8*/ PeriodicTimer(System.TimeSpan period, System.Action action);
                /*0x78dcf38*/ void Tick(object state);
                /*0x78dcfc8*/ void Dispose();
                /*0x78dd234*/ void <Tick>b__5_0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UniRx.BooleanDisposable d;
                /*0x18*/ System.Action action;

                /*0x78dc520*/ <>c__DisplayClass3_0();
                /*0x78dd258*/ void <Schedule>b__0(object _);
            }

            class <>c__DisplayClass7_0<T>
            {
                /*0x0*/ UniRx.ICancelable cancel;
                /*0x0*/ System.Action<T> action;

                /*0x380cb08*/ <>c__DisplayClass7_0();
                /*0x380d83c*/ void <ScheduleQueueing>b__0(object callBackState);
            }
        }

        class MainThreadScheduler : UniRx.IScheduler, UniRx.ISchedulerPeriodic, UniRx.ISchedulerQueueing
        {
            /*0x10*/ System.Action<object> scheduleAction;

            /*0x78db2a0*/ MainThreadScheduler();
            /*0x78dd4d0*/ System.Collections.IEnumerator DelayAction(System.TimeSpan dueTime, System.Action action, UniRx.ICancelable cancellation);
            /*0x78dd588*/ System.Collections.IEnumerator PeriodicAction(System.TimeSpan period, System.Action action, UniRx.ICancelable cancellation);
            /*0x78dd640*/ System.DateTimeOffset get_Now();
            /*0x78dd68c*/ void Schedule(object state);
            /*0x78dd750*/ System.IDisposable Schedule(System.Action action);
            /*0x78dd8b8*/ System.IDisposable Schedule(System.DateTimeOffset dueTime, System.Action action);
            /*0x78dd944*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
            /*0x78ddb80*/ System.IDisposable SchedulePeriodic(System.TimeSpan period, System.Action action);
            /*0x380d83c*/ void ScheduleQueueing<T>(object state);
            /*0x3907c14*/ void ScheduleQueueing<T>(UniRx.ICancelable cancel, T state, System.Action<T> action);

            class QueuedAction<T>
            {
                static /*0x0*/ System.Action<object> Instance;

                static /*0x38358cc*/ QueuedAction();
                static /*0x3837da0*/ void Invoke(object state);
            }

            class <DelayAction>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan dueTime;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;

                /*0x78dd560*/ <DelayAction>d__2(int <>1__state);
                /*0x78ddc54*/ void System.IDisposable.Dispose();
                /*0x78ddc58*/ bool MoveNext();
                /*0x78ddf48*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78ddf50*/ void System.Collections.IEnumerator.Reset();
                /*0x78ddf88*/ object System.Collections.IEnumerator.get_Current();
            }

            class <PeriodicAction>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan period;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ UnityEngine.WaitForSeconds <yieldInstruction>5__2;

                /*0x78dd618*/ <PeriodicAction>d__3(int <>1__state);
                /*0x78ddf90*/ void System.IDisposable.Dispose();
                /*0x78ddf94*/ bool MoveNext();
                /*0x78de228*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78de230*/ void System.Collections.IEnumerator.Reset();
                /*0x78de268*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class IgnoreTimeScaleMainThreadScheduler : UniRx.IScheduler, UniRx.ISchedulerPeriodic, UniRx.ISchedulerQueueing
        {
            /*0x10*/ System.Action<object> scheduleAction;

            /*0x78db400*/ IgnoreTimeScaleMainThreadScheduler();
            /*0x78de270*/ System.Collections.IEnumerator DelayAction(System.TimeSpan dueTime, System.Action action, UniRx.ICancelable cancellation);
            /*0x78de328*/ System.Collections.IEnumerator PeriodicAction(System.TimeSpan period, System.Action action, UniRx.ICancelable cancellation);
            /*0x78de3e0*/ System.DateTimeOffset get_Now();
            /*0x78de42c*/ void Schedule(object state);
            /*0x78de4f0*/ System.IDisposable Schedule(System.Action action);
            /*0x78de5bc*/ System.IDisposable Schedule(System.DateTimeOffset dueTime, System.Action action);
            /*0x78de648*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
            /*0x78de71c*/ System.IDisposable SchedulePeriodic(System.TimeSpan period, System.Action action);
            /*0x3907c14*/ void ScheduleQueueing<T>(UniRx.ICancelable cancel, T state, System.Action<T> action);

            class QueuedAction<T>
            {
                static /*0x0*/ System.Action<object> Instance;

                static /*0x38358cc*/ QueuedAction();
                static /*0x3837da0*/ void Invoke(object state);
            }

            class <DelayAction>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan dueTime;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ float <elapsed>5__2;
                /*0x3c*/ float <dt>5__3;

                /*0x78de300*/ <DelayAction>d__2(int <>1__state);
                /*0x78de7f0*/ void System.IDisposable.Dispose();
                /*0x78de7f4*/ bool MoveNext();
                /*0x78dea48*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78dea50*/ void System.Collections.IEnumerator.Reset();
                /*0x78dea88*/ object System.Collections.IEnumerator.get_Current();
            }

            class <PeriodicAction>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan period;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ float <elapsed>5__2;
                /*0x3c*/ float <dt>5__3;

                /*0x78de3b8*/ <PeriodicAction>d__3(int <>1__state);
                /*0x78dea90*/ void System.IDisposable.Dispose();
                /*0x78dea94*/ bool MoveNext();
                /*0x78ded0c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78ded14*/ void System.Collections.IEnumerator.Reset();
                /*0x78ded4c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedUpdateMainThreadScheduler : UniRx.IScheduler, UniRx.ISchedulerPeriodic, UniRx.ISchedulerQueueing
        {
            /*0x78db560*/ FixedUpdateMainThreadScheduler();
            /*0x3907c14*/ System.Collections.IEnumerator ImmediateAction<T>(T state, System.Action<T> action, UniRx.ICancelable cancellation);
            /*0x78ded54*/ System.Collections.IEnumerator DelayAction(System.TimeSpan dueTime, System.Action action, UniRx.ICancelable cancellation);
            /*0x78dee0c*/ System.Collections.IEnumerator PeriodicAction(System.TimeSpan period, System.Action action, UniRx.ICancelable cancellation);
            /*0x78deec4*/ System.DateTimeOffset get_Now();
            /*0x78def10*/ System.IDisposable Schedule(System.Action action);
            /*0x78df044*/ System.IDisposable Schedule(System.DateTimeOffset dueTime, System.Action action);
            /*0x78def70*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
            /*0x78df188*/ System.IDisposable SchedulePeriodic(System.TimeSpan period, System.Action action);
            /*0x3907c14*/ void ScheduleQueueing<T>(UniRx.ICancelable cancel, T state, System.Action<T> action);

            class <DelayAction>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan dueTime;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ float <startTime>5__2;
                /*0x3c*/ float <dt>5__3;

                /*0x78dede4*/ <DelayAction>d__2(int <>1__state);
                /*0x78df25c*/ void System.IDisposable.Dispose();
                /*0x78df260*/ bool MoveNext();
                /*0x78df4ac*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78df4b4*/ void System.Collections.IEnumerator.Reset();
                /*0x78df4ec*/ object System.Collections.IEnumerator.get_Current();
            }

            class <ImmediateAction>d__<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ object <>2__current;
                /*0x0*/ UniRx.ICancelable cancellation;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ T state;

                /*0x380cffc*/ <ImmediateAction>d__(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            }

            class <PeriodicAction>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan period;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ float <startTime>5__2;
                /*0x3c*/ float <dt>5__3;

                /*0x78dee9c*/ <PeriodicAction>d__3(int <>1__state);
                /*0x78df4f4*/ void System.IDisposable.Dispose();
                /*0x78df4f8*/ bool MoveNext();
                /*0x78df774*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78df77c*/ void System.Collections.IEnumerator.Reset();
                /*0x78df7b4*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class EndOfFrameMainThreadScheduler : UniRx.IScheduler, UniRx.ISchedulerPeriodic, UniRx.ISchedulerQueueing
        {
            /*0x78db664*/ EndOfFrameMainThreadScheduler();
            /*0x3907c14*/ System.Collections.IEnumerator ImmediateAction<T>(T state, System.Action<T> action, UniRx.ICancelable cancellation);
            /*0x78df7bc*/ System.Collections.IEnumerator DelayAction(System.TimeSpan dueTime, System.Action action, UniRx.ICancelable cancellation);
            /*0x78df874*/ System.Collections.IEnumerator PeriodicAction(System.TimeSpan period, System.Action action, UniRx.ICancelable cancellation);
            /*0x78df92c*/ System.DateTimeOffset get_Now();
            /*0x78df978*/ System.IDisposable Schedule(System.Action action);
            /*0x78dfaac*/ System.IDisposable Schedule(System.DateTimeOffset dueTime, System.Action action);
            /*0x78df9d8*/ System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
            /*0x78dfbf0*/ System.IDisposable SchedulePeriodic(System.TimeSpan period, System.Action action);
            /*0x3907c14*/ void ScheduleQueueing<T>(UniRx.ICancelable cancel, T state, System.Action<T> action);

            class <DelayAction>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan dueTime;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ float <elapsed>5__2;
                /*0x3c*/ float <dt>5__3;

                /*0x78df84c*/ <DelayAction>d__2(int <>1__state);
                /*0x78dfcc4*/ void System.IDisposable.Dispose();
                /*0x78dfcc8*/ bool MoveNext();
                /*0x78dff1c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78dff24*/ void System.Collections.IEnumerator.Reset();
                /*0x78dff5c*/ object System.Collections.IEnumerator.get_Current();
            }

            class <ImmediateAction>d__<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ object <>2__current;
                /*0x0*/ UniRx.ICancelable cancellation;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ T state;

                /*0x380cffc*/ <ImmediateAction>d__(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            }

            class <PeriodicAction>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.TimeSpan period;
                /*0x28*/ UniRx.ICancelable cancellation;
                /*0x30*/ System.Action action;
                /*0x38*/ float <elapsed>5__2;
                /*0x3c*/ float <dt>5__3;

                /*0x78df904*/ <PeriodicAction>d__3(int <>1__state);
                /*0x78dff64*/ void System.IDisposable.Dispose();
                /*0x78dff68*/ bool MoveNext();
                /*0x78e01e0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x78e01e8*/ void System.Collections.IEnumerator.Reset();
                /*0x78e0220*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ System.Action<System.Action> action;
            /*0x18*/ UniRx.IScheduler scheduler;
            /*0x20*/ object gate;
            /*0x28*/ UniRx.CompositeDisposable group;
            /*0x30*/ System.Action recursiveAction;
            /*0x38*/ System.Action <>9__1;

            /*0x78dac4c*/ <>c__DisplayClass11_0();
            /*0x78e0228*/ void <Schedule>b__0();
            /*0x78e02d8*/ void <Schedule>b__1();
        }

        class <>c__DisplayClass11_1
        {
            /*0x10*/ bool isAdded;
            /*0x18*/ System.IDisposable d;
            /*0x20*/ bool isDone;
            /*0x28*/ UniRx.Scheduler.<> CS$<>8__locals1;

            /*0x78e0508*/ <>c__DisplayClass11_1();
            /*0x78e0510*/ void <Schedule>b__2();
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ System.Action<System.Action<System.TimeSpan>> action;
            /*0x18*/ UniRx.IScheduler scheduler;
            /*0x20*/ object gate;
            /*0x28*/ UniRx.CompositeDisposable group;
            /*0x30*/ System.Action recursiveAction;
            /*0x38*/ System.Action<System.TimeSpan> <>9__1;

            /*0x78dae6c*/ <>c__DisplayClass12_0();
            /*0x78e064c*/ void <Schedule>b__0();
            /*0x78e06fc*/ void <Schedule>b__1(System.TimeSpan dt);
        }

        class <>c__DisplayClass12_1
        {
            /*0x10*/ bool isAdded;
            /*0x18*/ System.IDisposable d;
            /*0x20*/ bool isDone;
            /*0x28*/ UniRx.Scheduler.<> CS$<>8__locals1;

            /*0x78e093c*/ <>c__DisplayClass12_1();
            /*0x78e0944*/ void <Schedule>b__2();
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Action<System.Action<System.DateTimeOffset>> action;
            /*0x18*/ UniRx.IScheduler scheduler;
            /*0x20*/ object gate;
            /*0x28*/ UniRx.CompositeDisposable group;
            /*0x30*/ System.Action recursiveAction;
            /*0x38*/ System.Action<System.DateTimeOffset> <>9__1;

            /*0x78db054*/ <>c__DisplayClass13_0();
            /*0x78e0a80*/ void <Schedule>b__0();
            /*0x78e0b30*/ void <Schedule>b__1(System.DateTimeOffset dt);
        }

        class <>c__DisplayClass13_1
        {
            /*0x10*/ bool isAdded;
            /*0x18*/ System.IDisposable d;
            /*0x20*/ bool isDone;
            /*0x28*/ UniRx.Scheduler.<> CS$<>8__locals1;

            /*0x78e0d38*/ <>c__DisplayClass13_1();
            /*0x78e0d40*/ void <Schedule>b__2();
        }
    }

    interface IScheduler
    {
        System.DateTimeOffset get_Now();
        /*0x380bb68*/ System.IDisposable Schedule(System.Action action);
        System.IDisposable Schedule(System.TimeSpan dueTime, System.Action action);
    }

    interface ISchedulerPeriodic
    {
        System.IDisposable SchedulePeriodic(System.TimeSpan period, System.Action action);
    }

    interface ISchedulerLongRunning
    {
        /*0x380bb68*/ System.IDisposable ScheduleLongRunning(System.Action<UniRx.ICancelable> action);
    }

    interface ISchedulerQueueing
    {
        /*0x3907c14*/ void ScheduleQueueing<T>(UniRx.ICancelable cancel, T state, System.Action<T> action);
    }

    class AsyncSubject<T> : UniRx.ISubject<T>, UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>, UniRx.IOptimizedObservable<T>, System.IDisposable, System.Runtime.CompilerServices.INotifyCompletion
    {
        /*0x0*/ object observerLock;
        /*0x0*/ T lastValue;
        /*0x0*/ bool hasValue;
        /*0x0*/ bool isStopped;
        /*0x0*/ bool isDisposed;
        /*0x0*/ System.Exception lastError;
        /*0x0*/ System.IObserver<T> outObserver;

        /*0x380cb08*/ AsyncSubject();
        /*0x3907c14*/ T get_Value();
        /*0x380b128*/ bool get_HasObservers();
        /*0x380b128*/ bool get_IsCompleted();
        /*0x380cb08*/ void OnCompleted();
        /*0x380d83c*/ void OnError(System.Exception error);
        /*0x3907c14*/ void OnNext(T value);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380cb08*/ void Dispose();
        /*0x380cb08*/ void ThrowIfDisposed();
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
        /*0x380b9e8*/ UniRx.AsyncSubject<T> GetAwaiter();
        /*0x380d83c*/ void OnCompleted(System.Action continuation);
        void OnCompleted(System.Action continuation, bool originalContext);
        /*0x3907c14*/ T GetResult();

        class Subscription<T> : System.IDisposable
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.AsyncSubject<T> parent;
            /*0x0*/ System.IObserver<T> unsubscribeTarget;

            /*0x380d93c*/ Subscription(UniRx.AsyncSubject<T> parent, System.IObserver<T> unsubscribeTarget);
            /*0x380cb08*/ void Dispose();
        }

        class AwaitObserver<T> : System.IObserver<T>
        {
            /*0x0*/ System.Threading.SynchronizationContext _context;
            /*0x0*/ System.Action _callback;

            AwaitObserver(System.Action callback, bool originalContext);
            /*0x380cb08*/ void OnCompleted();
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380cb08*/ void InvokeOnOriginalContext();

            class <>c<T>
            {
                static /*0x0*/ UniRx.AsyncSubject.AwaitObserver.<>c<T> <>9;
                static /*0x0*/ System.Threading.SendOrPostCallback <>9__6_0;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380d83c*/ void <InvokeOnOriginalContext>b__6_0(object c);
            }
        }

        class <>c__DisplayClass25_0<T>
        {
            /*0x0*/ System.Threading.ManualResetEvent e;

            /*0x380cb08*/ <>c__DisplayClass25_0();
            /*0x380cb08*/ void <GetResult>b__0();
        }
    }

    class BehaviorSubject<T> : UniRx.ISubject<T>, UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>, System.IDisposable, UniRx.IOptimizedObservable<T>
    {
        /*0x0*/ object observerLock;
        /*0x0*/ bool isStopped;
        /*0x0*/ bool isDisposed;
        /*0x0*/ T lastValue;
        /*0x0*/ System.Exception lastError;
        /*0x0*/ System.IObserver<T> outObserver;

        /*0x3907c14*/ BehaviorSubject(T defaultValue);
        /*0x3907c14*/ T get_Value();
        /*0x380b128*/ bool get_HasObservers();
        /*0x380cb08*/ void OnCompleted();
        /*0x380d83c*/ void OnError(System.Exception error);
        /*0x3907c14*/ void OnNext(T value);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380cb08*/ void Dispose();
        /*0x380cb08*/ void ThrowIfDisposed();
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();

        class Subscription<T> : System.IDisposable
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.BehaviorSubject<T> parent;
            /*0x0*/ System.IObserver<T> unsubscribeTarget;

            /*0x380d93c*/ Subscription(UniRx.BehaviorSubject<T> parent, System.IObserver<T> unsubscribeTarget);
            /*0x380cb08*/ void Dispose();
        }
    }

    interface IConnectableObservable<T> : System.IObservable<T>
    {
        /*0x380b9e8*/ System.IDisposable Connect();
    }

    interface ISubject<TSource, TResult> : System.IObserver<TSource>, System.IObservable<TResult>
    {
    }

    interface ISubject<T> : UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>
    {
    }

    class ReplaySubject<T> : UniRx.ISubject<T>, UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>, UniRx.IOptimizedObservable<T>, System.IDisposable
    {
        /*0x0*/ object observerLock;
        /*0x0*/ bool isStopped;
        /*0x0*/ bool isDisposed;
        /*0x0*/ System.Exception lastError;
        /*0x0*/ System.IObserver<T> outObserver;
        /*0x0*/ int bufferSize;
        /*0x0*/ System.TimeSpan window;
        /*0x0*/ System.DateTimeOffset startTime;
        /*0x0*/ UniRx.IScheduler scheduler;
        /*0x0*/ System.Collections.Generic.Queue<UniRx.TimeInterval<T>> queue;

        /*0x380cb08*/ ReplaySubject();
        /*0x380d83c*/ ReplaySubject(UniRx.IScheduler scheduler);
        /*0x380cffc*/ ReplaySubject(int bufferSize);
        /*0x380d170*/ ReplaySubject(int bufferSize, UniRx.IScheduler scheduler);
        /*0x380e1ac*/ ReplaySubject(System.TimeSpan window);
        /*0x3907c14*/ ReplaySubject(System.TimeSpan window, UniRx.IScheduler scheduler);
        /*0x3907c14*/ ReplaySubject(int bufferSize, System.TimeSpan window, UniRx.IScheduler scheduler);
        /*0x380cb08*/ void Trim();
        /*0x380cb08*/ void OnCompleted();
        /*0x380d83c*/ void OnError(System.Exception error);
        /*0x3907c14*/ void OnNext(T value);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380cb08*/ void Dispose();
        /*0x380cb08*/ void ThrowIfDisposed();
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();

        class Subscription<T> : System.IDisposable
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.ReplaySubject<T> parent;
            /*0x0*/ System.IObserver<T> unsubscribeTarget;

            /*0x380d93c*/ Subscription(UniRx.ReplaySubject<T> parent, System.IObserver<T> unsubscribeTarget);
            /*0x380cb08*/ void Dispose();
        }
    }

    class Subject<T> : UniRx.ISubject<T>, UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>, System.IDisposable, UniRx.IOptimizedObservable<T>
    {
        /*0x0*/ object observerLock;
        /*0x0*/ bool isStopped;
        /*0x0*/ bool isDisposed;
        /*0x0*/ System.Exception lastError;
        /*0x0*/ System.IObserver<T> outObserver;

        /*0x380cb08*/ Subject();
        /*0x380b128*/ bool get_HasObservers();
        /*0x380cb08*/ void OnCompleted();
        /*0x380d83c*/ void OnError(System.Exception error);
        /*0x3907c14*/ void OnNext(T value);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380cb08*/ void Dispose();
        /*0x380cb08*/ void ThrowIfDisposed();
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();

        class Subscription<T> : System.IDisposable
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.Subject<T> parent;
            /*0x0*/ System.IObserver<T> unsubscribeTarget;

            /*0x380d93c*/ Subscription(UniRx.Subject<T> parent, System.IObserver<T> unsubscribeTarget);
            /*0x380cb08*/ void Dispose();
        }
    }

    class SubjectExtensions
    {
        static /*0x382eaf0*/ UniRx.ISubject<T> Synchronize<T>(UniRx.ISubject<T> subject);
        static /*0x3830700*/ UniRx.ISubject<T> Synchronize<T>(UniRx.ISubject<T> subject, object gate);

        class AnonymousSubject<T, U> : UniRx.ISubject<T, U>, System.IObserver<T>, System.IObservable<U>
        {
            /*0x0*/ System.IObserver<T> observer;
            /*0x0*/ System.IObservable<U> observable;

            /*0x380d93c*/ AnonymousSubject(System.IObserver<T> observer, System.IObservable<U> observable);
            /*0x380cb08*/ void OnCompleted();
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<U> observer);
        }

        class AnonymousSubject<T> : UniRx.SubjectExtensions.AnonymousSubject<T, T>, UniRx.ISubject<T>, UniRx.ISubject<T, T>, System.IObserver<T>, System.IObservable<T>
        {
            /*0x380d93c*/ AnonymousSubject(System.IObserver<T> observer, System.IObservable<T> observable);
        }
    }

    interface IGroupedObservable<TKey, TElement> : System.IObservable<TElement>
    {
        /*0x3907c14*/ TKey get_Key();
    }

    interface IOptimizedObservable<T> : System.IObservable<T>
    {
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
    }

    class OptimizedObservableExtensions
    {
        static /*0x381ac0c*/ bool IsRequiredSubscribeOnCurrentThread<T>(System.IObservable<T> source);
        static /*0x381cca4*/ bool IsRequiredSubscribeOnCurrentThread<T>(System.IObservable<T> source, UniRx.IScheduler scheduler);
    }

    struct Unit : System.IEquatable<UniRx.Unit>
    {
        static /*0x0*/ UniRx.Unit default;

        static /*0x78e0f90*/ Unit();
        static /*0x78e0e7c*/ UniRx.Unit get_Default();
        static /*0x78e0ed4*/ bool op_Equality(UniRx.Unit first, UniRx.Unit second);
        static /*0x78e0edc*/ bool op_Inequality(UniRx.Unit first, UniRx.Unit second);
        /*0x78e0ee4*/ bool Equals(UniRx.Unit other);
        /*0x78e0eec*/ bool Equals(object obj);
        /*0x78e0f48*/ int GetHashCode();
        /*0x78e0f50*/ string ToString();
    }

    class TaskObservableExtensions
    {
        static /*0x78e0f94*/ System.IObservable<UniRx.Unit> ToObservable(System.Threading.Tasks.Task task);
        static /*0x78e1208*/ System.IObservable<UniRx.Unit> ToObservable(System.Threading.Tasks.Task task, UniRx.IScheduler scheduler);
        static /*0x78e0fec*/ System.IObservable<UniRx.Unit> ToObservableImpl(System.Threading.Tasks.Task task, UniRx.IScheduler scheduler);
        static /*0x78e1284*/ System.IObservable<UniRx.Unit> ToObservableSlow(System.Threading.Tasks.Task task, UniRx.IScheduler scheduler);
        static /*0x78e1400*/ void ToObservableDone(System.Threading.Tasks.Task task, System.IObserver<UniRx.Unit> subject);
        static /*0x382eaf0*/ System.IObservable<TResult> ToObservable<TResult>(System.Threading.Tasks.Task<TResult> task);
        static /*0x3830700*/ System.IObservable<TResult> ToObservable<TResult>(System.Threading.Tasks.Task<TResult> task, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<TResult> ToObservableImpl<TResult>(System.Threading.Tasks.Task<TResult> task, UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<TResult> ToObservableSlow<TResult>(System.Threading.Tasks.Task<TResult> task, UniRx.IScheduler scheduler);
        static /*0x383af28*/ void ToObservableDone<TResult>(System.Threading.Tasks.Task<TResult> task, System.IObserver<TResult> subject);
        static /*0x78e13f0*/ System.Threading.Tasks.TaskContinuationOptions GetTaskContinuationOptions(UniRx.IScheduler scheduler);
        static /*0x3830700*/ System.IObservable<TResult> ToObservableResult<TResult>(UniRx.AsyncSubject<TResult> subject, UniRx.IScheduler scheduler);
        static /*0x382eaf0*/ System.Threading.Tasks.Task<TResult> ToTask<TResult>(System.IObservable<TResult> observable);
        static /*0x3830700*/ System.Threading.Tasks.Task<TResult> ToTask<TResult>(System.IObservable<TResult> observable, object state);
        static /*0x382fdd8*/ System.Threading.Tasks.Task<TResult> ToTask<TResult>(System.IObservable<TResult> observable, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ System.Threading.Tasks.Task<TResult> ToTask<TResult>(System.IObservable<TResult> observable, System.Threading.CancellationToken cancellationToken, object state);

        class <>c__DisplayClass15_0<TResult>
        {
            /*0x0*/ UniRx.SingleAssignmentDisposable disposable;
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<TResult> tcs;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ bool hasValue;
            /*0x0*/ TResult lastValue;
            /*0x0*/ System.Threading.CancellationTokenRegistration ctr;

            /*0x380cb08*/ <>c__DisplayClass15_0();
            /*0x380cb08*/ void <ToTask>b__0();
            /*0x3907c14*/ void <ToTask>b__1(TResult value);
            /*0x380d83c*/ void <ToTask>b__2(System.Exception ex);
            /*0x380cb08*/ void <ToTask>b__3();
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ System.Threading.Tasks.Task task;
            /*0x18*/ UniRx.AsyncSubject<UniRx.Unit> subject;

            /*0x78e13e8*/ <>c__DisplayClass3_0();
            /*0x78e1688*/ void <ToObservableSlow>b__0(System.Threading.Tasks.Task t);
        }

        class <>c__DisplayClass8_0<TResult>
        {
            /*0x0*/ System.Threading.Tasks.Task<TResult> task;
            /*0x0*/ UniRx.AsyncSubject<TResult> subject;

            /*0x380cb08*/ <>c__DisplayClass8_0();
            /*0x380d83c*/ void <ToObservableSlow>b__0(System.Threading.Tasks.Task<TResult> t);
        }
    }

    struct TimeInterval<T> : System.IEquatable<UniRx.TimeInterval<T>>
    {
        /*0x0*/ System.TimeSpan _interval;
        /*0x0*/ T _value;

        static /*0x3907c14*/ bool op_Equality(UniRx.TimeInterval<T> first, UniRx.TimeInterval<T> second);
        static /*0x3907c14*/ bool op_Inequality(UniRx.TimeInterval<T> first, UniRx.TimeInterval<T> second);
        /*0x3907c14*/ TimeInterval(T value, System.TimeSpan interval);
        /*0x3907c14*/ T get_Value();
        /*0x380c718*/ System.TimeSpan get_Interval();
        /*0x3907c14*/ bool Equals(UniRx.TimeInterval<T> other);
        /*0x380b2f0*/ bool Equals(object obj);
        /*0x380b6a0*/ int GetHashCode();
        /*0x380b9e8*/ string ToString();
    }

    struct Timestamped<T> : System.IEquatable<UniRx.Timestamped<T>>
    {
        /*0x0*/ System.DateTimeOffset _timestamp;
        /*0x0*/ T _value;

        static /*0x3907c14*/ bool op_Equality(UniRx.Timestamped<T> first, UniRx.Timestamped<T> second);
        static /*0x3907c14*/ bool op_Inequality(UniRx.Timestamped<T> first, UniRx.Timestamped<T> second);
        /*0x3907c14*/ Timestamped(T value, System.DateTimeOffset timestamp);
        /*0x3907c14*/ T get_Value();
        System.DateTimeOffset get_Timestamp();
        /*0x3907c14*/ bool Equals(UniRx.Timestamped<T> other);
        /*0x380b2f0*/ bool Equals(object obj);
        /*0x380b6a0*/ int GetHashCode();
        /*0x380b9e8*/ string ToString();
    }

    class Timestamped
    {
        static /*0x3907c14*/ UniRx.Timestamped<T> Create<T>(T value, System.DateTimeOffset timestamp);
    }

    class AsyncOperationExtensions
    {
        static /*0x78e1694*/ System.IObservable<UnityEngine.AsyncOperation> AsObservable(UnityEngine.AsyncOperation asyncOperation, System.IProgress<float> progress);
        static /*0x3907c14*/ System.IObservable<T> AsAsyncOperationObservable<T>(T asyncOperation, System.IProgress<float> progress);
        static /*0x3907c14*/ System.Collections.IEnumerator AsObservableCore<T>(T asyncOperation, System.IObserver<T> observer, System.IProgress<float> reportProgress, System.Threading.CancellationToken cancel);

        class <>c__DisplayClass0_0
        {
            /*0x10*/ UnityEngine.AsyncOperation asyncOperation;
            /*0x18*/ System.IProgress<float> progress;

            /*0x78e17a8*/ <>c__DisplayClass0_0();
            /*0x78e17b0*/ System.Collections.IEnumerator <AsObservable>b__0(System.IObserver<UnityEngine.AsyncOperation> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass1_0<T>
        {
            /*0x0*/ T asyncOperation;
            /*0x0*/ System.IProgress<float> progress;

            /*0x380cb08*/ <>c__DisplayClass1_0();
            /*0x380bc30*/ System.Collections.IEnumerator <AsAsyncOperationObservable>b__0(System.IObserver<T> observer, System.Threading.CancellationToken cancellation);
        }

        class <AsObservableCore>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ System.IProgress<float> reportProgress;
            /*0x0*/ T asyncOperation;
            /*0x0*/ System.IObserver<T> observer;
            /*0x0*/ System.Threading.CancellationToken cancel;

            /*0x380cffc*/ <AsObservableCore>d__2(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class CoroutineAsyncBridge : System.Runtime.CompilerServices.INotifyCompletion
    {
        /*0x10*/ System.Action continuation;
        /*0x18*/ bool <IsCompleted>k__BackingField;

        static /*0x3907c14*/ UniRx.CoroutineAsyncBridge Start<T>(T awaitTarget);
        /*0x78e1824*/ CoroutineAsyncBridge();
        /*0x78e1810*/ bool get_IsCompleted();
        /*0x78e1818*/ void set_IsCompleted(bool value);
        /*0x3907c14*/ System.Collections.IEnumerator Run<T>(T target);
        /*0x78e1840*/ void OnCompleted(System.Action continuation);
        /*0x78e1848*/ void GetResult();

        class <Run>d__7<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T target;
            /*0x0*/ UniRx.CoroutineAsyncBridge <>4__this;

            /*0x380cffc*/ <Run>d__7(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class CoroutineAsyncBridge<T> : System.Runtime.CompilerServices.INotifyCompletion
    {
        /*0x0*/ T result;
        /*0x0*/ System.Action continuation;
        /*0x0*/ bool <IsCompleted>k__BackingField;

        static /*0x3907c14*/ UniRx.CoroutineAsyncBridge<T> Start(T awaitTarget);
        /*0x3907c14*/ CoroutineAsyncBridge(T result);
        /*0x380b128*/ bool get_IsCompleted();
        /*0x380cdf0*/ void set_IsCompleted(bool value);
        /*0x3907c14*/ System.Collections.IEnumerator Run(T target);
        /*0x380d83c*/ void OnCompleted(System.Action continuation);
        /*0x3907c14*/ T GetResult();

        class <Run>d__8<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T target;
            /*0x0*/ UniRx.CoroutineAsyncBridge<T> <>4__this;

            /*0x380cffc*/ <Run>d__8(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class CoroutineAsyncExtensions
    {
        static /*0x78e18a4*/ UniRx.CoroutineAsyncBridge GetAwaiter(UnityEngine.Coroutine coroutine);
    }

    struct FrameInterval<T> : System.IEquatable<UniRx.FrameInterval<T>>
    {
        /*0x0*/ int _interval;
        /*0x0*/ T _value;

        static /*0x3907c14*/ bool op_Equality(UniRx.FrameInterval<T> first, UniRx.FrameInterval<T> second);
        static /*0x3907c14*/ bool op_Inequality(UniRx.FrameInterval<T> first, UniRx.FrameInterval<T> second);
        /*0x3907c14*/ FrameInterval(T value, int interval);
        /*0x3907c14*/ T get_Value();
        /*0x380b6a0*/ int get_Interval();
        /*0x3907c14*/ bool Equals(UniRx.FrameInterval<T> other);
        /*0x380b2f0*/ bool Equals(object obj);
        /*0x380b6a0*/ int GetHashCode();
        /*0x380b9e8*/ string ToString();
    }

    class IntReactiveProperty : UniRx.ReactiveProperty<int>
    {
        /*0x78e18ec*/ IntReactiveProperty();
        /*0x78e1958*/ IntReactiveProperty(int initialValue);
    }

    class LongReactiveProperty : UniRx.ReactiveProperty<long>
    {
        /*0x78e19d4*/ LongReactiveProperty();
        /*0x78e1a40*/ LongReactiveProperty(long initialValue);
    }

    class ByteReactiveProperty : UniRx.ReactiveProperty<byte>
    {
        /*0x78e1abc*/ ByteReactiveProperty();
        /*0x78e1b28*/ ByteReactiveProperty(byte initialValue);
    }

    class FloatReactiveProperty : UniRx.ReactiveProperty<float>
    {
        /*0x78e1ba4*/ FloatReactiveProperty();
        /*0x78e1c10*/ FloatReactiveProperty(float initialValue);
    }

    class DoubleReactiveProperty : UniRx.ReactiveProperty<double>
    {
        /*0x78e1c8c*/ DoubleReactiveProperty();
        /*0x78e1cf8*/ DoubleReactiveProperty(double initialValue);
    }

    class StringReactiveProperty : UniRx.ReactiveProperty<string>
    {
        /*0x78e1d74*/ StringReactiveProperty();
        /*0x78e1de0*/ StringReactiveProperty(string initialValue);
    }

    class BoolReactiveProperty : UniRx.ReactiveProperty<bool>
    {
        /*0x78e1e5c*/ BoolReactiveProperty();
        /*0x78e1ec8*/ BoolReactiveProperty(bool initialValue);
    }

    class Vector2ReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Vector2>
    {
        /*0x78e1f44*/ Vector2ReactiveProperty();
        /*0x78e1fb0*/ Vector2ReactiveProperty(UnityEngine.Vector2 initialValue);
        /*0x78e2034*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector2> get_EqualityComparer();
    }

    class Vector3ReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Vector3>
    {
        /*0x78e208c*/ Vector3ReactiveProperty();
        /*0x78e20f8*/ Vector3ReactiveProperty(UnityEngine.Vector3 initialValue);
        /*0x78e218c*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector3> get_EqualityComparer();
    }

    class Vector4ReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Vector4>
    {
        /*0x78e21e4*/ Vector4ReactiveProperty();
        /*0x78e2250*/ Vector4ReactiveProperty(UnityEngine.Vector4 initialValue);
        /*0x78e22ec*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector4> get_EqualityComparer();
    }

    class ColorReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Color>
    {
        /*0x78e2344*/ ColorReactiveProperty();
        /*0x78e23b0*/ ColorReactiveProperty(UnityEngine.Color initialValue);
        /*0x78e244c*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Color> get_EqualityComparer();
    }

    class RectReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Rect>
    {
        /*0x78e24a4*/ RectReactiveProperty();
        /*0x78e2510*/ RectReactiveProperty(UnityEngine.Rect initialValue);
        /*0x78e25ac*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Rect> get_EqualityComparer();
    }

    class AnimationCurveReactiveProperty : UniRx.ReactiveProperty<UnityEngine.AnimationCurve>
    {
        /*0x78e2604*/ AnimationCurveReactiveProperty();
        /*0x78e2670*/ AnimationCurveReactiveProperty(UnityEngine.AnimationCurve initialValue);
    }

    class BoundsReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Bounds>
    {
        /*0x78e26ec*/ BoundsReactiveProperty();
        /*0x78e2758*/ BoundsReactiveProperty(UnityEngine.Bounds initialValue);
        /*0x78e2800*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Bounds> get_EqualityComparer();
    }

    class QuaternionReactiveProperty : UniRx.ReactiveProperty<UnityEngine.Quaternion>
    {
        /*0x78e2858*/ QuaternionReactiveProperty();
        /*0x78e28c4*/ QuaternionReactiveProperty(UnityEngine.Quaternion initialValue);
        /*0x78e2960*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Quaternion> get_EqualityComparer();
    }

    class InspectorDisplayAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string <FieldName>k__BackingField;
        /*0x20*/ bool <NotifyPropertyChanged>k__BackingField;

        /*0x78e29dc*/ InspectorDisplayAttribute(string fieldName, bool notifyPropertyChanged);
        /*0x78e29b8*/ string get_FieldName();
        /*0x78e29c0*/ void set_FieldName(string value);
        /*0x78e29c8*/ bool get_NotifyPropertyChanged();
        /*0x78e29d0*/ void set_NotifyPropertyChanged(bool value);
    }

    class MultilineReactivePropertyAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int <Lines>k__BackingField;

        /*0x78e2a2c*/ MultilineReactivePropertyAttribute();
        /*0x78e2a4c*/ MultilineReactivePropertyAttribute(int lines);
        /*0x78e2a1c*/ int get_Lines();
        /*0x78e2a24*/ void set_Lines(int value);
    }

    class RangeReactivePropertyAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float <Min>k__BackingField;
        /*0x1c*/ float <Max>k__BackingField;

        /*0x78e2a94*/ RangeReactivePropertyAttribute(float min, float max);
        /*0x78e2a74*/ float get_Min();
        /*0x78e2a7c*/ void set_Min(float value);
        /*0x78e2a84*/ float get_Max();
        /*0x78e2a8c*/ void set_Max(float value);
    }

    class MainThreadDispatcher : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ UniRx.MainThreadDispatcher.CullingMode cullingMode;
        static /*0x8*/ UniRx.MainThreadDispatcher instance;
        static /*0x10*/ bool initialized;
        static /*0x11*/ bool isQuitting;
        [ThreadStatic] static object mainThreadToken;
        /*0x20*/ UniRx.InternalUtil.ThreadSafeQueueWorker queueWorker;
        /*0x28*/ System.Action<System.Exception> unhandledExceptionCallback;
        /*0x30*/ UniRx.InternalUtil.MicroCoroutine updateMicroCoroutine;
        /*0x38*/ UniRx.InternalUtil.MicroCoroutine fixedUpdateMicroCoroutine;
        /*0x40*/ UniRx.InternalUtil.MicroCoroutine endOfFrameMicroCoroutine;
        /*0x48*/ UniRx.Subject<UniRx.Unit> update;
        /*0x50*/ UniRx.Subject<UniRx.Unit> lateUpdate;
        /*0x58*/ UniRx.Subject<bool> onApplicationFocus;
        /*0x60*/ UniRx.Subject<bool> onApplicationPause;
        /*0x68*/ UniRx.Subject<UniRx.Unit> onApplicationQuit;

        static /*0x78e3f98*/ MainThreadDispatcher();
        static /*0x78dd81c*/ void Post(System.Action<object> action, object state);
        static /*0x78e2b1c*/ void Send(System.Action<object> action, object state);
        static /*0x78dde30*/ void UnsafeSend(System.Action action);
        static /*0x3907c14*/ void UnsafeSend<T>(System.Action<T> action, T state);
        static /*0x78dda18*/ void SendStartCoroutine(System.Collections.IEnumerator routine);
        static /*0x78e2d78*/ void StartUpdateMicroCoroutine(System.Collections.IEnumerator routine);
        static /*0x78df0d0*/ void StartFixedUpdateMicroCoroutine(System.Collections.IEnumerator routine);
        static /*0x78dfb38*/ void StartEndOfFrameMicroCoroutine(System.Collections.IEnumerator routine);
        static /*0x78e2cc0*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        static /*0x78e2e30*/ void RegisterUnhandledExceptionCallback(System.Action<System.Exception> exceptionCallback);
        static /*0x78e2ee0*/ string get_InstanceName();
        static /*0x78e2fe4*/ bool get_IsInitialized();
        static /*0x78e2ac0*/ UniRx.MainThreadDispatcher get_Instance();
        static /*0x78dd294*/ void Initialize();
        static /*0x78e34c0*/ bool get_IsInMainThread();
        static /*0x78e3664*/ void DestroyDispatcher(UniRx.MainThreadDispatcher aDispatcher);
        static /*0x78e3820*/ void CullAllExcessDispatchers();
        static /*0x78d4c84*/ System.IObservable<UniRx.Unit> UpdateAsObservable();
        static /*0x78d4ea4*/ System.IObservable<UniRx.Unit> LateUpdateAsObservable();
        static /*0x78d5834*/ System.IObservable<bool> OnApplicationFocusAsObservable();
        static /*0x78d56cc*/ System.IObservable<bool> OnApplicationPauseAsObservable();
        static /*0x78d59a0*/ System.IObservable<UniRx.Unit> OnApplicationQuitAsObservable();
        /*0x78e3e70*/ MainThreadDispatcher();
        /*0x78e3098*/ void Awake();
        /*0x78e3520*/ System.Collections.IEnumerator RunUpdateMicroCoroutine();
        /*0x78e358c*/ System.Collections.IEnumerator RunFixedUpdateMicroCoroutine();
        /*0x78e35f8*/ System.Collections.IEnumerator RunEndOfFrameMicroCoroutine();
        /*0x78e397c*/ void OnDestroy();
        /*0x78e3a9c*/ void Update();
        /*0x78e3c04*/ void LateUpdate();
        /*0x78e3cc0*/ void OnApplicationFocus(bool focus);
        /*0x78e3d20*/ void OnApplicationPause(bool pause);
        /*0x78e3d80*/ void OnApplicationQuit();
        /*0x78e3fe8*/ void <Awake>b__30_0(System.Exception ex);
        /*0x78e400c*/ void <Awake>b__30_1(System.Exception ex);
        /*0x78e4030*/ void <Awake>b__30_2(System.Exception ex);

        enum CullingMode
        {
            Disabled = 0,
            Self = 1,
            All = 2,
        }

        class <>c
        {
            static /*0x0*/ UniRx.MainThreadDispatcher.<> <>9;
            static /*0x8*/ System.Action<System.Exception> <>9__52_0;

            static /*0x78e4054*/ <>c();
            /*0x78e40bc*/ <>c();
            /*0x78e40c4*/ void <.ctor>b__52_0(System.Exception ex);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ System.Collections.IEnumerator routine;

            /*0x78e2cb8*/ <>c__DisplayClass6_0();
            /*0x78e411c*/ void <SendStartCoroutine>b__0(object _);
        }

        class <RunEndOfFrameMicroCoroutine>d__33 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UniRx.MainThreadDispatcher <>4__this;

            /*0x78e3954*/ <RunEndOfFrameMicroCoroutine>d__33(int <>1__state);
            /*0x78e41d0*/ void System.IDisposable.Dispose();
            /*0x78e41d4*/ bool MoveNext();
            /*0x78e428c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e4294*/ void System.Collections.IEnumerator.Reset();
            /*0x78e42cc*/ object System.Collections.IEnumerator.get_Current();
        }

        class <RunFixedUpdateMicroCoroutine>d__32 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UniRx.MainThreadDispatcher <>4__this;

            /*0x78e392c*/ <RunFixedUpdateMicroCoroutine>d__32(int <>1__state);
            /*0x78e42d4*/ void System.IDisposable.Dispose();
            /*0x78e42d8*/ bool MoveNext();
            /*0x78e4390*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e4398*/ void System.Collections.IEnumerator.Reset();
            /*0x78e43d0*/ object System.Collections.IEnumerator.get_Current();
        }

        class <RunUpdateMicroCoroutine>d__31 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UniRx.MainThreadDispatcher <>4__this;

            /*0x78e3904*/ <RunUpdateMicroCoroutine>d__31(int <>1__state);
            /*0x78e43d8*/ void System.IDisposable.Dispose();
            /*0x78e43dc*/ bool MoveNext();
            /*0x78e444c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e4454*/ void System.Collections.IEnumerator.Reset();
            /*0x78e448c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum FrameCountType
    {
        Update = 0,
        FixedUpdate = 1,
        EndOfFrame = 2,
    }

    enum MainThreadDispatchType
    {
        Update = 0,
        FixedUpdate = 1,
        EndOfFrame = 2,
        GameObjectUpdate = 3,
        LateUpdate = 4,
    }

    class FrameCountTypeExtensions
    {
        static /*0x78e4494*/ UnityEngine.YieldInstruction GetYieldInstruction(UniRx.FrameCountType frameCountType);
    }

    interface ICustomYieldInstructionErrorHandler
    {
        /*0x380b128*/ bool get_HasError();
        /*0x380b9e8*/ System.Exception get_Error();
        /*0x380b128*/ bool get_IsReThrowOnError();
        /*0x380cb08*/ void ForceDisableRethrowOnError();
        /*0x380cb08*/ void ForceEnableRethrowOnError();
    }

    class ObservableYieldInstruction<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, UniRx.ICustomYieldInstructionErrorHandler
    {
        /*0x0*/ System.IDisposable subscription;
        /*0x0*/ System.Threading.CancellationToken cancel;
        /*0x0*/ bool reThrowOnError;
        /*0x0*/ T current;
        /*0x0*/ T result;
        /*0x0*/ bool moveNext;
        /*0x0*/ bool hasResult;
        /*0x0*/ System.Exception error;

        /*0x3907c14*/ ObservableYieldInstruction(System.IObservable<T> source, bool reThrowOnError, System.Threading.CancellationToken cancel);
        /*0x380b128*/ bool get_HasError();
        /*0x380b128*/ bool get_HasResult();
        /*0x380b128*/ bool get_IsCanceled();
        /*0x380b128*/ bool get_IsDone();
        /*0x3907c14*/ T get_Result();
        /*0x3907c14*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
        /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        /*0x380b9e8*/ System.Exception get_Error();
        /*0x380b128*/ bool System.Collections.IEnumerator.MoveNext();
        /*0x380b128*/ bool UniRx.ICustomYieldInstructionErrorHandler.get_IsReThrowOnError();
        /*0x380cb08*/ void UniRx.ICustomYieldInstructionErrorHandler.ForceDisableRethrowOnError();
        /*0x380cb08*/ void UniRx.ICustomYieldInstructionErrorHandler.ForceEnableRethrowOnError();
        /*0x380cb08*/ void Dispose();
        /*0x380cb08*/ void System.Collections.IEnumerator.Reset();

        class ToYieldInstruction<T> : System.IObserver<T>
        {
            /*0x0*/ UniRx.ObservableYieldInstruction<T> parent;

            /*0x380d83c*/ ToYieldInstruction(UniRx.ObservableYieldInstruction<T> parent);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }
    }

    class ObservableWWW
    {
        static /*0x78e4530*/ System.IObservable<string> Get(string url, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e4668*/ System.IObservable<System.Byte[]> GetAndGetBytes(string url, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e47a0*/ System.IObservable<UnityEngine.WWW> GetWWW(string url, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e48d8*/ System.IObservable<string> Post(string url, byte[] postData, System.IProgress<float> progress);
        static /*0x78e4a10*/ System.IObservable<string> Post(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e4b5c*/ System.IObservable<string> Post(string url, UnityEngine.WWWForm content, System.IProgress<float> progress);
        static /*0x78e4c94*/ System.IObservable<string> Post(string url, UnityEngine.WWWForm content, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e4dfc*/ System.IObservable<System.Byte[]> PostAndGetBytes(string url, byte[] postData, System.IProgress<float> progress);
        static /*0x78e4f34*/ System.IObservable<System.Byte[]> PostAndGetBytes(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e5080*/ System.IObservable<System.Byte[]> PostAndGetBytes(string url, UnityEngine.WWWForm content, System.IProgress<float> progress);
        static /*0x78e51b8*/ System.IObservable<System.Byte[]> PostAndGetBytes(string url, UnityEngine.WWWForm content, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e5320*/ System.IObservable<UnityEngine.WWW> PostWWW(string url, byte[] postData, System.IProgress<float> progress);
        static /*0x78e5458*/ System.IObservable<UnityEngine.WWW> PostWWW(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e55a4*/ System.IObservable<UnityEngine.WWW> PostWWW(string url, UnityEngine.WWWForm content, System.IProgress<float> progress);
        static /*0x78e56dc*/ System.IObservable<UnityEngine.WWW> PostWWW(string url, UnityEngine.WWWForm content, System.Collections.Generic.Dictionary<string, string> headers, System.IProgress<float> progress);
        static /*0x78e5844*/ System.IObservable<UnityEngine.AssetBundle> LoadFromCacheOrDownload(string url, int version, System.IProgress<float> progress);
        static /*0x78e5970*/ System.IObservable<UnityEngine.AssetBundle> LoadFromCacheOrDownload(string url, int version, uint crc, System.IProgress<float> progress);
        static /*0x78e5aa0*/ System.IObservable<UnityEngine.AssetBundle> LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash128, System.IProgress<float> progress);
        static /*0x78e5bd0*/ System.IObservable<UnityEngine.AssetBundle> LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash128, uint crc, System.IProgress<float> progress);
        static /*0x78e5d10*/ System.Collections.Generic.Dictionary<string, string> MergeHash(System.Collections.Generic.Dictionary<string, string> wwwFormHeaders, System.Collections.Generic.Dictionary<string, string> externalHeaders);
        static /*0x78e5ea0*/ System.Collections.IEnumerator Fetch(UnityEngine.WWW www, System.IObserver<UnityEngine.WWW> observer, System.IProgress<float> reportProgress, System.Threading.CancellationToken cancel);
        static /*0x78e5f80*/ System.Collections.IEnumerator FetchText(UnityEngine.WWW www, System.IObserver<string> observer, System.IProgress<float> reportProgress, System.Threading.CancellationToken cancel);
        static /*0x78e6060*/ System.Collections.IEnumerator FetchBytes(UnityEngine.WWW www, System.IObserver<System.Byte[]> observer, System.IProgress<float> reportProgress, System.Threading.CancellationToken cancel);
        static /*0x78e6140*/ System.Collections.IEnumerator FetchAssetBundle(UnityEngine.WWW www, System.IObserver<UnityEngine.AssetBundle> observer, System.IProgress<float> reportProgress, System.Threading.CancellationToken cancel);

        class <>c__DisplayClass0_0
        {
            /*0x10*/ string url;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e4660*/ <>c__DisplayClass0_0();
            /*0x78e6220*/ System.Collections.IEnumerator <Get>b__0(System.IObserver<string> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass10_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.WWWForm content;
            /*0x20*/ System.Collections.Generic.Dictionary<string, string> contentHeaders;
            /*0x28*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x30*/ System.IProgress<float> progress;

            /*0x78e5318*/ <>c__DisplayClass10_0();
            /*0x78e62ec*/ System.Collections.IEnumerator <PostAndGetBytes>b__0(System.IObserver<System.Byte[]> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ string url;
            /*0x18*/ byte[] postData;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e5450*/ <>c__DisplayClass11_0();
            /*0x78e639c*/ System.Collections.IEnumerator <PostWWW>b__0(System.IObserver<UnityEngine.WWW> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ string url;
            /*0x18*/ byte[] postData;
            /*0x20*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x28*/ System.IProgress<float> progress;

            /*0x78e559c*/ <>c__DisplayClass12_0();
            /*0x78e6424*/ System.Collections.IEnumerator <PostWWW>b__0(System.IObserver<UnityEngine.WWW> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.WWWForm content;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e56d4*/ <>c__DisplayClass13_0();
            /*0x78e64b4*/ System.Collections.IEnumerator <PostWWW>b__0(System.IObserver<UnityEngine.WWW> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass14_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.WWWForm content;
            /*0x20*/ System.Collections.Generic.Dictionary<string, string> contentHeaders;
            /*0x28*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x30*/ System.IProgress<float> progress;

            /*0x78e583c*/ <>c__DisplayClass14_0();
            /*0x78e653c*/ System.Collections.IEnumerator <PostWWW>b__0(System.IObserver<UnityEngine.WWW> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass15_0
        {
            /*0x10*/ string url;
            /*0x18*/ int version;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e5968*/ <>c__DisplayClass15_0();
            /*0x78e65ec*/ System.Collections.IEnumerator <LoadFromCacheOrDownload>b__0(System.IObserver<UnityEngine.AssetBundle> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass16_0
        {
            /*0x10*/ string url;
            /*0x18*/ int version;
            /*0x1c*/ uint crc;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e5a98*/ <>c__DisplayClass16_0();
            /*0x78e662c*/ System.Collections.IEnumerator <LoadFromCacheOrDownload>b__0(System.IObserver<UnityEngine.AssetBundle> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass17_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.Hash128 hash128;
            /*0x28*/ System.IProgress<float> progress;

            /*0x78e5bc8*/ <>c__DisplayClass17_0();
            /*0x78e666c*/ System.Collections.IEnumerator <LoadFromCacheOrDownload>b__0(System.IObserver<UnityEngine.AssetBundle> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass18_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.Hash128 hash128;
            /*0x28*/ uint crc;
            /*0x30*/ System.IProgress<float> progress;

            /*0x78e5d08*/ <>c__DisplayClass18_0();
            /*0x78e66ac*/ System.Collections.IEnumerator <LoadFromCacheOrDownload>b__0(System.IObserver<UnityEngine.AssetBundle> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass1_0
        {
            /*0x10*/ string url;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e4798*/ <>c__DisplayClass1_0();
            /*0x78e66f0*/ System.Collections.IEnumerator <GetAndGetBytes>b__0(System.IObserver<System.Byte[]> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ string url;
            /*0x18*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e48d0*/ <>c__DisplayClass2_0();
            /*0x78e67bc*/ System.Collections.IEnumerator <GetWWW>b__0(System.IObserver<UnityEngine.WWW> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ string url;
            /*0x18*/ byte[] postData;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e4a08*/ <>c__DisplayClass3_0();
            /*0x78e6888*/ System.Collections.IEnumerator <Post>b__0(System.IObserver<string> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ string url;
            /*0x18*/ byte[] postData;
            /*0x20*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x28*/ System.IProgress<float> progress;

            /*0x78e4b54*/ <>c__DisplayClass4_0();
            /*0x78e6910*/ System.Collections.IEnumerator <Post>b__0(System.IObserver<string> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.WWWForm content;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e4c8c*/ <>c__DisplayClass5_0();
            /*0x78e69a0*/ System.Collections.IEnumerator <Post>b__0(System.IObserver<string> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.WWWForm content;
            /*0x20*/ System.Collections.Generic.Dictionary<string, string> contentHeaders;
            /*0x28*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x30*/ System.IProgress<float> progress;

            /*0x78e4df4*/ <>c__DisplayClass6_0();
            /*0x78e6a28*/ System.Collections.IEnumerator <Post>b__0(System.IObserver<string> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass7_0
        {
            /*0x10*/ string url;
            /*0x18*/ byte[] postData;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e4f2c*/ <>c__DisplayClass7_0();
            /*0x78e6ad8*/ System.Collections.IEnumerator <PostAndGetBytes>b__0(System.IObserver<System.Byte[]> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass8_0
        {
            /*0x10*/ string url;
            /*0x18*/ byte[] postData;
            /*0x20*/ System.Collections.Generic.Dictionary<string, string> headers;
            /*0x28*/ System.IProgress<float> progress;

            /*0x78e5078*/ <>c__DisplayClass8_0();
            /*0x78e6b60*/ System.Collections.IEnumerator <PostAndGetBytes>b__0(System.IObserver<System.Byte[]> observer, System.Threading.CancellationToken cancellation);
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ string url;
            /*0x18*/ UnityEngine.WWWForm content;
            /*0x20*/ System.IProgress<float> progress;

            /*0x78e51b0*/ <>c__DisplayClass9_0();
            /*0x78e6bf0*/ System.Collections.IEnumerator <PostAndGetBytes>b__0(System.IObserver<System.Byte[]> observer, System.Threading.CancellationToken cancellation);
        }

        class <Fetch>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.WWW www;
            /*0x28*/ System.IProgress<float> reportProgress;
            /*0x30*/ System.IObserver<UnityEngine.WWW> observer;
            /*0x38*/ System.Threading.CancellationToken cancel;
            /*0x40*/ UnityEngine.WWW <>7__wrap1;

            /*0x78e5f58*/ <Fetch>d__20(int <>1__state);
            /*0x78e6c78*/ void System.IDisposable.Dispose();
            /*0x78e6ca4*/ bool MoveNext();
            /*0x78e7568*/ void <>m__Finally1();
            /*0x78e7618*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e7620*/ void System.Collections.IEnumerator.Reset();
            /*0x78e7658*/ object System.Collections.IEnumerator.get_Current();
        }

        class <FetchAssetBundle>d__23 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.WWW www;
            /*0x28*/ System.IProgress<float> reportProgress;
            /*0x30*/ System.IObserver<UnityEngine.AssetBundle> observer;
            /*0x38*/ System.Threading.CancellationToken cancel;
            /*0x40*/ UnityEngine.WWW <>7__wrap1;

            /*0x78e61f8*/ <FetchAssetBundle>d__23(int <>1__state);
            /*0x78e7660*/ void System.IDisposable.Dispose();
            /*0x78e768c*/ bool MoveNext();
            /*0x78e7de4*/ void <>m__Finally1();
            /*0x78e7e94*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e7e9c*/ void System.Collections.IEnumerator.Reset();
            /*0x78e7ed4*/ object System.Collections.IEnumerator.get_Current();
        }

        class <FetchBytes>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.WWW www;
            /*0x28*/ System.IProgress<float> reportProgress;
            /*0x30*/ System.IObserver<System.Byte[]> observer;
            /*0x38*/ System.Threading.CancellationToken cancel;
            /*0x40*/ UnityEngine.WWW <>7__wrap1;

            /*0x78e6118*/ <FetchBytes>d__22(int <>1__state);
            /*0x78e7edc*/ void System.IDisposable.Dispose();
            /*0x78e7f08*/ bool MoveNext();
            /*0x78e8674*/ void <>m__Finally1();
            /*0x78e8724*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e872c*/ void System.Collections.IEnumerator.Reset();
            /*0x78e8764*/ object System.Collections.IEnumerator.get_Current();
        }

        class <FetchText>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.WWW www;
            /*0x28*/ System.IProgress<float> reportProgress;
            /*0x30*/ System.IObserver<string> observer;
            /*0x38*/ System.Threading.CancellationToken cancel;
            /*0x40*/ UnityEngine.WWW <>7__wrap1;

            /*0x78e6038*/ <FetchText>d__21(int <>1__state);
            /*0x78e876c*/ void System.IDisposable.Dispose();
            /*0x78e8798*/ bool MoveNext();
            /*0x78e8f04*/ void <>m__Finally1();
            /*0x78e8fb4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e8fbc*/ void System.Collections.IEnumerator.Reset();
            /*0x78e8ff4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class WWWErrorException : System.Exception
    {
        /*0x90*/ string <RawErrorMessage>k__BackingField;
        /*0x98*/ bool <HasResponse>k__BackingField;
        /*0xa0*/ string <Text>k__BackingField;
        /*0xa8*/ System.Net.HttpStatusCode <StatusCode>k__BackingField;
        /*0xb0*/ System.Collections.Generic.Dictionary<string, string> <ResponseHeaders>k__BackingField;
        /*0xb8*/ UnityEngine.WWW <WWW>k__BackingField;

        /*0x78e73f4*/ WWWErrorException(UnityEngine.WWW www, string text);
        /*0x78e8ffc*/ string get_RawErrorMessage();
        /*0x78e9004*/ void set_RawErrorMessage(string value);
        /*0x78e900c*/ bool get_HasResponse();
        /*0x78e9014*/ void set_HasResponse(bool value);
        /*0x78e9020*/ string get_Text();
        /*0x78e9028*/ void set_Text(string value);
        /*0x78e9030*/ System.Net.HttpStatusCode get_StatusCode();
        /*0x78e9038*/ void set_StatusCode(System.Net.HttpStatusCode value);
        /*0x78e9040*/ System.Collections.Generic.Dictionary<string, string> get_ResponseHeaders();
        /*0x78e9048*/ void set_ResponseHeaders(System.Collections.Generic.Dictionary<string, string> value);
        /*0x78e9050*/ UnityEngine.WWW get_WWW();
        /*0x78e9058*/ void set_WWW(UnityEngine.WWW value);
        /*0x78e9060*/ string ToString();
    }

    class ObserveExtensions
    {
        static /*0x3907c14*/ System.IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(TSource source, System.Func<TSource, TProperty> propertySelector, UniRx.FrameCountType frameCountType, bool fastDestroyCheck);
        static /*0x3907c14*/ System.IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(TSource source, System.Func<TSource, TProperty> propertySelector, UniRx.FrameCountType frameCountType, System.Collections.Generic.IEqualityComparer<TProperty> comparer);
        static /*0x3907c14*/ System.IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(TSource source, System.Func<TSource, TProperty> propertySelector, UniRx.FrameCountType frameCountType, System.Collections.Generic.IEqualityComparer<TProperty> comparer, bool fastDestroyCheck);
        static /*0x78e90d8*/ System.Collections.IEnumerator EmptyEnumerator();
        static /*0x3907c14*/ System.Collections.IEnumerator PublishPocoValueChanged<TSource, TProperty>(System.WeakReference sourceReference, TProperty firstValue, System.Func<TSource, TProperty> propertySelector, System.Collections.Generic.IEqualityComparer<TProperty> comparer, System.IObserver<TProperty> observer, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ System.Collections.IEnumerator PublishUnityObjectValueChanged<TSource, TProperty>(UnityEngine.Object unityObject, TProperty firstValue, System.Func<TSource, TProperty> propertySelector, System.Collections.Generic.IEqualityComparer<TProperty> comparer, System.IObserver<TProperty> observer, System.Threading.CancellationToken cancellationToken, bool fastDestroyCheck);
        static /*0x78e9158*/ UniRx.Triggers.ObservableDestroyTrigger GetOrAddDestroyTrigger(UnityEngine.GameObject go);

        class <>c__DisplayClass2_0<TSource, TProperty>
        {
            /*0x0*/ UnityEngine.Object unityObject;
            /*0x0*/ System.Func<TSource, TProperty> propertySelector;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TProperty> comparer;
            /*0x0*/ bool fastDestroyCheck;

            /*0x380cb08*/ <>c__DisplayClass2_0();
            /*0x380bc30*/ System.Collections.IEnumerator <ObserveEveryValueChanged>b__0(System.IObserver<TProperty> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <>c__DisplayClass2_1<TSource, TProperty>
        {
            /*0x0*/ System.WeakReference reference;
            /*0x0*/ UniRx.ObserveExtensions.<>c__DisplayClass2_0<TSource, TProperty> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass2_1();
            /*0x380bc30*/ System.Collections.IEnumerator <ObserveEveryValueChanged>b__1(System.IObserver<TProperty> observer, System.Threading.CancellationToken cancellationToken);
        }

        class <EmptyEnumerator>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;

            /*0x78e9130*/ <EmptyEnumerator>d__3(int <>1__state);
            /*0x78e9218*/ void System.IDisposable.Dispose();
            /*0x78e921c*/ bool MoveNext();
            /*0x78e9234*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x78e923c*/ void System.Collections.IEnumerator.Reset();
            /*0x78e9274*/ object System.Collections.IEnumerator.get_Current();
        }

        class <PublishPocoValueChanged>d__4<TSource, TProperty> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ TProperty firstValue;
            /*0x0*/ System.WeakReference sourceReference;
            /*0x0*/ System.Func<TSource, TProperty> propertySelector;
            /*0x0*/ System.IObserver<TProperty> observer;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TProperty> comparer;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ TProperty <prevValue>5__2;

            /*0x380cffc*/ <PublishPocoValueChanged>d__4(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <PublishUnityObjectValueChanged>d__5<TSource, TProperty> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ TProperty firstValue;
            /*0x0*/ UnityEngine.Object unityObject;
            /*0x0*/ bool fastDestroyCheck;
            /*0x0*/ System.Func<TSource, TProperty> propertySelector;
            /*0x0*/ System.IObserver<TProperty> observer;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TProperty> comparer;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ TProperty <prevValue>5__2;
            /*0x0*/ TSource <source>5__3;
            /*0x0*/ UniRx.Triggers.ObservableDestroyTrigger <destroyTrigger>5__4;

            /*0x380cffc*/ <PublishUnityObjectValueChanged>d__5(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    struct CollectionAddEvent<T> : System.IEquatable<UniRx.CollectionAddEvent<T>>
    {
        /*0x0*/ int <Index>k__BackingField;
        /*0x0*/ T <Value>k__BackingField;

        /*0x3907c14*/ CollectionAddEvent(int index, T value);
        /*0x380b6a0*/ int get_Index();
        /*0x380cffc*/ void set_Index(int value);
        /*0x3907c14*/ T get_Value();
        /*0x3907c14*/ void set_Value(T value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.CollectionAddEvent<T> other);
    }

    struct CollectionRemoveEvent<T> : System.IEquatable<UniRx.CollectionRemoveEvent<T>>
    {
        /*0x0*/ int <Index>k__BackingField;
        /*0x0*/ T <Value>k__BackingField;

        /*0x3907c14*/ CollectionRemoveEvent(int index, T value);
        /*0x380b6a0*/ int get_Index();
        /*0x380cffc*/ void set_Index(int value);
        /*0x3907c14*/ T get_Value();
        /*0x3907c14*/ void set_Value(T value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.CollectionRemoveEvent<T> other);
    }

    struct CollectionMoveEvent<T> : System.IEquatable<UniRx.CollectionMoveEvent<T>>
    {
        /*0x0*/ int <OldIndex>k__BackingField;
        /*0x0*/ int <NewIndex>k__BackingField;
        /*0x0*/ T <Value>k__BackingField;

        /*0x3907c14*/ CollectionMoveEvent(int oldIndex, int newIndex, T value);
        /*0x380b6a0*/ int get_OldIndex();
        /*0x380cffc*/ void set_OldIndex(int value);
        /*0x380b6a0*/ int get_NewIndex();
        /*0x380cffc*/ void set_NewIndex(int value);
        /*0x3907c14*/ T get_Value();
        /*0x3907c14*/ void set_Value(T value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.CollectionMoveEvent<T> other);
    }

    struct CollectionReplaceEvent<T> : System.IEquatable<UniRx.CollectionReplaceEvent<T>>
    {
        /*0x0*/ int <Index>k__BackingField;
        /*0x0*/ T <OldValue>k__BackingField;
        /*0x0*/ T <NewValue>k__BackingField;

        /*0x3907c14*/ CollectionReplaceEvent(int index, T oldValue, T newValue);
        /*0x380b6a0*/ int get_Index();
        /*0x380cffc*/ void set_Index(int value);
        /*0x3907c14*/ T get_OldValue();
        /*0x3907c14*/ void set_OldValue(T value);
        /*0x3907c14*/ T get_NewValue();
        /*0x3907c14*/ void set_NewValue(T value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.CollectionReplaceEvent<T> other);
    }

    interface IReadOnlyReactiveCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        /*0x380b6a0*/ int get_Count();
        /*0x3907c14*/ T get_Item(int index);
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionAddEvent<T>> ObserveAdd();
        System.IObservable<int> ObserveCountChanged(bool notifyCurrentCount);
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionMoveEvent<T>> ObserveMove();
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionRemoveEvent<T>> ObserveRemove();
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionReplaceEvent<T>> ObserveReplace();
        /*0x380b9e8*/ System.IObservable<UniRx.Unit> ObserveReset();
    }

    interface IReactiveCollection<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, UniRx.IReadOnlyReactiveCollection<T>
    {
        /*0x380b6a0*/ int get_Count();
        /*0x3907c14*/ T get_Item(int index);
        /*0x3907c14*/ void set_Item(int index, T value);
        /*0x380d0e4*/ void Move(int oldIndex, int newIndex);
    }

    class ReactiveCollection<T> : System.Collections.ObjectModel.Collection<T>, UniRx.IReactiveCollection<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, UniRx.IReadOnlyReactiveCollection<T>, System.IDisposable
    {
        /*0x0*/ bool isDisposed;
        /*0x0*/ UniRx.Subject<int> countChanged;
        /*0x0*/ UniRx.Subject<UniRx.Unit> collectionReset;
        /*0x0*/ UniRx.Subject<UniRx.CollectionAddEvent<T>> collectionAdd;
        /*0x0*/ UniRx.Subject<UniRx.CollectionMoveEvent<T>> collectionMove;
        /*0x0*/ UniRx.Subject<UniRx.CollectionRemoveEvent<T>> collectionRemove;
        /*0x0*/ UniRx.Subject<UniRx.CollectionReplaceEvent<T>> collectionReplace;
        /*0x0*/ bool disposedValue;

        /*0x380cb08*/ ReactiveCollection();
        /*0x380d83c*/ ReactiveCollection(System.Collections.Generic.IEnumerable<T> collection);
        /*0x380d83c*/ ReactiveCollection(System.Collections.Generic.List<T> list);
        /*0x380cb08*/ void ClearItems();
        /*0x3907c14*/ void InsertItem(int index, T item);
        /*0x380d0e4*/ void Move(int oldIndex, int newIndex);
        /*0x380d0e4*/ void MoveItem(int oldIndex, int newIndex);
        /*0x380cffc*/ void RemoveItem(int index);
        /*0x3907c14*/ void SetItem(int index, T item);
        System.IObservable<int> ObserveCountChanged(bool notifyCurrentCount);
        /*0x380b9e8*/ System.IObservable<UniRx.Unit> ObserveReset();
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionAddEvent<T>> ObserveAdd();
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionMoveEvent<T>> ObserveMove();
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionRemoveEvent<T>> ObserveRemove();
        /*0x380b9e8*/ System.IObservable<UniRx.CollectionReplaceEvent<T>> ObserveReplace();
        /*0x380d83c*/ void DisposeSubject<TSubject>(ref UniRx.Subject<TSubject> subject);
        /*0x380cdf0*/ void Dispose(bool disposing);
        /*0x380cb08*/ void Dispose();
        /*0x380b6a0*/ int <ObserveCountChanged>b__11_0();
    }

    class ReactiveCollectionExtensions
    {
        static /*0x382eaf0*/ UniRx.ReactiveCollection<T> ToReactiveCollection<T>(System.Collections.Generic.IEnumerable<T> source);
    }

    interface IReactiveCommand<T> : System.IObservable<T>
    {
        /*0x380b9e8*/ UniRx.IReadOnlyReactiveProperty<bool> get_CanExecute();
        /*0x3907c14*/ bool Execute(T parameter);
    }

    interface IAsyncReactiveCommand<T>
    {
        /*0x380b9e8*/ UniRx.IReadOnlyReactiveProperty<bool> get_CanExecute();
        /*0x3907c14*/ System.IDisposable Execute(T parameter);
        /*0x380bb68*/ System.IDisposable Subscribe(System.Func<T, System.IObservable<UniRx.Unit>> asyncAction);
    }

    class ReactiveCommand : UniRx.ReactiveCommand<UniRx.Unit>
    {
        /*0x78e927c*/ ReactiveCommand();
        /*0x78e92c4*/ ReactiveCommand(System.IObservable<bool> canExecuteSource, bool initialValue);
        /*0x78e9324*/ bool Execute();
        /*0x78e93cc*/ void ForceExecute();
    }

    class ReactiveCommand<T> : UniRx.IReactiveCommand<T>, System.IObservable<T>, System.IDisposable
    {
        /*0x0*/ UniRx.Subject<T> trigger;
        /*0x0*/ System.IDisposable canExecuteSubscription;
        /*0x0*/ UniRx.ReactiveProperty<bool> canExecute;
        /*0x0*/ bool <IsDisposed>k__BackingField;

        /*0x380cb08*/ ReactiveCommand();
        ReactiveCommand(System.IObservable<bool> canExecuteSource, bool initialValue);
        /*0x380b9e8*/ UniRx.IReadOnlyReactiveProperty<bool> get_CanExecute();
        /*0x380b128*/ bool get_IsDisposed();
        /*0x380cdf0*/ void set_IsDisposed(bool value);
        /*0x3907c14*/ bool Execute(T parameter);
        /*0x3907c14*/ void ForceExecute(T parameter);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380cb08*/ void Dispose();

        class <>c<T>
        {
            static /*0x0*/ UniRx.ReactiveCommand.<>c<T> <>9;
            static /*0x0*/ System.Action<bool, UniRx.ReactiveProperty<bool>> <>9__10_0;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            void <.ctor>b__10_0(bool b, UniRx.ReactiveProperty<bool> c);
        }
    }

    class AsyncReactiveCommand : UniRx.AsyncReactiveCommand<UniRx.Unit>
    {
        /*0x78e9474*/ AsyncReactiveCommand();
        /*0x78e94bc*/ AsyncReactiveCommand(System.IObservable<bool> canExecuteSource);
        /*0x78e9514*/ AsyncReactiveCommand(UniRx.IReactiveProperty<bool> sharedCanExecute);
        /*0x78e956c*/ System.IDisposable Execute();
    }

    class AsyncReactiveCommand<T> : UniRx.IAsyncReactiveCommand<T>
    {
        /*0x0*/ UniRx.InternalUtil.ImmutableList<System.Func<T, System.IObservable<UniRx.Unit>>> asyncActions;
        /*0x0*/ object gate;
        /*0x0*/ UniRx.IReactiveProperty<bool> canExecuteSource;
        /*0x0*/ UniRx.IReadOnlyReactiveProperty<bool> canExecute;
        /*0x0*/ bool <IsDisposed>k__BackingField;

        /*0x380cb08*/ AsyncReactiveCommand();
        /*0x380d83c*/ AsyncReactiveCommand(System.IObservable<bool> canExecuteSource);
        /*0x380d83c*/ AsyncReactiveCommand(UniRx.IReactiveProperty<bool> sharedCanExecute);
        /*0x380b9e8*/ UniRx.IReadOnlyReactiveProperty<bool> get_CanExecute();
        /*0x380b128*/ bool get_IsDisposed();
        /*0x380cdf0*/ void set_IsDisposed(bool value);
        /*0x3907c14*/ System.IDisposable Execute(T parameter);
        /*0x380bb68*/ System.IDisposable Subscribe(System.Func<T, System.IObservable<UniRx.Unit>> asyncAction);
        /*0x380cb08*/ void Dispose();
        /*0x380cb08*/ void <Execute>b__13_0();
        /*0x380cb08*/ void <Execute>b__13_1();

        class Subscription<T> : System.IDisposable
        {
            /*0x0*/ UniRx.AsyncReactiveCommand<T> parent;
            /*0x0*/ System.Func<T, System.IObservable<UniRx.Unit>> asyncAction;

            /*0x380d93c*/ Subscription(UniRx.AsyncReactiveCommand<T> parent, System.Func<T, System.IObservable<UniRx.Unit>> asyncAction);
            /*0x380cb08*/ void Dispose();
        }

        class <>c<T>
        {
            static /*0x0*/ UniRx.AsyncReactiveCommand.<>c<T> <>9;
            static /*0x0*/ System.Func<bool, bool, bool> <>9__11_0;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            bool <.ctor>b__11_0(bool x, bool y);
        }
    }

    class ReactiveCommandExtensions
    {
        static /*0x0*/ System.Action<object> Callback;

        static /*0x78e9d28*/ ReactiveCommandExtensions();
        static /*0x78e9614*/ UniRx.ReactiveCommand ToReactiveCommand(System.IObservable<bool> canExecuteSource, bool initialValue);
        static /*0x382fccc*/ UniRx.ReactiveCommand<T> ToReactiveCommand<T>(System.IObservable<bool> canExecuteSource, bool initialValue);
        static /*0x78e967c*/ void CancelCallback(object state);
        static /*0x382fdd8*/ System.Threading.Tasks.Task<T> WaitUntilExecuteAsync<T>(UniRx.IReactiveCommand<T> source, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ System.Runtime.CompilerServices.TaskAwaiter<T> GetAwaiter<T>(UniRx.IReactiveCommand<T> command);
        static /*0x78e97f8*/ System.IDisposable BindTo(UniRx.IReactiveCommand<UniRx.Unit> command, UnityEngine.UI.Button button);
        static /*0x78e9ac4*/ System.IDisposable BindToOnClick(UniRx.IReactiveCommand<UniRx.Unit> command, UnityEngine.UI.Button button, System.Action<UniRx.Unit> onClick);
        static /*0x78e9ca8*/ System.IDisposable BindToButtonOnClick(System.IObservable<bool> canExecuteSource, UnityEngine.UI.Button button, System.Action<UniRx.Unit> onClick, bool initialValue);

        class <>c
        {
            static /*0x0*/ UniRx.ReactiveCommandExtensions.<> <>9;
            static /*0x8*/ System.Action<UniRx.Unit, UniRx.IReactiveCommand<UniRx.Unit>> <>9__6_0;
            static /*0x10*/ System.Action<UniRx.Unit, UniRx.IReactiveCommand<UniRx.Unit>> <>9__7_0;

            static /*0x78e9dc8*/ <>c();
            /*0x78e9e30*/ <>c();
            /*0x78e9e38*/ void <BindTo>b__6_0(UniRx.Unit x, UniRx.IReactiveCommand<UniRx.Unit> c);
            /*0x78e9ee0*/ void <BindToOnClick>b__7_0(UniRx.Unit x, UniRx.IReactiveCommand<UniRx.Unit> c);
        }

        class <>c__DisplayClass4_0<T>
        {
            /*0x0*/ UniRx.SingleAssignmentDisposable disposable;
            /*0x0*/ UniRx.InternalUtil.CancellableTaskCompletionSource<T> tcs;

            /*0x380cb08*/ <>c__DisplayClass4_0();
            /*0x3907c14*/ void <WaitUntilExecuteAsync>b__0(T x);
            /*0x380d83c*/ void <WaitUntilExecuteAsync>b__1(System.Exception ex);
            /*0x380cb08*/ void <WaitUntilExecuteAsync>b__2();
        }
    }

    class AsyncReactiveCommandExtensions
    {
        static /*0x0*/ System.Action<object> Callback;

        static /*0x78ea624*/ AsyncReactiveCommandExtensions();
        static /*0x78e9f88*/ UniRx.AsyncReactiveCommand ToAsyncReactiveCommand(UniRx.IReactiveProperty<bool> sharedCanExecuteSource);
        static /*0x382eaf0*/ UniRx.AsyncReactiveCommand<T> ToAsyncReactiveCommand<T>(UniRx.IReactiveProperty<bool> sharedCanExecuteSource);
        static /*0x78e9fe0*/ void CancelCallback(object state);
        static /*0x382fdd8*/ System.Threading.Tasks.Task<T> WaitUntilExecuteAsync<T>(UniRx.IAsyncReactiveCommand<T> source, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ System.Runtime.CompilerServices.TaskAwaiter<T> GetAwaiter<T>(UniRx.IAsyncReactiveCommand<T> command);
        static /*0x78ea15c*/ System.IDisposable BindTo(UniRx.IAsyncReactiveCommand<UniRx.Unit> command, UnityEngine.UI.Button button);
        static /*0x78ea308*/ System.IDisposable BindToOnClick(UniRx.IAsyncReactiveCommand<UniRx.Unit> command, UnityEngine.UI.Button button, System.Func<UniRx.Unit, System.IObservable<UniRx.Unit>> asyncOnClick);
        static /*0x78ea528*/ System.IDisposable BindToOnClick(UnityEngine.UI.Button button, System.Func<UniRx.Unit, System.IObservable<UniRx.Unit>> asyncOnClick);
        static /*0x78ea5b4*/ System.IDisposable BindToOnClick(UnityEngine.UI.Button button, UniRx.IReactiveProperty<bool> sharedCanExecuteSource, System.Func<UniRx.Unit, System.IObservable<UniRx.Unit>> asyncOnClick);

        class <>c
        {
            static /*0x0*/ UniRx.AsyncReactiveCommandExtensions.<> <>9;
            static /*0x8*/ System.Action<UniRx.Unit, UniRx.IAsyncReactiveCommand<UniRx.Unit>> <>9__6_0;
            static /*0x10*/ System.Action<UniRx.Unit, UniRx.IAsyncReactiveCommand<UniRx.Unit>> <>9__7_0;

            static /*0x78ea6c4*/ <>c();
            /*0x78ea72c*/ <>c();
            /*0x78ea734*/ void <BindTo>b__6_0(UniRx.Unit x, UniRx.IAsyncReactiveCommand<UniRx.Unit> c);
            /*0x78ea7dc*/ void <BindToOnClick>b__7_0(UniRx.Unit x, UniRx.IAsyncReactiveCommand<UniRx.Unit> c);
        }

        class <>c__DisplayClass4_0<T>
        {
            /*0x0*/ UniRx.InternalUtil.CancellableTaskCompletionSource<T> tcs;

            /*0x380cb08*/ <>c__DisplayClass4_0();
            /*0x3907c14*/ System.IObservable<UniRx.Unit> <WaitUntilExecuteAsync>b__0(T x);
        }
    }

    struct DictionaryAddEvent<TKey, TValue> : System.IEquatable<UniRx.DictionaryAddEvent<TKey, TValue>>
    {
        /*0x0*/ TKey <Key>k__BackingField;
        /*0x0*/ TValue <Value>k__BackingField;

        /*0x3907c14*/ DictionaryAddEvent(TKey key, TValue value);
        /*0x3907c14*/ TKey get_Key();
        /*0x3907c14*/ void set_Key(TKey value);
        /*0x3907c14*/ TValue get_Value();
        /*0x3907c14*/ void set_Value(TValue value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.DictionaryAddEvent<TKey, TValue> other);
    }

    struct DictionaryRemoveEvent<TKey, TValue> : System.IEquatable<UniRx.DictionaryRemoveEvent<TKey, TValue>>
    {
        /*0x0*/ TKey <Key>k__BackingField;
        /*0x0*/ TValue <Value>k__BackingField;

        /*0x3907c14*/ DictionaryRemoveEvent(TKey key, TValue value);
        /*0x3907c14*/ TKey get_Key();
        /*0x3907c14*/ void set_Key(TKey value);
        /*0x3907c14*/ TValue get_Value();
        /*0x3907c14*/ void set_Value(TValue value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.DictionaryRemoveEvent<TKey, TValue> other);
    }

    struct DictionaryReplaceEvent<TKey, TValue> : System.IEquatable<UniRx.DictionaryReplaceEvent<TKey, TValue>>
    {
        /*0x0*/ TKey <Key>k__BackingField;
        /*0x0*/ TValue <OldValue>k__BackingField;
        /*0x0*/ TValue <NewValue>k__BackingField;

        /*0x3907c14*/ DictionaryReplaceEvent(TKey key, TValue oldValue, TValue newValue);
        /*0x3907c14*/ TKey get_Key();
        /*0x3907c14*/ void set_Key(TKey value);
        /*0x3907c14*/ TValue get_OldValue();
        /*0x3907c14*/ void set_OldValue(TValue value);
        /*0x3907c14*/ TValue get_NewValue();
        /*0x3907c14*/ void set_NewValue(TValue value);
        /*0x380b9e8*/ string ToString();
        /*0x380b6a0*/ int GetHashCode();
        /*0x3907c14*/ bool Equals(UniRx.DictionaryReplaceEvent<TKey, TValue> other);
    }

    interface IReadOnlyReactiveDictionary<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    {
        /*0x380b6a0*/ int get_Count();
        /*0x3907c14*/ TValue get_Item(TKey index);
        /*0x3907c14*/ bool ContainsKey(TKey key);
        /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
        /*0x380b9e8*/ System.IObservable<UniRx.DictionaryAddEvent<TKey, TValue>> ObserveAdd();
        System.IObservable<int> ObserveCountChanged(bool notifyCurrentCount);
        /*0x380b9e8*/ System.IObservable<UniRx.DictionaryRemoveEvent<TKey, TValue>> ObserveRemove();
        /*0x380b9e8*/ System.IObservable<UniRx.DictionaryReplaceEvent<TKey, TValue>> ObserveReplace();
        /*0x380b9e8*/ System.IObservable<UniRx.Unit> ObserveReset();
    }

    interface IReactiveDictionary<TKey, TValue> : UniRx.IReadOnlyReactiveDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
    {
    }

    class ReactiveDictionary<TKey, TValue> : UniRx.IReactiveDictionary<TKey, TValue>, UniRx.IReadOnlyReactiveDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection, System.IDisposable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
    {
        /*0x0*/ bool isDisposed;
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> inner;
        /*0x0*/ bool disposedValue;
        /*0x0*/ UniRx.Subject<int> countChanged;
        /*0x0*/ UniRx.Subject<UniRx.Unit> collectionReset;
        /*0x0*/ UniRx.Subject<UniRx.DictionaryAddEvent<TKey, TValue>> dictionaryAdd;
        /*0x0*/ UniRx.Subject<UniRx.DictionaryRemoveEvent<TKey, TValue>> dictionaryRemove;
        /*0x0*/ UniRx.Subject<UniRx.DictionaryReplaceEvent<TKey, TValue>> dictionaryReplace;

        /*0x380cb08*/ ReactiveDictionary();
        /*0x380d83c*/ ReactiveDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer);
        /*0x380d83c*/ ReactiveDictionary(System.Collections.Generic.Dictionary<TKey, TValue> innerDictionary);
        /*0x3907c14*/ TValue get_Item(TKey key);
        /*0x3907c14*/ void set_Item(TKey key, TValue value);
        /*0x380b6a0*/ int get_Count();
        /*0x380b9e8*/ System.Collections.Generic.Dictionary.KeyCollection<TKey, TValue> get_Keys();
        /*0x380b9e8*/ System.Collections.Generic.Dictionary.ValueCollection<TKey, TValue> get_Values();
        /*0x3907c14*/ void Add(TKey key, TValue value);
        /*0x380cb08*/ void Clear();
        /*0x3907c14*/ bool Remove(TKey key);
        /*0x3907c14*/ bool ContainsKey(TKey key);
        /*0x3907c14*/ bool TryGetValue(TKey key, ref TValue value);
        /*0x3907c14*/ System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetEnumerator();
        /*0x380d83c*/ void DisposeSubject<TSubject>(ref UniRx.Subject<TSubject> subject);
        /*0x380cdf0*/ void Dispose(bool disposing);
        /*0x380cb08*/ void Dispose();
        System.IObservable<int> ObserveCountChanged(bool notifyCurrentCount);
        /*0x380b9e8*/ System.IObservable<UniRx.Unit> ObserveReset();
        /*0x380b9e8*/ System.IObservable<UniRx.DictionaryAddEvent<TKey, TValue>> ObserveAdd();
        /*0x380b9e8*/ System.IObservable<UniRx.DictionaryRemoveEvent<TKey, TValue>> ObserveRemove();
        /*0x380b9e8*/ System.IObservable<UniRx.DictionaryReplaceEvent<TKey, TValue>> ObserveReplace();
        /*0x380bb68*/ object System.Collections.IDictionary.get_Item(object key);
        /*0x380d93c*/ void System.Collections.IDictionary.set_Item(object key, object value);
        /*0x380b128*/ bool System.Collections.IDictionary.get_IsFixedSize();
        /*0x380b128*/ bool System.Collections.IDictionary.get_IsReadOnly();
        /*0x380b128*/ bool System.Collections.ICollection.get_IsSynchronized();
        /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
        /*0x380b9e8*/ object System.Collections.ICollection.get_SyncRoot();
        /*0x380b9e8*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
        /*0x380b128*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
        /*0x380b9e8*/ System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
        /*0x380b9e8*/ System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
        /*0x380d93c*/ void System.Collections.IDictionary.Add(object key, object value);
        /*0x380b2f0*/ bool System.Collections.IDictionary.Contains(object key);
        /*0x380d8b8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
        void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        /*0x380d83c*/ void OnDeserialization(object sender);
        /*0x380d83c*/ void System.Collections.IDictionary.Remove(object key);
        /*0x3907c14*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
        /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
        /*0x380d8b8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
        /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
        /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x3907c14*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
        /*0x380b9e8*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
        /*0x380b6a0*/ int <ObserveCountChanged>b__25_0();
    }

    class ReactiveDictionaryExtensions
    {
        static /*0x382eaf0*/ UniRx.ReactiveDictionary<TKey, TValue> ToReactiveDictionary<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary);
    }

    interface IReadOnlyReactiveProperty<T> : System.IObservable<T>
    {
        /*0x3907c14*/ T get_Value();
        /*0x380b128*/ bool get_HasValue();
    }

    interface IReactiveProperty<T> : UniRx.IReadOnlyReactiveProperty<T>, System.IObservable<T>
    {
        /*0x3907c14*/ T get_Value();
        /*0x3907c14*/ void set_Value(T value);
    }

    interface IObserverLinkedList<T>
    {
        /*0x380d83c*/ void UnsubscribeNode(UniRx.ObserverNode<T> node);
    }

    class ObserverNode<T> : System.IObserver<T>, System.IDisposable
    {
        /*0x0*/ System.IObserver<T> observer;
        /*0x0*/ UniRx.IObserverLinkedList<T> list;
        /*0x0*/ UniRx.ObserverNode<T> <Previous>k__BackingField;
        /*0x0*/ UniRx.ObserverNode<T> <Next>k__BackingField;

        /*0x380d93c*/ ObserverNode(UniRx.IObserverLinkedList<T> list, System.IObserver<T> observer);
        /*0x380b9e8*/ UniRx.ObserverNode<T> get_Previous();
        /*0x380d83c*/ void set_Previous(UniRx.ObserverNode<T> value);
        /*0x380b9e8*/ UniRx.ObserverNode<T> get_Next();
        /*0x380d83c*/ void set_Next(UniRx.ObserverNode<T> value);
        /*0x3907c14*/ void OnNext(T value);
        /*0x380d83c*/ void OnError(System.Exception error);
        /*0x380cb08*/ void OnCompleted();
        /*0x380cb08*/ void Dispose();
    }

    class ReactiveProperty<T> : UniRx.IReactiveProperty<T>, UniRx.IReadOnlyReactiveProperty<T>, System.IObservable<T>, System.IDisposable, UniRx.IOptimizedObservable<T>, UniRx.IObserverLinkedList<T>
    {
        static /*0x0*/ System.Collections.Generic.IEqualityComparer<T> defaultEqualityComparer;
        /*0x0*/ T value;
        /*0x0*/ UniRx.ObserverNode<T> root;
        /*0x0*/ UniRx.ObserverNode<T> last;
        /*0x0*/ bool isDisposed;

        static /*0x38358cc*/ ReactiveProperty();
        /*0x380cb08*/ ReactiveProperty();
        /*0x3907c14*/ ReactiveProperty(T initialValue);
        /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<T> get_EqualityComparer();
        /*0x3907c14*/ T get_Value();
        /*0x3907c14*/ void set_Value(T value);
        /*0x380b128*/ bool get_HasValue();
        /*0x380d83c*/ void RaiseOnNext(ref T value);
        /*0x3907c14*/ void SetValue(T value);
        /*0x3907c14*/ void SetValueAndForceNotify(T value);
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380d83c*/ void UniRx.IObserverLinkedList<T>.UnsubscribeNode(UniRx.ObserverNode<T> node);
        /*0x380cb08*/ void Dispose();
        /*0x380cdf0*/ void Dispose(bool disposing);
        /*0x380b9e8*/ string ToString();
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
    }

    class ReadOnlyReactiveProperty<T> : UniRx.IReadOnlyReactiveProperty<T>, System.IObservable<T>, System.IDisposable, UniRx.IOptimizedObservable<T>, UniRx.IObserverLinkedList<T>, System.IObserver<T>
    {
        static /*0x0*/ System.Collections.Generic.IEqualityComparer<T> defaultEqualityComparer;
        /*0x0*/ bool distinctUntilChanged;
        /*0x0*/ bool canPublishValueOnSubscribe;
        /*0x0*/ bool isDisposed;
        /*0x0*/ bool isSourceCompleted;
        /*0x0*/ T latestValue;
        /*0x0*/ System.Exception lastException;
        /*0x0*/ System.IDisposable sourceConnection;
        /*0x0*/ UniRx.ObserverNode<T> root;
        /*0x0*/ UniRx.ObserverNode<T> last;

        static /*0x38358cc*/ ReadOnlyReactiveProperty();
        /*0x380d83c*/ ReadOnlyReactiveProperty(System.IObservable<T> source);
        ReadOnlyReactiveProperty(System.IObservable<T> source, bool distinctUntilChanged);
        /*0x3907c14*/ ReadOnlyReactiveProperty(System.IObservable<T> source, T initialValue);
        /*0x3907c14*/ ReadOnlyReactiveProperty(System.IObservable<T> source, T initialValue, bool distinctUntilChanged);
        /*0x3907c14*/ T get_Value();
        /*0x380b128*/ bool get_HasValue();
        /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<T> get_EqualityComparer();
        /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        /*0x380cb08*/ void Dispose();
        /*0x380cdf0*/ void Dispose(bool disposing);
        /*0x380d83c*/ void UniRx.IObserverLinkedList<T>.UnsubscribeNode(UniRx.ObserverNode<T> node);
        /*0x3907c14*/ void System.IObserver<T>.OnNext(T value);
        /*0x380d83c*/ void System.IObserver<T>.OnError(System.Exception error);
        /*0x380cb08*/ void System.IObserver<T>.OnCompleted();
        /*0x380b9e8*/ string ToString();
        /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
    }

    class ReactivePropertyExtensions
    {
        static /*0x0*/ System.Action<object> Callback;

        static /*0x78eacb0*/ ReactivePropertyExtensions();
        static /*0x382eaf0*/ UniRx.IReadOnlyReactiveProperty<T> ToReactiveProperty<T>(System.IObservable<T> source);
        static /*0x3907c14*/ UniRx.IReadOnlyReactiveProperty<T> ToReactiveProperty<T>(System.IObservable<T> source, T initialValue);
        static /*0x382eaf0*/ UniRx.ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(System.IObservable<T> source);
        static /*0x78ea884*/ void CancelCallback(object state);
        static /*0x382fdd8*/ System.Threading.Tasks.Task<T> WaitUntilValueChangedAsync<T>(UniRx.IReadOnlyReactiveProperty<T> source, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ System.Runtime.CompilerServices.TaskAwaiter<T> GetAwaiter<T>(UniRx.IReadOnlyReactiveProperty<T> source);
        static /*0x382eaf0*/ UniRx.ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(System.IObservable<T> source);
        static /*0x3907c14*/ UniRx.ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(System.IObservable<T> source, T initialValue);
        static /*0x3907c14*/ UniRx.ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(System.IObservable<T> source, T initialValue);
        static /*0x382eaf0*/ System.IObservable<T> SkipLatestValueOnSubscribe<T>(UniRx.IReadOnlyReactiveProperty<T> source);
        static /*0x78eaa00*/ System.IObservable<bool> CombineLatestValuesAreAllTrue(System.Collections.Generic.IEnumerable<System.IObservable<bool>> sources);
        static /*0x78eab58*/ System.IObservable<bool> CombineLatestValuesAreAllFalse(System.Collections.Generic.IEnumerable<System.IObservable<bool>> sources);

        class <>c
        {
            static /*0x0*/ UniRx.ReactivePropertyExtensions.<> <>9;
            static /*0x8*/ System.Func<System.Collections.Generic.IList<bool>, bool> <>9__11_0;
            static /*0x10*/ System.Func<System.Collections.Generic.IList<bool>, bool> <>9__12_0;

            static /*0x78ead50*/ <>c();
            /*0x78eadb8*/ <>c();
            /*0x78eadc0*/ bool <CombineLatestValuesAreAllTrue>b__11_0(System.Collections.Generic.IList<bool> xs);
            /*0x78eb090*/ bool <CombineLatestValuesAreAllFalse>b__12_0(System.Collections.Generic.IList<bool> xs);
        }

        class <>c__DisplayClass5_0<T>
        {
            /*0x0*/ UniRx.SingleAssignmentDisposable disposable;
            /*0x0*/ UniRx.InternalUtil.CancellableTaskCompletionSource<T> tcs;

            /*0x380cb08*/ <>c__DisplayClass5_0();
            /*0x380d83c*/ void <WaitUntilValueChangedAsync>b__4(System.Exception ex);
            /*0x380cb08*/ void <WaitUntilValueChangedAsync>b__5();
            /*0x3907c14*/ void <WaitUntilValueChangedAsync>b__0(T x);
            /*0x380d83c*/ void <WaitUntilValueChangedAsync>b__1(System.Exception ex);
            /*0x380cb08*/ void <WaitUntilValueChangedAsync>b__2();
        }

        class <>c__DisplayClass5_<T>
        {
            /*0x0*/ bool isFirstValue;
            /*0x0*/ UniRx.ReactivePropertyExtensions.<>c__DisplayClass5_0<T> CS$<>8__locals1;

            /*0x380cb08*/ <>c__DisplayClass5_();
            /*0x3907c14*/ void <WaitUntilValueChangedAsync>b__3(T x);
        }
    }

    class UnityEventExtensions
    {
        static /*0x78eb360*/ System.IObservable<UniRx.Unit> AsObservable(UnityEngine.Events.UnityEvent unityEvent);
        static /*0x382eaf0*/ System.IObservable<T> AsObservable<T>(UnityEngine.Events.UnityEvent<T> unityEvent);
        static /*0x382eaf0*/ System.IObservable<System.Tuple<T0, T1>> AsObservable<T0, T1>(UnityEngine.Events.UnityEvent<T0, T1> unityEvent);
        static /*0x382eaf0*/ System.IObservable<System.Tuple<T0, T1, T2>> AsObservable<T0, T1, T2>(UnityEngine.Events.UnityEvent<T0, T1, T2> unityEvent);
        static /*0x382eaf0*/ System.IObservable<System.Tuple<T0, T1, T2, T3>> AsObservable<T0, T1, T2, T3>(UnityEngine.Events.UnityEvent<T0, T1, T2, T3> unityEvent);

        class <>c
        {
            static /*0x0*/ UniRx.UnityEventExtensions.<> <>9;
            static /*0x8*/ System.Func<System.Action, UnityEngine.Events.UnityAction> <>9__0_0;

            static /*0x78eb54c*/ <>c();
            /*0x78eb5b4*/ <>c();
            /*0x78eb5bc*/ UnityEngine.Events.UnityAction <AsObservable>b__0_0(System.Action h);
        }

        class <>c__<T>
        {
            static /*0x0*/ UniRx.UnityEventExtensions.<>c__1<T> <>9;
            static /*0x0*/ System.Func<System.Action<T>, UnityEngine.Events.UnityAction<T>> <>9__1_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x380bb68*/ UnityEngine.Events.UnityAction<T> <AsObservable>b__1_0(System.Action<T> h);
        }

        class <>c__<T0, T1>
        {
            static /*0x0*/ UniRx.UnityEventExtensions.<>c__2<T0, T1> <>9;
            static /*0x0*/ System.Func<System.Action<System.Tuple<T0, T1>>, UnityEngine.Events.UnityAction<T0, T1>> <>9__2_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x380bb68*/ UnityEngine.Events.UnityAction<T0, T1> <AsObservable>b__2_0(System.Action<System.Tuple<T0, T1>> h);
        }

        class <>c__<T0, T1, T2>
        {
            static /*0x0*/ UniRx.UnityEventExtensions.<>c__3<T0, T1, T2> <>9;
            static /*0x0*/ System.Func<System.Action<System.Tuple<T0, T1, T2>>, UnityEngine.Events.UnityAction<T0, T1, T2>> <>9__3_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x380bb68*/ UnityEngine.Events.UnityAction<T0, T1, T2> <AsObservable>b__3_0(System.Action<System.Tuple<T0, T1, T2>> h);
        }

        class <>c__<T0, T1, T2, T3>
        {
            static /*0x0*/ UniRx.UnityEventExtensions.<>c__4<T0, T1, T2, T3> <>9;
            static /*0x0*/ System.Func<System.Action<System.Tuple<T0, T1, T2, T3>>, UnityEngine.Events.UnityAction<T0, T1, T2, T3>> <>9__4_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x380bb68*/ UnityEngine.Events.UnityAction<T0, T1, T2, T3> <AsObservable>b__4_0(System.Action<System.Tuple<T0, T1, T2, T3>> h);
        }

        class <>c__DisplayClass0_0
        {
            /*0x10*/ UnityEngine.Events.UnityEvent unityEvent;

            /*0x78eb544*/ <>c__DisplayClass0_0();
            /*0x78eb638*/ void <AsObservable>b__1(UnityEngine.Events.UnityAction h);
            /*0x78eb654*/ void <AsObservable>b__2(UnityEngine.Events.UnityAction h);
        }

        class <>c__DisplayClass1_0<T>
        {
            /*0x0*/ UnityEngine.Events.UnityEvent<T> unityEvent;

            /*0x380cb08*/ <>c__DisplayClass1_0();
            /*0x380d83c*/ void <AsObservable>b__1(UnityEngine.Events.UnityAction<T> h);
            /*0x380d83c*/ void <AsObservable>b__2(UnityEngine.Events.UnityAction<T> h);
        }

        class <>c__DisplayClass2_0<T0, T1>
        {
            /*0x0*/ UnityEngine.Events.UnityEvent<T0, T1> unityEvent;

            /*0x380cb08*/ <>c__DisplayClass2_0();
            /*0x380d83c*/ void <AsObservable>b__1(UnityEngine.Events.UnityAction<T0, T1> h);
            /*0x380d83c*/ void <AsObservable>b__2(UnityEngine.Events.UnityAction<T0, T1> h);
        }

        class <>c__DisplayClass2_1<T0, T1>
        {
            /*0x0*/ System.Action<System.Tuple<T0, T1>> h;

            /*0x380cb08*/ <>c__DisplayClass2_1();
            /*0x3907c14*/ void <AsObservable>b__3(T0 t0, T1 t1);
        }

        class <>c__DisplayClass3_0<T0, T1, T2>
        {
            /*0x0*/ UnityEngine.Events.UnityEvent<T0, T1, T2> unityEvent;

            /*0x380cb08*/ <>c__DisplayClass3_0();
            /*0x380d83c*/ void <AsObservable>b__1(UnityEngine.Events.UnityAction<T0, T1, T2> h);
            /*0x380d83c*/ void <AsObservable>b__2(UnityEngine.Events.UnityAction<T0, T1, T2> h);
        }

        class <>c__DisplayClass3_1<T0, T1, T2>
        {
            /*0x0*/ System.Action<System.Tuple<T0, T1, T2>> h;

            /*0x380cb08*/ <>c__DisplayClass3_1();
            /*0x3907c14*/ void <AsObservable>b__3(T0 t0, T1 t1, T2 t2);
        }

        class <>c__DisplayClass4_0<T0, T1, T2, T3>
        {
            /*0x0*/ UnityEngine.Events.UnityEvent<T0, T1, T2, T3> unityEvent;

            /*0x380cb08*/ <>c__DisplayClass4_0();
            /*0x380d83c*/ void <AsObservable>b__1(UnityEngine.Events.UnityAction<T0, T1, T2, T3> h);
            /*0x380d83c*/ void <AsObservable>b__2(UnityEngine.Events.UnityAction<T0, T1, T2, T3> h);
        }

        class <>c__DisplayClass4_1<T0, T1, T2, T3>
        {
            /*0x0*/ System.Action<System.Tuple<T0, T1, T2, T3>> h;

            /*0x380cb08*/ <>c__DisplayClass4_1();
            /*0x3907c14*/ void <AsObservable>b__3(T0 t0, T1 t1, T2 t2, T3 t3);
        }
    }

    class UnityGraphicExtensions
    {
        static /*0x78eb670*/ System.IObservable<UniRx.Unit> DirtyLayoutCallbackAsObservable(UnityEngine.UI.Graphic graphic);
        static /*0x78eb778*/ System.IObservable<UniRx.Unit> DirtyMaterialCallbackAsObservable(UnityEngine.UI.Graphic graphic);
        static /*0x78eb880*/ System.IObservable<UniRx.Unit> DirtyVerticesCallbackAsObservable(UnityEngine.UI.Graphic graphic);

        class <>c__DisplayClass0_0
        {
            /*0x10*/ UnityEngine.UI.Graphic graphic;

            /*0x78eb770*/ <>c__DisplayClass0_0();
            /*0x78eb988*/ System.IDisposable <DirtyLayoutCallbackAsObservable>b__0(System.IObserver<UniRx.Unit> observer);
        }

        class <>c__DisplayClass0_1
        {
            /*0x10*/ System.IObserver<UniRx.Unit> observer;
            /*0x18*/ UnityEngine.Events.UnityAction registerHandler;
            /*0x20*/ UniRx.UnityGraphicExtensions.<> CS$<>8__locals1;

            /*0x78ebae4*/ <>c__DisplayClass0_1();
            /*0x78ebaec*/ void <DirtyLayoutCallbackAsObservable>b__1();
            /*0x78ebbf0*/ void <DirtyLayoutCallbackAsObservable>b__2();
        }

        class <>c__DisplayClass1_0
        {
            /*0x10*/ UnityEngine.UI.Graphic graphic;

            /*0x78eb878*/ <>c__DisplayClass1_0();
            /*0x78ebc1c*/ System.IDisposable <DirtyMaterialCallbackAsObservable>b__0(System.IObserver<UniRx.Unit> observer);
        }

        class <>c__DisplayClass1_1
        {
            /*0x10*/ System.IObserver<UniRx.Unit> observer;
            /*0x18*/ UnityEngine.Events.UnityAction registerHandler;
            /*0x20*/ UniRx.UnityGraphicExtensions.<> CS$<>8__locals1;

            /*0x78ebd78*/ <>c__DisplayClass1_1();
            /*0x78ebd80*/ void <DirtyMaterialCallbackAsObservable>b__1();
            /*0x78ebe84*/ void <DirtyMaterialCallbackAsObservable>b__2();
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ UnityEngine.UI.Graphic graphic;

            /*0x78eb980*/ <>c__DisplayClass2_0();
            /*0x78ebeb0*/ System.IDisposable <DirtyVerticesCallbackAsObservable>b__0(System.IObserver<UniRx.Unit> observer);
        }

        class <>c__DisplayClass2_1
        {
            /*0x10*/ System.IObserver<UniRx.Unit> observer;
            /*0x18*/ UnityEngine.Events.UnityAction registerHandler;
            /*0x20*/ UniRx.UnityGraphicExtensions.<> CS$<>8__locals1;

            /*0x78ec00c*/ <>c__DisplayClass2_1();
            /*0x78ec014*/ void <DirtyVerticesCallbackAsObservable>b__1();
            /*0x78ec118*/ void <DirtyVerticesCallbackAsObservable>b__2();
        }
    }

    class UnityUIComponentExtensions
    {
        static /*0x78ec144*/ System.IDisposable SubscribeToText(System.IObservable<string> source, UnityEngine.UI.Text text);
        static /*0x3830700*/ System.IDisposable SubscribeToText<T>(System.IObservable<T> source, UnityEngine.UI.Text text);
        static /*0x3830a9c*/ System.IDisposable SubscribeToText<T>(System.IObservable<T> source, UnityEngine.UI.Text text, System.Func<T, string> selector);
        static /*0x78e99a4*/ System.IDisposable SubscribeToInteractable(System.IObservable<bool> source, UnityEngine.UI.Selectable selectable);
        static /*0x78e9aac*/ System.IObservable<UniRx.Unit> OnClickAsObservable(UnityEngine.UI.Button button);
        static /*0x78ec24c*/ System.IObservable<bool> OnValueChangedAsObservable(UnityEngine.UI.Toggle toggle);
        static /*0x78ec368*/ System.IObservable<float> OnValueChangedAsObservable(UnityEngine.UI.Scrollbar scrollbar);
        static /*0x78ec484*/ System.IObservable<UnityEngine.Vector2> OnValueChangedAsObservable(UnityEngine.UI.ScrollRect scrollRect);
        static /*0x78ec5a0*/ System.IObservable<float> OnValueChangedAsObservable(UnityEngine.UI.Slider slider);
        static /*0x78ec6bc*/ System.IObservable<string> OnEndEditAsObservable(UnityEngine.UI.InputField inputField);
        static /*0x78ec70c*/ System.IObservable<string> OnValueChangedAsObservable(UnityEngine.UI.InputField inputField);
        static /*0x78ec828*/ System.IObservable<int> OnValueChangedAsObservable(UnityEngine.UI.Dropdown dropdown);

        class <>c
        {
            static /*0x0*/ UniRx.UnityUIComponentExtensions.<> <>9;
            static /*0x8*/ System.Action<string, UnityEngine.UI.Text> <>9__0_0;
            static /*0x10*/ System.Action<bool, UnityEngine.UI.Selectable> <>9__3_0;
            static /*0x18*/ System.Func<UnityEngine.UI.Toggle, System.IObserver<bool>, System.IDisposable> <>9__5_0;
            static /*0x20*/ System.Func<UnityEngine.UI.Scrollbar, System.IObserver<float>, System.IDisposable> <>9__6_0;
            static /*0x28*/ System.Func<UnityEngine.UI.ScrollRect, System.IObserver<UnityEngine.Vector2>, System.IDisposable> <>9__7_0;
            static /*0x30*/ System.Func<UnityEngine.UI.Slider, System.IObserver<float>, System.IDisposable> <>9__8_0;
            static /*0x38*/ System.Func<UnityEngine.UI.InputField, System.IObserver<string>, System.IDisposable> <>9__10_0;
            static /*0x40*/ System.Func<UnityEngine.UI.Dropdown, System.IObserver<int>, System.IDisposable> <>9__11_0;

            static /*0x78ec944*/ <>c();
            /*0x78ec9ac*/ <>c();
            /*0x78ec9b4*/ void <SubscribeToText>b__0_0(string x, UnityEngine.UI.Text t);
            /*0x78ec9dc*/ void <SubscribeToInteractable>b__3_0(bool x, UnityEngine.UI.Selectable s);
            /*0x78ec9f8*/ System.IDisposable <OnValueChangedAsObservable>b__5_0(UnityEngine.UI.Toggle t, System.IObserver<bool> observer);
            /*0x78ecb48*/ System.IDisposable <OnValueChangedAsObservable>b__6_0(UnityEngine.UI.Scrollbar s, System.IObserver<float> observer);
            /*0x78ecca0*/ System.IDisposable <OnValueChangedAsObservable>b__7_0(UnityEngine.UI.ScrollRect s, System.IObserver<UnityEngine.Vector2> observer);
            /*0x78ece00*/ System.IDisposable <OnValueChangedAsObservable>b__8_0(UnityEngine.UI.Slider s, System.IObserver<float> observer);
            /*0x78ecf60*/ System.IDisposable <OnValueChangedAsObservable>b__10_0(UnityEngine.UI.InputField i, System.IObserver<string> observer);
            /*0x78ed0ac*/ System.IDisposable <OnValueChangedAsObservable>b__11_0(UnityEngine.UI.Dropdown d, System.IObserver<int> observer);
        }

        class <>c__<T>
        {
            static /*0x0*/ UniRx.UnityUIComponentExtensions.<>c__1<T> <>9;
            static /*0x0*/ System.Action<T, UnityEngine.UI.Text> <>9__1_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x3907c14*/ void <SubscribeToText>b__1_0(T x, UnityEngine.UI.Text t);
        }

        class <>c__2<T>
        {
            static /*0x0*/ UniRx.UnityUIComponentExtensions.<>c__2<T> <>9;
            static /*0x0*/ System.Action<T, UnityEngine.UI.Text, System.Func<T, string>> <>9__2_0;

            static /*0x38358cc*/ <>c__2();
            /*0x380cb08*/ <>c__2();
            /*0x3907c14*/ void <SubscribeToText>b__2_0(T x, UnityEngine.UI.Text t, System.Func<T, string> s);
        }
    }

    class YieldInstructionCache
    {
        static /*0x0*/ UnityEngine.WaitForEndOfFrame WaitForEndOfFrame;
        static /*0x8*/ UnityEngine.WaitForFixedUpdate WaitForFixedUpdate;

        static /*0x78ed1f8*/ YieldInstructionCache();
    }

    namespace Triggers
    {
        class ObservableAnimatorTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<int> onAnimatorIK;
            /*0x58*/ UniRx.Subject<UniRx.Unit> onAnimatorMove;

            /*0x78ed558*/ ObservableAnimatorTrigger();
            /*0x78ed2b8*/ void OnAnimatorIK(int layerIndex);
            /*0x78ed318*/ System.IObservable<int> OnAnimatorIKAsObservable();
            /*0x78ed39c*/ void OnAnimatorMove();
            /*0x78ed458*/ System.IObservable<UniRx.Unit> OnAnimatorMoveAsObservable();
            /*0x78ed4dc*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableBeginDragTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onBeginDrag;

            /*0x78ed69c*/ ObservableBeginDragTrigger();
            /*0x78ed560*/ void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ed5c0*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsObservable();
            /*0x78ed644*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableCancelTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onCancel;

            /*0x78ed7e0*/ ObservableCancelTrigger();
            /*0x78ed6a4*/ void UnityEngine.EventSystems.ICancelHandler.OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78ed704*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnCancelAsObservable();
            /*0x78ed788*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableCanvasGroupChangedTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> onCanvasGroupChanged;

            /*0x78ed980*/ ObservableCanvasGroupChangedTrigger();
            /*0x78ed7e8*/ void OnCanvasGroupChanged();
            /*0x78ed8a4*/ System.IObservable<UniRx.Unit> OnCanvasGroupChangedAsObservable();
            /*0x78ed928*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableCollision2DTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UnityEngine.Collision2D> onCollisionEnter2D;
            /*0x58*/ UniRx.Subject<UnityEngine.Collision2D> onCollisionExit2D;
            /*0x60*/ UniRx.Subject<UnityEngine.Collision2D> onCollisionStay2D;

            /*0x78edcac*/ ObservableCollision2DTrigger();
            /*0x78ed988*/ void OnCollisionEnter2D(UnityEngine.Collision2D coll);
            /*0x78ed9e8*/ System.IObservable<UnityEngine.Collision2D> OnCollisionEnter2DAsObservable();
            /*0x78eda6c*/ void OnCollisionExit2D(UnityEngine.Collision2D coll);
            /*0x78edacc*/ System.IObservable<UnityEngine.Collision2D> OnCollisionExit2DAsObservable();
            /*0x78edb50*/ void OnCollisionStay2D(UnityEngine.Collision2D coll);
            /*0x78edbb0*/ System.IObservable<UnityEngine.Collision2D> OnCollisionStay2DAsObservable();
            /*0x78edc34*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableCollisionTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UnityEngine.Collision> onCollisionEnter;
            /*0x58*/ UniRx.Subject<UnityEngine.Collision> onCollisionExit;
            /*0x60*/ UniRx.Subject<UnityEngine.Collision> onCollisionStay;

            /*0x78edfd8*/ ObservableCollisionTrigger();
            /*0x78edcb4*/ void OnCollisionEnter(UnityEngine.Collision collision);
            /*0x78edd14*/ System.IObservable<UnityEngine.Collision> OnCollisionEnterAsObservable();
            /*0x78edd98*/ void OnCollisionExit(UnityEngine.Collision collisionInfo);
            /*0x78eddf8*/ System.IObservable<UnityEngine.Collision> OnCollisionExitAsObservable();
            /*0x78ede7c*/ void OnCollisionStay(UnityEngine.Collision collisionInfo);
            /*0x78ededc*/ System.IObservable<UnityEngine.Collision> OnCollisionStayAsObservable();
            /*0x78edf60*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableDeselectTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDeselectHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onDeselect;

            /*0x78ee11c*/ ObservableDeselectTrigger();
            /*0x78edfe0*/ void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78ee040*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnDeselectAsObservable();
            /*0x78ee0c4*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableDestroyTrigger : UnityEngine.MonoBehaviour
        {
            /*0x20*/ bool calledDestroy;
            /*0x28*/ UniRx.Subject<UniRx.Unit> onDestroy;
            /*0x30*/ UniRx.CompositeDisposable disposablesOnDestroy;
            /*0x38*/ bool <IsMonitoredActivate>k__BackingField;
            /*0x39*/ bool <IsActivated>k__BackingField;

            /*0x78ee4ec*/ ObservableDestroyTrigger();
            /*0x78ee124*/ bool get_IsMonitoredActivate();
            /*0x78ee12c*/ void set_IsMonitoredActivate(bool value);
            /*0x78ee138*/ bool get_IsActivated();
            /*0x78ee140*/ void set_IsActivated(bool value);
            /*0x78ee14c*/ bool get_IsCalledOnDestroy();
            /*0x78ee154*/ void Awake();
            /*0x78ee160*/ void OnDestroy();
            /*0x78ee26c*/ System.IObservable<UniRx.Unit> OnDestroyAsObservable();
            /*0x78d1f70*/ void ForceRaiseOnDestroy();
            /*0x78ee3f0*/ void AddDisposableOnDestroy(System.IDisposable disposable);
        }

        class ObservableDragTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onDrag;

            /*0x78ee630*/ ObservableDragTrigger();
            /*0x78ee4f4*/ void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ee554*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnDragAsObservable();
            /*0x78ee5d8*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableDropTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDropHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onDrop;

            /*0x78ee774*/ ObservableDropTrigger();
            /*0x78ee638*/ void UnityEngine.EventSystems.IDropHandler.OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ee698*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnDropAsObservable();
            /*0x78ee71c*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableEnableTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> onEnable;
            /*0x58*/ UniRx.Subject<UniRx.Unit> onDisable;

            /*0x78eea64*/ ObservableEnableTrigger();
            /*0x78ee77c*/ void OnEnable();
            /*0x78ee838*/ System.IObservable<UniRx.Unit> OnEnableAsObservable();
            /*0x78ee8bc*/ void OnDisable();
            /*0x78ee978*/ System.IObservable<UniRx.Unit> OnDisableAsObservable();
            /*0x78ee9fc*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableEndDragTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onEndDrag;

            /*0x78eeba8*/ ObservableEndDragTrigger();
            /*0x78eea6c*/ void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78eeacc*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnEndDragAsObservable();
            /*0x78eeb50*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableEventTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onDeselect;
            /*0x58*/ UniRx.Subject<UnityEngine.EventSystems.AxisEventData> onMove;
            /*0x60*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerDown;
            /*0x68*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerEnter;
            /*0x70*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerExit;
            /*0x78*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerUp;
            /*0x80*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onSelect;
            /*0x88*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerClick;
            /*0x90*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onSubmit;
            /*0x98*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onDrag;
            /*0xa0*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onBeginDrag;
            /*0xa8*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onEndDrag;
            /*0xb0*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onDrop;
            /*0xb8*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onUpdateSelected;
            /*0xc0*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onInitializePotentialDrag;
            /*0xc8*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onCancel;
            /*0xd0*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onScroll;

            /*0x78efc54*/ ObservableEventTrigger();
            /*0x78eebb0*/ void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78eec10*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnDeselectAsObservable();
            /*0x78eec94*/ void UnityEngine.EventSystems.IMoveHandler.OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x78eecf4*/ System.IObservable<UnityEngine.EventSystems.AxisEventData> OnMoveAsObservable();
            /*0x78eed78*/ void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78eedd8*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsObservable();
            /*0x78eee5c*/ void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78eeebc*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsObservable();
            /*0x78eef40*/ void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78eefa0*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsObservable();
            /*0x78ef024*/ void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef084*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsObservable();
            /*0x78ef108*/ void UnityEngine.EventSystems.ISelectHandler.OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78ef168*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnSelectAsObservable();
            /*0x78ef1ec*/ void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef24c*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsObservable();
            /*0x78ef2d0*/ void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78ef330*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnSubmitAsObservable();
            /*0x78ef3b4*/ void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef414*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnDragAsObservable();
            /*0x78ef498*/ void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef4f8*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsObservable();
            /*0x78ef57c*/ void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef5dc*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnEndDragAsObservable();
            /*0x78ef660*/ void UnityEngine.EventSystems.IDropHandler.OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef6c0*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnDropAsObservable();
            /*0x78ef744*/ void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78ef7a4*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsObservable();
            /*0x78ef828*/ void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78ef888*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsObservable();
            /*0x78ef90c*/ void UnityEngine.EventSystems.ICancelHandler.OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78ef96c*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnCancelAsObservable();
            /*0x78ef9f0*/ void UnityEngine.EventSystems.IScrollHandler.OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78efa50*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnScrollAsObservable();
            /*0x78efad4*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableFixedUpdateTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> fixedUpdate;

            /*0x78efdf4*/ ObservableFixedUpdateTrigger();
            /*0x78efc5c*/ void FixedUpdate();
            /*0x78efd18*/ System.IObservable<UniRx.Unit> FixedUpdateAsObservable();
            /*0x78efd9c*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableInitializePotentialDragTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onInitializePotentialDrag;

            /*0x78eff38*/ ObservableInitializePotentialDragTrigger();
            /*0x78efdfc*/ void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78efe5c*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsObservable();
            /*0x78efee0*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableJointTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<float> onJointBreak;
            /*0x58*/ UniRx.Subject<UnityEngine.Joint2D> onJointBreak2D;

            /*0x78f0190*/ ObservableJointTrigger();
            /*0x78eff40*/ void OnJointBreak(float breakForce);
            /*0x78effac*/ System.IObservable<float> OnJointBreakAsObservable();
            /*0x78f0030*/ void OnJointBreak2D(UnityEngine.Joint2D brokenJoint);
            /*0x78f0090*/ System.IObservable<UnityEngine.Joint2D> OnJointBreak2DAsObservable();
            /*0x78f0114*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableLateUpdateTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> lateUpdate;

            /*0x78f0330*/ ObservableLateUpdateTrigger();
            /*0x78f0198*/ void LateUpdate();
            /*0x78f0254*/ System.IObservable<UniRx.Unit> LateUpdateAsObservable();
            /*0x78f02d8*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableMoveTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IMoveHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.AxisEventData> onMove;

            /*0x78f0474*/ ObservableMoveTrigger();
            /*0x78f0338*/ void UnityEngine.EventSystems.IMoveHandler.OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x78f0398*/ System.IObservable<UnityEngine.EventSystems.AxisEventData> OnMoveAsObservable();
            /*0x78f041c*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableParticleTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UnityEngine.GameObject> onParticleCollision;
            /*0x58*/ UniRx.Subject<UniRx.Unit> onParticleTrigger;

            /*0x78f071c*/ ObservableParticleTrigger();
            /*0x78f047c*/ void OnParticleCollision(UnityEngine.GameObject other);
            /*0x78f04dc*/ System.IObservable<UnityEngine.GameObject> OnParticleCollisionAsObservable();
            /*0x78f0560*/ void OnParticleTrigger();
            /*0x78f061c*/ System.IObservable<UniRx.Unit> OnParticleTriggerAsObservable();
            /*0x78f06a0*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservablePointerClickTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerClickHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerClick;

            /*0x78f0860*/ ObservablePointerClickTrigger();
            /*0x78f0724*/ void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78f0784*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsObservable();
            /*0x78f0808*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservablePointerDownTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerDown;

            /*0x78f09a4*/ ObservablePointerDownTrigger();
            /*0x78f0868*/ void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78f08c8*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsObservable();
            /*0x78f094c*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservablePointerEnterTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerEnterHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerEnter;

            /*0x78f0ae8*/ ObservablePointerEnterTrigger();
            /*0x78f09ac*/ void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78f0a0c*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsObservable();
            /*0x78f0a90*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservablePointerExitTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerExit;

            /*0x78f0c2c*/ ObservablePointerExitTrigger();
            /*0x78f0af0*/ void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78f0b50*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsObservable();
            /*0x78f0bd4*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservablePointerUpTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onPointerUp;

            /*0x78f0d70*/ ObservablePointerUpTrigger();
            /*0x78f0c34*/ void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78f0c94*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsObservable();
            /*0x78f0d18*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableRectTransformTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> onRectTransformDimensionsChange;
            /*0x58*/ UniRx.Subject<UniRx.Unit> onRectTransformRemoved;

            /*0x78f1060*/ ObservableRectTransformTrigger();
            /*0x78f0d78*/ void OnRectTransformDimensionsChange();
            /*0x78f0e34*/ System.IObservable<UniRx.Unit> OnRectTransformDimensionsChangeAsObservable();
            /*0x78f0eb8*/ void OnRectTransformRemoved();
            /*0x78f0f74*/ System.IObservable<UniRx.Unit> OnRectTransformRemovedAsObservable();
            /*0x78f0ff8*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableScrollTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IScrollHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.PointerEventData> onScroll;

            /*0x78f11a4*/ ObservableScrollTrigger();
            /*0x78f1068*/ void UnityEngine.EventSystems.IScrollHandler.OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x78f10c8*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnScrollAsObservable();
            /*0x78f114c*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableSelectTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISelectHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onSelect;

            /*0x78f12e8*/ ObservableSelectTrigger();
            /*0x78f11ac*/ void UnityEngine.EventSystems.ISelectHandler.OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78f120c*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnSelectAsObservable();
            /*0x78f1290*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableStateMachineTrigger : UnityEngine.StateMachineBehaviour
        {
            /*0x18*/ UniRx.Subject<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> onStateExit;
            /*0x20*/ UniRx.Subject<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> onStateEnter;
            /*0x28*/ UniRx.Subject<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> onStateIK;
            /*0x30*/ UniRx.Subject<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> onStateUpdate;
            /*0x38*/ UniRx.Subject<UniRx.Triggers.ObservableStateMachineTrigger.OnStateMachineInfo> onStateMachineEnter;
            /*0x40*/ UniRx.Subject<UniRx.Triggers.ObservableStateMachineTrigger.OnStateMachineInfo> onStateMachineExit;

            /*0x78f1b7c*/ ObservableStateMachineTrigger();
            /*0x78f12f0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
            /*0x78f1428*/ System.IObservable<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> OnStateExitAsObservable();
            /*0x78f14ac*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
            /*0x78f158c*/ System.IObservable<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> OnStateEnterAsObservable();
            /*0x78f1610*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
            /*0x78f16f0*/ System.IObservable<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> OnStateIKAsObservable();
            /*0x78f1774*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
            /*0x78f1854*/ System.IObservable<UniRx.Triggers.ObservableStateMachineTrigger.OnStateInfo> OnStateUpdateAsObservable();
            /*0x78f18d8*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
            /*0x78f19c4*/ System.IObservable<UniRx.Triggers.ObservableStateMachineTrigger.OnStateMachineInfo> OnStateMachineEnterAsObservable();
            /*0x78f1a48*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
            /*0x78f1af8*/ System.IObservable<UniRx.Triggers.ObservableStateMachineTrigger.OnStateMachineInfo> OnStateMachineExitAsObservable();

            class OnStateInfo
            {
                /*0x10*/ UnityEngine.Animator <Animator>k__BackingField;
                /*0x18*/ UnityEngine.AnimatorStateInfo <StateInfo>k__BackingField;
                /*0x3c*/ int <LayerIndex>k__BackingField;

                /*0x78f13d0*/ OnStateInfo(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
                /*0x78f1b84*/ UnityEngine.Animator get_Animator();
                /*0x78f1b8c*/ void set_Animator(UnityEngine.Animator value);
                /*0x78f1b94*/ UnityEngine.AnimatorStateInfo get_StateInfo();
                /*0x78f1bac*/ void set_StateInfo(UnityEngine.AnimatorStateInfo value);
                /*0x78f1bc4*/ int get_LayerIndex();
                /*0x78f1bcc*/ void set_LayerIndex(int value);
            }

            class OnStateMachineInfo
            {
                /*0x10*/ UnityEngine.Animator <Animator>k__BackingField;
                /*0x18*/ int <StateMachinePathHash>k__BackingField;

                /*0x78f1988*/ OnStateMachineInfo(UnityEngine.Animator animator, int stateMachinePathHash);
                /*0x78f1bd4*/ UnityEngine.Animator get_Animator();
                /*0x78f1bdc*/ void set_Animator(UnityEngine.Animator value);
                /*0x78f1be4*/ int get_StateMachinePathHash();
                /*0x78f1bec*/ void set_StateMachinePathHash(int value);
            }
        }

        class ObservableSubmitTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onSubmit;

            /*0x78f1d30*/ ObservableSubmitTrigger();
            /*0x78f1bf4*/ void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78f1c54*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnSubmitAsObservable();
            /*0x78f1cd8*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableTransformChangedTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> onBeforeTransformParentChanged;
            /*0x58*/ UniRx.Subject<UniRx.Unit> onTransformParentChanged;
            /*0x60*/ UniRx.Subject<UniRx.Unit> onTransformChildrenChanged;

            /*0x78f2178*/ ObservableTransformChangedTrigger();
            /*0x78f1d40*/ void OnBeforeTransformParentChanged();
            /*0x78f1dfc*/ System.IObservable<UniRx.Unit> OnBeforeTransformParentChangedAsObservable();
            /*0x78f1e80*/ void OnTransformParentChanged();
            /*0x78f1f3c*/ System.IObservable<UniRx.Unit> OnTransformParentChangedAsObservable();
            /*0x78f1fc0*/ void OnTransformChildrenChanged();
            /*0x78f207c*/ System.IObservable<UniRx.Unit> OnTransformChildrenChangedAsObservable();
            /*0x78f2100*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableTrigger2DTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UnityEngine.Collider2D> onTriggerEnter2D;
            /*0x58*/ UniRx.Subject<UnityEngine.Collider2D> onTriggerExit2D;
            /*0x60*/ UniRx.Subject<UnityEngine.Collider2D> onTriggerStay2D;

            /*0x78f24a4*/ ObservableTrigger2DTrigger();
            /*0x78f2180*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
            /*0x78f21e0*/ System.IObservable<UnityEngine.Collider2D> OnTriggerEnter2DAsObservable();
            /*0x78f2264*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
            /*0x78f22c4*/ System.IObservable<UnityEngine.Collider2D> OnTriggerExit2DAsObservable();
            /*0x78f2348*/ void OnTriggerStay2D(UnityEngine.Collider2D other);
            /*0x78f23a8*/ System.IObservable<UnityEngine.Collider2D> OnTriggerStay2DAsObservable();
            /*0x78f242c*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableTriggerBase : UnityEngine.MonoBehaviour
        {
            /*0x20*/ bool calledAwake;
            /*0x28*/ UniRx.Subject<UniRx.Unit> awake;
            /*0x30*/ bool calledStart;
            /*0x38*/ UniRx.Subject<UniRx.Unit> start;
            /*0x40*/ bool calledDestroy;
            /*0x48*/ UniRx.Subject<UniRx.Unit> onDestroy;

            /*0x78f1d38*/ ObservableTriggerBase();
            /*0x78f24ac*/ void Awake();
            /*0x78f25a4*/ System.IObservable<UniRx.Unit> AwakeAsObservable();
            /*0x78f26f0*/ void Start();
            /*0x78f27e8*/ System.IObservable<UniRx.Unit> StartAsObservable();
            /*0x78f2934*/ void OnDestroy();
            /*0x78f2a2c*/ System.IObservable<UniRx.Unit> OnDestroyAsObservable();
            /*0x380cb08*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableTriggerExtensions
        {
            static /*0x78f2bb0*/ System.IObservable<int> OnAnimatorIKAsObservable(UnityEngine.Component component);
            static /*0x78f2ccc*/ System.IObservable<UniRx.Unit> OnAnimatorMoveAsObservable(UnityEngine.Component component);
            static /*0x78f2de8*/ System.IObservable<UnityEngine.Collision2D> OnCollisionEnter2DAsObservable(UnityEngine.Component component);
            static /*0x78f2f04*/ System.IObservable<UnityEngine.Collision2D> OnCollisionExit2DAsObservable(UnityEngine.Component component);
            static /*0x78f3020*/ System.IObservable<UnityEngine.Collision2D> OnCollisionStay2DAsObservable(UnityEngine.Component component);
            static /*0x78f313c*/ System.IObservable<UnityEngine.Collision> OnCollisionEnterAsObservable(UnityEngine.Component component);
            static /*0x78f3258*/ System.IObservable<UnityEngine.Collision> OnCollisionExitAsObservable(UnityEngine.Component component);
            static /*0x78f3374*/ System.IObservable<UnityEngine.Collision> OnCollisionStayAsObservable(UnityEngine.Component component);
            static /*0x78f3490*/ System.IObservable<UniRx.Unit> OnDestroyAsObservable(UnityEngine.Component component);
            static /*0x78f362c*/ System.IObservable<UniRx.Unit> OnEnableAsObservable(UnityEngine.Component component);
            static /*0x78f3748*/ System.IObservable<UniRx.Unit> OnDisableAsObservable(UnityEngine.Component component);
            static /*0x78f3864*/ System.IObservable<UniRx.Unit> FixedUpdateAsObservable(UnityEngine.Component component);
            static /*0x78f3980*/ System.IObservable<UniRx.Unit> LateUpdateAsObservable(UnityEngine.Component component);
            static /*0x78f3a9c*/ System.IObservable<UnityEngine.Collider2D> OnTriggerEnter2DAsObservable(UnityEngine.Component component);
            static /*0x78f3bb4*/ System.IObservable<UnityEngine.Collider2D> OnTriggerExit2DAsObservable(UnityEngine.Component component);
            static /*0x78f3ccc*/ System.IObservable<UnityEngine.Collider2D> OnTriggerStay2DAsObservable(UnityEngine.Component component);
            static /*0x78f3de4*/ System.IObservable<UnityEngine.Collider> OnTriggerEnterAsObservable(UnityEngine.Component component);
            static /*0x78f3f80*/ System.IObservable<UnityEngine.Collider> OnTriggerExitAsObservable(UnityEngine.Component component);
            static /*0x78f411c*/ System.IObservable<UnityEngine.Collider> OnTriggerStayAsObservable(UnityEngine.Component component);
            static /*0x78f42b8*/ System.IObservable<UniRx.Unit> UpdateAsObservable(UnityEngine.Component component);
            static /*0x78f4454*/ System.IObservable<UniRx.Unit> OnBecameInvisibleAsObservable(UnityEngine.Component component);
            static /*0x78f45f0*/ System.IObservable<UniRx.Unit> OnBecameVisibleAsObservable(UnityEngine.Component component);
            static /*0x78f478c*/ System.IObservable<UniRx.Unit> OnBeforeTransformParentChangedAsObservable(UnityEngine.Component component);
            static /*0x78f48a4*/ System.IObservable<UniRx.Unit> OnTransformParentChangedAsObservable(UnityEngine.Component component);
            static /*0x78f49bc*/ System.IObservable<UniRx.Unit> OnTransformChildrenChangedAsObservable(UnityEngine.Component component);
            static /*0x78f4ad4*/ System.IObservable<UniRx.Unit> OnCanvasGroupChangedAsObservable(UnityEngine.Component component);
            static /*0x78f4bf0*/ System.IObservable<UniRx.Unit> OnRectTransformDimensionsChangeAsObservable(UnityEngine.Component component);
            static /*0x78f4d0c*/ System.IObservable<UniRx.Unit> OnRectTransformRemovedAsObservable(UnityEngine.Component component);
            static /*0x78f4e28*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnDeselectAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f4f44*/ System.IObservable<UnityEngine.EventSystems.AxisEventData> OnMoveAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5060*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f517c*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5298*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f53b4*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f54d0*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnSelectAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f55ec*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5708*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnSubmitAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5820*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnDragAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f593c*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5a58*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnEndDragAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5b74*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnDropAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5c90*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5e2c*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f5f48*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnCancelAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f6064*/ System.IObservable<UnityEngine.EventSystems.PointerEventData> OnScrollAsObservable(UnityEngine.EventSystems.UIBehaviour component);
            static /*0x78f6180*/ System.IObservable<UnityEngine.GameObject> OnParticleCollisionAsObservable(UnityEngine.Component component);
            static /*0x78f629c*/ System.IObservable<UniRx.Unit> OnParticleTriggerAsObservable(UnityEngine.Component component);
            static /*0x78f63b8*/ System.IObservable<int> OnAnimatorIKAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6490*/ System.IObservable<UniRx.Unit> OnAnimatorMoveAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6568*/ System.IObservable<UnityEngine.Collision2D> OnCollisionEnter2DAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6640*/ System.IObservable<UnityEngine.Collision2D> OnCollisionExit2DAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6718*/ System.IObservable<UnityEngine.Collision2D> OnCollisionStay2DAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f67f0*/ System.IObservable<UnityEngine.Collision> OnCollisionEnterAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f68c8*/ System.IObservable<UnityEngine.Collision> OnCollisionExitAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f69a0*/ System.IObservable<UnityEngine.Collision> OnCollisionStayAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6a78*/ System.IObservable<UniRx.Unit> OnDestroyAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6bd0*/ System.IObservable<UniRx.Unit> OnEnableAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6ca8*/ System.IObservable<UniRx.Unit> OnDisableAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6d80*/ System.IObservable<UniRx.Unit> FixedUpdateAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6e58*/ System.IObservable<UniRx.Unit> LateUpdateAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f6f30*/ System.IObservable<UnityEngine.Collider2D> OnTriggerEnter2DAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7004*/ System.IObservable<UnityEngine.Collider2D> OnTriggerExit2DAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f70d8*/ System.IObservable<UnityEngine.Collider2D> OnTriggerStay2DAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f71ac*/ System.IObservable<UnityEngine.Collider> OnTriggerEnterAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7280*/ System.IObservable<UnityEngine.Collider> OnTriggerExitAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7354*/ System.IObservable<UnityEngine.Collider> OnTriggerStayAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7428*/ System.IObservable<UniRx.Unit> UpdateAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f74fc*/ System.IObservable<UniRx.Unit> OnBecameInvisibleAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f75d0*/ System.IObservable<UniRx.Unit> OnBecameVisibleAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f76a4*/ System.IObservable<UniRx.Unit> OnBeforeTransformParentChangedAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7778*/ System.IObservable<UniRx.Unit> OnTransformParentChangedAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f784c*/ System.IObservable<UniRx.Unit> OnTransformChildrenChangedAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7920*/ System.IObservable<UniRx.Unit> OnCanvasGroupChangedAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f79f8*/ System.IObservable<UniRx.Unit> OnRectTransformDimensionsChangeAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7ad0*/ System.IObservable<UniRx.Unit> OnRectTransformRemovedAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7ba8*/ System.IObservable<UnityEngine.GameObject> OnParticleCollisionAsObservable(UnityEngine.GameObject gameObject);
            static /*0x78f7c80*/ System.IObservable<UniRx.Unit> OnParticleTriggerAsObservable(UnityEngine.GameObject gameObject);
            static /*0x3907c14*/ T GetOrAddComponent<T>(UnityEngine.GameObject gameObject);
        }

        class ObservableTriggerTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UnityEngine.Collider> onTriggerEnter;
            /*0x58*/ UniRx.Subject<UnityEngine.Collider> onTriggerExit;
            /*0x60*/ UniRx.Subject<UnityEngine.Collider> onTriggerStay;

            /*0x78f7ef0*/ ObservableTriggerTrigger();
            /*0x78f7d58*/ void OnTriggerEnter(UnityEngine.Collider other);
            /*0x78f3efc*/ System.IObservable<UnityEngine.Collider> OnTriggerEnterAsObservable();
            /*0x78f7db8*/ void OnTriggerExit(UnityEngine.Collider other);
            /*0x78f4098*/ System.IObservable<UnityEngine.Collider> OnTriggerExitAsObservable();
            /*0x78f7e18*/ void OnTriggerStay(UnityEngine.Collider other);
            /*0x78f4234*/ System.IObservable<UnityEngine.Collider> OnTriggerStayAsObservable();
            /*0x78f7e78*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableUpdateSelectedTrigger : UniRx.Triggers.ObservableTriggerBase, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IUpdateSelectedHandler
        {
            /*0x50*/ UniRx.Subject<UnityEngine.EventSystems.BaseEventData> onUpdateSelected;

            /*0x78f7fb0*/ ObservableUpdateSelectedTrigger();
            /*0x78f7ef8*/ void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x78f5da8*/ System.IObservable<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsObservable();
            /*0x78f7f58*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableUpdateTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> update;

            /*0x78f80cc*/ ObservableUpdateTrigger();
            /*0x78f7fb8*/ void Update();
            /*0x78f43d0*/ System.IObservable<UniRx.Unit> UpdateAsObservable();
            /*0x78f8074*/ void RaiseOnCompletedOnDestroy();
        }

        class ObservableVisibleTrigger : UniRx.Triggers.ObservableTriggerBase
        {
            /*0x50*/ UniRx.Subject<UniRx.Unit> onBecameInvisible;
            /*0x58*/ UniRx.Subject<UniRx.Unit> onBecameVisible;

            /*0x78f82b4*/ ObservableVisibleTrigger();
            /*0x78f80d4*/ void OnBecameInvisible();
            /*0x78f456c*/ System.IObservable<UniRx.Unit> OnBecameInvisibleAsObservable();
            /*0x78f8190*/ void OnBecameVisible();
            /*0x78f4708*/ System.IObservable<UniRx.Unit> OnBecameVisibleAsObservable();
            /*0x78f824c*/ void RaiseOnCompletedOnDestroy();
        }
    }

    namespace Toolkit
    {
        class ObjectPool<T> : System.IDisposable
        {
            /*0x0*/ bool isDisposed;
            /*0x0*/ System.Collections.Generic.Queue<T> q;

            /*0x380cb08*/ ObjectPool();
            /*0x380b6a0*/ int get_MaxPoolCount();
            /*0x3907c14*/ T CreateInstance();
            /*0x3907c14*/ void OnBeforeRent(T instance);
            /*0x3907c14*/ void OnBeforeReturn(T instance);
            /*0x3907c14*/ void OnClear(T instance);
            /*0x380b6a0*/ int get_Count();
            /*0x3907c14*/ T Rent();
            /*0x3907c14*/ void Return(T instance);
            /*0x380cdf0*/ void Clear(bool callOnBeforeRent);
            /*0x3907c14*/ void Shrink(float instanceCountRatio, int minSize, bool callOnBeforeRent);
            /*0x3907c14*/ System.IDisposable StartShrinkTimer(System.TimeSpan checkInterval, float instanceCountRatio, int minSize, bool callOnBeforeRent);
            System.IObservable<UniRx.Unit> PreloadAsync(int preloadCount, int threshold);
            /*0x3907c14*/ System.Collections.IEnumerator PreloadCore(int preloadCount, int threshold, System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
            /*0x380cdf0*/ void Dispose(bool disposing);
            /*0x380cb08*/ void Dispose();

            class <>c__DisplayClass14_0<T>
            {
                /*0x0*/ UniRx.Toolkit.ObjectPool<T> <>4__this;
                /*0x0*/ float instanceCountRatio;
                /*0x0*/ int minSize;
                /*0x0*/ bool callOnBeforeRent;

                /*0x380cb08*/ <>c__DisplayClass14_0();
                bool <StartShrinkTimer>b__0(long _);
                /*0x380d438*/ void <StartShrinkTimer>b__1(long _);
            }

            class <>c__DisplayClass15_0<T>
            {
                /*0x0*/ UniRx.Toolkit.ObjectPool<T> <>4__this;
                /*0x0*/ int preloadCount;
                /*0x0*/ int threshold;

                /*0x380cb08*/ <>c__DisplayClass15_0();
                /*0x380bc30*/ System.Collections.IEnumerator <PreloadAsync>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancel);
            }

            class <PreloadCore>d__16<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ object <>2__current;
                /*0x0*/ int preloadCount;
                /*0x0*/ UniRx.Toolkit.ObjectPool<T> <>4__this;
                /*0x0*/ int threshold;
                /*0x0*/ System.IObserver<UniRx.Unit> observer;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;

                /*0x380cffc*/ <PreloadCore>d__16(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class AsyncObjectPool<T> : System.IDisposable
        {
            /*0x0*/ bool isDisposed;
            /*0x0*/ System.Collections.Generic.Queue<T> q;

            /*0x380cb08*/ AsyncObjectPool();
            /*0x380b6a0*/ int get_MaxPoolCount();
            /*0x380b9e8*/ System.IObservable<T> CreateInstanceAsync();
            /*0x3907c14*/ void OnBeforeRent(T instance);
            /*0x3907c14*/ void OnBeforeReturn(T instance);
            /*0x3907c14*/ void OnClear(T instance);
            /*0x380b6a0*/ int get_Count();
            /*0x380b9e8*/ System.IObservable<T> RentAsync();
            /*0x3907c14*/ void Return(T instance);
            /*0x3907c14*/ void Shrink(float instanceCountRatio, int minSize, bool callOnBeforeRent);
            /*0x3907c14*/ System.IDisposable StartShrinkTimer(System.TimeSpan checkInterval, float instanceCountRatio, int minSize, bool callOnBeforeRent);
            /*0x380cdf0*/ void Clear(bool callOnBeforeRent);
            System.IObservable<UniRx.Unit> PreloadAsync(int preloadCount, int threshold);
            /*0x3907c14*/ System.Collections.IEnumerator PreloadCore(int preloadCount, int threshold, System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancellationToken);
            /*0x380cdf0*/ void Dispose(bool disposing);
            /*0x380cb08*/ void Dispose();
            /*0x3907c14*/ void <RentAsync>b__10_0(T x);
            /*0x3907c14*/ void <PreloadCore>b__16_0(T x);

            class <>c__DisplayClass13_0<T>
            {
                /*0x0*/ UniRx.Toolkit.AsyncObjectPool<T> <>4__this;
                /*0x0*/ float instanceCountRatio;
                /*0x0*/ int minSize;
                /*0x0*/ bool callOnBeforeRent;

                /*0x380cb08*/ <>c__DisplayClass13_0();
                bool <StartShrinkTimer>b__0(long _);
                /*0x380d438*/ void <StartShrinkTimer>b__1(long _);
            }

            class <>c__DisplayClass15_0<T>
            {
                /*0x0*/ UniRx.Toolkit.AsyncObjectPool<T> <>4__this;
                /*0x0*/ int preloadCount;
                /*0x0*/ int threshold;

                /*0x380cb08*/ <>c__DisplayClass15_0();
                /*0x380bc30*/ System.Collections.IEnumerator <PreloadAsync>b__0(System.IObserver<UniRx.Unit> observer, System.Threading.CancellationToken cancel);
            }

            class <PreloadCore>d__16<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ object <>2__current;
                /*0x0*/ int preloadCount;
                /*0x0*/ UniRx.Toolkit.AsyncObjectPool<T> <>4__this;
                /*0x0*/ int threshold;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ System.IObserver<UniRx.Unit> observer;
                /*0x0*/ UniRx.ObservableYieldInstruction<UniRx.Unit> <awaiter>5__2;

                /*0x380cffc*/ <PreloadCore>d__16(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            }
        }
    }

    namespace Diagnostics
    {
        struct LogEntry
        {
            /*0x10*/ string <LoggerName>k__BackingField;
            /*0x18*/ UnityEngine.LogType <LogType>k__BackingField;
            /*0x20*/ string <Message>k__BackingField;
            /*0x28*/ System.DateTime <Timestamp>k__BackingField;
            /*0x30*/ UnityEngine.Object <Context>k__BackingField;
            /*0x38*/ System.Exception <Exception>k__BackingField;
            /*0x40*/ string <StackTrace>k__BackingField;
            /*0x48*/ object <State>k__BackingField;

            /*0x78f833c*/ LogEntry(string loggerName, UnityEngine.LogType logType, System.DateTime timestamp, string message, UnityEngine.Object context, System.Exception exception, string stackTrace, object state);
            /*0x78f82bc*/ string get_LoggerName();
            /*0x78f82c4*/ void set_LoggerName(string value);
            /*0x78f82cc*/ UnityEngine.LogType get_LogType();
            /*0x78f82d4*/ void set_LogType(UnityEngine.LogType value);
            /*0x78f82dc*/ string get_Message();
            /*0x78f82e4*/ void set_Message(string value);
            /*0x78f82ec*/ System.DateTime get_Timestamp();
            /*0x78f82f4*/ void set_Timestamp(System.DateTime value);
            /*0x78f82fc*/ UnityEngine.Object get_Context();
            /*0x78f8304*/ void set_Context(UnityEngine.Object value);
            /*0x78f830c*/ System.Exception get_Exception();
            /*0x78f8314*/ void set_Exception(System.Exception value);
            /*0x78f831c*/ string get_StackTrace();
            /*0x78f8324*/ void set_StackTrace(string value);
            /*0x78f832c*/ object get_State();
            /*0x78f8334*/ void set_State(object value);
            /*0x78f840c*/ string ToString();
        }

        class LogEntryExtensions
        {
            static /*0x78f86a0*/ System.IDisposable LogToUnityDebug(System.IObservable<UniRx.Diagnostics.LogEntry> source);
        }

        class Logger
        {
            static /*0x0*/ bool isInitialized;
            static /*0x1*/ bool isDebugBuild;
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ System.Action<UniRx.Diagnostics.LogEntry> logPublisher;

            /*0x78f8780*/ Logger(string loggerName);
            /*0x78f8770*/ string get_Name();
            /*0x78f8778*/ void set_Name(string value);
            /*0x78f88fc*/ void Debug(object message, UnityEngine.Object context);
            /*0x78f8a8c*/ void DebugFormat(string format, object[] args);
            /*0x78f8c1c*/ void Log(object message, UnityEngine.Object context);
            /*0x78f8d34*/ void LogFormat(string format, object[] args);
            /*0x78f8e4c*/ void Warning(object message, UnityEngine.Object context);
            /*0x78f8f64*/ void WarningFormat(string format, object[] args);
            /*0x78f907c*/ void Error(object message, UnityEngine.Object context);
            /*0x78f9194*/ void ErrorFormat(string format, object[] args);
            /*0x78f92ac*/ void Exception(System.Exception exception, UnityEngine.Object context);
            /*0x78f93c4*/ void Raw(UniRx.Diagnostics.LogEntry logEntry);
        }

        class ObservableDebugExtensions
        {
            static /*0x3830700*/ System.IObservable<T> Debug<T>(System.IObservable<T> source, string label);
            static /*0x3830700*/ System.IObservable<T> Debug<T>(System.IObservable<T> source, UniRx.Diagnostics.Logger logger);
        }

        class ObservableLogger : System.IObservable<UniRx.Diagnostics.LogEntry>
        {
            static /*0x0*/ UniRx.Subject<UniRx.Diagnostics.LogEntry> logPublisher;
            static /*0x8*/ UniRx.Diagnostics.ObservableLogger Listener;

            static /*0x78f94a0*/ ObservableLogger();
            static /*0x78f880c*/ System.Action<UniRx.Diagnostics.LogEntry> RegisterLogger(UniRx.Diagnostics.Logger logger);
            /*0x78f9418*/ ObservableLogger();
            /*0x78f9420*/ System.IDisposable Subscribe(System.IObserver<UniRx.Diagnostics.LogEntry> observer);
        }

        class UnityDebugSink : System.IObserver<UniRx.Diagnostics.LogEntry>
        {
            /*0x78f8768*/ UnityDebugSink();
            /*0x78f9560*/ void OnCompleted();
            /*0x78f9564*/ void OnError(System.Exception error);
            /*0x78f9568*/ void OnNext(UniRx.Diagnostics.LogEntry value);
        }
    }

    namespace Operators
    {
        class AggregateObservable<TSource> : UniRx.Operators.OperatorObservableBase<TSource>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Func<TSource, TSource, TSource> accumulator;

            /*0x380d93c*/ AggregateObservable(System.IObservable<TSource> source, System.Func<TSource, TSource, TSource> accumulator);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TSource> observer, System.IDisposable cancel);

            class Aggregate<TSource> : UniRx.Operators.OperatorObserverBase<TSource, TSource>
            {
                /*0x0*/ UniRx.Operators.AggregateObservable<TSource> parent;
                /*0x0*/ TSource accumulation;
                /*0x0*/ bool seenValue;

                /*0x380da4c*/ Aggregate(UniRx.Operators.AggregateObservable<TSource> parent, System.IObserver<TSource> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class AggregateObservable<TSource, TAccumulate> : UniRx.Operators.OperatorObservableBase<TAccumulate>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ TAccumulate seed;
            /*0x0*/ System.Func<TAccumulate, TSource, TAccumulate> accumulator;

            /*0x3907c14*/ AggregateObservable(System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TAccumulate> observer, System.IDisposable cancel);

            class Aggregate<TSource, TAccumulate> : UniRx.Operators.OperatorObserverBase<TSource, TAccumulate>
            {
                /*0x0*/ UniRx.Operators.AggregateObservable<TSource, TAccumulate> parent;
                /*0x0*/ TAccumulate accumulation;

                /*0x380da4c*/ Aggregate(UniRx.Operators.AggregateObservable<TSource, TAccumulate> parent, System.IObserver<TAccumulate> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class AggregateObservable<TSource, TAccumulate, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ TAccumulate seed;
            /*0x0*/ System.Func<TAccumulate, TSource, TAccumulate> accumulator;
            /*0x0*/ System.Func<TAccumulate, TResult> resultSelector;

            /*0x3907c14*/ AggregateObservable(System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator, System.Func<TAccumulate, TResult> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class Aggregate<TSource, TAccumulate, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.AggregateObservable<TSource, TAccumulate, TResult> parent;
                /*0x0*/ TAccumulate accumulation;

                /*0x380da4c*/ Aggregate(UniRx.Operators.AggregateObservable<TSource, TAccumulate, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class AmbObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObservable<T> second;

            /*0x380d93c*/ AmbObservable(System.IObservable<T> source, System.IObservable<T> second);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class AmbOuterObserver<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.AmbObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.SingleAssignmentDisposable leftSubscription;
                /*0x0*/ UniRx.SingleAssignmentDisposable rightSubscription;
                /*0x0*/ UniRx.Operators.AmbObservable.AmbOuterObserver.AmbState<T> choice;

                /*0x380da4c*/ AmbOuterObserver(UniRx.Operators.AmbObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                enum AmbState<T>
                {
                    Left = 0,
                    Right = 1,
                    Neither = 2,
                }

                class Amb<T> : System.IObserver<T>
                {
                    /*0x0*/ System.IObserver<T> targetObserver;
                    /*0x0*/ System.IDisposable targetDisposable;

                    /*0x380cb08*/ Amb();
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }

                class AmbDecisionObserver<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.AmbObservable.AmbOuterObserver<T> parent;
                    /*0x0*/ UniRx.Operators.AmbObservable.AmbOuterObserver.AmbState<T> me;
                    /*0x0*/ System.IDisposable otherSubscription;
                    /*0x0*/ UniRx.Operators.AmbObservable.AmbOuterObserver.Amb<T> self;

                    /*0x3907c14*/ AmbDecisionObserver(UniRx.Operators.AmbObservable.AmbOuterObserver<T> parent, UniRx.Operators.AmbObservable.AmbOuterObserver.AmbState<T> me, System.IDisposable otherSubscription, UniRx.Operators.AmbObservable.AmbOuterObserver.Amb<T> self);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class AsObservableObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ AsObservableObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class AsObservable<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ AsObservable(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class AsSingleUnitObservableObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ AsSingleUnitObservableObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class AsSingleUnitObservable<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Unit>
            {
                /*0x380d93c*/ AsSingleUnitObservable(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class AsUnitObservableObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ AsUnitObservableObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class AsUnitObservable<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Unit>
            {
                /*0x380d93c*/ AsUnitObservable(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class BufferObservable<T> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<T>>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int count;
            /*0x0*/ int skip;
            /*0x0*/ System.TimeSpan timeSpan;
            /*0x0*/ System.TimeSpan timeShift;
            /*0x0*/ UniRx.IScheduler scheduler;

            BufferObservable(System.IObservable<T> source, int count, int skip);
            /*0x3907c14*/ BufferObservable(System.IObservable<T> source, System.TimeSpan timeSpan, System.TimeSpan timeShift, UniRx.IScheduler scheduler);
            /*0x3907c14*/ BufferObservable(System.IObservable<T> source, System.TimeSpan timeSpan, int count, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);

            class Buffer<T> : UniRx.Operators.OperatorObserverBase<T, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.BufferObservable<T> parent;
                /*0x0*/ System.Collections.Generic.List<T> list;

                /*0x380da4c*/ Buffer(UniRx.Operators.BufferObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Buffer_<T> : UniRx.Operators.OperatorObserverBase<T, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.BufferObservable<T> parent;
                /*0x0*/ System.Collections.Generic.Queue<System.Collections.Generic.List<T>> q;
                /*0x0*/ int index;

                /*0x380da4c*/ Buffer_(UniRx.Operators.BufferObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class BufferT<T> : UniRx.Operators.OperatorObserverBase<T, System.Collections.Generic.IList<T>>
            {
                static /*0x0*/ T[] EmptyArray;
                /*0x0*/ UniRx.Operators.BufferObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.List<T> list;

                static /*0x38358cc*/ BufferT();
                /*0x380da4c*/ BufferT(UniRx.Operators.BufferObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class Buffer<T> : System.IObserver<long>
                {
                    /*0x0*/ UniRx.Operators.BufferObservable.BufferT<T> parent;

                    /*0x380d83c*/ Buffer(UniRx.Operators.BufferObservable.BufferT<T> parent);
                    /*0x380d438*/ void OnNext(long value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class BufferTS<T> : UniRx.Operators.OperatorObserverBase<T, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.BufferObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<System.Collections.Generic.IList<T>> q;
                /*0x0*/ System.TimeSpan totalTime;
                /*0x0*/ System.TimeSpan nextShift;
                /*0x0*/ System.TimeSpan nextSpan;
                /*0x0*/ UniRx.SerialDisposable timerD;

                /*0x380da4c*/ BufferTS(UniRx.Operators.BufferObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void CreateTimer();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ UniRx.Operators.BufferObservable.BufferTS<T> <>4__this;
                    /*0x0*/ bool isShift;
                    /*0x0*/ bool isSpan;

                    /*0x380cb08*/ <>c__DisplayClass9_0();
                    /*0x380cb08*/ void <CreateTimer>b__0();
                }
            }

            class BufferTC<T> : UniRx.Operators.OperatorObserverBase<T, System.Collections.Generic.IList<T>>
            {
                static /*0x0*/ T[] EmptyArray;
                /*0x0*/ UniRx.Operators.BufferObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.List<T> list;
                /*0x0*/ long timerId;
                /*0x0*/ UniRx.SerialDisposable timerD;

                static /*0x38358cc*/ BufferTC();
                /*0x380da4c*/ BufferTC(UniRx.Operators.BufferObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void CreateTimer();
                /*0x380d438*/ void OnNextTick(long currentTimerId);
                void OnNextRecursive(long currentTimerId, System.Action<System.TimeSpan> self);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ UniRx.Operators.BufferObservable.BufferTC<T> <>4__this;
                    /*0x0*/ long currentTimerId;

                    /*0x380cb08*/ <>c__DisplayClass8_0();
                    /*0x380cb08*/ void <CreateTimer>b__0();
                    /*0x380d83c*/ void <CreateTimer>b__1(System.Action<System.TimeSpan> self);
                }
            }
        }

        class BufferObservable<TSource, TWindowBoundary> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<TSource>>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.IObservable<TWindowBoundary> windowBoundaries;

            /*0x380d93c*/ BufferObservable(System.IObservable<TSource> source, System.IObservable<TWindowBoundary> windowBoundaries);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<TSource>> observer, System.IDisposable cancel);

            class Buffer<TSource, TWindowBoundary> : UniRx.Operators.OperatorObserverBase<TSource, System.Collections.Generic.IList<TSource>>
            {
                static /*0x0*/ TSource[] EmptyArray;
                /*0x0*/ UniRx.Operators.BufferObservable<TSource, TWindowBoundary> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.List<TSource> list;

                static /*0x38358cc*/ Buffer();
                /*0x380da4c*/ Buffer(UniRx.Operators.BufferObservable<TSource, TWindowBoundary> parent, System.IObserver<System.Collections.Generic.IList<TSource>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class Buffer_<TSource, TWindowBoundary> : System.IObserver<TWindowBoundary>
                {
                    /*0x0*/ UniRx.Operators.BufferObservable.Buffer<TSource, TWindowBoundary> parent;

                    /*0x380d83c*/ Buffer_(UniRx.Operators.BufferObservable.Buffer<TSource, TWindowBoundary> parent);
                    /*0x3907c14*/ void OnNext(TWindowBoundary value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class CastObservable<TSource, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TSource> source;

            /*0x380d83c*/ CastObservable(System.IObservable<TSource> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class Cast<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x380d93c*/ Cast(System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CatchObservable<T, TException> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<TException, System.IObservable<T>> errorHandler;

            /*0x380d93c*/ CatchObservable(System.IObservable<T> source, System.Func<TException, System.IObservable<T>> errorHandler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Catch<T, TException> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.CatchObservable<T, TException> parent;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;
                /*0x0*/ UniRx.SingleAssignmentDisposable exceptionSubscription;

                /*0x380da4c*/ Catch(UniRx.Operators.CatchObservable<T, TException> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CatchObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> sources;

            /*0x380d83c*/ CatchObservable(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Catch<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.CatchObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool isDisposed;
                /*0x0*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> e;
                /*0x0*/ UniRx.SerialDisposable subscription;
                /*0x0*/ System.Exception lastException;
                /*0x0*/ System.Action nextSelf;

                /*0x380da4c*/ Catch(UniRx.Operators.CatchObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void RecursiveRun(System.Action self);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__8_0();
            }
        }

        class CombineLatestFunc<T1, T2, T3, TR> : System.MulticastDelegate
        {
            CombineLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class CombineLatestFunc<T1, T2, T3, T4, TR> : System.MulticastDelegate
        {
            CombineLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class CombineLatestFunc<T1, T2, T3, T4, T5, TR> : System.MulticastDelegate
        {
            CombineLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> : System.MulticastDelegate
        {
            CombineLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> : System.MulticastDelegate
        {
            CombineLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class CombineLatestObservable<TLeft, TRight, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TLeft> left;
            /*0x0*/ System.IObservable<TRight> right;
            /*0x0*/ System.Func<TLeft, TRight, TResult> selector;

            /*0x380da4c*/ CombineLatestObservable(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class CombineLatest<TLeft, TRight, TResult> : UniRx.Operators.OperatorObserverBase<TResult, TResult>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<TLeft, TRight, TResult> parent;
                /*0x0*/ object gate;
                /*0x0*/ TLeft leftValue;
                /*0x0*/ bool leftStarted;
                /*0x0*/ bool leftCompleted;
                /*0x0*/ TRight rightValue;
                /*0x0*/ bool rightStarted;
                /*0x0*/ bool rightCompleted;

                /*0x380da4c*/ CombineLatest(UniRx.Operators.CombineLatestObservable<TLeft, TRight, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void Publish();
                /*0x3907c14*/ void OnNext(TResult value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class LeftObserver<TLeft, TRight, TResult> : System.IObserver<TLeft>
                {
                    /*0x0*/ UniRx.Operators.CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ LeftObserver(UniRx.Operators.CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TLeft value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }

                class RightObserver<TLeft, TRight, TResult> : System.IObserver<TRight>
                {
                    /*0x0*/ UniRx.Operators.CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ RightObserver(UniRx.Operators.CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TRight value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class CombineLatestObservable<T> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<T>>
        {
            /*0x0*/ System.IObservable<T> sources;

            /*0x380d83c*/ CombineLatestObservable(System.IObservable<T> sources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);

            class CombineLatest<T> : UniRx.Operators.OperatorObserverBase<System.Collections.Generic.IList<T>, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ int length;
                /*0x0*/ T[] values;
                /*0x0*/ bool[] isStarted;
                /*0x0*/ bool[] isCompleted;
                /*0x0*/ bool isAllValueStarted;

                /*0x380da4c*/ CombineLatest(UniRx.Operators.CombineLatestObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cffc*/ void Publish(int index);
                /*0x380d83c*/ void OnNext(System.Collections.Generic.IList<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class CombineLatestObserver<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.CombineLatestObservable.CombineLatest<T> parent;
                    /*0x0*/ int index;

                    /*0x380d8b8*/ CombineLatestObserver(UniRx.Operators.CombineLatestObservable.CombineLatest<T> parent, int index);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception ex);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class CombineLatestObservable<T1, T2, T3, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ UniRx.Operators.CombineLatestFunc<T1, T2, T3, TR> resultSelector;

            /*0x380da84*/ CombineLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, UniRx.Operators.CombineLatestFunc<T1, T2, T3, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class CombineLatest<T1, T2, T3, TR> : UniRx.Operators.NthCombineLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<T1, T2, T3, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T3> c3;

                CombineLatest(int length, UniRx.Operators.CombineLatestObservable<T1, T2, T3, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CombineLatestObservable<T1, T2, T3, T4, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector;

            /*0x380db04*/ CombineLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class CombineLatest<T1, T2, T3, T4, TR> : UniRx.Operators.NthCombineLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T4> c4;

                CombineLatest(int length, UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CombineLatestObservable<T1, T2, T3, T4, T5, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector;

            /*0x380db40*/ CombineLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class CombineLatest<T1, T2, T3, T4, T5, TR> : UniRx.Operators.NthCombineLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T4> c4;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T5> c5;

                CombineLatest(int length, UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ System.IObservable<T6> source6;
            /*0x0*/ UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector;

            /*0x380db80*/ CombineLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class CombineLatest<T1, T2, T3, T4, T5, T6, TR> : UniRx.Operators.NthCombineLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T4> c4;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T5> c5;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T6> c6;

                CombineLatest(int length, UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ System.IObservable<T6> source6;
            /*0x0*/ System.IObservable<T7> source7;
            /*0x0*/ UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector;

            /*0x380dbc4*/ CombineLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, System.IObservable<T7> source7, UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class CombineLatest<T1, T2, T3, T4, T5, T6, T7, TR> : UniRx.Operators.NthCombineLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T4> c4;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T5> c5;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T6> c6;
                /*0x0*/ UniRx.Operators.CombineLatestObserver<T7> c7;

                CombineLatest(int length, UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        interface ICombineLatestObservable
        {
            /*0x380cffc*/ void Publish(int index);
            /*0x380d83c*/ void Fail(System.Exception error);
            /*0x380cffc*/ void Done(int index);
        }

        class NthCombineLatestObserverBase<T> : UniRx.Operators.OperatorObserverBase<T, T>, UniRx.Operators.ICombineLatestObservable
        {
            /*0x0*/ int length;
            /*0x0*/ bool isAllValueStarted;
            /*0x0*/ bool[] isStarted;
            /*0x0*/ bool[] isCompleted;

            NthCombineLatestObserverBase(int length, System.IObserver<T> observer, System.IDisposable cancel);
            /*0x3907c14*/ T GetResult();
            /*0x380cffc*/ void Publish(int index);
            /*0x380cffc*/ void Done(int index);
            /*0x380d83c*/ void Fail(System.Exception error);
        }

        class CombineLatestObserver<T> : System.IObserver<T>
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.Operators.ICombineLatestObservable parent;
            /*0x0*/ int index;
            /*0x0*/ T value;

            CombineLatestObserver(object gate, UniRx.Operators.ICombineLatestObservable parent, int index);
            /*0x3907c14*/ T get_Value();
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class ConcatObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> sources;

            static /*0x3830700*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> CombineSources(System.Collections.Generic.IEnumerable<System.IObservable<T>> first, System.Collections.Generic.IEnumerable<System.IObservable<T>> second);
            /*0x380d83c*/ ConcatObservable(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
            /*0x380bb68*/ System.IObservable<T> Combine(System.Collections.Generic.IEnumerable<System.IObservable<T>> combineSources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Concat<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ConcatObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool isDisposed;
                /*0x0*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> e;
                /*0x0*/ UniRx.SerialDisposable subscription;
                /*0x0*/ System.Action nextSelf;

                /*0x380da4c*/ Concat(UniRx.Operators.ConcatObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void RecursiveRun(System.Action self);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__7_0();
            }

            class <CombineSources>d__3<T> : System.Collections.Generic.IEnumerable<System.IObservable<T>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.IObservable<T>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.IObservable<T> <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> first;
                /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> <>3__first;
                /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> second;
                /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> <>3__second;
                /*0x0*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> <>7__wrap1;

                /*0x380cffc*/ <CombineSources>d__3(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void <>m__Finally1();
                /*0x380cb08*/ void <>m__Finally2();
                /*0x380b9e8*/ System.IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ContinueWithObservable<TSource, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Func<TSource, System.IObservable<TResult>> selector;

            /*0x380d93c*/ ContinueWithObservable(System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TResult>> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class ContinueWith<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.ContinueWithObservable<TSource, TResult> parent;
                /*0x0*/ UniRx.SerialDisposable serialDisposable;
                /*0x0*/ bool seenValue;
                /*0x0*/ TSource lastValue;

                /*0x380da4c*/ ContinueWith(UniRx.Operators.ContinueWithObservable<TSource, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CreateObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Func<System.IObserver<T>, System.IDisposable> subscribe;

            /*0x380d83c*/ CreateObservable(System.Func<System.IObserver<T>, System.IDisposable> subscribe);
            CreateObservable(System.Func<System.IObserver<T>, System.IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Create<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Create(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CreateObservable<T, TState> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ TState state;
            /*0x0*/ System.Func<TState, System.IObserver<T>, System.IDisposable> subscribe;

            /*0x3907c14*/ CreateObservable(TState state, System.Func<TState, System.IObserver<T>, System.IDisposable> subscribe);
            /*0x3907c14*/ CreateObservable(TState state, System.Func<TState, System.IObserver<T>, System.IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Create<T, TState> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Create(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class CreateSafeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Func<System.IObserver<T>, System.IDisposable> subscribe;

            /*0x380d83c*/ CreateSafeObservable(System.Func<System.IObserver<T>, System.IDisposable> subscribe);
            CreateSafeObservable(System.Func<System.IObserver<T>, System.IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class CreateSafe<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ CreateSafe(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DefaultIfEmptyObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ T defaultValue;

            /*0x3907c14*/ DefaultIfEmptyObservable(System.IObservable<T> source, T defaultValue);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DefaultIfEmpty<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DefaultIfEmptyObservable<T> parent;
                /*0x0*/ bool hasValue;

                /*0x380da4c*/ DefaultIfEmpty(UniRx.Operators.DefaultIfEmptyObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DeferObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Func<System.IObservable<T>> observableFactory;

            /*0x380d83c*/ DeferObservable(System.Func<System.IObservable<T>> observableFactory);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Defer<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Defer(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DelayObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.TimeSpan dueTime;
            /*0x0*/ UniRx.IScheduler scheduler;

            DelayObservable(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Delay<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DelayObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool hasFailed;
                /*0x0*/ bool running;
                /*0x0*/ bool active;
                /*0x0*/ System.Exception exception;
                /*0x0*/ System.Collections.Generic.Queue<UniRx.Timestamped<T>> queue;
                /*0x0*/ bool onCompleted;
                /*0x0*/ System.DateTimeOffset completeAt;
                /*0x0*/ System.IDisposable sourceSubscription;
                /*0x0*/ System.TimeSpan delay;
                /*0x0*/ bool ready;
                /*0x0*/ UniRx.SerialDisposable cancelable;

                /*0x380da4c*/ Delay(UniRx.Operators.DelayObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380d83c*/ void DrainQueue(System.Action<System.TimeSpan> recurse);
            }
        }

        class DelaySubscriptionObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ UniRx.IScheduler scheduler;
            /*0x0*/ System.Nullable<System.TimeSpan> dueTimeT;
            /*0x0*/ System.Nullable<System.DateTimeOffset> dueTimeD;

            DelaySubscriptionObservable(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
            DelaySubscriptionObservable(System.IObservable<T> source, System.DateTimeOffset dueTime, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class <>c__DisplayClass6_0<T>
            {
                /*0x0*/ UniRx.Operators.DelaySubscriptionObservable<T> <>4__this;
                /*0x0*/ System.IObserver<T> observer;

                /*0x380cb08*/ <>c__DisplayClass6_0();
            }

            class <>c__DisplayClass6_<T>
            {
                /*0x0*/ UniRx.MultipleAssignmentDisposable d;
                /*0x0*/ UniRx.Operators.DelaySubscriptionObservable.<>c__DisplayClass6_0<T> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass6_();
                /*0x380cb08*/ void <SubscribeCore>b__0();
            }

            class <>c__DisplayClass6_2<T>
            {
                /*0x0*/ UniRx.MultipleAssignmentDisposable d;
                /*0x0*/ UniRx.Operators.DelaySubscriptionObservable.<>c__DisplayClass6_0<T> CS$<>8__locals2;

                /*0x380cb08*/ <>c__DisplayClass6_2();
                /*0x380cb08*/ void <SubscribeCore>b__1();
            }
        }

        class DematerializeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<UniRx.Notification<T>> source;

            /*0x380d83c*/ DematerializeObservable(System.IObservable<UniRx.Notification<T>> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Dematerialize<T> : UniRx.Operators.OperatorObserverBase<UniRx.Notification<T>, T>
            {
                /*0x0*/ UniRx.Operators.DematerializeObservable<T> parent;

                /*0x380da4c*/ Dematerialize(UniRx.Operators.DematerializeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void OnNext(UniRx.Notification<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DistinctObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<T> comparer;

            /*0x380d93c*/ DistinctObservable(System.IObservable<T> source, System.Collections.Generic.IEqualityComparer<T> comparer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Distinct<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ System.Collections.Generic.HashSet<T> hashSet;

                /*0x380da4c*/ Distinct(UniRx.Operators.DistinctObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DistinctObservable<T, TKey> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TKey> comparer;
            /*0x0*/ System.Func<T, TKey> keySelector;

            /*0x380da4c*/ DistinctObservable(System.IObservable<T> source, System.Func<T, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Distinct<T, TKey> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DistinctObservable<T, TKey> parent;
                /*0x0*/ System.Collections.Generic.HashSet<TKey> hashSet;

                /*0x380da4c*/ Distinct(UniRx.Operators.DistinctObservable<T, TKey> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DistinctUntilChangedObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<T> comparer;

            /*0x380d93c*/ DistinctUntilChangedObservable(System.IObservable<T> source, System.Collections.Generic.IEqualityComparer<T> comparer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DistinctUntilChanged<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DistinctUntilChangedObservable<T> parent;
                /*0x0*/ bool isFirst;
                /*0x0*/ T prevKey;

                /*0x380da4c*/ DistinctUntilChanged(UniRx.Operators.DistinctUntilChangedObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DistinctUntilChangedObservable<T, TKey> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TKey> comparer;
            /*0x0*/ System.Func<T, TKey> keySelector;

            /*0x380da4c*/ DistinctUntilChangedObservable(System.IObservable<T> source, System.Func<T, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DistinctUntilChanged<T, TKey> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DistinctUntilChangedObservable<T, TKey> parent;
                /*0x0*/ bool isFirst;
                /*0x0*/ TKey prevKey;

                /*0x380da4c*/ DistinctUntilChanged(UniRx.Operators.DistinctUntilChangedObservable<T, TKey> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action<T> onNext;
            /*0x0*/ System.Action<System.Exception> onError;
            /*0x0*/ System.Action onCompleted;

            /*0x380da84*/ DoObservable(System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Do<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoObservable<T> parent;

                /*0x380da4c*/ Do(UniRx.Operators.DoObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoObserverObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObserver<T> observer;

            /*0x380d93c*/ DoObserverObservable(System.IObservable<T> source, System.IObserver<T> observer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Do<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoObserverObservable<T> parent;

                /*0x380da4c*/ Do(UniRx.Operators.DoObserverObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoOnErrorObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action<System.Exception> onError;

            /*0x380d93c*/ DoOnErrorObservable(System.IObservable<T> source, System.Action<System.Exception> onError);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DoOnError<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoOnErrorObservable<T> parent;

                /*0x380da4c*/ DoOnError(UniRx.Operators.DoOnErrorObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoOnCompletedObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action onCompleted;

            /*0x380d93c*/ DoOnCompletedObservable(System.IObservable<T> source, System.Action onCompleted);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DoOnCompleted<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoOnCompletedObservable<T> parent;

                /*0x380da4c*/ DoOnCompleted(UniRx.Operators.DoOnCompletedObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoOnTerminateObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action onTerminate;

            /*0x380d93c*/ DoOnTerminateObservable(System.IObservable<T> source, System.Action onTerminate);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DoOnTerminate<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoOnTerminateObservable<T> parent;

                /*0x380da4c*/ DoOnTerminate(UniRx.Operators.DoOnTerminateObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoOnSubscribeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action onSubscribe;

            /*0x380d93c*/ DoOnSubscribeObservable(System.IObservable<T> source, System.Action onSubscribe);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DoOnSubscribe<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoOnSubscribeObservable<T> parent;

                /*0x380da4c*/ DoOnSubscribe(UniRx.Operators.DoOnSubscribeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class DoOnCancelObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action onCancel;

            /*0x380d93c*/ DoOnCancelObservable(System.IObservable<T> source, System.Action onCancel);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DoOnCancel<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DoOnCancelObservable<T> parent;
                /*0x0*/ bool isCompletedCall;

                /*0x380da4c*/ DoOnCancel(UniRx.Operators.DoOnCancelObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__3_0();
            }
        }

        class EmptyObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d83c*/ EmptyObservable(UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Empty<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Empty(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ImmutableEmptyObservable<T> : System.IObservable<T>, UniRx.IOptimizedObservable<T>
        {
            static /*0x0*/ UniRx.Operators.ImmutableEmptyObservable<T> Instance;

            static /*0x38358cc*/ ImmutableEmptyObservable();
            /*0x380cb08*/ ImmutableEmptyObservable();
            /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        }

        class FinallyObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action finallyAction;

            /*0x380d93c*/ FinallyObservable(System.IObservable<T> source, System.Action finallyAction);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Finally<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.FinallyObservable<T> parent;

                /*0x380da4c*/ Finally(UniRx.Operators.FinallyObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__2_0();
            }
        }

        class FirstObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ bool useDefault;
            /*0x0*/ System.Func<T, bool> predicate;

            FirstObservable(System.IObservable<T> source, bool useDefault);
            FirstObservable(System.IObservable<T> source, System.Func<T, bool> predicate, bool useDefault);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class First<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.FirstObservable<T> parent;
                /*0x0*/ bool notPublished;

                /*0x380da4c*/ First(UniRx.Operators.FirstObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class First_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.FirstObservable<T> parent;
                /*0x0*/ bool notPublished;

                /*0x380da4c*/ First_(UniRx.Operators.FirstObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ForEachAsyncObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Action<T> onNext;
            /*0x0*/ System.Action<T, int> onNextWithIndex;

            /*0x380d93c*/ ForEachAsyncObservable(System.IObservable<T> source, System.Action<T> onNext);
            /*0x380d93c*/ ForEachAsyncObservable(System.IObservable<T> source, System.Action<T, int> onNext);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class ForEachAsync<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Unit>
            {
                /*0x0*/ UniRx.Operators.ForEachAsyncObservable<T> parent;

                /*0x380da4c*/ ForEachAsync(UniRx.Operators.ForEachAsyncObservable<T> parent, System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class ForEachAsync_<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Unit>
            {
                /*0x0*/ UniRx.Operators.ForEachAsyncObservable<T> parent;
                /*0x0*/ int index;

                /*0x380da4c*/ ForEachAsync_(UniRx.Operators.ForEachAsyncObservable<T> parent, System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class FromEventPatternObservable<TDelegate, TEventArgs> : UniRx.Operators.OperatorObservableBase<UniRx.EventPattern<TEventArgs>>
        {
            /*0x0*/ System.Func<System.EventHandler<TEventArgs>, TDelegate> conversion;
            /*0x0*/ System.Action<TDelegate> addHandler;
            /*0x0*/ System.Action<TDelegate> removeHandler;

            /*0x380da4c*/ FromEventPatternObservable(System.Func<System.EventHandler<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.EventPattern<TEventArgs>> observer, System.IDisposable cancel);

            class FromEventPattern<TDelegate, TEventArgs> : System.IDisposable
            {
                /*0x0*/ UniRx.Operators.FromEventPatternObservable<TDelegate, TEventArgs> parent;
                /*0x0*/ System.IObserver<UniRx.EventPattern<TEventArgs>> observer;
                /*0x0*/ TDelegate handler;

                /*0x380d93c*/ FromEventPattern(UniRx.Operators.FromEventPatternObservable<TDelegate, TEventArgs> parent, System.IObserver<UniRx.EventPattern<TEventArgs>> observer);
                /*0x380b128*/ bool Register();
                /*0x3907c14*/ void OnNext(object sender, TEventArgs eventArgs);
                /*0x380cb08*/ void Dispose();
            }
        }

        class FromEventObservable<TDelegate> : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x0*/ System.Func<System.Action, TDelegate> conversion;
            /*0x0*/ System.Action<TDelegate> addHandler;
            /*0x0*/ System.Action<TDelegate> removeHandler;

            /*0x380da4c*/ FromEventObservable(System.Func<System.Action, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class FromEvent<TDelegate> : System.IDisposable
            {
                /*0x0*/ UniRx.Operators.FromEventObservable<TDelegate> parent;
                /*0x0*/ System.IObserver<UniRx.Unit> observer;
                /*0x0*/ TDelegate handler;

                /*0x380d93c*/ FromEvent(UniRx.Operators.FromEventObservable<TDelegate> parent, System.IObserver<UniRx.Unit> observer);
                /*0x380b128*/ bool Register();
                /*0x380cb08*/ void OnNext();
                /*0x380cb08*/ void Dispose();
            }
        }

        class FromEventObservable<TDelegate, TEventArgs> : UniRx.Operators.OperatorObservableBase<TEventArgs>
        {
            /*0x0*/ System.Func<System.Action<TEventArgs>, TDelegate> conversion;
            /*0x0*/ System.Action<TDelegate> addHandler;
            /*0x0*/ System.Action<TDelegate> removeHandler;

            /*0x380da4c*/ FromEventObservable(System.Func<System.Action<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TEventArgs> observer, System.IDisposable cancel);

            class FromEvent<TDelegate, TEventArgs> : System.IDisposable
            {
                /*0x0*/ UniRx.Operators.FromEventObservable<TDelegate, TEventArgs> parent;
                /*0x0*/ System.IObserver<TEventArgs> observer;
                /*0x0*/ TDelegate handler;

                /*0x380d93c*/ FromEvent(UniRx.Operators.FromEventObservable<TDelegate, TEventArgs> parent, System.IObserver<TEventArgs> observer);
                /*0x380b128*/ bool Register();
                /*0x3907c14*/ void OnNext(TEventArgs args);
                /*0x380cb08*/ void Dispose();
            }
        }

        class FromEventObservable : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x18*/ System.Action<System.Action> addHandler;
            /*0x20*/ System.Action<System.Action> removeHandler;

            /*0x78f9718*/ FromEventObservable(System.Action<System.Action> addHandler, System.Action<System.Action> removeHandler);
            /*0x78f9794*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class FromEvent : System.IDisposable
            {
                /*0x10*/ UniRx.Operators.FromEventObservable parent;
                /*0x18*/ System.IObserver<UniRx.Unit> observer;
                /*0x20*/ System.Action handler;

                /*0x78f9840*/ FromEvent(UniRx.Operators.FromEventObservable parent, System.IObserver<UniRx.Unit> observer);
                /*0x78f9900*/ bool Register();
                /*0x78f9a3c*/ void OnNext();
                /*0x78f9b40*/ void Dispose();
            }
        }

        class FromEventObservable_<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Action<System.Action<T>> addHandler;
            /*0x0*/ System.Action<System.Action<T>> removeHandler;

            /*0x380d93c*/ FromEventObservable_(System.Action<System.Action<T>> addHandler, System.Action<System.Action<T>> removeHandler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class FromEvent<T> : System.IDisposable
            {
                /*0x0*/ UniRx.Operators.FromEventObservable_<T> parent;
                /*0x0*/ System.IObserver<T> observer;
                /*0x0*/ System.Action<T> handler;

                /*0x380d93c*/ FromEvent(UniRx.Operators.FromEventObservable_<T> parent, System.IObserver<T> observer);
                /*0x380b128*/ bool Register();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380cb08*/ void Dispose();
            }
        }

        class GroupedObservable<TKey, TElement> : UniRx.IGroupedObservable<TKey, TElement>, System.IObservable<TElement>
        {
            /*0x0*/ TKey key;
            /*0x0*/ System.IObservable<TElement> subject;
            /*0x0*/ UniRx.RefCountDisposable refCount;

            /*0x3907c14*/ GroupedObservable(TKey key, UniRx.ISubject<TElement> subject, UniRx.RefCountDisposable refCount);
            /*0x3907c14*/ TKey get_Key();
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<TElement> observer);
        }

        class GroupByObservable<TSource, TKey, TElement> : UniRx.Operators.OperatorObservableBase<UniRx.IGroupedObservable<TKey, TElement>>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Func<TSource, TKey> keySelector;
            /*0x0*/ System.Func<TSource, TElement> elementSelector;
            /*0x0*/ System.Nullable<int> capacity;
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TKey> comparer;

            /*0x3907c14*/ GroupByObservable(System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Nullable<int> capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.IGroupedObservable<TKey, TElement>> observer, System.IDisposable cancel);

            class GroupBy<TSource, TKey, TElement> : UniRx.Operators.OperatorObserverBase<TSource, UniRx.IGroupedObservable<TKey, TElement>>
            {
                /*0x0*/ UniRx.Operators.GroupByObservable<TSource, TKey, TElement> parent;
                /*0x0*/ System.Collections.Generic.Dictionary<TKey, UniRx.ISubject<TElement>> map;
                /*0x0*/ UniRx.ISubject<TElement> nullKeySubject;
                /*0x0*/ UniRx.CompositeDisposable groupDisposable;
                /*0x0*/ UniRx.RefCountDisposable refCountDisposable;

                /*0x380da4c*/ GroupBy(UniRx.Operators.GroupByObservable<TSource, TKey, TElement> parent, System.IObserver<UniRx.IGroupedObservable<TKey, TElement>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380d83c*/ void Error(System.Exception exception);
            }
        }

        class IgnoreElementsObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ IgnoreElementsObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class IgnoreElements<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ IgnoreElements(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class LastObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ bool useDefault;
            /*0x0*/ System.Func<T, bool> predicate;

            LastObservable(System.IObservable<T> source, bool useDefault);
            LastObservable(System.IObservable<T> source, System.Func<T, bool> predicate, bool useDefault);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Last<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.LastObservable<T> parent;
                /*0x0*/ bool notPublished;
                /*0x0*/ T lastValue;

                /*0x380da4c*/ Last(UniRx.Operators.LastObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Last_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.LastObservable<T> parent;
                /*0x0*/ bool notPublished;
                /*0x0*/ T lastValue;

                /*0x380da4c*/ Last_(UniRx.Operators.LastObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class MaterializeObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.Notification<T>>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ MaterializeObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Notification<T>> observer, System.IDisposable cancel);

            class Materialize<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Notification<T>>
            {
                /*0x0*/ UniRx.Operators.MaterializeObservable<T> parent;

                /*0x380da4c*/ Materialize(UniRx.Operators.MaterializeObservable<T> parent, System.IObserver<UniRx.Notification<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class MergeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<System.IObservable<T>> sources;
            /*0x0*/ int maxConcurrent;

            MergeObservable(System.IObservable<System.IObservable<T>> sources, bool isRequiredSubscribeOnCurrentThread);
            MergeObservable(System.IObservable<System.IObservable<T>> sources, int maxConcurrent, bool isRequiredSubscribeOnCurrentThread);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class MergeOuterObserver<T> : UniRx.Operators.OperatorObserverBase<System.IObservable<T>, T>
            {
                /*0x0*/ UniRx.Operators.MergeObservable<T> parent;
                /*0x0*/ UniRx.CompositeDisposable collectionDisposable;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceDisposable;
                /*0x0*/ object gate;
                /*0x0*/ bool isStopped;

                /*0x380da4c*/ MergeOuterObserver(UniRx.Operators.MergeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void OnNext(System.IObservable<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class Merge<T> : UniRx.Operators.OperatorObserverBase<T, T>
                {
                    /*0x0*/ UniRx.Operators.MergeObservable.MergeOuterObserver<T> parent;
                    /*0x0*/ System.IDisposable cancel;

                    /*0x380d93c*/ Merge(UniRx.Operators.MergeObservable.MergeOuterObserver<T> parent, System.IDisposable cancel);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class MergeConcurrentObserver<T> : UniRx.Operators.OperatorObserverBase<System.IObservable<T>, T>
            {
                /*0x0*/ UniRx.Operators.MergeObservable<T> parent;
                /*0x0*/ UniRx.CompositeDisposable collectionDisposable;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceDisposable;
                /*0x0*/ object gate;
                /*0x0*/ bool isStopped;
                /*0x0*/ System.Collections.Generic.Queue<System.IObservable<T>> q;
                /*0x0*/ int activeCount;

                /*0x380da4c*/ MergeConcurrentObserver(UniRx.Operators.MergeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void OnNext(System.IObservable<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380d83c*/ void Subscribe(System.IObservable<T> innerSource);

                class Merge<T> : UniRx.Operators.OperatorObserverBase<T, T>
                {
                    /*0x0*/ UniRx.Operators.MergeObservable.MergeConcurrentObserver<T> parent;
                    /*0x0*/ System.IDisposable cancel;

                    /*0x380d93c*/ Merge(UniRx.Operators.MergeObservable.MergeConcurrentObserver<T> parent, System.IDisposable cancel);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class NeverObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x380cb08*/ NeverObservable();
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);
        }

        class ImmutableNeverObservable<T> : System.IObservable<T>, UniRx.IOptimizedObservable<T>
        {
            static /*0x0*/ UniRx.Operators.ImmutableNeverObservable<T> Instance;

            static /*0x38358cc*/ ImmutableNeverObservable();
            /*0x380cb08*/ ImmutableNeverObservable();
            /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        }

        class ObserveOnObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d93c*/ ObserveOnObservable(System.IObservable<T> source, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class ObserveOn<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ObserveOnObservable<T> parent;
                /*0x0*/ System.Collections.Generic.LinkedList<UniRx.Operators.ObserveOnObservable.ObserveOn.SchedulableAction<T>> actions;
                /*0x0*/ bool isDisposed;

                /*0x380da4c*/ ObserveOn(UniRx.Operators.ObserveOnObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380d83c*/ void QueueAction(UniRx.Notification<T> data);
                /*0x380cb08*/ void ProcessNext();
                /*0x380cb08*/ void <Run>b__5_0();

                class SchedulableAction<T> : System.IDisposable
                {
                    /*0x0*/ UniRx.Notification<T> data;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<UniRx.Operators.ObserveOnObservable.ObserveOn.SchedulableAction<T>> node;
                    /*0x0*/ System.IDisposable schedule;

                    /*0x380cb08*/ SchedulableAction();
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool get_IsScheduled();
                }

                class <>c__DisplayClass10_0<T>
                {
                    /*0x0*/ UniRx.Operators.ObserveOnObservable.ObserveOn<T> <>4__this;
                    /*0x0*/ UniRx.Operators.ObserveOnObservable.ObserveOn.SchedulableAction<T> action;

                    /*0x380cb08*/ <>c__DisplayClass10_0();
                    /*0x380cb08*/ void <ProcessNext>b__0();
                }
            }

            class ObserveOn_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ObserveOnObservable<T> parent;
                /*0x0*/ UniRx.ISchedulerQueueing scheduler;
                /*0x0*/ UniRx.BooleanDisposable isDisposed;
                /*0x0*/ System.Action<T> onNext;

                /*0x380da84*/ ObserveOn_(UniRx.Operators.ObserveOnObservable<T> parent, UniRx.ISchedulerQueueing scheduler, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext_(T value);
                /*0x380d83c*/ void OnError_(System.Exception error);
                /*0x380e2c4*/ void OnCompleted_(UniRx.Unit _);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class OfTypeObservable<TSource, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TSource> source;

            /*0x380d83c*/ OfTypeObservable(System.IObservable<TSource> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class OfType<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x380d93c*/ OfType(System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class OperatorObservableBase<T> : System.IObservable<T>, UniRx.IOptimizedObservable<T>
        {
            /*0x0*/ bool isRequiredSubscribeOnCurrentThread;

            /*0x380cdf0*/ OperatorObservableBase(bool isRequiredSubscribeOnCurrentThread);
            /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ UniRx.SingleAssignmentDisposable subscription;
                /*0x0*/ UniRx.Operators.OperatorObservableBase<T> <>4__this;
                /*0x0*/ System.IObserver<T> observer;

                /*0x380cb08*/ <>c__DisplayClass3_0();
                /*0x380cb08*/ void <Subscribe>b__0();
            }
        }

        class OperatorObserverBase<TSource, TResult> : System.IDisposable, System.IObserver<TSource>
        {
            /*0x0*/ System.IObserver<TResult> observer;
            /*0x0*/ System.IDisposable cancel;

            /*0x380d93c*/ OperatorObserverBase(System.IObserver<TResult> observer, System.IDisposable cancel);
            /*0x3907c14*/ void OnNext(TSource value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
            /*0x380cb08*/ void Dispose();
        }

        class PairwiseObservable<T, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, T, TR> selector;

            /*0x380d93c*/ PairwiseObservable(System.IObservable<T> source, System.Func<T, T, TR> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Pairwise<T, TR> : UniRx.Operators.OperatorObserverBase<T, TR>
            {
                /*0x0*/ UniRx.Operators.PairwiseObservable<T, TR> parent;
                /*0x0*/ T prev;
                /*0x0*/ bool isFirst;

                /*0x380da4c*/ Pairwise(UniRx.Operators.PairwiseObservable<T, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class PairwiseObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.Pair<T>>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ PairwiseObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Pair<T>> observer, System.IDisposable cancel);

            class Pairwise<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Pair<T>>
            {
                /*0x0*/ T prev;
                /*0x0*/ bool isFirst;

                /*0x380d93c*/ Pairwise(System.IObserver<UniRx.Pair<T>> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class RangeObservable : UniRx.Operators.OperatorObservableBase<int>
        {
            /*0x14*/ int start;
            /*0x18*/ int count;
            /*0x20*/ UniRx.IScheduler scheduler;

            /*0x78f9b90*/ RangeObservable(int start, int count, UniRx.IScheduler scheduler);
            /*0x78f9c8c*/ System.IDisposable SubscribeCore(System.IObserver<int> observer, System.IDisposable cancel);

            class Range : UniRx.Operators.OperatorObserverBase<int, int>
            {
                /*0x78f9f5c*/ Range(System.IObserver<int> observer, System.IDisposable cancel);
                /*0x78f9fbc*/ void OnNext(int value);
                /*0x78fa100*/ void OnError(System.Exception error);
                /*0x78fa250*/ void OnCompleted();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UniRx.Operators.RangeObservable <>4__this;
                /*0x18*/ System.IObserver<int> observer;
                /*0x20*/ int i;

                /*0x78f9f54*/ <>c__DisplayClass4_0();
                /*0x78fa394*/ void <SubscribeCore>b__0(System.Action self);
            }
        }

        class RefCountObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ UniRx.IConnectableObservable<T> source;
            /*0x0*/ object gate;
            /*0x0*/ int refCount;
            /*0x0*/ System.IDisposable connection;

            /*0x380d83c*/ RefCountObservable(UniRx.IConnectableObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class RefCount<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.RefCountObservable<T> parent;

                /*0x380da4c*/ RefCount(UniRx.Operators.RefCountObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <>c__DisplayClass2_0<T>
                {
                    /*0x0*/ System.IDisposable subcription;
                    /*0x0*/ UniRx.Operators.RefCountObservable.RefCount<T> <>4__this;

                    /*0x380cb08*/ <>c__DisplayClass2_0();
                    /*0x380cb08*/ void <Run>b__0();
                }
            }
        }

        class RepeatObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ T value;
            /*0x0*/ System.Nullable<int> repeatCount;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x3907c14*/ RepeatObservable(T value, System.Nullable<int> repeatCount, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Repeat<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Repeat(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class <>c__DisplayClass4_0<T>
            {
                /*0x0*/ System.IObserver<T> observer;
                /*0x0*/ UniRx.Operators.RepeatObservable<T> <>4__this;

                /*0x380cb08*/ <>c__DisplayClass4_0();
                /*0x380d83c*/ void <SubscribeCore>b__0(System.Action self);
            }

            class <>c__DisplayClass4_<T>
            {
                /*0x0*/ int currentCount;
                /*0x0*/ UniRx.Operators.RepeatObservable.<>c__DisplayClass4_0<T> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass4_();
                /*0x380d83c*/ void <SubscribeCore>b__1(System.Action self);
            }
        }

        class RepeatSafeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> sources;

            RepeatSafeObservable(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources, bool isRequiredSubscribeOnCurrentThread);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class RepeatSafe<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.RepeatSafeObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> e;
                /*0x0*/ UniRx.SerialDisposable subscription;
                /*0x0*/ System.Action nextSelf;
                /*0x0*/ bool isDisposed;
                /*0x0*/ bool isRunNext;

                /*0x380da4c*/ RepeatSafe(UniRx.Operators.RepeatSafeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void RecursiveRun(System.Action self);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__8_0();
            }
        }

        class ReturnObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ T value;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x3907c14*/ ReturnObservable(T value, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Return<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Return(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ System.IObserver<T> observer;
                /*0x0*/ UniRx.Operators.ReturnObservable<T> <>4__this;

                /*0x380cb08*/ <>c__DisplayClass3_0();
                /*0x380cb08*/ void <SubscribeCore>b__0();
            }
        }

        class ImmediateReturnObservable<T> : System.IObservable<T>, UniRx.IOptimizedObservable<T>
        {
            /*0x0*/ T value;

            /*0x3907c14*/ ImmediateReturnObservable(T value);
            /*0x380b128*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x380bb68*/ System.IDisposable Subscribe(System.IObserver<T> observer);
        }

        class ImmutableReturnUnitObservable : System.IObservable<UniRx.Unit>, UniRx.IOptimizedObservable<UniRx.Unit>
        {
            static /*0x0*/ UniRx.Operators.ImmutableReturnUnitObservable Instance;

            static /*0x78fa698*/ ImmutableReturnUnitObservable();
            /*0x78fa4f0*/ ImmutableReturnUnitObservable();
            /*0x78fa4f8*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x78fa500*/ System.IDisposable Subscribe(System.IObserver<UniRx.Unit> observer);
        }

        class ImmutableReturnTrueObservable : System.IObservable<bool>, UniRx.IOptimizedObservable<bool>
        {
            static /*0x0*/ UniRx.Operators.ImmutableReturnTrueObservable Instance;

            static /*0x78fa840*/ ImmutableReturnTrueObservable();
            /*0x78fa700*/ ImmutableReturnTrueObservable();
            /*0x78fa708*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x78fa710*/ System.IDisposable Subscribe(System.IObserver<bool> observer);
        }

        class ImmutableReturnFalseObservable : System.IObservable<bool>, UniRx.IOptimizedObservable<bool>
        {
            static /*0x0*/ UniRx.Operators.ImmutableReturnFalseObservable Instance;

            static /*0x78fa9e8*/ ImmutableReturnFalseObservable();
            /*0x78fa8a8*/ ImmutableReturnFalseObservable();
            /*0x78fa8b0*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x78fa8b8*/ System.IDisposable Subscribe(System.IObserver<bool> observer);
        }

        class ImmutableReturnInt32Observable : System.IObservable<int>, UniRx.IOptimizedObservable<int>
        {
            static /*0x0*/ UniRx.Operators.ImmutableReturnInt32Observable[] Caches;
            /*0x10*/ int x;

            static /*0x78fac90*/ ImmutableReturnInt32Observable();
            static /*0x78faa50*/ System.IObservable<int> GetInt32Observable(int x);
            /*0x78fab20*/ ImmutableReturnInt32Observable(int x);
            /*0x78fab48*/ bool IsRequiredSubscribeOnCurrentThread();
            /*0x78fab50*/ System.IDisposable Subscribe(System.IObserver<int> observer);
        }

        class SampleObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.TimeSpan interval;
            /*0x0*/ UniRx.IScheduler scheduler;

            SampleObservable(System.IObservable<T> source, System.TimeSpan interval, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Sample<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SampleObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ T latestValue;
                /*0x0*/ bool isUpdated;
                /*0x0*/ bool isCompleted;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;

                /*0x380da4c*/ Sample(UniRx.Operators.SampleObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void OnNextTick();
                /*0x380d83c*/ void OnNextRecursive(System.Action<System.TimeSpan> self);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SampleObservable<T, T2> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObservable<T2> intervalSource;

            /*0x380d93c*/ SampleObservable(System.IObservable<T> source, System.IObservable<T2> intervalSource);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Sample<T, T2> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SampleObservable<T, T2> parent;
                /*0x0*/ object gate;
                /*0x0*/ T latestValue;
                /*0x0*/ bool isUpdated;
                /*0x0*/ bool isCompleted;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;

                /*0x380da4c*/ Sample(UniRx.Operators.SampleObservable<T, T2> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SampleTick<T, T2> : System.IObserver<T2>
                {
                    /*0x0*/ UniRx.Operators.SampleObservable.Sample<T, T2> parent;

                    /*0x380d83c*/ SampleTick(UniRx.Operators.SampleObservable.Sample<T, T2> parent);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x3907c14*/ void OnNext(T2 _);
                }
            }
        }

        class ScanObservable<TSource> : UniRx.Operators.OperatorObservableBase<TSource>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Func<TSource, TSource, TSource> accumulator;

            /*0x380d93c*/ ScanObservable(System.IObservable<TSource> source, System.Func<TSource, TSource, TSource> accumulator);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TSource> observer, System.IDisposable cancel);

            class Scan<TSource> : UniRx.Operators.OperatorObserverBase<TSource, TSource>
            {
                /*0x0*/ UniRx.Operators.ScanObservable<TSource> parent;
                /*0x0*/ TSource accumulation;
                /*0x0*/ bool isFirst;

                /*0x380da4c*/ Scan(UniRx.Operators.ScanObservable<TSource> parent, System.IObserver<TSource> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ScanObservable<TSource, TAccumulate> : UniRx.Operators.OperatorObservableBase<TAccumulate>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ TAccumulate seed;
            /*0x0*/ System.Func<TAccumulate, TSource, TAccumulate> accumulator;

            /*0x3907c14*/ ScanObservable(System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TAccumulate> observer, System.IDisposable cancel);

            class Scan<TSource, TAccumulate> : UniRx.Operators.OperatorObserverBase<TSource, TAccumulate>
            {
                /*0x0*/ UniRx.Operators.ScanObservable<TSource, TAccumulate> parent;
                /*0x0*/ TAccumulate accumulation;
                /*0x0*/ bool isFirst;

                /*0x380da4c*/ Scan(UniRx.Operators.ScanObservable<TSource, TAccumulate> parent, System.IObserver<TAccumulate> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        interface ISelect<TR>
        {
            /*0x380bb68*/ System.IObservable<TR> CombinePredicate(System.Func<TR, bool> predicate);
        }

        class SelectObservable<T, TR> : UniRx.Operators.OperatorObservableBase<TR>, UniRx.Operators.ISelect<TR>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, TR> selector;
            /*0x0*/ System.Func<T, int, TR> selectorWithIndex;

            /*0x380d93c*/ SelectObservable(System.IObservable<T> source, System.Func<T, TR> selector);
            /*0x380d93c*/ SelectObservable(System.IObservable<T> source, System.Func<T, int, TR> selector);
            /*0x380bb68*/ System.IObservable<TR> CombinePredicate(System.Func<TR, bool> predicate);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Select<T, TR> : UniRx.Operators.OperatorObserverBase<T, TR>
            {
                /*0x0*/ UniRx.Operators.SelectObservable<T, TR> parent;

                /*0x380da4c*/ Select(UniRx.Operators.SelectObservable<T, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Select_<T, TR> : UniRx.Operators.OperatorObserverBase<T, TR>
            {
                /*0x0*/ UniRx.Operators.SelectObservable<T, TR> parent;
                /*0x0*/ int index;

                /*0x380da4c*/ Select_(UniRx.Operators.SelectObservable<T, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SelectManyObservable<TSource, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Func<TSource, System.IObservable<TResult>> selector;
            /*0x0*/ System.Func<TSource, int, System.IObservable<TResult>> selectorWithIndex;
            /*0x0*/ System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selectorEnumerable;
            /*0x0*/ System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>> selectorEnumerableWithIndex;

            /*0x380d93c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TResult>> selector);
            /*0x380d93c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TResult>> selector);
            /*0x380d93c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector);
            /*0x380d93c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class SelectManyOuterObserver<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TResult> parent;
                /*0x0*/ UniRx.CompositeDisposable collectionDisposable;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceDisposable;
                /*0x0*/ object gate;
                /*0x0*/ bool isStopped;

                /*0x380da4c*/ SelectManyOuterObserver(UniRx.Operators.SelectManyObservable<TSource, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SelectMany<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TResult, TResult>
                {
                    /*0x0*/ UniRx.Operators.SelectManyObservable.SelectManyOuterObserver<TSource, TResult> parent;
                    /*0x0*/ System.IDisposable cancel;

                    /*0x380d93c*/ SelectMany(UniRx.Operators.SelectManyObservable.SelectManyOuterObserver<TSource, TResult> parent, System.IDisposable cancel);
                    /*0x3907c14*/ void OnNext(TResult value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class SelectManyObserverWithIndex<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TResult> parent;
                /*0x0*/ UniRx.CompositeDisposable collectionDisposable;
                /*0x0*/ int index;
                /*0x0*/ object gate;
                /*0x0*/ bool isStopped;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceDisposable;

                /*0x380da4c*/ SelectManyObserverWithIndex(UniRx.Operators.SelectManyObservable<TSource, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SelectMany<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TResult, TResult>
                {
                    /*0x0*/ UniRx.Operators.SelectManyObservable.SelectManyObserverWithIndex<TSource, TResult> parent;
                    /*0x0*/ System.IDisposable cancel;

                    /*0x380d93c*/ SelectMany(UniRx.Operators.SelectManyObservable.SelectManyObserverWithIndex<TSource, TResult> parent, System.IDisposable cancel);
                    /*0x3907c14*/ void OnNext(TResult value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class SelectManyEnumerableObserver<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TResult> parent;

                /*0x380da4c*/ SelectManyEnumerableObserver(UniRx.Operators.SelectManyObservable<TSource, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class SelectManyEnumerableObserverWithIndex<TSource, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TResult> parent;
                /*0x0*/ int index;

                /*0x380da4c*/ SelectManyEnumerableObserverWithIndex(UniRx.Operators.SelectManyObservable<TSource, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SelectManyObservable<TSource, TCollection, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TSource> source;
            /*0x0*/ System.Func<TSource, System.IObservable<TCollection>> collectionSelector;
            /*0x0*/ System.Func<TSource, int, System.IObservable<TCollection>> collectionSelectorWithIndex;
            /*0x0*/ System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelectorEnumerable;
            /*0x0*/ System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>> collectionSelectorEnumerableWithIndex;
            /*0x0*/ System.Func<TSource, TCollection, TResult> resultSelector;
            /*0x0*/ System.Func<TSource, int, TCollection, int, TResult> resultSelectorWithIndex;

            /*0x380da4c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector);
            /*0x380da4c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector);
            /*0x380da4c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector);
            /*0x380da4c*/ SelectManyObservable(System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class SelectManyOuterObserver<TSource, TCollection, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent;
                /*0x0*/ UniRx.CompositeDisposable collectionDisposable;
                /*0x0*/ object gate;
                /*0x0*/ bool isStopped;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceDisposable;

                /*0x380da4c*/ SelectManyOuterObserver(UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SelectMany<TSource, TCollection, TResult> : UniRx.Operators.OperatorObserverBase<TCollection, TResult>
                {
                    /*0x0*/ UniRx.Operators.SelectManyObservable.SelectManyOuterObserver<TSource, TCollection, TResult> parent;
                    /*0x0*/ TSource sourceValue;
                    /*0x0*/ System.IDisposable cancel;

                    /*0x3907c14*/ SelectMany(UniRx.Operators.SelectManyObservable.SelectManyOuterObserver<TSource, TCollection, TResult> parent, TSource value, System.IDisposable cancel);
                    /*0x3907c14*/ void OnNext(TCollection value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class SelectManyObserverWithIndex<TSource, TCollection, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent;
                /*0x0*/ UniRx.CompositeDisposable collectionDisposable;
                /*0x0*/ object gate;
                /*0x0*/ bool isStopped;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceDisposable;
                /*0x0*/ int index;

                /*0x380da4c*/ SelectManyObserverWithIndex(UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SelectManyObserver<TSource, TCollection, TResult> : UniRx.Operators.OperatorObserverBase<TCollection, TResult>
                {
                    /*0x0*/ UniRx.Operators.SelectManyObservable.SelectManyObserverWithIndex<TSource, TCollection, TResult> parent;
                    /*0x0*/ TSource sourceValue;
                    /*0x0*/ int sourceIndex;
                    /*0x0*/ System.IDisposable cancel;
                    /*0x0*/ int index;

                    /*0x3907c14*/ SelectManyObserver(UniRx.Operators.SelectManyObservable.SelectManyObserverWithIndex<TSource, TCollection, TResult> parent, TSource value, int index, System.IDisposable cancel);
                    /*0x3907c14*/ void OnNext(TCollection value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class SelectManyEnumerableObserver<TSource, TCollection, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent;

                /*0x380da4c*/ SelectManyEnumerableObserver(UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class SelectManyEnumerableObserverWithIndex<TSource, TCollection, TResult> : UniRx.Operators.OperatorObserverBase<TSource, TResult>
            {
                /*0x0*/ UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent;
                /*0x0*/ int index;

                /*0x380da4c*/ SelectManyEnumerableObserverWithIndex(UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SelectWhereObservable<T, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, TR> selector;
            /*0x0*/ System.Func<TR, bool> predicate;

            /*0x380da4c*/ SelectWhereObservable(System.IObservable<T> source, System.Func<T, TR> selector, System.Func<TR, bool> predicate);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class SelectWhere<T, TR> : UniRx.Operators.OperatorObserverBase<T, TR>
            {
                /*0x0*/ UniRx.Operators.SelectWhereObservable<T, TR> parent;

                /*0x380da4c*/ SelectWhere(UniRx.Operators.SelectWhereObservable<T, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SingleObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ bool useDefault;
            /*0x0*/ System.Func<T, bool> predicate;

            SingleObservable(System.IObservable<T> source, bool useDefault);
            SingleObservable(System.IObservable<T> source, System.Func<T, bool> predicate, bool useDefault);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Single<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SingleObservable<T> parent;
                /*0x0*/ bool seenValue;
                /*0x0*/ T lastValue;

                /*0x380da4c*/ Single(UniRx.Operators.SingleObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Single_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SingleObservable<T> parent;
                /*0x0*/ bool seenValue;
                /*0x0*/ T lastValue;

                /*0x380da4c*/ Single_(UniRx.Operators.SingleObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SkipObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int count;
            /*0x0*/ System.TimeSpan duration;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d8b8*/ SkipObservable(System.IObservable<T> source, int count);
            SkipObservable(System.IObservable<T> source, System.TimeSpan duration, UniRx.IScheduler scheduler);
            /*0x380ba90*/ System.IObservable<T> Combine(int count);
            /*0x3907c14*/ System.IObservable<T> Combine(System.TimeSpan duration);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Skip<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ int remaining;

                /*0x380da4c*/ Skip(UniRx.Operators.SkipObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Skip_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SkipObservable<T> parent;
                /*0x0*/ bool open;

                /*0x380da4c*/ Skip_(UniRx.Operators.SkipObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void Tick();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SkipUntilObservable<T, TOther> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObservable<TOther> other;

            /*0x380d93c*/ SkipUntilObservable(System.IObservable<T> source, System.IObservable<TOther> other);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class SkipUntilOuterObserver<T, TOther> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SkipUntilObservable<T, TOther> parent;

                /*0x380da4c*/ SkipUntilOuterObserver(UniRx.Operators.SkipUntilObservable<T, TOther> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SkipUntil<T, TOther> : System.IObserver<T>
                {
                    /*0x0*/ System.IObserver<T> observer;
                    /*0x0*/ UniRx.Operators.SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent;
                    /*0x0*/ System.IDisposable subscription;

                    /*0x380d93c*/ SkipUntil(UniRx.Operators.SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent, System.IDisposable subscription);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }

                class SkipUntilOther<T, TOther> : System.IObserver<TOther>
                {
                    /*0x0*/ UniRx.Operators.SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent;
                    /*0x0*/ UniRx.Operators.SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<T, TOther> sourceObserver;
                    /*0x0*/ System.IDisposable subscription;

                    /*0x380da4c*/ SkipUntilOther(UniRx.Operators.SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent, UniRx.Operators.SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<T, TOther> sourceObserver, System.IDisposable subscription);
                    /*0x3907c14*/ void OnNext(TOther value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class SkipWhileObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, bool> predicate;
            /*0x0*/ System.Func<T, int, bool> predicateWithIndex;

            /*0x380d93c*/ SkipWhileObservable(System.IObservable<T> source, System.Func<T, bool> predicate);
            /*0x380d93c*/ SkipWhileObservable(System.IObservable<T> source, System.Func<T, int, bool> predicateWithIndex);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class SkipWhile<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SkipWhileObservable<T> parent;
                /*0x0*/ bool endSkip;

                /*0x380da4c*/ SkipWhile(UniRx.Operators.SkipWhileObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class SkipWhile_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SkipWhileObservable<T> parent;
                /*0x0*/ bool endSkip;
                /*0x0*/ int index;

                /*0x380da4c*/ SkipWhile_(UniRx.Operators.SkipWhileObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class StartObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Action action;
            /*0x0*/ System.Func<T> function;
            /*0x0*/ UniRx.IScheduler scheduler;
            /*0x0*/ System.Nullable<System.TimeSpan> startAfter;

            /*0x3907c14*/ StartObservable(System.Func<T> function, System.Nullable<System.TimeSpan> startAfter, UniRx.IScheduler scheduler);
            /*0x3907c14*/ StartObservable(System.Action action, System.Nullable<System.TimeSpan> startAfter, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class StartObserver<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.StartObservable<T> parent;

                /*0x380da4c*/ StartObserver(UniRx.Operators.StartObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380cb08*/ void Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class StartWithObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ T value;
            /*0x0*/ System.Func<T> valueFactory;

            /*0x3907c14*/ StartWithObservable(System.IObservable<T> source, T value);
            /*0x380d93c*/ StartWithObservable(System.IObservable<T> source, System.Func<T> valueFactory);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class StartWith<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.StartWithObservable<T> parent;

                /*0x380da4c*/ StartWith(UniRx.Operators.StartWithObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SubscribeOnObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d93c*/ SubscribeOnObservable(System.IObservable<T> source, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ UniRx.SerialDisposable d;
                /*0x0*/ UniRx.Operators.SubscribeOnObservable<T> <>4__this;
                /*0x0*/ System.IObserver<T> observer;

                /*0x380cb08*/ <>c__DisplayClass3_0();
                /*0x380cb08*/ void <SubscribeCore>b__0();
            }
        }

        class SwitchObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<System.IObservable<T>> sources;

            /*0x380d83c*/ SwitchObservable(System.IObservable<System.IObservable<T>> sources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class SwitchObserver<T> : UniRx.Operators.OperatorObserverBase<System.IObservable<T>, T>
            {
                /*0x0*/ UniRx.Operators.SwitchObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.SerialDisposable innerSubscription;
                /*0x0*/ bool isStopped;
                /*0x0*/ ulong latest;
                /*0x0*/ bool hasLatest;

                /*0x380da4c*/ SwitchObserver(UniRx.Operators.SwitchObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void OnNext(System.IObservable<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class Switch<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.SwitchObservable.SwitchObserver<T> parent;
                    /*0x0*/ ulong id;

                    Switch(UniRx.Operators.SwitchObservable.SwitchObserver<T> observer, ulong id);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class SynchronizeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ object gate;

            /*0x380d93c*/ SynchronizeObservable(System.IObservable<T> source, object gate);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Synchronize<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SynchronizeObservable<T> parent;

                /*0x380da4c*/ Synchronize(UniRx.Operators.SynchronizeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class SynchronizedObserver<T> : System.IObserver<T>
        {
            /*0x0*/ System.IObserver<T> observer;
            /*0x0*/ object gate;

            /*0x380d93c*/ SynchronizedObserver(System.IObserver<T> observer, object gate);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class TakeObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int count;
            /*0x0*/ System.TimeSpan duration;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d8b8*/ TakeObservable(System.IObservable<T> source, int count);
            TakeObservable(System.IObservable<T> source, System.TimeSpan duration, UniRx.IScheduler scheduler);
            /*0x380ba90*/ System.IObservable<T> Combine(int count);
            /*0x3907c14*/ System.IObservable<T> Combine(System.TimeSpan duration);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Take<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ int rest;

                /*0x380da4c*/ Take(UniRx.Operators.TakeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Take_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TakeObservable<T> parent;
                /*0x0*/ object gate;

                /*0x380da4c*/ Take_(UniRx.Operators.TakeObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void Tick();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class TakeLastObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int count;
            /*0x0*/ System.TimeSpan duration;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d8b8*/ TakeLastObservable(System.IObservable<T> source, int count);
            TakeLastObservable(System.IObservable<T> source, System.TimeSpan duration, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class TakeLast<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TakeLastObservable<T> parent;
                /*0x0*/ System.Collections.Generic.Queue<T> q;

                /*0x380da4c*/ TakeLast(UniRx.Operators.TakeLastObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class TakeLast_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ System.DateTimeOffset startTime;
                /*0x0*/ UniRx.Operators.TakeLastObservable<T> parent;
                /*0x0*/ System.Collections.Generic.Queue<UniRx.TimeInterval<T>> q;

                /*0x380da4c*/ TakeLast_(UniRx.Operators.TakeLastObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380e1ac*/ void Trim(System.TimeSpan now);
            }
        }

        class TakeUntilObservable<T, TOther> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObservable<TOther> other;

            /*0x380d93c*/ TakeUntilObservable(System.IObservable<T> source, System.IObservable<TOther> other);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class TakeUntil<T, TOther> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TakeUntilObservable<T, TOther> parent;
                /*0x0*/ object gate;

                /*0x380da4c*/ TakeUntil(UniRx.Operators.TakeUntilObservable<T, TOther> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class TakeUntilOther<T, TOther> : System.IObserver<TOther>
                {
                    /*0x0*/ UniRx.Operators.TakeUntilObservable.TakeUntil<T, TOther> sourceObserver;
                    /*0x0*/ System.IDisposable subscription;

                    /*0x380d93c*/ TakeUntilOther(UniRx.Operators.TakeUntilObservable.TakeUntil<T, TOther> sourceObserver, System.IDisposable subscription);
                    /*0x3907c14*/ void OnNext(TOther value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class TakeWhileObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, bool> predicate;
            /*0x0*/ System.Func<T, int, bool> predicateWithIndex;

            /*0x380d93c*/ TakeWhileObservable(System.IObservable<T> source, System.Func<T, bool> predicate);
            /*0x380d93c*/ TakeWhileObservable(System.IObservable<T> source, System.Func<T, int, bool> predicateWithIndex);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class TakeWhile<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TakeWhileObservable<T> parent;

                /*0x380da4c*/ TakeWhile(UniRx.Operators.TakeWhileObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class TakeWhile_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TakeWhileObservable<T> parent;
                /*0x0*/ int index;

                /*0x380da4c*/ TakeWhile_(UniRx.Operators.TakeWhileObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ThrottleObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.TimeSpan dueTime;
            /*0x0*/ UniRx.IScheduler scheduler;

            ThrottleObservable(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Throttle<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ThrottleObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ T latestValue;
                /*0x0*/ bool hasValue;
                /*0x0*/ UniRx.SerialDisposable cancelable;
                /*0x0*/ ulong id;

                /*0x380da4c*/ Throttle(UniRx.Operators.ThrottleObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                void OnNext(ulong currentid);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ UniRx.Operators.ThrottleObservable.Throttle<T> <>4__this;
                    /*0x0*/ ulong currentid;

                    /*0x380cb08*/ <>c__DisplayClass9_0();
                    /*0x380cb08*/ void <OnNext>b__0();
                }
            }
        }

        class ThrottleFirstObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.TimeSpan dueTime;
            /*0x0*/ UniRx.IScheduler scheduler;

            ThrottleFirstObservable(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class ThrottleFirst<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ThrottleFirstObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool open;
                /*0x0*/ UniRx.SerialDisposable cancelable;

                /*0x380da4c*/ ThrottleFirst(UniRx.Operators.ThrottleFirstObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void OnNext();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ThrowObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Exception error;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d93c*/ ThrowObservable(System.Exception error, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Throw<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ Throw(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ System.IObserver<T> observer;
                /*0x0*/ UniRx.Operators.ThrowObservable<T> <>4__this;

                /*0x380cb08*/ <>c__DisplayClass3_0();
                /*0x380cb08*/ void <SubscribeCore>b__0();
            }
        }

        class TimeIntervalObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.TimeInterval<T>>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d93c*/ TimeIntervalObservable(System.IObservable<T> source, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.TimeInterval<T>> observer, System.IDisposable cancel);

            class TimeInterval<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.TimeInterval<T>>
            {
                /*0x0*/ UniRx.Operators.TimeIntervalObservable<T> parent;
                /*0x0*/ System.DateTimeOffset lastTime;

                /*0x380da4c*/ TimeInterval(UniRx.Operators.TimeIntervalObservable<T> parent, System.IObserver<UniRx.TimeInterval<T>> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class TimeoutObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Nullable<System.TimeSpan> dueTime;
            /*0x0*/ System.Nullable<System.DateTimeOffset> dueTimeDT;
            /*0x0*/ UniRx.IScheduler scheduler;

            TimeoutObservable(System.IObservable<T> source, System.TimeSpan dueTime, UniRx.IScheduler scheduler);
            TimeoutObservable(System.IObservable<T> source, System.DateTimeOffset dueTime, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Timeout<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TimeoutObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ ulong objectId;
                /*0x0*/ bool isTimeout;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;
                /*0x0*/ UniRx.SerialDisposable timerSubscription;

                /*0x380da4c*/ Timeout(UniRx.Operators.TimeoutObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                System.IDisposable RunTimer(ulong timerId);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <>c__DisplayClass8_0<T>
                {
                    /*0x0*/ UniRx.Operators.TimeoutObservable.Timeout<T> <>4__this;
                    /*0x0*/ ulong timerId;

                    /*0x380cb08*/ <>c__DisplayClass8_0();
                    /*0x380cb08*/ void <RunTimer>b__0();
                }
            }

            class Timeout_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TimeoutObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool isFinished;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;
                /*0x0*/ System.IDisposable timerSubscription;

                /*0x380da4c*/ Timeout_(UniRx.Operators.TimeoutObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void OnNext();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class TimerObservable : UniRx.Operators.OperatorObservableBase<long>
        {
            /*0x18*/ System.Nullable<System.DateTimeOffset> dueTimeA;
            /*0x30*/ System.Nullable<System.TimeSpan> dueTimeB;
            /*0x40*/ System.Nullable<System.TimeSpan> period;
            /*0x50*/ UniRx.IScheduler scheduler;

            /*0x78fb060*/ TimerObservable(System.DateTimeOffset dueTime, System.Nullable<System.TimeSpan> period, UniRx.IScheduler scheduler);
            /*0x78fb16c*/ TimerObservable(System.TimeSpan dueTime, System.Nullable<System.TimeSpan> period, UniRx.IScheduler scheduler);
            /*0x78fb264*/ System.IDisposable SubscribeCore(System.IObserver<long> observer, System.IDisposable cancel);

            class Timer : UniRx.Operators.OperatorObserverBase<long, long>
            {
                /*0x20*/ long index;

                /*0x78fb980*/ Timer(System.IObserver<long> observer, System.IDisposable cancel);
                /*0x78fb9f8*/ void OnNext();
                /*0x78fbb44*/ void OnNext(long value);
                /*0x78fbb48*/ void OnError(System.Exception error);
                /*0x78fbc98*/ void OnCompleted();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UniRx.Operators.TimerObservable.Timer timerObserver;
                /*0x18*/ UniRx.Operators.TimerObservable <>4__this;

                /*0x78fb978*/ <>c__DisplayClass6_0();
                /*0x78fbddc*/ void <SubscribeCore>b__0();
            }

            class <>c__DisplayClass6_1
            {
                /*0x10*/ UniRx.ISchedulerPeriodic periodicScheduler;
                /*0x18*/ UniRx.Operators.TimerObservable.<> CS$<>8__locals1;

                /*0x78fb9e0*/ <>c__DisplayClass6_1();
            }

            class <>c__DisplayClass6_2
            {
                /*0x10*/ UniRx.SerialDisposable disposable;
                /*0x18*/ UniRx.Operators.TimerObservable.<> CS$<>8__locals2;

                /*0x78fb9e8*/ <>c__DisplayClass6_2();
                /*0x78fbe0c*/ void <SubscribeCore>b__1();
            }

            class <>c__DisplayClass6_3
            {
                /*0x10*/ System.TimeSpan timeP;
                /*0x18*/ UniRx.Operators.TimerObservable.<> CS$<>8__locals3;

                /*0x78fb9f0*/ <>c__DisplayClass6_3();
                /*0x78fbfbc*/ void <SubscribeCore>b__2(System.Action<System.TimeSpan> self);
            }
        }

        class TimestampObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.Timestamped<T>>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d93c*/ TimestampObservable(System.IObservable<T> source, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Timestamped<T>> observer, System.IDisposable cancel);

            class Timestamp<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.Timestamped<T>>
            {
                /*0x0*/ UniRx.Operators.TimestampObservable<T> parent;

                /*0x380da4c*/ Timestamp(UniRx.Operators.TimestampObservable<T> parent, System.IObserver<UniRx.Timestamped<T>> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ToArrayObservable<TSource> : UniRx.Operators.OperatorObservableBase<TSource[]>
        {
            /*0x0*/ System.IObservable<TSource> source;

            /*0x380d83c*/ ToArrayObservable(System.IObservable<TSource> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TSource[]> observer, System.IDisposable cancel);

            class ToArray<TSource> : UniRx.Operators.OperatorObserverBase<TSource, TSource[]>
            {
                /*0x0*/ System.Collections.Generic.List<TSource> list;

                /*0x380d93c*/ ToArray(System.IObserver<TSource[]> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ToListObservable<TSource> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<TSource>>
        {
            /*0x0*/ System.IObservable<TSource> source;

            /*0x380d83c*/ ToListObservable(System.IObservable<TSource> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<TSource>> observer, System.IDisposable cancel);

            class ToList<TSource> : UniRx.Operators.OperatorObserverBase<TSource, System.Collections.Generic.IList<TSource>>
            {
                /*0x0*/ System.Collections.Generic.List<TSource> list;

                /*0x380d93c*/ ToList(System.IObserver<System.Collections.Generic.IList<TSource>> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(TSource value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ToObservableObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
            /*0x0*/ UniRx.IScheduler scheduler;

            /*0x380d93c*/ ToObservableObservable(System.Collections.Generic.IEnumerable<T> source, UniRx.IScheduler scheduler);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class ToObservable<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ToObservableObservable<T> parent;

                /*0x380da4c*/ ToObservable(UniRx.Operators.ToObservableObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <>c__DisplayClass2_0<T>
                {
                    /*0x0*/ UniRx.SingleAssignmentDisposable flag;
                    /*0x0*/ System.Collections.Generic.IEnumerator<T> e;
                    /*0x0*/ UniRx.Operators.ToObservableObservable.ToObservable<T> <>4__this;

                    /*0x380cb08*/ <>c__DisplayClass2_0();
                    /*0x380d83c*/ void <Run>b__0(System.Action self);
                }
            }
        }

        class Wait<T> : System.IObserver<T>
        {
            static /*0x0*/ System.TimeSpan InfiniteTimeSpan;
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.TimeSpan timeout;
            /*0x0*/ System.Threading.ManualResetEvent semaphore;
            /*0x0*/ bool seenValue;
            /*0x0*/ T value;
            /*0x0*/ System.Exception ex;

            static /*0x38358cc*/ Wait();
            Wait(System.IObservable<T> source, System.TimeSpan timeout);
            /*0x3907c14*/ T Run();
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class WhenAllObservable<T> : UniRx.Operators.OperatorObservableBase<T[]>
        {
            /*0x0*/ System.IObservable<T> sources;
            /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> sourcesEnumerable;

            /*0x380d83c*/ WhenAllObservable(System.IObservable<T> sources);
            /*0x380d83c*/ WhenAllObservable(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T[]> observer, System.IDisposable cancel);

            class WhenAll<T> : UniRx.Operators.OperatorObserverBase<T[], T[]>
            {
                /*0x0*/ System.IObservable<T> sources;
                /*0x0*/ object gate;
                /*0x0*/ int completedCount;
                /*0x0*/ int length;
                /*0x0*/ T[] values;

                /*0x380da4c*/ WhenAll(System.IObservable<T> sources, System.IObserver<T[]> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void OnNext(T[] value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class WhenAllCollectionObserver<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.WhenAllObservable.WhenAll<T> parent;
                    /*0x0*/ int index;
                    /*0x0*/ bool isCompleted;

                    /*0x380d8b8*/ WhenAllCollectionObserver(UniRx.Operators.WhenAllObservable.WhenAll<T> parent, int index);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class WhenAll_<T> : UniRx.Operators.OperatorObserverBase<T[], T[]>
            {
                /*0x0*/ System.Collections.Generic.IList<System.IObservable<T>> sources;
                /*0x0*/ object gate;
                /*0x0*/ int completedCount;
                /*0x0*/ int length;
                /*0x0*/ T[] values;

                /*0x380da4c*/ WhenAll_(System.Collections.Generic.IList<System.IObservable<T>> sources, System.IObserver<T[]> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void OnNext(T[] value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class WhenAllCollectionObserver<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.WhenAllObservable.WhenAll_<T> parent;
                    /*0x0*/ int index;
                    /*0x0*/ bool isCompleted;

                    /*0x380d8b8*/ WhenAllCollectionObserver(UniRx.Operators.WhenAllObservable.WhenAll_<T> parent, int index);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class WhenAllObservable : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x18*/ System.IObservable<UniRx.Unit> sources;
            /*0x20*/ System.Collections.Generic.IEnumerable<System.IObservable<UniRx.Unit>> sourcesEnumerable;

            /*0x78fc00c*/ WhenAllObservable(System.IObservable<UniRx.Unit> sources);
            /*0x78fc074*/ WhenAllObservable(System.Collections.Generic.IEnumerable<System.IObservable<UniRx.Unit>> sources);
            /*0x78fc0dc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class WhenAll : UniRx.Operators.OperatorObserverBase<UniRx.Unit, UniRx.Unit>
            {
                /*0x20*/ System.IObservable<UniRx.Unit> sources;
                /*0x28*/ object gate;
                /*0x30*/ int completedCount;
                /*0x34*/ int length;

                /*0x78fc210*/ WhenAll(System.IObservable<UniRx.Unit> sources, System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x78fc2c4*/ System.IDisposable Run();
                /*0x78fcb84*/ void OnNext(UniRx.Unit value);
                /*0x78fcc30*/ void OnError(System.Exception error);
                /*0x78fcd80*/ void OnCompleted();

                class WhenAllCollectionObserver : System.IObserver<UniRx.Unit>
                {
                    /*0x10*/ UniRx.Operators.WhenAllObservable.WhenAll parent;
                    /*0x18*/ bool isCompleted;

                    /*0x78fcb54*/ WhenAllCollectionObserver(UniRx.Operators.WhenAllObservable.WhenAll parent);
                    /*0x78fcec4*/ void OnNext(UniRx.Unit value);
                    /*0x78fcec8*/ void OnError(System.Exception error);
                    /*0x78fcfb8*/ void OnCompleted();
                }
            }

            class WhenAll_ : UniRx.Operators.OperatorObserverBase<UniRx.Unit, UniRx.Unit>
            {
                /*0x20*/ System.Collections.Generic.IList<System.IObservable<UniRx.Unit>> sources;
                /*0x28*/ object gate;
                /*0x30*/ int completedCount;
                /*0x34*/ int length;

                /*0x78fc648*/ WhenAll_(System.Collections.Generic.IList<System.IObservable<UniRx.Unit>> sources, System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x78fc6fc*/ System.IDisposable Run();
                /*0x78fd194*/ void OnNext(UniRx.Unit value);
                /*0x78fd240*/ void OnError(System.Exception error);
                /*0x78fd390*/ void OnCompleted();

                class WhenAllCollectionObserver : System.IObserver<UniRx.Unit>
                {
                    /*0x10*/ UniRx.Operators.WhenAllObservable.WhenAll_ parent;
                    /*0x18*/ bool isCompleted;

                    /*0x78fd164*/ WhenAllCollectionObserver(UniRx.Operators.WhenAllObservable.WhenAll_ parent);
                    /*0x78fd4d4*/ void OnNext(UniRx.Unit value);
                    /*0x78fd4d8*/ void OnError(System.Exception error);
                    /*0x78fd5c8*/ void OnCompleted();
                }
            }
        }

        class WhereObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, bool> predicate;
            /*0x0*/ System.Func<T, int, bool> predicateWithIndex;

            /*0x380d93c*/ WhereObservable(System.IObservable<T> source, System.Func<T, bool> predicate);
            /*0x380d93c*/ WhereObservable(System.IObservable<T> source, System.Func<T, int, bool> predicateWithIndex);
            /*0x380bb68*/ System.IObservable<T> CombinePredicate(System.Func<T, bool> combinePredicate);
            /*0x380bb68*/ System.IObservable<TR> CombineSelector<TR>(System.Func<T, TR> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class Where<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.WhereObservable<T> parent;

                /*0x380da4c*/ Where(UniRx.Operators.WhereObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class Where_<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.WhereObservable<T> parent;
                /*0x0*/ int index;

                /*0x380da4c*/ Where_(UniRx.Operators.WhereObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }

            class <>c__DisplayClass5_0<T>
            {
                /*0x0*/ UniRx.Operators.WhereObservable<T> <>4__this;
                /*0x0*/ System.Func<T, bool> combinePredicate;

                /*0x380cb08*/ <>c__DisplayClass5_0();
                /*0x3907c14*/ bool <CombinePredicate>b__0(T x);
            }
        }

        class WhereSelectObservable<T, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.Func<T, bool> predicate;
            /*0x0*/ System.Func<T, TR> selector;

            /*0x380da4c*/ WhereSelectObservable(System.IObservable<T> source, System.Func<T, bool> predicate, System.Func<T, TR> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class WhereSelect<T, TR> : UniRx.Operators.OperatorObserverBase<T, TR>
            {
                /*0x0*/ UniRx.Operators.WhereSelectObservable<T, TR> parent;

                /*0x380da4c*/ WhereSelect(UniRx.Operators.WhereSelectObservable<T, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class WithLatestFromObservable<TLeft, TRight, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TLeft> left;
            /*0x0*/ System.IObservable<TRight> right;
            /*0x0*/ System.Func<TLeft, TRight, TResult> selector;

            /*0x380da4c*/ WithLatestFromObservable(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class WithLatestFrom<TLeft, TRight, TResult> : UniRx.Operators.OperatorObserverBase<TResult, TResult>
            {
                /*0x0*/ UniRx.Operators.WithLatestFromObservable<TLeft, TRight, TResult> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool hasLatest;
                /*0x0*/ TRight latestValue;

                /*0x380da4c*/ WithLatestFrom(UniRx.Operators.WithLatestFromObservable<TLeft, TRight, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(TResult value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class LeftObserver<TLeft, TRight, TResult> : System.IObserver<TLeft>
                {
                    /*0x0*/ UniRx.Operators.WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ LeftObserver(UniRx.Operators.WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TLeft value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }

                class RightObserver<TLeft, TRight, TResult> : System.IObserver<TRight>
                {
                    /*0x0*/ UniRx.Operators.WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent;
                    /*0x0*/ System.IDisposable selfSubscription;

                    /*0x380d93c*/ RightObserver(UniRx.Operators.WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent, System.IDisposable subscription);
                    /*0x3907c14*/ void OnNext(TRight value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class ZipFunc<T1, T2, T3, TR> : System.MulticastDelegate
        {
            ZipFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipFunc<T1, T2, T3, T4, TR> : System.MulticastDelegate
        {
            ZipFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipFunc<T1, T2, T3, T4, T5, TR> : System.MulticastDelegate
        {
            ZipFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipFunc<T1, T2, T3, T4, T5, T6, TR> : System.MulticastDelegate
        {
            ZipFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> : System.MulticastDelegate
        {
            ZipFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipObservable<TLeft, TRight, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TLeft> left;
            /*0x0*/ System.IObservable<TRight> right;
            /*0x0*/ System.Func<TLeft, TRight, TResult> selector;

            /*0x380da4c*/ ZipObservable(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class Zip<TLeft, TRight, TResult> : UniRx.Operators.OperatorObserverBase<TResult, TResult>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<TLeft, TRight, TResult> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<TLeft> leftQ;
                /*0x0*/ bool leftCompleted;
                /*0x0*/ System.Collections.Generic.Queue<TRight> rightQ;
                /*0x0*/ bool rightCompleted;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<TLeft, TRight, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void Dequeue();
                /*0x3907c14*/ void OnNext(TResult value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__7_0();

                class LeftZipObserver<TLeft, TRight, TResult> : System.IObserver<TLeft>
                {
                    /*0x0*/ UniRx.Operators.ZipObservable.Zip<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ LeftZipObserver(UniRx.Operators.ZipObservable.Zip<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TLeft value);
                    /*0x380d83c*/ void OnError(System.Exception ex);
                    /*0x380cb08*/ void OnCompleted();
                }

                class RightZipObserver<TLeft, TRight, TResult> : System.IObserver<TRight>
                {
                    /*0x0*/ UniRx.Operators.ZipObservable.Zip<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ RightZipObserver(UniRx.Operators.ZipObservable.Zip<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TRight value);
                    /*0x380d83c*/ void OnError(System.Exception ex);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class ZipObservable<T> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<T>>
        {
            /*0x0*/ System.IObservable<T> sources;

            /*0x380d83c*/ ZipObservable(System.IObservable<T> sources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);

            class Zip<T> : UniRx.Operators.OperatorObserverBase<System.Collections.Generic.IList<T>, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<T> queues;
                /*0x0*/ bool[] isDone;
                /*0x0*/ int length;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cffc*/ void Dequeue(int index);
                /*0x380d83c*/ void OnNext(System.Collections.Generic.IList<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__6_0();

                class ZipObserver<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.ZipObservable.Zip<T> parent;
                    /*0x0*/ int index;

                    /*0x380d8b8*/ ZipObserver(UniRx.Operators.ZipObservable.Zip<T> parent, int index);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception ex);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class ZipObservable<T1, T2, T3, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ UniRx.Operators.ZipFunc<T1, T2, T3, TR> resultSelector;

            /*0x380da84*/ ZipObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, UniRx.Operators.ZipFunc<T1, T2, T3, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Zip<T1, T2, T3, TR> : UniRx.Operators.NthZipObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<T1, T2, T3, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<T1> q1;
                /*0x0*/ System.Collections.Generic.Queue<T2> q2;
                /*0x0*/ System.Collections.Generic.Queue<T3> q3;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<T1, T2, T3, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__6_0();
            }
        }

        class ZipObservable<T1, T2, T3, T4, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ UniRx.Operators.ZipFunc<T1, T2, T3, T4, TR> resultSelector;

            /*0x380db04*/ ZipObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, UniRx.Operators.ZipFunc<T1, T2, T3, T4, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Zip<T1, T2, T3, T4, TR> : UniRx.Operators.NthZipObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<T1, T2, T3, T4, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<T1> q1;
                /*0x0*/ System.Collections.Generic.Queue<T2> q2;
                /*0x0*/ System.Collections.Generic.Queue<T3> q3;
                /*0x0*/ System.Collections.Generic.Queue<T4> q4;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<T1, T2, T3, T4, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__7_0();
            }
        }

        class ZipObservable<T1, T2, T3, T4, T5, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, TR> resultSelector;

            /*0x380db40*/ ZipObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Zip<T1, T2, T3, T4, T5, TR> : UniRx.Operators.NthZipObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<T1> q1;
                /*0x0*/ System.Collections.Generic.Queue<T2> q2;
                /*0x0*/ System.Collections.Generic.Queue<T3> q3;
                /*0x0*/ System.Collections.Generic.Queue<T4> q4;
                /*0x0*/ System.Collections.Generic.Queue<T5> q5;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__8_0();
            }
        }

        class ZipObservable<T1, T2, T3, T4, T5, T6, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ System.IObservable<T6> source6;
            /*0x0*/ UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector;

            /*0x380db80*/ ZipObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Zip<T1, T2, T3, T4, T5, T6, TR> : UniRx.Operators.NthZipObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, T6, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<T1> q1;
                /*0x0*/ System.Collections.Generic.Queue<T2> q2;
                /*0x0*/ System.Collections.Generic.Queue<T3> q3;
                /*0x0*/ System.Collections.Generic.Queue<T4> q4;
                /*0x0*/ System.Collections.Generic.Queue<T5> q5;
                /*0x0*/ System.Collections.Generic.Queue<T6> q6;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, T6, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__9_0();
            }
        }

        class ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ System.IObservable<T6> source6;
            /*0x0*/ System.IObservable<T7> source7;
            /*0x0*/ UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector;

            /*0x380dbc4*/ ZipObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, System.IObservable<T7> source7, UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class Zip<T1, T2, T3, T4, T5, T6, T7, TR> : UniRx.Operators.NthZipObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<T1> q1;
                /*0x0*/ System.Collections.Generic.Queue<T2> q2;
                /*0x0*/ System.Collections.Generic.Queue<T3> q3;
                /*0x0*/ System.Collections.Generic.Queue<T4> q4;
                /*0x0*/ System.Collections.Generic.Queue<T5> q5;
                /*0x0*/ System.Collections.Generic.Queue<T6> q6;
                /*0x0*/ System.Collections.Generic.Queue<T7> q7;

                /*0x380da4c*/ Zip(UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380cb08*/ void <Run>b__10_0();
            }
        }

        interface IZipObservable
        {
            /*0x380cffc*/ void Dequeue(int index);
            /*0x380d83c*/ void Fail(System.Exception error);
            /*0x380cffc*/ void Done(int index);
        }

        class NthZipObserverBase<T> : UniRx.Operators.OperatorObserverBase<T, T>, UniRx.Operators.IZipObservable
        {
            /*0x0*/ System.Collections.ICollection[] queues;
            /*0x0*/ bool[] isDone;
            /*0x0*/ int length;

            /*0x380d93c*/ NthZipObserverBase(System.IObserver<T> observer, System.IDisposable cancel);
            /*0x380d83c*/ void SetQueue(System.Collections.ICollection[] queues);
            /*0x3907c14*/ T GetResult();
            /*0x380cffc*/ void Dequeue(int index);
            /*0x380cffc*/ void Done(int index);
            /*0x380d83c*/ void Fail(System.Exception error);
        }

        class ZipObserver<T> : System.IObserver<T>
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.Operators.IZipObservable parent;
            /*0x0*/ int index;
            /*0x0*/ System.Collections.Generic.Queue<T> queue;

            ZipObserver(object gate, UniRx.Operators.IZipObservable parent, int index, System.Collections.Generic.Queue<T> queue);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class ZipLatestFunc<T1, T2, T3, TR> : System.MulticastDelegate
        {
            ZipLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipLatestFunc<T1, T2, T3, T4, TR> : System.MulticastDelegate
        {
            ZipLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipLatestFunc<T1, T2, T3, T4, T5, TR> : System.MulticastDelegate
        {
            ZipLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> : System.MulticastDelegate
        {
            ZipLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> : System.MulticastDelegate
        {
            ZipLatestFunc(object object, nint method);
            /*0x3907c14*/ TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, System.AsyncCallback callback, object object);
            /*0x3907c14*/ TR EndInvoke(System.IAsyncResult result);
        }

        class ZipLatestObservable<TLeft, TRight, TResult> : UniRx.Operators.OperatorObservableBase<TResult>
        {
            /*0x0*/ System.IObservable<TLeft> left;
            /*0x0*/ System.IObservable<TRight> right;
            /*0x0*/ System.Func<TLeft, TRight, TResult> selector;

            /*0x380da4c*/ ZipLatestObservable(System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, TRight, TResult> selector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TResult> observer, System.IDisposable cancel);

            class ZipLatest<TLeft, TRight, TResult> : UniRx.Operators.OperatorObserverBase<TResult, TResult>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<TLeft, TRight, TResult> parent;
                /*0x0*/ object gate;
                /*0x0*/ TLeft leftValue;
                /*0x0*/ bool leftStarted;
                /*0x0*/ bool leftCompleted;
                /*0x0*/ TRight rightValue;
                /*0x0*/ bool rightStarted;
                /*0x0*/ bool rightCompleted;

                /*0x380da4c*/ ZipLatest(UniRx.Operators.ZipLatestObservable<TLeft, TRight, TResult> parent, System.IObserver<TResult> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void Publish();
                /*0x3907c14*/ void OnNext(TResult value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class LeftObserver<TLeft, TRight, TResult> : System.IObserver<TLeft>
                {
                    /*0x0*/ UniRx.Operators.ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ LeftObserver(UniRx.Operators.ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TLeft value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }

                class RightObserver<TLeft, TRight, TResult> : System.IObserver<TRight>
                {
                    /*0x0*/ UniRx.Operators.ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent;

                    /*0x380d83c*/ RightObserver(UniRx.Operators.ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent);
                    /*0x3907c14*/ void OnNext(TRight value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class ZipLatestObservable<T> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<T>>
        {
            /*0x0*/ System.IObservable<T> sources;

            /*0x380d83c*/ ZipLatestObservable(System.IObservable<T> sources);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);

            class ZipLatest<T> : UniRx.Operators.OperatorObserverBase<System.Collections.Generic.IList<T>, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ int length;
                /*0x0*/ T[] values;
                /*0x0*/ bool[] isStarted;
                /*0x0*/ bool[] isCompleted;

                /*0x380da4c*/ ZipLatest(UniRx.Operators.ZipLatestObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cffc*/ void Publish(int index);
                /*0x380d83c*/ void OnNext(System.Collections.Generic.IList<T> value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class ZipLatestObserver<T> : System.IObserver<T>
                {
                    /*0x0*/ UniRx.Operators.ZipLatestObservable.ZipLatest<T> parent;
                    /*0x0*/ int index;

                    /*0x380d8b8*/ ZipLatestObserver(UniRx.Operators.ZipLatestObservable.ZipLatest<T> parent, int index);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception ex);
                    /*0x380cb08*/ void OnCompleted();
                }
            }
        }

        class ZipLatestObservable<T1, T2, T3, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ UniRx.Operators.ZipLatestFunc<T1, T2, T3, TR> resultSelector;

            /*0x380da84*/ ZipLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, UniRx.Operators.ZipLatestFunc<T1, T2, T3, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class ZipLatest<T1, T2, T3, TR> : UniRx.Operators.NthZipLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<T1, T2, T3, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T3> c3;

                ZipLatest(int length, UniRx.Operators.ZipLatestObservable<T1, T2, T3, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ZipLatestObservable<T1, T2, T3, T4, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, TR> resultSelector;

            /*0x380db04*/ ZipLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class ZipLatest<T1, T2, T3, T4, TR> : UniRx.Operators.NthZipLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T4> c4;

                ZipLatest(int length, UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ZipLatestObservable<T1, T2, T3, T4, T5, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector;

            /*0x380db40*/ ZipLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class ZipLatest<T1, T2, T3, T4, T5, TR> : UniRx.Operators.NthZipLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T4> c4;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T5> c5;

                ZipLatest(int length, UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ System.IObservable<T6> source6;
            /*0x0*/ UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector;

            /*0x380db80*/ ZipLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class ZipLatest<T1, T2, T3, T4, T5, T6, TR> : UniRx.Operators.NthZipLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T4> c4;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T5> c5;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T6> c6;

                ZipLatest(int length, UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> : UniRx.Operators.OperatorObservableBase<TR>
        {
            /*0x0*/ System.IObservable<T1> source1;
            /*0x0*/ System.IObservable<T2> source2;
            /*0x0*/ System.IObservable<T3> source3;
            /*0x0*/ System.IObservable<T4> source4;
            /*0x0*/ System.IObservable<T5> source5;
            /*0x0*/ System.IObservable<T6> source6;
            /*0x0*/ System.IObservable<T7> source7;
            /*0x0*/ UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector;

            /*0x380dbc4*/ ZipLatestObservable(System.IObservable<T1> source1, System.IObservable<T2> source2, System.IObservable<T3> source3, System.IObservable<T4> source4, System.IObservable<T5> source5, System.IObservable<T6> source6, System.IObservable<T7> source7, UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<TR> observer, System.IDisposable cancel);

            class ZipLatest<T1, T2, T3, T4, T5, T6, T7, TR> : UniRx.Operators.NthZipLatestObserverBase<TR>
            {
                /*0x0*/ UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T1> c1;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T2> c2;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T3> c3;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T4> c4;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T5> c5;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T6> c6;
                /*0x0*/ UniRx.Operators.ZipLatestObserver<T7> c7;

                ZipLatest(int length, UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, System.IObserver<TR> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ TR GetResult();
                /*0x3907c14*/ void OnNext(TR value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        interface IZipLatestObservable
        {
            /*0x380cffc*/ void Publish(int index);
            /*0x380d83c*/ void Fail(System.Exception error);
            /*0x380cffc*/ void Done(int index);
        }

        class NthZipLatestObserverBase<T> : UniRx.Operators.OperatorObserverBase<T, T>, UniRx.Operators.IZipLatestObservable
        {
            /*0x0*/ int length;
            /*0x0*/ bool[] isStarted;
            /*0x0*/ bool[] isCompleted;

            NthZipLatestObserverBase(int length, System.IObserver<T> observer, System.IDisposable cancel);
            /*0x3907c14*/ T GetResult();
            /*0x380cffc*/ void Publish(int index);
            /*0x380cffc*/ void Done(int index);
            /*0x380d83c*/ void Fail(System.Exception error);
        }

        class ZipLatestObserver<T> : System.IObserver<T>
        {
            /*0x0*/ object gate;
            /*0x0*/ UniRx.Operators.IZipLatestObservable parent;
            /*0x0*/ int index;
            /*0x0*/ T value;

            ZipLatestObserver(object gate, UniRx.Operators.IZipLatestObservable parent, int index);
            /*0x3907c14*/ T get_Value();
            /*0x3907c14*/ void OnNext(T value);
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x380cb08*/ void OnCompleted();
        }

        class BatchFrameObservable<T> : UniRx.Operators.OperatorObservableBase<System.Collections.Generic.IList<T>>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            BatchFrameObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);

            class BatchFrame<T> : UniRx.Operators.OperatorObserverBase<T, System.Collections.Generic.IList<T>>
            {
                /*0x0*/ UniRx.Operators.BatchFrameObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.BooleanDisposable cancellationToken;
                /*0x0*/ System.Collections.IEnumerator timer;
                /*0x0*/ bool isRunning;
                /*0x0*/ bool isCompleted;
                /*0x0*/ System.Collections.Generic.List<T> list;

                /*0x380da4c*/ BatchFrame(UniRx.Operators.BatchFrameObservable<T> parent, System.IObserver<System.Collections.Generic.IList<T>> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class ReusableEnumerator<T> : System.Collections.IEnumerator
                {
                    /*0x0*/ UniRx.Operators.BatchFrameObservable.BatchFrame<T> parent;
                    /*0x0*/ int currentFrame;

                    /*0x380d83c*/ ReusableEnumerator(UniRx.Operators.BatchFrameObservable.BatchFrame<T> parent);
                    /*0x380b9e8*/ object get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                }
            }
        }

        class BatchFrameObservable : UniRx.Operators.OperatorObservableBase<UniRx.Unit>
        {
            /*0x18*/ System.IObservable<UniRx.Unit> source;
            /*0x20*/ int frameCount;
            /*0x24*/ UniRx.FrameCountType frameCountType;

            /*0x78fd774*/ BatchFrameObservable(System.IObservable<UniRx.Unit> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x78fd814*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);

            class BatchFrame : UniRx.Operators.OperatorObserverBase<UniRx.Unit, UniRx.Unit>
            {
                /*0x20*/ UniRx.Operators.BatchFrameObservable parent;
                /*0x28*/ object gate;
                /*0x30*/ UniRx.BooleanDisposable cancellationToken;
                /*0x38*/ System.Collections.IEnumerator timer;
                /*0x40*/ bool isRunning;
                /*0x41*/ bool isCompleted;

                /*0x78fd88c*/ BatchFrame(UniRx.Operators.BatchFrameObservable parent, System.IObserver<UniRx.Unit> observer, System.IDisposable cancel);
                /*0x78fd9c8*/ System.IDisposable Run();
                /*0x78fdab0*/ void OnNext(UniRx.Unit value);
                /*0x78fdcdc*/ void OnError(System.Exception error);
                /*0x78fde2c*/ void OnCompleted();

                class ReusableEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ UniRx.Operators.BatchFrameObservable.BatchFrame parent;
                    /*0x18*/ int currentFrame;

                    /*0x78fda80*/ ReusableEnumerator(UniRx.Operators.BatchFrameObservable.BatchFrame parent);
                    /*0x78fe0e0*/ object get_Current();
                    /*0x78fe0e8*/ bool MoveNext();
                    /*0x78fe340*/ void Reset();
                }
            }
        }

        class DelayFrameObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            DelayFrameObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class DelayFrame<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.DelayFrameObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ UniRx.Operators.DelayFrameObservable.QueuePool<T> pool;
                /*0x0*/ int runningEnumeratorCount;
                /*0x0*/ bool readyDrainEnumerator;
                /*0x0*/ bool running;
                /*0x0*/ System.IDisposable sourceSubscription;
                /*0x0*/ System.Collections.Generic.Queue<T> currentQueueReference;
                /*0x0*/ bool calledCompleted;
                /*0x0*/ bool hasError;
                /*0x0*/ System.Exception error;
                /*0x0*/ UniRx.BooleanDisposable cancelationToken;

                /*0x380da4c*/ DelayFrame(UniRx.Operators.DelayFrameObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380bc74*/ System.Collections.IEnumerator DrainQueue(System.Collections.Generic.Queue<T> q, int frameCount);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class <DrainQueue>d__14<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ UniRx.Operators.DelayFrameObservable.DelayFrame<T> <>4__this;
                    /*0x0*/ int frameCount;
                    /*0x0*/ System.Collections.Generic.Queue<T> q;

                    /*0x380cffc*/ <DrainQueue>d__14(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class QueuePool<T>
            {
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.Queue<System.Collections.Generic.Queue<T>> pool;

                /*0x380cb08*/ QueuePool();
                /*0x380b9e8*/ System.Collections.Generic.Queue<T> Get();
                /*0x380d83c*/ void Return(System.Collections.Generic.Queue<T> q);
            }
        }

        class DelayFrameSubscriptionObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            DelayFrameSubscriptionObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class <>c<T>
            {
                static /*0x0*/ UniRx.Operators.DelayFrameSubscriptionObservable.<>c<T> <>9;
                static /*0x0*/ System.Action<long, System.IObserver<T>, UniRx.MultipleAssignmentDisposable, System.IObservable<T>> <>9__4_0;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x3907c14*/ void <SubscribeCore>b__4_0(long _, System.IObserver<T> o, UniRx.MultipleAssignmentDisposable disp, System.IObservable<T> s);
            }
        }

        class FrameIntervalObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.FrameInterval<T>>
        {
            /*0x0*/ System.IObservable<T> source;

            /*0x380d83c*/ FrameIntervalObservable(System.IObservable<T> source);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.FrameInterval<T>> observer, System.IDisposable cancel);

            class FrameInterval<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.FrameInterval<T>>
            {
                /*0x0*/ int lastFrame;

                /*0x380d93c*/ FrameInterval(System.IObserver<UniRx.FrameInterval<T>> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class FrameTimeIntervalObservable<T> : UniRx.Operators.OperatorObservableBase<UniRx.TimeInterval<T>>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ bool ignoreTimeScale;

            FrameTimeIntervalObservable(System.IObservable<T> source, bool ignoreTimeScale);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<UniRx.TimeInterval<T>> observer, System.IDisposable cancel);

            class FrameTimeInterval<T> : UniRx.Operators.OperatorObserverBase<T, UniRx.TimeInterval<T>>
            {
                /*0x0*/ UniRx.Operators.FrameTimeIntervalObservable<T> parent;
                /*0x0*/ float lastTime;

                /*0x380da4c*/ FrameTimeInterval(UniRx.Operators.FrameTimeIntervalObservable<T> parent, System.IObserver<UniRx.TimeInterval<T>> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class FromCoroutineObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Func<System.IObserver<T>, System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine;

            /*0x380d83c*/ FromCoroutineObservable(System.Func<System.IObserver<T>, System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class FromCoroutine<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ FromCoroutine(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class FromMicroCoroutineObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Func<System.IObserver<T>, System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            /*0x380d8b8*/ FromMicroCoroutineObservable(System.Func<System.IObserver<T>, System.Threading.CancellationToken, System.Collections.IEnumerator> coroutine, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class FromMicroCoroutine<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x380d93c*/ FromMicroCoroutine(System.IObserver<T> observer, System.IDisposable cancel);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
            }
        }

        class RepeatUntilObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.Collections.Generic.IEnumerable<System.IObservable<T>> sources;
            /*0x0*/ System.IObservable<UniRx.Unit> trigger;
            /*0x0*/ UnityEngine.GameObject lifeTimeChecker;

            /*0x380da4c*/ RepeatUntilObservable(System.Collections.Generic.IEnumerable<System.IObservable<T>> sources, System.IObservable<UniRx.Unit> trigger, UnityEngine.GameObject lifeTimeChecker);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class RepeatUntil<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.RepeatUntilObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ System.Collections.Generic.IEnumerator<System.IObservable<T>> e;
                /*0x0*/ UniRx.SerialDisposable subscription;
                /*0x0*/ UniRx.SingleAssignmentDisposable schedule;
                /*0x0*/ System.Action nextSelf;
                /*0x0*/ bool isStopped;
                /*0x0*/ bool isDisposed;
                /*0x0*/ bool isFirstSubscribe;
                /*0x0*/ System.IDisposable stopper;

                static /*0x3830bec*/ System.Collections.IEnumerator SubscribeAfterEndOfFrame(UniRx.SingleAssignmentDisposable d, System.IObservable<T> source, System.IObserver<T> observer, UnityEngine.GameObject lifeTimeChecker);
                /*0x380da4c*/ RepeatUntil(UniRx.Operators.RepeatUntilObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d83c*/ void RecursiveRun(System.Action self);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();
                /*0x380e2c4*/ void <Run>b__11_0(UniRx.Unit _);
                /*0x380cb08*/ void <Run>b__11_1();

                class <SubscribeAfterEndOfFrame>d__13<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ UniRx.SingleAssignmentDisposable d;
                    /*0x0*/ UnityEngine.GameObject lifeTimeChecker;
                    /*0x0*/ System.IObservable<T> source;
                    /*0x0*/ System.IObserver<T> observer;

                    /*0x380cffc*/ <SubscribeAfterEndOfFrame>d__13(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        class SampleFrameObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            SampleFrameObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class SampleFrame<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.SampleFrameObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ T latestValue;
                /*0x0*/ bool isUpdated;
                /*0x0*/ bool isCompleted;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;

                /*0x380da4c*/ SampleFrame(UniRx.Operators.SampleFrameObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380d438*/ void OnNextTick(long _);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class SampleFrameTick<T> : System.IObserver<long>
                {
                    /*0x0*/ UniRx.Operators.SampleFrameObservable.SampleFrame<T> parent;

                    /*0x380d83c*/ SampleFrameTick(UniRx.Operators.SampleFrameObservable.SampleFrame<T> parent);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380d438*/ void OnNext(long _);
                }
            }
        }

        class SubscribeOnMainThreadObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ System.IObservable<long> subscribeTrigger;

            /*0x380d93c*/ SubscribeOnMainThreadObservable(System.IObservable<T> source, System.IObservable<long> subscribeTrigger);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class <>c<T>
            {
                static /*0x0*/ UniRx.Operators.SubscribeOnMainThreadObservable.<>c<T> <>9;
                static /*0x0*/ System.Action<long, System.IObserver<T>, UniRx.SerialDisposable, System.IObservable<T>> <>9__3_0;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x3907c14*/ void <SubscribeCore>b__3_0(long _, System.IObserver<T> o, UniRx.SerialDisposable disp, System.IObservable<T> s);
            }
        }

        class ThrottleFirstFrameObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            ThrottleFirstFrameObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class ThrottleFirstFrame<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ThrottleFirstFrameObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ bool open;
                /*0x0*/ UniRx.SerialDisposable cancelable;
                /*0x0*/ UniRx.Operators.ThrottleFirstFrameObservable.ThrottleFirstFrame.ThrottleFirstFrameTick<T> tick;

                /*0x380da4c*/ ThrottleFirstFrame(UniRx.Operators.ThrottleFirstFrameObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x380cb08*/ void OnNext();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class ThrottleFirstFrameTick<T> : System.IObserver<long>
                {
                    /*0x0*/ UniRx.Operators.ThrottleFirstFrameObservable.ThrottleFirstFrame<T> parent;

                    /*0x380d83c*/ ThrottleFirstFrameTick(UniRx.Operators.ThrottleFirstFrameObservable.ThrottleFirstFrame<T> parent);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380d438*/ void OnNext(long _);
                }
            }
        }

        class ThrottleFrameObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            ThrottleFrameObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class ThrottleFrame<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.ThrottleFrameObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ T latestValue;
                /*0x0*/ bool hasValue;
                /*0x0*/ UniRx.SerialDisposable cancelable;
                /*0x0*/ ulong id;

                /*0x380da4c*/ ThrottleFrame(UniRx.Operators.ThrottleFrameObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class ThrottleFrameTick<T> : System.IObserver<long>
                {
                    /*0x0*/ UniRx.Operators.ThrottleFrameObservable.ThrottleFrame<T> parent;
                    /*0x0*/ ulong currentid;

                    ThrottleFrameTick(UniRx.Operators.ThrottleFrameObservable.ThrottleFrame<T> parent, ulong currentid);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380d438*/ void OnNext(long _);
                }
            }
        }

        class TimeoutFrameObservable<T> : UniRx.Operators.OperatorObservableBase<T>
        {
            /*0x0*/ System.IObservable<T> source;
            /*0x0*/ int frameCount;
            /*0x0*/ UniRx.FrameCountType frameCountType;

            TimeoutFrameObservable(System.IObservable<T> source, int frameCount, UniRx.FrameCountType frameCountType);
            /*0x380bcbc*/ System.IDisposable SubscribeCore(System.IObserver<T> observer, System.IDisposable cancel);

            class TimeoutFrame<T> : UniRx.Operators.OperatorObserverBase<T, T>
            {
                /*0x0*/ UniRx.Operators.TimeoutFrameObservable<T> parent;
                /*0x0*/ object gate;
                /*0x0*/ ulong objectId;
                /*0x0*/ bool isTimeout;
                /*0x0*/ UniRx.SingleAssignmentDisposable sourceSubscription;
                /*0x0*/ UniRx.SerialDisposable timerSubscription;

                /*0x380da4c*/ TimeoutFrame(UniRx.Operators.TimeoutFrameObservable<T> parent, System.IObserver<T> observer, System.IDisposable cancel);
                /*0x380b9e8*/ System.IDisposable Run();
                System.IDisposable RunTimer(ulong timerId);
                /*0x3907c14*/ void OnNext(T value);
                /*0x380d83c*/ void OnError(System.Exception error);
                /*0x380cb08*/ void OnCompleted();

                class TimeoutFrameTick<T> : System.IObserver<long>
                {
                    /*0x0*/ UniRx.Operators.TimeoutFrameObservable.TimeoutFrame<T> parent;
                    /*0x0*/ ulong timerId;

                    TimeoutFrameTick(UniRx.Operators.TimeoutFrameObservable.TimeoutFrame<T> parent, ulong timerId);
                    /*0x380cb08*/ void OnCompleted();
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380d438*/ void OnNext(long _);
                }
            }
        }
    }

    namespace InternalUtil
    {
        class AsyncLock : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Queue<System.Action> queue;
            /*0x18*/ bool isAcquired;
            /*0x19*/ bool hasFaulted;

            /*0x78fe844*/ AsyncLock();
            /*0x78fe348*/ void Wait(System.Action action);
            /*0x78fe744*/ void Dispose();
        }

        interface ICancellableTaskCompletionSource
        {
            /*0x380b2f0*/ bool TrySetException(System.Exception exception);
            /*0x380b128*/ bool TrySetCanceled();
        }

        class CancellableTaskCompletionSource<T> : System.Threading.Tasks.TaskCompletionSource<T>, UniRx.InternalUtil.ICancellableTaskCompletionSource
        {
            /*0x380cb08*/ CancellableTaskCompletionSource();
            /*0x380b2f0*/ bool UniRx.InternalUtil.ICancellableTaskCompletionSource.TrySetException(System.Exception exception);
            /*0x380b128*/ bool UniRx.InternalUtil.ICancellableTaskCompletionSource.TrySetCanceled();
        }

        class ExceptionExtensions
        {
            static /*0x78fe8cc*/ void Throw(System.Exception exception);
        }

        class ImmutableList<T>
        {
            static /*0x0*/ UniRx.InternalUtil.ImmutableList<T> Empty;
            /*0x0*/ T[] data;

            static /*0x38358cc*/ ImmutableList();
            /*0x380cb08*/ ImmutableList();
            /*0x380d83c*/ ImmutableList(T[] data);
            /*0x380b9e8*/ T[] get_Data();
            /*0x3907c14*/ UniRx.InternalUtil.ImmutableList<T> Add(T value);
            /*0x3907c14*/ UniRx.InternalUtil.ImmutableList<T> Remove(T value);
            /*0x3907c14*/ int IndexOf(T value);
        }

        class ListObserver<T> : System.IObserver<T>
        {
            /*0x0*/ UniRx.InternalUtil.ImmutableList<System.IObserver<T>> _observers;

            /*0x380d83c*/ ListObserver(UniRx.InternalUtil.ImmutableList<System.IObserver<T>> observers);
            /*0x380cb08*/ void OnCompleted();
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x3907c14*/ void OnNext(T value);
            /*0x380bb68*/ System.IObserver<T> Add(System.IObserver<T> observer);
            /*0x380bb68*/ System.IObserver<T> Remove(System.IObserver<T> observer);
        }

        class EmptyObserver<T> : System.IObserver<T>
        {
            static /*0x0*/ UniRx.InternalUtil.EmptyObserver<T> Instance;

            static /*0x38358cc*/ EmptyObserver();
            /*0x380cb08*/ EmptyObserver();
            /*0x380cb08*/ void OnCompleted();
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x3907c14*/ void OnNext(T value);
        }

        class ThrowObserver<T> : System.IObserver<T>
        {
            static /*0x0*/ UniRx.InternalUtil.ThrowObserver<T> Instance;

            static /*0x38358cc*/ ThrowObserver();
            /*0x380cb08*/ ThrowObserver();
            /*0x380cb08*/ void OnCompleted();
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x3907c14*/ void OnNext(T value);
        }

        class DisposedObserver<T> : System.IObserver<T>
        {
            static /*0x0*/ UniRx.InternalUtil.DisposedObserver<T> Instance;

            static /*0x38358cc*/ DisposedObserver();
            /*0x380cb08*/ DisposedObserver();
            /*0x380cb08*/ void OnCompleted();
            /*0x380d83c*/ void OnError(System.Exception error);
            /*0x3907c14*/ void OnNext(T value);
        }

        class MicroCoroutine
        {
            static int InitialSize = 16;
            /*0x10*/ object runningAndQueueLock;
            /*0x18*/ object arrayLock;
            /*0x20*/ System.Action<System.Exception> unhandledExceptionCallback;
            /*0x28*/ int tail;
            /*0x2c*/ bool running;
            /*0x30*/ System.Collections.IEnumerator[] coroutines;
            /*0x38*/ System.Collections.Generic.Queue<System.Collections.IEnumerator> waitQueue;

            /*0x78fe90c*/ MicroCoroutine(System.Action<System.Exception> unhandledExceptionCallback);
            /*0x78fea3c*/ void AddCoroutine(System.Collections.IEnumerator enumerator);
            /*0x78fece4*/ void Run();
        }

        class PriorityQueue<T>
        {
            static /*0x0*/ long _count;
            /*0x0*/ UniRx.InternalUtil.PriorityQueue.IndexedItem<T> _items;
            /*0x0*/ int _size;

            static /*0x38358cc*/ PriorityQueue();
            /*0x380cb08*/ PriorityQueue();
            /*0x380cffc*/ PriorityQueue(int capacity);
            bool IsHigherPriority(int left, int right);
            /*0x380cffc*/ void Percolate(int index);
            /*0x380cb08*/ void Heapify();
            /*0x380cffc*/ void Heapify(int index);
            /*0x380b6a0*/ int get_Count();
            /*0x3907c14*/ T Peek();
            /*0x380cffc*/ void RemoveAt(int index);
            /*0x3907c14*/ T Dequeue();
            /*0x3907c14*/ void Enqueue(T item);
            /*0x3907c14*/ bool Remove(T item);

            struct IndexedItem<T> : System.IComparable<UniRx.InternalUtil.PriorityQueue.IndexedItem<T>>
            {
                /*0x0*/ T Value;
                /*0x0*/ long Id;

                /*0x3907c14*/ int CompareTo(UniRx.InternalUtil.PriorityQueue.IndexedItem<T> other);
            }
        }

        class PromiseHelper
        {
            static /*0x3907c14*/ void TrySetResultAll<T>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.TaskCompletionSource<T>> source, T value);
        }

        class ScheduledItem : System.IComparable<UniRx.InternalUtil.ScheduledItem>
        {
            /*0x10*/ UniRx.BooleanDisposable _disposable;
            /*0x18*/ System.TimeSpan _dueTime;
            /*0x20*/ System.Action _action;

            static /*0x78ff7ac*/ bool op_LessThan(UniRx.InternalUtil.ScheduledItem left, UniRx.InternalUtil.ScheduledItem right);
            static /*0x78ff7c8*/ bool op_LessThanOrEqual(UniRx.InternalUtil.ScheduledItem left, UniRx.InternalUtil.ScheduledItem right);
            static /*0x78ff7e8*/ bool op_GreaterThan(UniRx.InternalUtil.ScheduledItem left, UniRx.InternalUtil.ScheduledItem right);
            static /*0x78ff808*/ bool op_GreaterThanOrEqual(UniRx.InternalUtil.ScheduledItem left, UniRx.InternalUtil.ScheduledItem right);
            static /*0x78ff828*/ bool op_Equality(UniRx.InternalUtil.ScheduledItem left, UniRx.InternalUtil.ScheduledItem right);
            static /*0x78ff834*/ bool op_Inequality(UniRx.InternalUtil.ScheduledItem left, UniRx.InternalUtil.ScheduledItem right);
            /*0x78ff650*/ ScheduledItem(System.Action action, System.TimeSpan dueTime);
            /*0x78ff6e0*/ System.TimeSpan get_DueTime();
            /*0x78ff6e8*/ void Invoke();
            /*0x78ff724*/ int CompareTo(UniRx.InternalUtil.ScheduledItem other);
            /*0x78ff840*/ bool Equals(object obj);
            /*0x78ff84c*/ int GetHashCode();
            /*0x78ff854*/ System.IDisposable get_Cancellation();
            /*0x78ff85c*/ bool get_IsCanceled();
        }

        class SchedulerQueue
        {
            /*0x10*/ UniRx.InternalUtil.PriorityQueue<UniRx.InternalUtil.ScheduledItem> _queue;

            /*0x78ff878*/ SchedulerQueue();
            /*0x78ff880*/ SchedulerQueue(int capacity);
            /*0x78ff954*/ int get_Count();
            /*0x78ff99c*/ void Enqueue(UniRx.InternalUtil.ScheduledItem scheduledItem);
            /*0x78ff9f4*/ bool Remove(UniRx.InternalUtil.ScheduledItem scheduledItem);
            /*0x78ffa4c*/ UniRx.InternalUtil.ScheduledItem Dequeue();
            /*0x78ffa9c*/ UniRx.InternalUtil.ScheduledItem Peek();
        }

        class ThreadSafeQueueWorker
        {
            static int MaxArrayLength = 2146435071;
            static int InitialSize = 16;
            /*0x10*/ object gate;
            /*0x18*/ bool dequing;
            /*0x1c*/ int actionListCount;
            /*0x20*/ System.Action<object> actionList;
            /*0x28*/ object[] actionStates;
            /*0x30*/ int waitingListCount;
            /*0x38*/ System.Action<object> waitingList;
            /*0x40*/ object[] waitingStates;

            /*0x79002e0*/ ThreadSafeQueueWorker();
            /*0x78ffaec*/ void Enqueue(System.Action<object> action, object state);
            /*0x78ffeb8*/ void ExecuteAll(System.Action<System.Exception> unhandledExceptionCallback);
        }

        class UnityEqualityComparer
        {
            static /*0x0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector2> Vector2;
            static /*0x8*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector3> Vector3;
            static /*0x10*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector4> Vector4;
            static /*0x18*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Color> Color;
            static /*0x20*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Color32> Color32;
            static /*0x28*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Rect> Rect;
            static /*0x30*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Bounds> Bounds;
            static /*0x38*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Quaternion> Quaternion;
            static /*0x40*/ System.RuntimeTypeHandle vector2Type;
            static /*0x48*/ System.RuntimeTypeHandle vector3Type;
            static /*0x50*/ System.RuntimeTypeHandle vector4Type;
            static /*0x58*/ System.RuntimeTypeHandle colorType;
            static /*0x60*/ System.RuntimeTypeHandle color32Type;
            static /*0x68*/ System.RuntimeTypeHandle rectType;
            static /*0x70*/ System.RuntimeTypeHandle boundsType;
            static /*0x78*/ System.RuntimeTypeHandle quaternionType;
            static /*0x80*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector2Int> Vector2Int;
            static /*0x88*/ System.Collections.Generic.IEqualityComparer<UnityEngine.Vector3Int> Vector3Int;
            static /*0x90*/ System.Collections.Generic.IEqualityComparer<UnityEngine.RangeInt> RangeInt;
            static /*0x98*/ System.Collections.Generic.IEqualityComparer<UnityEngine.RectInt> RectInt;
            static /*0xa0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.BoundsInt> BoundsInt;
            static /*0xa8*/ System.RuntimeTypeHandle vector2IntType;
            static /*0xb0*/ System.RuntimeTypeHandle vector3IntType;
            static /*0xb8*/ System.RuntimeTypeHandle rangeIntType;
            static /*0xc0*/ System.RuntimeTypeHandle rectIntType;
            static /*0xc8*/ System.RuntimeTypeHandle boundsIntType;

            static /*0x7900770*/ UnityEqualityComparer();
            static /*0x382dee4*/ System.Collections.Generic.IEqualityComparer<T> GetDefault<T>();
            static /*0x79003ec*/ object GetDefaultHelper(System.Type type);

            class Cache<T>
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<T> Comparer;

                static /*0x38358cc*/ Cache();
            }

            class Vector2EqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Vector2>
            {
                /*0x7900e40*/ Vector2EqualityComparer();
                /*0x7900ea8*/ bool Equals(UnityEngine.Vector2 self, UnityEngine.Vector2 vector);
                /*0x7900ef8*/ int GetHashCode(UnityEngine.Vector2 obj);
            }

            class Vector3EqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Vector3>
            {
                /*0x7900e48*/ Vector3EqualityComparer();
                /*0x7900f38*/ bool Equals(UnityEngine.Vector3 self, UnityEngine.Vector3 vector);
                /*0x7900fac*/ int GetHashCode(UnityEngine.Vector3 obj);
            }

            class Vector4EqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Vector4>
            {
                /*0x7900e50*/ Vector4EqualityComparer();
                /*0x7901010*/ bool Equals(UnityEngine.Vector4 self, UnityEngine.Vector4 vector);
                /*0x79010a4*/ int GetHashCode(UnityEngine.Vector4 obj);
            }

            class ColorEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Color>
            {
                /*0x7900e58*/ ColorEqualityComparer();
                /*0x7901128*/ bool Equals(UnityEngine.Color self, UnityEngine.Color other);
                /*0x79011bc*/ int GetHashCode(UnityEngine.Color obj);
            }

            class RectEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Rect>
            {
                /*0x7900e68*/ RectEqualityComparer();
                /*0x7901240*/ bool Equals(UnityEngine.Rect self, UnityEngine.Rect other);
                /*0x79012e4*/ int GetHashCode(UnityEngine.Rect obj);
            }

            class BoundsEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Bounds>
            {
                /*0x7900e70*/ BoundsEqualityComparer();
                /*0x790136c*/ bool Equals(UnityEngine.Bounds self, UnityEngine.Bounds vector);
                /*0x79013d8*/ int GetHashCode(UnityEngine.Bounds obj);
            }

            class QuaternionEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Quaternion>
            {
                /*0x7900e78*/ QuaternionEqualityComparer();
                /*0x79014b0*/ bool Equals(UnityEngine.Quaternion self, UnityEngine.Quaternion vector);
                /*0x7901544*/ int GetHashCode(UnityEngine.Quaternion obj);
            }

            class Color32EqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Color32>
            {
                /*0x7900e60*/ Color32EqualityComparer();
                /*0x79015c8*/ bool Equals(UnityEngine.Color32 self, UnityEngine.Color32 vector);
                /*0x7901648*/ int GetHashCode(UnityEngine.Color32 obj);
            }

            class Vector2IntEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Vector2Int>
            {
                /*0x7900e80*/ Vector2IntEqualityComparer();
                /*0x79016b4*/ bool Equals(UnityEngine.Vector2Int self, UnityEngine.Vector2Int vector);
                /*0x790170c*/ int GetHashCode(UnityEngine.Vector2Int obj);
            }

            class Vector3IntEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Vector3Int>
            {
                static /*0x0*/ UniRx.InternalUtil.UnityEqualityComparer.Vector3IntEqualityComparer Default;

                static /*0x7901830*/ Vector3IntEqualityComparer();
                /*0x7900e88*/ Vector3IntEqualityComparer();
                /*0x790174c*/ bool Equals(UnityEngine.Vector3Int self, UnityEngine.Vector3Int vector);
                /*0x79017cc*/ int GetHashCode(UnityEngine.Vector3Int obj);
            }

            class RangeIntEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.RangeInt>
            {
                /*0x7900e90*/ RangeIntEqualityComparer();
                /*0x7901898*/ bool Equals(UnityEngine.RangeInt self, UnityEngine.RangeInt vector);
                /*0x79018e8*/ int GetHashCode(UnityEngine.RangeInt obj);
            }

            class RectIntEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.RectInt>
            {
                /*0x7900e98*/ RectIntEqualityComparer();
                /*0x7901924*/ bool Equals(UnityEngine.RectInt self, UnityEngine.RectInt other);
                /*0x79019c0*/ int GetHashCode(UnityEngine.RectInt obj);
            }

            class BoundsIntEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.BoundsInt>
            {
                /*0x7900ea0*/ BoundsIntEqualityComparer();
                /*0x7901a40*/ bool Equals(UnityEngine.BoundsInt self, UnityEngine.BoundsInt vector);
                /*0x7901b0c*/ int GetHashCode(UnityEngine.BoundsInt obj);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 9B98AC97311973D1E115665EF3D07BFD00FE5F61784AD894E0CBF280ECFEF82D;
    static /*0x3cbf*/ <PrivateImplementationDetails> B6C86341FA7229E752518D85ECBD663A6D76A6EC93CEBE1A36BABA34A822269C;

    struct __StaticArrayInitTypeSize=15551
    {
    }

    struct __StaticArrayInitTypeSize=26188
    {
    }
}
