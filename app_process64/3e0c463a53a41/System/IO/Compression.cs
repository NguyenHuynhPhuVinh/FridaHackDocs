class <Module>
{
}

class Interop
{
    class Brotli
    {
        static /*0x7552d04*/ Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle BrotliDecoderCreateInstance(nint allocFunc, nint freeFunc, nint opaque);
        static /*0x7552da0*/ int BrotliDecoderDecompressStream(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state, ref nint availableIn, byte** nextIn, ref nint availableOut, byte** nextOut, ref nint totalOut);
        static /*0x7552e3c*/ void BrotliDecoderDestroyInstance(nint state);
        static /*0x7552e40*/ bool BrotliDecoderIsFinished(Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle state);
        static /*0x7552ea8*/ Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle BrotliEncoderCreateInstance(nint allocFunc, nint freeFunc, nint opaque);
        static /*0x7552f44*/ bool BrotliEncoderCompressStream(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state, System.IO.Compression.BrotliEncoderOperation op, ref nint availableIn, byte** nextIn, ref nint availableOut, byte** nextOut, ref nint totalOut);
        static /*0x7552ff4*/ bool BrotliEncoderHasMoreOutput(Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle state);
        static /*0x755305c*/ void BrotliEncoderDestroyInstance(nint state);
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

                static /*0x75536d8*/ void ValidateParameters(byte[] array, int offset, int count);
                static /*0x7553980*/ void ThrowInvalidBeginCall();
                /*0x7553060*/ BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x7553258*/ void EnsureNotDisposed();
                /*0x75532d0*/ void Dispose(bool disposing);
                /*0x75537ec*/ bool get_CanRead();
                /*0x7553810*/ bool get_CanWrite();
                /*0x7553838*/ bool get_CanSeek();
                /*0x7553840*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x7553878*/ long get_Length();
                /*0x75538b0*/ long get_Position();
                /*0x75538e8*/ void set_Position(long value);
                /*0x7553920*/ void SetLength(long value);
                /*0x7553958*/ bool get_AsyncOperationIsActive();
                /*0x7553968*/ void EnsureNoActiveAsyncOperation();
                /*0x75539cc*/ void AsyncOperationStarting();
                /*0x75539f4*/ void AsyncOperationCompleting();
                /*0x7553a08*/ int Read(byte[] buffer, int offset, int count);
                /*0x7553abc*/ int Read(System.Span<byte> buffer);
                /*0x7554118*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x75542bc*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x7554304*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7554414*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x755459c*/ System.Threading.Tasks.ValueTask<int> FinishReadAsyncMemory(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x755470c*/ void Write(byte[] buffer, int offset, int count);
                /*0x75547b8*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x7553478*/ void WriteCore(System.ReadOnlySpan<byte> buffer, bool isFinalBlock);
                /*0x75547d0*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x7554880*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x7554978*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x7554a98*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x7554c10*/ System.Threading.Tasks.Task WriteAsyncMemoryCore(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x7554d30*/ void Flush();
                /*0x7554f7c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x755509c*/ System.Threading.Tasks.Task FlushAsyncCore(System.Threading.CancellationToken cancellationToken);

                struct <FinishReadAsyncMemory>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder;
                    /*0x38*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Memory<byte> buffer;
                    /*0x58*/ int <totalWritten>5__2;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

                    /*0x7555198*/ void MoveNext();
                    /*0x7555a1c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x7555a74*/ void MoveNext();
                    /*0x7556288*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <FlushAsyncCore>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.IO.Compression.BrotliStream <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Buffers.OperationStatus <lastResult>5__2;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;

                    /*0x75562f0*/ void MoveNext();
                    /*0x7556a94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct BrotliDecoder : System.IDisposable
            {
                /*0x10*/ Microsoft.Win32.SafeHandles.SafeBrotliDecoderHandle _state;
                /*0x18*/ bool _disposed;

                /*0x7556afc*/ void InitializeDecoder();
                /*0x7556b90*/ void EnsureInitialized();
                /*0x7556c30*/ void Dispose();
                /*0x7556bb8*/ void EnsureNotDisposed();
                /*0x7553e7c*/ System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten);
            }

            struct BrotliEncoder : System.IDisposable
            {
                /*0x10*/ Microsoft.Win32.SafeHandles.SafeBrotliEncoderHandle _state;
                /*0x18*/ bool _disposed;

                /*0x7556c50*/ void InitializeEncoder();
                /*0x7556d60*/ void EnsureInitialized();
                /*0x7556d88*/ void Dispose();
                /*0x7556ce8*/ void EnsureNotDisposed();
                /*0x7556a14*/ System.Buffers.OperationStatus Flush(System.Memory<byte> destination, ref int bytesWritten);
                /*0x7554ee0*/ System.Buffers.OperationStatus Flush(System.Span<byte> destination, ref int bytesWritten);
                /*0x75561b8*/ System.Buffers.OperationStatus Compress(System.ReadOnlyMemory<byte> source, System.Memory<byte> destination, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock);
                /*0x75547c0*/ System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock);
                /*0x7556da8*/ System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, ref int bytesConsumed, ref int bytesWritten, System.IO.Compression.BrotliEncoderOperation operation);
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
                static /*0x75541c8*/ System.IAsyncResult Begin(System.Threading.Tasks.Task task, System.AsyncCallback callback, object state);
                static /*0x7554888*/ void End(System.IAsyncResult asyncResult);
                static /*0x3907c14*/ TResult End<TResult>(System.IAsyncResult asyncResult);
                static /*0x7557090*/ void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult);

                class TaskWrapperAsyncResult : System.IAsyncResult
                {
                    /*0x10*/ System.Threading.Tasks.Task Task;
                    /*0x18*/ object _state;
                    /*0x20*/ bool _completedSynchronously;

                    /*0x7557038*/ TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously);
                    /*0x75571a0*/ object System.IAsyncResult.get_AsyncState();
                    /*0x75571a8*/ bool System.IAsyncResult.get_CompletedSynchronously();
                    /*0x75571b0*/ bool System.IAsyncResult.get_IsCompleted();
                    /*0x75571cc*/ System.Threading.WaitHandle System.IAsyncResult.get_AsyncWaitHandle();
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ System.AsyncCallback callback;
                    /*0x18*/ System.IAsyncResult asyncResult;

                    /*0x7557198*/ <>c__DisplayClass3_0();
                    /*0x7557270*/ void <InvokeCallbackWhenTaskCompletes>b__0();
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
                /*0x7552f34*/ SafeBrotliEncoderHandle();
                /*0x7557298*/ bool ReleaseHandle();
                /*0x75572b0*/ bool get_IsInvalid();
            }

            class SafeBrotliDecoderHandle : System.Runtime.InteropServices.SafeHandle
            {
                /*0x7552d90*/ SafeBrotliDecoderHandle();
                /*0x75572c0*/ bool ReleaseHandle();
                /*0x75572d8*/ bool get_IsInvalid();
            }
        }
    }
}
