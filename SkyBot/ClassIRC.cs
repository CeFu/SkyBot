using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace SkyBot
{
    class ClassIRC
    {
        TcpClient Client;
        NetworkStream Stream;
        StreamReader Reader;
        StreamWriter Writer;

        Thread IRCListener;

        public ClassIRC()
        {
            Client = new TcpClient("", 6667);
            Stream = Client.GetStream();
            Reader = new StreamReader(Stream, Encoding.GetEncoding("iso8859-1"));
            Writer = new StreamWriter(Stream, Encoding.GetEncoding("iso8859-1"));

            IRCListener = new Thread(new ThreadStart(Listen));
            IRCListener.Start();
        }

        public void Listen()
        {

        }
    }
}
