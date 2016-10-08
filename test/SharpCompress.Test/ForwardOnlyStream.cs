﻿using System;
using System.IO;

namespace SharpCompress.Test
{
    public class ForwardOnlyStream : Stream
    {
        private readonly Stream stream;

        public bool IsDisposed { get; private set; }

        public ForwardOnlyStream(Stream stream)
        {
            this.stream = stream;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            stream.Dispose();
            IsDisposed = true;
        }

        public override bool CanRead => true;

        public override bool CanSeek => false;
        public override bool CanWrite => false;

        public override void Flush()
        {
            throw new NotSupportedException();
        }

        public override long Length
        {
            get { throw new NotSupportedException(); }
        }

        public override long Position
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {throw new NotSupportedException();
        }
    }
}