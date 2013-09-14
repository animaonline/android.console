using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Animaonline.Utils
{
    public class ConsoleInputCapture
    {
        /// <summary>
        /// Will trigger the provided callbacks when Console's Input stream requires it.
        /// </summary>
        public static void Start(Func<string> readLine, Func<int> read)
        {
            if (_originalCinHandler == null)
                _originalCinHandler = Console.In;

            var cinHandler = new ConsoleInputHandler(readLine, read);

            Console.SetIn(cinHandler);
        }

        static TextReader _originalCinHandler;

        public static void Stop()
        {
            Console.SetIn(_originalCinHandler);
        }

        private class ConsoleInputHandler : TextReader
        {
            readonly Func<string> _readLine;
            readonly Func<int> _read;

            public ConsoleInputHandler(Func<string> readLine = null, Func<int> read = null)
            {
                _readLine = readLine;
                _read = read;
            }

            public override int Read(char[] buffer, int index, int count)
            {
                return base.Read(buffer, index, count);
            }

            public override int Read()
            {
                return _read != null ? _read() : base.Read();
            }

            public override string ReadLine()
            {
                return _readLine != null ? _readLine() : base.ReadLine();
            }
        }
    }
}
