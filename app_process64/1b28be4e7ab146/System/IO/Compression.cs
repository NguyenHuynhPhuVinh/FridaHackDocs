class <Module>
{
}

class Interop
{
    class Brotli
    {
        static /*0x756a134*/ Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(nint allocFunc, nint freeFunc, nint opaque);
        static /*0x756a1d0*/ int BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, ref nint availableIn, byte** nextIn, ref nint availableOut, byte** nextOut, ref nint totalOut);
        static /*0x756a26c*/ void BrotliDecoderDestroyInstance(nint state);
        static /*0x756a270*/ bool BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state);
        static /*0x756a2d8*/ Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(nint allocFunc, nint freeFunc, nint opaque);
        static /*0x756a374*/ bool BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, ref nint availableIn, byte** nextIn, ref nint availableOut, byte** nextOut, ref nint totalOut);
        static /*0x756a424*/ bool BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state);
        static /*0x756a48c*/ void BrotliEncoderDestroyInstance(nint state);
    }
}

namespace System
{
    namespace IO
    {
        namespace Compression
        {
            class BrotliStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _stream;
                /*0x30*/ byte[] _buffer;
                /*0x38*/ bool _leaveOpen;
                /*0x3c*/ System.IO.Compression.CompressionMode _mode;
                /*0x40*/ int _activeAsyncOperation;
                /*0x48*/ System.IO.Compression.BrotliDecoder _decoder;
                /*0x58*/ int _bufferOffset;
                /*0x5c*/ int _bufferCount;
                /*0x60*/ System.IO.Compression.BrotliEncoder _encoder;

                static /*0x756ab08*/ void ValidateParameters(byte[] array, int offset, int count);
                static /*0x756adb0*/ void ThrowInvalidBeginCall();
                /*0x756a490*/ BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x756a688*/ void EnsureNotDisposed();
                /*0x756a700*/ void Dispose(bool disposing);
                /*0x756ac1c*/ bool get_CanRead();
                /*0x756ac40*/ bool get_CanWrite();
                /*0x756ac68*/ bool get_CanSeek();
                /*0x756ac70*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x756aca8*/ long get_Length();
                /*0x756ace0*/ long get_Position();
                /*0x756ad18*/ void set_Position(long value);
                /*0x756ad50*/ void SetLength(long value);
                /*0x756ad88*/ bool get_AsyncOperationIsActive();
                /*0x756ad98*/ void EnsureNoActiveAsyncOperation();
                /*0x756adfc*/ void AsyncOperationStarting();
                /*0x756ae24*/ void AsyncOperationCompleting();
                /*0x756ae38*/ int Read(byte[] buffer, int offset, int count);
                /*0x756aeec*/ int Read(System.Span<byte> buffer);
                /*0x756b548*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x756b6ec*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x756b734*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x756b844*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x756b9cc*/ System.Threading.Tasks.ValueTask<int> FinishReadAsyncMemory(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x756bb3c*/ void Write(byte[] buffer, int offset, int count);
                /*0x756bbe8*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x756a8a8*/ void WriteCore(System.ReadOnlySpan<byte> buffer, bool isFinalBlock);
                /*0x756bc00*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x756bcb0*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x756bda8*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x756bec8*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x756c040*/ System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x756c160*/ void Flush();
                /*0x756c3ac*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x756c4cc*/ System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken);

                struct <FinishReadAsyncMemory>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder;
                    /*0x38*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Memory<byte> buffer;
                    /*0x58*/ int <totalWritten>5__2;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

                    /*0x756c5c8*/ void MoveNext();
                    /*0x756ce4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WriteAsyncMemoryCore>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x38*/ System.ReadOnlyMemory<byte> buffer;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Buffers.OperationStatus <lastResult>5__2;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;

                    /*0x756cea4*/ void MoveNext();
                    /*0x756d6b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <FlushAsyncCore>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Buffers.OperationStatus <lastResult>5__2;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;

                    /*0x756d720*/ void MoveNext();
                    /*0x756dec4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct BrotliDecoder : System.IDisposable
            {
                /*0x10*/ Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle _state;
                /*0x18*/ bool _disposed;

                /*0x756df2c*/ void InitializeDecoder();
                /*0x756dfc0*/ void EnsureInitialized();
                /*0x756e060*/ void Dispose();
                /*0x756dfe8*/ void EnsureNotDisposed();
                /*0x756b2ac*/ System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten);
            }

            struct BrotliEncoder : System.IDisposable
            {
                /*0x10*/ Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle _state;
                /*0x18*/ bool _disposed;

                /*0x756e080*/ void InitializeEncoder();
                /*0x756e190*/ void EnsureInitialized();
                /*0x756e1b8*/ void Dispose();
                /*0x756e118*/ void EnsureNotDisposed();
                /*0x756de44*/ System.Buffers.OperationStatus Flush(System.Memory<byte> destination, ref int bytesWritten);
                /*0x756c310*/ System.Buffers.OperationStatus Flush(System.Span<byte> destination, ref int bytesWritten);
                /*0x756d5e8*/ System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<byte> source, System.Memory<byte> destination, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock);
                /*0x756bbf0*/ System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock);
                /*0x756e1d8*/ System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten, System.IO.Compression.BrotliEncoderOperation operation);
            }

            enum BrotliEncoderOperation
            {
                Process = 0,
                Flush = 1,
                Finish = 2,
                EmitMetadata = 3,
            }
        }
    }

    namespace Threading
    {
        namespace Tasks
        {
            class TaskToApm
            {
                static /*0x756b5f8*/ System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, object state);
                static /*0x756bcb8*/ void End(System.IAsyncResult asyncResult);
                static /*0x3910ae8*/ TResult End<TResult>(System.IAsyncResult asyncResult);
                static /*0x756e4c0*/ void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult);

                class TaskWrapperAsyncResult : System.IAsyncResult
                {
                    /*0x10*/ System.Threading.Tasks.Task Task;
                    /*0x18*/ object _state;
                    /*0x20*/ bool _completedSynchronously;

                    /*0x756e468*/ TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously);
                    /*0x756e5d0*/ object System.IAsyncResult.get_AsyncState();
                    /*0x756e5d8*/ bool System.IAsyncResult.get_CompletedSynchronously();
                    /*0x756e5e0*/ bool System.IAsyncResult.get_IsCompleted();
                    /*0x756e5fc*/ System.Threading.WaitHandle System.IAsyncResult.get_AsyncWaitHandle();
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.AsyncCallback callback;
                    /*0x18*/ System.IAsyncResult asyncResult;

                    /*0x756e5c8*/ <>c__DisplayClass3_0();
                    /*0x756e6a0*/ void <InvokeCallbackWhenTaskCompletes>b__0();
                }
            }
        }
    }
}

namespace Microsoft
{
    namespace Win32
    {
        namespace SafeHandles
        {
            class SafeBrotliEncoderHandle : System.Runtime.InteropServices.SafeHandle
            {
                /*0x756a364*/ SafeBrotliEncoderHandle();
                /*0x756e6c8*/ bool ReleaseHandle();
                /*0x756e6e0*/ bool get_IsInvalid();
            }

            class SafeBrotliDecoderHandle : System.Runtime.InteropServices.SafeHandle
            {
                /*0x756a1c0*/ SafeBrotliDecoderHandle();
                /*0x756e6f0*/ bool ReleaseHandle();
                /*0x756e708*/ bool get_IsInvalid();
            }
        }
    }
}
