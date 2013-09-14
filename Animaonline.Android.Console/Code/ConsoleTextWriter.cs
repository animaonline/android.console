using System;
using System.IO;
using System.Text;

namespace Animaonline.Utils
{
    public class ConsoleTextWriter : TextWriter
    {
        #region Public Constructor

        public ConsoleTextWriter(TextWriter wrap, Action<string> onWrite, Action<string> onWriteLine)
        {
            _writer = wrap;
            _buffer = new StringBuilder();

            this._onWrite = onWrite;
            this._onWriteLine = onWriteLine;
        }

        #endregion

        #region Private Fields

        private readonly TextWriter _writer;
        private readonly StringBuilder _buffer;
        private readonly Action<string> _onWrite;
        private readonly Action<string> _onWriteLine;

        #endregion

        #region Overridden Methods

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }

        public override void Write(string value)
        {
            _writer.Write(value);
            _buffer.Append(value);

            if (_onWrite != null)
                _onWrite(value);
        }

        public override void WriteLine(string value)
        {
            _writer.WriteLine(value);
            _buffer.AppendLine(value);

            if (_onWriteLine != null)
                _onWriteLine(value);
        }

        public override void WriteLine()
        {
            _writer.WriteLine();
            _buffer.AppendLine();

            if (_onWriteLine != null)
                _onWriteLine(null);
        }

        #endregion

        #region Public Properties

        public string Buffer
        {
            get
            {
                return _buffer.ToString();
            }
        }

        #endregion
    }
}