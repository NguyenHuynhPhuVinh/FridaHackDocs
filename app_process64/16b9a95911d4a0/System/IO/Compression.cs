class <Module>
{
}

class Interop
{
    class Brotli
    {
        static /*0x37db048*/ Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(nint allocFunc, nint freeFunc, nint opaque);
        static /*0x37db0e4*/ int BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, ref nint availableIn, byte** nextIn, ref nint availableOut, byte** nextOut, ref nint totalOut);
        static /*0x37db180*/ void BrotliDecoderDestroyInstance(nint state);
        static /*0x37db184*/ bool BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state);
        static /*0x37db1ec*/ Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(nint allocFunc, nint freeFunc, nint opaque);
        static /*0x37db288*/ bool BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, ref nint availableIn, byte** nextIn, ref nint availableOut, byte** nextOut, ref nint totalOut);
        static /*0x37db338*/ bool BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state);
        static /*0x37db3a0*/ void BrotliEncoderDestroyInstance(nint state);
    }
}

namespace System
{
    namespace Threading
    {
        namespace Tasks
        {
            class TaskToApm
            {
                static /*0x37db3a4*/ System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, object state);
                static /*0x37db5f0*/ void End(System.IAsyncResult asyncResult);
                static /*0x1ffc854*/ TResult End<TResult>(System.IAsyncResult asyncResult);
                static /*0x37db4e8*/ void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult);

                class TaskWrapperAsyncResult : System.IAsyncResult
                {
                    /*0x10*/ System.Threading.Tasks.Task Task;
                    /*0x18*/ object _state;
                    /*0x20*/ bool _completedSynchronously;

                    /*0x37db490*/ TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously);
                    /*0x37db6e4*/ object System.IAsyncResult.get_AsyncState();
                    /*0x37db6ec*/ bool System.IAsyncResult.get_CompletedSynchronously();
                    /*0x37db6f4*/ bool System.IAsyncResult.get_IsCompleted();
                    /*0x37db70c*/ System.Threading.WaitHandle System.IAsyncResult.get_AsyncWaitHandle();
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.AsyncCallback callback;
                    /*0x18*/ System.IAsyncResult asyncResult;

                    /*0x37db6dc*/ <>c__DisplayClass3_0();
                    /*0x37db7b0*/ void <InvokeCallbackWhenTaskCompletes>b__0();
                }
            }
        }
    }

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

                static /*0x37dbe78*/ void ValidateParameters(byte[] array, int offset, int count);
                static /*0x37dc11c*/ void ThrowInvalidBeginCall();
                /*0x37db7d4*/ BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x37db9cc*/ void EnsureNotDisposed();
                /*0x37dba3c*/ void Dispose(bool disposing);
                /*0x37dbf8c*/ bool get_CanRead();
                /*0x37dbfb0*/ bool get_CanWrite();
                /*0x37dbfd8*/ bool get_CanSeek();
                /*0x37dbfe0*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x37dc018*/ long get_Length();
                /*0x37dc050*/ long get_Position();
                /*0x37dc088*/ void set_Position(long value);
                /*0x37dc0c0*/ void SetLength(long value);
                /*0x37dc0f8*/ bool get_AsyncOperationIsActive();
                /*0x37dc108*/ void EnsureNoActiveAsyncOperation();
                /*0x37dc168*/ void AsyncOperationStarting();
                /*0x37dc190*/ void AsyncOperationCompleting();
                /*0x37dc1a4*/ int Read(byte[] buffer, int offset, int count);
                /*0x37dc24c*/ int Read(System.Span<byte> buffer);
                /*0x37dc8ec*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x37dc99c*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x37dc9f8*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x37dcadc*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x37dcc48*/ System.Threading.Tasks.ValueTask<int> FinishReadAsyncMemory(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x37dcd70*/ void Write(byte[] buffer, int offset, int count);
                /*0x37dce4c*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x37dbbbc*/ void WriteCore(System.ReadOnlySpan<byte> buffer, bool isFinalBlock);
                /*0x37dce64*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x37dcf14*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x37dcf1c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x37dd03c*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x37dd1b4*/ System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x37dd2d0*/ void Flush();
                /*0x37dd554*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x37dd674*/ System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken);

                struct <FinishReadAsyncMemory>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder;
                    /*0x38*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Memory<byte> buffer;
                    /*0x58*/ int <totalWritten>5__2;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

                    /*0x37dd76c*/ void MoveNext();
                    /*0x37ddfdc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x37de034*/ void MoveNext();
                    /*0x37de67c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <FlushAsyncCore>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Buffers.OperationStatus <lastResult>5__2;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;

                    /*0x37de6e4*/ void MoveNext();
                    /*0x37decd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct BrotliDecoder : System.IDisposable
            {
                /*0x10*/ Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle _state;
                /*0x18*/ bool _disposed;

                /*0x37ded40*/ void InitializeDecoder();
                /*0x37dedd4*/ void EnsureInitialized();
                /*0x37dee6c*/ void Dispose();
                /*0x37dedfc*/ void EnsureNotDisposed();
                /*0x37dc5f0*/ System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten);
            }

            struct BrotliEncoder : System.IDisposable
            {
                /*0x10*/ Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle _state;
                /*0x18*/ bool _disposed;

                /*0x37dee8c*/ void InitializeEncoder();
                /*0x37def94*/ void EnsureInitialized();
                /*0x37defbc*/ void Dispose();
                /*0x37def24*/ void EnsureNotDisposed();
                /*0x37dec58*/ System.Buffers.OperationStatus Flush(System.Memory<byte> destination, ref int bytesWritten);
                /*0x37dd4b8*/ System.Buffers.OperationStatus Flush(System.Span<byte> destination, ref int bytesWritten);
                /*0x37de5ac*/ System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<byte> source, System.Memory<byte> destination, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock);
                /*0x37dce54*/ System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock);
                /*0x37defdc*/ System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten, System.IO.Compression.BrotliEncoderOperation operation);
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
}

namespace Microsoft
{
    namespace Win32
    {
        namespace SafeHandles
        {
            class SafeBrotliEncoderHandle : System.Runtime.InteropServices.SafeHandle
            {
                /*0x37db278*/ SafeBrotliEncoderHandle();
                /*0x37df2d0*/ bool ReleaseHandle();
                /*0x37df2e8*/ bool get_IsInvalid();
            }

            class SafeBrotliDecoderHandle : System.Runtime.InteropServices.SafeHandle
            {
                /*0x37db0d4*/ SafeBrotliDecoderHandle();
                /*0x37df2f8*/ bool ReleaseHandle();
                /*0x37df310*/ bool get_IsInvalid();
            }
        }
    }
}
