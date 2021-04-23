using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace AppKiosco.Controllers
{
    class WebService
    {
        private static string WS_TOKEN = "f1f5516b3507d94af48a701cdf8bcd59";
        private static string WS_GET_BALANCE = "https://api.xenterglobal.com:2053/account_balance?token=" + WS_TOKEN + "&account=";
        private static string WS_POST_TRANSACTION = "https://api.xenterglobal.com:2053/transaction?token=" + WS_TOKEN;

        public static string GetBalance(string account) {
            try{
                HttpWebRequest request = WebRequest.Create(WS_GET_BALANCE + account) as HttpWebRequest;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                WebHeaderCollection header = response.Headers;
                StreamReader reader = new StreamReader(response.GetResponseStream(), ASCIIEncoding.ASCII);
                string resp = reader.ReadToEnd();
                return resp;
            }catch(Exception e){
                return "";
            }
        }

        public static string PostTransaction(string account, float paid) {
            try {
                JObject obj = new JObject();
                obj.Add("account", account);
                obj.Add("paid", paid);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(WS_POST_TRANSACTION);
                request.Method = "POST";
                string postData = obj.ToString();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] bytes = encoding.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = bytes.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                var streamReader = new StreamReader(response.GetResponseStream());
                string resp = streamReader.ReadToEnd();

                if (resp.Contains("user") && resp.Contains("debt")){
                    return "OK";
                }else {
                    return "";
                }
            } catch (Exception e) {
                return "";
            }
        }
    }
}
