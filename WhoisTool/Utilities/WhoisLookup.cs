using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace WhoisTool.Utilities
{
    public struct WhoisLookup
    {
        private readonly static string[,] whoisServer = load();

        public static (string, string) Lookup(string url)
        {
            return resultParse(
                getResponseWhoisServer(
                    getWhoisServer(
                        url.Substring(url.LastIndexOf(".") + 1)
                        )
                        , url
                    )
                );
        }

        private static string getResponseWhoisServer(string whoisServer, string domain)
        {
            using (var tcpClient = new TcpClient())
            {
                tcpClient.Connect(whoisServer, 43);
                domain += "\n";
                byte[] bytes = Encoding.UTF8.GetBytes(domain);
                using (var stream = tcpClient.GetStream())
                using (var sr = new StreamReader(tcpClient.GetStream(), Encoding.UTF8))
                {
                    stream.Write(bytes, 0, domain.Length);
                    stream.Flush();
                    return sr.ReadToEnd();
                }
            }
        }

        private static (string, string) resultParse(string result)
        {
            string c = Regex.Split(Regex.Split(result, "Creation Date: ")[1], "T")[0];
            string e = Regex.Split(Regex.Split(result, "Registry Expiry Date: ")[1], "T")[0];
            return (c, e);
        }

        private static string getWhoisServer(string tld)
        {
            int length = whoisServer.Length / 2;
            for (int i = 0; i < length; i++)
                if (whoisServer[i, 0] == tld)
                    return whoisServer[i, 1];
            return null;
        }

        private static string[,] load()
        {
            return new string[143, 2] {
                { "com", "whois.verisign-grs.com" },
                { "net", "whois.verisign-grs.com" },
                { "org","whois.publicinterestregistry.net" },
                { "info","whois.afilias.info" },
                { "biz","whois.neulevel.biz" },
                { "us","whois.nic.us" },
                { "uk","whois.nic.uk" },
                { "ca","whois.cira.ca" },
                { "tel","whois.nic.tel" },
                { "ie","whois.iedr.ie"},
                { "it","whois.nic.it" },
                { "li","whois.nic.li" },
                { "no","whois.norid.no" },
                { "cc","whois.nic.cc" },
                { "eu","whois.eu" },
                { "nu","whois.nic.nu" },
                { "au","whois.aunic.net" },
                { "de","whois.nic.de" },
                { "ws","whois.nic.ws" },
                { "sc","whois2.afilias-grs.net" },
                { "mobi","whois.dotmobiregistry.net" },
                { "pro","whois.registry.pro" },
                { "edu","whois.educause.net" },
                { "tv","whois.nic.tv" },
                { "travel","whois.nic.travel" },
                { "name", "whois.nic.name" },
                { "in", "whois.registry.in"},
                { "me","whois.nic.me" },
                { "at","whois.nic.at" },
                { "be","whois.dns.be" },
                { "cn","whois.cnnic.cn" },
                { "asia","whois.nic.asia" },
                { "ru","whois.ripn.ru" },
                { "ro","whois.rotld.ro"},
                { "aero","whois.aero" },
                { "fr","whois.nic.fr" },
                { "se","whois.nic.se" },
                { "nl","whois.sidn.nl" },
                { "nz","whois.srs.net.nz" },
                { "mx","whois.nic.mx" },
                { "tw","whois.apnic.net" },
                { "ch","whois.nic.ch" },
                { "hk","whois.hknic.net.hk" },
                { "ac","whois.nic.ac" },
                { "ae","whois.nic.ae" },
                { "af","whois.nic.af" },
                { "ag","whois.nic.ag" },
                { "al","whois.ripe.net" },
                { "am","whois.amnic.net" },
                { "as","whois.nic.as" },
                { "az","whois.ripe.net" },
                { "ba","whois.ripe.net" },
                { "bg","whois.register.bg" },
                { "bi","whois.nic.bi" },
                { "bj","www.nic.bj" },
                { "br","whois.nic.br" },
                { "bt","whois.netnames.net" },
                { "by","whois.ripe.net" },
                { "bz","whois.belizenic.bz" },
                { "cd","whois.nic.cd" },
                { "ck","whois.nic.ck" },
                { "co","whois.nic.co" },
                { "cl","nic.cl" },
                { "coop","whois.nic.coop" },
                { "cx","whois.nic.cx" },
                { "cy","whois.ripe.net" },
                { "cz","whois.nic.cz" },
                { "dk","whois.dk-hostmaster.dk" },
                { "dm","whois.nic.cx" },
                { "dz","whois.ripe.net" },
                { "ee","whois.eenet.ee" },
                { "eg","whois.ripe.net" },
                { "es","whois.nic.es" },
                { "fi","whois.ficora.fi" },
                { "fo","whois.ripe.net" },
                { "gb","whois.ripe.net" },
                { "ge", "whois.ripe.net" },
                { "gl", "whois.ripe.net" },
                { "gm","whois.ripe.net" },
                { "gov","whois.nic.gov" },
                { "gr","whois.ripe.net" },
                { "gs","whois.adamsnames.tc" },
                { "hm","whois.registry.hm" },
                { "hn","whois2.afilias-grs.net" },
                { "hr","whois.ripe.net" },
                { "hu","whois.ripe.net" },
                { "il","whois.isoc.org.il" },
                { "int","whois.isi.edu" },
                { "ig","vrx.net" },
                { "ir","whois.nic.ir" },
                { "is","whois.isnic.is" },
                { "je","whois.je" },
                { "jp","whois.jprs.jp" },
                { "kg","whois.domain.kg" },
                { "kr","whois.nic.or.kr" },
                { "la","whois2.afilias-grs.net" },
                { "lt","whois.domreg.lt" },
                { "lu","whois.restena.lu" },
                { "lv","whois.nic.lv" },
                { "ly","whois.lydomains.com" },
                { "ma","whois.iam.net.ma" },
                { "mc","whois.ripe.net" },
                { "md","whois.nic.md" },
                { "mil","whois.nic.mil" },
                { "mk","whois.ripe.net" },
                { "ms","whois.nic.ms" },
                { "mt","whois.ripe.net" },
                { "mu","whois.nic.mu" },
                { "my","whois.mynic.net.my" },
                { "nf","whois.nic.cx" },
                { "pl","whois.dns.pl" },
                { "pr","whois.nic.pr" },
                { "pt","whois.dns.pt" },
                { "sa","saudinic.net.sa" },
                { "sb","whois.nic.net.sb" },
                { "sg","whois.nic.net.sg" },
                { "sh","whois.nic.sh"},
                { "si","whois.arnes.si" },
                { "sk","whois.sk-nic.sk" },
                { "sm","whois.ripe.net" },
                { "st","whois.nic.st" },
                { "su","whois.ripn.net" },
                { "tc","whois.adamsnames.tc" },
                { "tf","whois.nic.tf" },
                { "th","whois.thnic.net" },
                { "tj","whois.nic.tj" },
                { "tk","whois.nic.tk" },
                { "tl", "whois.domains.tl" },
                { "tm","whois.nic.tm" },
                { "tn","whois.ripe.net" },
                { "to","whois.tonic.to" },
                { "tp","whois.domains.tl" },
                { "tr","whois.nic.tr" },
                { "ua","whois.ripe.net" },
                { "uy","nic.uy" },
                { "uz","whois.cctld.uz" },
                { "va","whois.ripe.net" },
                { "vc","whois2.afilias-grs.net"},
                { "ve","whois.nic.ve"},
                { "vg","whois.adamsnames.tc"},
                { "yu","whois.ripe.net" },
                { "science","whois.iana.org" },
                { "xyz", "whois.nic.xyz" }
            };
        }
    }
}
