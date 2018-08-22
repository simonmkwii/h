using System;
using System.Text;
using System.Net;

namespace h
{
    class h
    {
        static void H(string h_url, string h_content, string h_token)
        {
            try
            {
                var h = WebRequest.Create(h_url);

                h.Method = "POST";
                h.ContentType = "application/json";
                h.Headers.Add("authorization", h_token);
                h.GetRequestStream().Write(Encoding.ASCII.GetBytes(h_content), 0, h_content.Length);
                h.GetResponse();
                h.Abort();

                Console.WriteLine("h");
            }
            catch (Exception)
            {
                Console.WriteLine("oof rate limited");
            }
        }

        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                while (true)
                {
                    H
                        (
                        "https://discordapp.com/api/v6/channels/322148780080103435/messages",
                        "{\"content\":\"h\"}",
                        args[0]
                        );
                }
            }
            else
            {
                Console.WriteLine("h: h.exe <token>");
            }
        }
    }
}
