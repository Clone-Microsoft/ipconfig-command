using ipconfigtest.MUI;
using System;
using System.Globalization;
using System.Linq;

namespace ipconfigtest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            CultureInfo ci = CultureInfo.InstalledUICulture;

            string dLanguage = ci.DisplayName;
            string enLanguage = ci.EnglishName;
            string tisoLanguage = ci.TwoLetterISOLanguageName;
            string tlisoLanguage = ci.ThreeLetterISOLanguageName;
            Console.WriteLine("* 3-letter Win32 API Name: {0}", ci.ThreeLetterWindowsLanguageName);


            string sysLanguage = ci.Name; //  ro-RO // fr-FR // en-US // ja-JP
            string defLanguage = "EN"; // FR // EN // RO // JP


            string pSuffixeDNS = "";
            string aIPv6 = "2a01:e0a:566:d0a0:5473:97a7:ed91:f44";
            string aIPv6Temp = "2a01:e0a:566:d0a0:4918:bbf1:2e4d:4b82";
            string aIPv6Local = "fe80::5473:97a7:ed91:f44%3";
            string aIPv4 = "192.168.0.13";
            string srMask = "255.255.255.0";
            string aGTW6Default = "fe80::f6ca:e5ff:fe4d:4105%3";
            string aGTW4Default = "192.168.0.254";
            #endregion

            if (args == null)
            {
                /*  Console.WriteLine("\r");
                  Console.WriteLine("Configuration IP de Windows");
                  Console.WriteLine("\r\n");
                  Console.WriteLine("Carte Ethernet Ethernet:");
                  Console.WriteLine("\r\n" +
                  "   Suffixe DNS propre à la connexion. . . : " + pSuffixeDNS + "\n" +
                  "   Adresse IPv6. . . . . . . . . . . . . .: " + aIPv6 + "\n" +
                  "   Adresse IPv6 temporaire . . . . . . . .: " + aIPv6Temp + "\n" +
                  "   Adresse IPv6 de liaison locale. . . . .: " + aIPv6Local + "\n" +
                  "   Adresse IPv4. . . . . . . . . . . . . .: " + aIPv4 + "\n" +
                  "   Masque de sous-réseau. . . . . . . . . : " + srMask + "\n" +
                  "   Passerelle par défaut. . . . . . . . . : " + aGTW6Default + "\n                                       " + aGTW4Default
                  );*/
                /*for (int i = 0; i < args.Length; i++) {
                    Console.WriteLine(Convert.ToString(args[i]));
                }*/
            }  //ipconfigtest
            if (args.Contains("/all"))
            {
                Console.WriteLine("\r");
                Console.WriteLine("Configuration IP de Windows");
                Console.WriteLine("\r" +
                "   Nom de l’hôte . . . . . . . . . . : " + "DESKTOP-1IPI186" + "\n" +
                "   Suffixe DNS principal . . . . . . : " + "" + "\n" +
                "   Type de noeud. . . . . . . . . .  : " + "Hybride" + "\n" +
                "   Routage IP activé . . . . . . . . : " + "Non" + "\n" +
                "   Proxy WINS activé . . . . . . . . : " + "Non" + "\n" +
                "\r");
                Console.WriteLine("Carte Ethernet Ethernet:");
                Console.WriteLine("\r\n" +
                "   Suffixe DNS propre à la connexion. . . : " + "" + "\n" +
                "   Description. . . . . . . . . . . . . . : " + "Realtek PCIe GbE Family Controller" + "\n" +
                "   Adresse physique . . . . . . . . . . . : " + "44 - 8A - 5B - 2B - 74 - 56" + "\n" +
                "   DHCP activé. . . . . . . . . . . . . . : " + "Oui" + "\n" +
                "   Configuration automatique activée. . . : " + "Oui" + "\n" +
                "   Adresse IPv6. . . . . . . . . . . . . .: " + "2a01: e0a:566:d0a0: 5473:97a7: ed91:f44(préféré)" + "\n" +
                "   Adresse IPv6 temporaire . . . . . . . .: " + "2a01: e0a:566:d0a0: 4918:bbf1: 2e4d:4b82(déprécié)" + "\n" +
                "   Adresse IPv6 de liaison locale. . . . .: " + "fe80::5473:97a7: ed91:f44 % 3(préféré)" + "\n" +
                "   Adresse IPv4. . . . . . . . . . . . . .: " + "192.168.0.13(préféré)" + "\n" +
                "   Masque de sous-réseau. . . . . . . . . : " + "255.255.255.0" + "\n" +
                "   Bail obtenu. . . . . . . . . . . . . . : " + "mardi 13 octobre 2020 18:04:26" + "\n" +
                "   Bail expirant. . . . . . . . . . . . . : " + "mercredi 14 octobre 2020 06:04:26" + "\n" +
                "   Passerelle par défaut. . . . . . . . . : " + "fe80::f6ca:e5ff: fe4d:4105 % 3" + "\n" +
                "                                       " + "192.168.0.254" + "\n" +
                "   Serveur DHCP . . . . . . . . . . . . . : " + "192.168.0.254" + "\n" +
                "   IAID DHCPv6 . . . . . . . . . . . : " + "105155163" + "\n" +
                "   DUID de client DHCPv6. . . . . . . . : " + "00 - 01 - 00 - 01 - 26 - 54 - 9E-46 - 44 - 8A - 5B - 2B - 74 - 56" + "\n" +
                "   Serveurs DNS. . .  . . . . . . . . . . : " + "192.168.0.254" + "\n" +
                "   NetBIOS sur Tcpip. . . . . . . . . . . : " + "Activé" + "\n" +
                "\r");

            } // ipconfigtest /all
            if (args.Contains("/allcompartments"))
            {
             
            } // ipconfigtest /allcompartments
            if (args.Contains("/?"))
            {
                if (defLanguage == "FR")
                {
                    Console.WriteLine(StringsFR.FR0x000028AA);
                }
                if (defLanguage == "EN")
                {
                    Console.WriteLine(StringsEN.EN0x000028AA);
                }
                if (defLanguage == "RO")
                {
                    // Console.WriteLine(StringsRO.RO0x000028AA);
                }
                if (defLanguage == "JP")
                {
                    Console.WriteLine(StringsJP.JP0x000028AA);
                }
                else if (defLanguage == "")
                {
                    Console.WriteLine(StringsEN.EN0x000028AA);
                } //Default in EN

                if (args.Contains("/?"))
                {
                }
            }

            if (args.Contains("/release"))
            {
            }
            if (args.Contains("/release6"))
            {
            }
            if (args.Contains("/renew"))
            {
            }
            if (args.Contains("/renew6"))
            {
            }
            if (args.Contains("/flushdns"))
            {
            }
            if (args.Contains("/registerdns"))
            {
            }
            if (args.Contains("/displaydns"))
            {
            }
            if (args.Contains("/showclassid carte"))
            {

                Console.WriteLine("\r");
                Console.WriteLine("Configuration IP de Windows");
                Console.WriteLine("\r\n");
                Console.WriteLine("L’opération a échoué car aucune carte n’a le statut autorisé pour cette opération.");
                                    
            }
            if (args.Contains("/setclassid carte"))
            {
                if (args.Contains(""))
                {
                }
            }
            
            if (args.Contains("/showclassid6 carte"))
            {

                Console.WriteLine("\r");
                Console.WriteLine("Configuration IP de Windows");
                Console.WriteLine("\r\n");
                Console.WriteLine("L’opération a échoué car aucune carte n’a le statut autorisé pour cette opération.");

            }
            if (args.Contains("/setclassid6 carte"))
            {
                if (args.Contains(""))
                {
                }
            }


            //        Console.WriteLine(StringsEN.EN0x00002710);
            //   Console.WriteLine(StringsFR.FR0x00002758, null);

            if (args.Contains("/test"))
            {
                Console.WriteLine(StringsFR.FR0x00002710); //"Configuration IP de Windows
                Console.WriteLine(StringsFR.FR0x00002711, "DESKTOP-1IPI186"); //Nom de l’hôte
                Console.WriteLine(StringsFR.FR0x00002712, ""); //Suffixe DNS principal

                Console.WriteLine(StringsFR.FR0x00002725); //Type de noeud
                                                           // FR0x00002713 //Inconnu
                                                           // FR0x00002714 //Diffusion
                                                           // FR0x00002724 //Mixte
                                                           // FR0x00002725 //Hybride
                                                           // FR0x00002726 //Pair-Pair

                Console.WriteLine(StringsFR.FR0x0000272E); //Routage IP activé
                                                           // FR0x0000272E //non
                                                           // FR0x0000272F //oui

                Console.WriteLine(StringsFR.FR0x00002738); //Proxy WINS activé
                                                           //FR0x00002738 //non
                                                           // FR0x00002739 //oui

                Console.WriteLine(StringsFR.FR0x00002758, null); //Carte Ethernet Ethernet:

               
                Console.WriteLine(StringsFR.FR0x0000277E, null); //Suffixe DNS propre à la connexion
                Console.WriteLine(StringsFR.FR0x0000277F, null); //Description
                Console.WriteLine(StringsFR.FR0x00002780, null); //Adresse physique
                Console.WriteLine(StringsFR.FR0x00002782); //DHCP activé
                                                           //FR0x00002781 //non
                                                           //FR0x00002782 //oui

                Console.WriteLine(StringsFR.FR0x00002782);  //Configuration automatique activée
                                                            //FR0x00002788 //non
                                                            //FR0x00002789 //oui

                Console.WriteLine(StringsFR.FR0x0000296B, aIPv6, null); //Adresse IPv6
                Console.WriteLine(StringsFR.FR0x00002968, aIPv6Temp, null); //Adresse IPv6 temporaire
                Console.WriteLine(StringsFR.FR0x0000296A, aIPv6Local, null); //Adresse IPv6 de liaison locale
                Console.WriteLine(StringsFR.FR0x0000278A, aIPv4, null); //Adresse IPv4
                Console.WriteLine(StringsFR.FR0x0000278C, srMask); //Masque de sous-réseau

                Console.WriteLine(StringsFR.FR0x000027A6, null);//Bail obtenu
                Console.WriteLine(StringsFR.FR0x000027A7, null);//Bail expirant
                Console.WriteLine(StringsFR.FR0x0000278D, aGTW6Default + "\n\r" + aGTW4Default); //Passerelle par défaut
                                                                                                 
                Console.WriteLine(StringsFR.FR0x0000278F, null);//Serveur DHCP
                Console.WriteLine(StringsFR.FR0x00002A31, null); //IAID DHCPv6

                Console.WriteLine(StringsFR.FR0x00002A30, null);  //DUID de client DHCPv6. .

                Console.WriteLine(StringsFR.FR0x00002790, null);  //Serveurs DNS

                Console.WriteLine(StringsFR.FR0x0000279C); //NetBIOS sur Tcpip
                                                           // FR0x0000279C dezactive
                                                           //FR0x0000279D active


                /* Console.WriteLine("\r");
                 Console.WriteLine("Configuration IP de Windows");
                 Console.WriteLine("\r" +
                 "   Nom de l’hôte . . . . . . . . . . : " + "DESKTOP-1IPI186" + "\n" +
                 "   Suffixe DNS principal . . . . . . : " + "" + "\n" +
                 "   Type de noeud. . . . . . . . . .  : " + "Hybride" + "\n" +
                 "   Routage IP activé . . . . . . . . : " + "Non" + "\n" +
                 "   Proxy WINS activé . . . . . . . . : " + "Non" + "\n" +
                 "\r");*/
                //  Console.WriteLine("Carte Ethernet Ethernet:");
                /*   Console.WriteLine("\r\n" +
                   "   Suffixe DNS propre à la connexion. . . : " + "" + "\n" +
                   "   Description. . . . . . . . . . . . . . : " + "Realtek PCIe GbE Family Controller" + "\n" +
                   "   Adresse physique . . . . . . . . . . . : " + "44 - 8A - 5B - 2B - 74 - 56" + "\n" +
                   "   DHCP activé. . . . . . . . . . . . . . : " + "Oui" + "\n" +
                   "   Configuration automatique activée. . . : " + "Oui" + "\n" +
                   "   Adresse IPv6. . . . . . . . . . . . . .: " + "2a01: e0a:566:d0a0: 5473:97a7: ed91:f44(préféré)" + "\n" +
                   "   Adresse IPv6 temporaire . . . . . . . .: " + "2a01: e0a:566:d0a0: 4918:bbf1: 2e4d:4b82(déprécié)" + "\n" +
                   "   Adresse IPv6 de liaison locale. . . . .: " + "fe80::5473:97a7: ed91:f44 % 3(préféré)" + "\n" +
                   "   Adresse IPv4. . . . . . . . . . . . . .: " + "192.168.0.13(préféré)" + "\n" +
                   "   Masque de sous-réseau. . . . . . . . . : " + "255.255.255.0" + "\n" +
                   "   Bail obtenu. . . . . . . . . . . . . . : " + "mardi 13 octobre 2020 18:04:26" + "\n" +
                   "   Bail expirant. . . . . . . . . . . . . : " + "mercredi 14 octobre 2020 06:04:26" + "\n" +
                   "   Passerelle par défaut. . . . . . . . . : " + "fe80::f6ca:e5ff: fe4d:4105 % 3" + "\n" +
                   "                                       " + "192.168.0.254" + "\n" +
                   "   Serveur DHCP . . . . . . . . . . . . . : " + "192.168.0.254" + "\n" +
                   "   IAID DHCPv6 . . . . . . . . . . . : " + "105155163" + "\n" +
                   "   DUID de client DHCPv6. . . . . . . . : " + "00 - 01 - 00 - 01 - 26 - 54 - 9E-46 - 44 - 8A - 5B - 2B - 74 - 56" + "\n" +
                   "   Serveurs DNS. . .  . . . . . . . . . . : " + "192.168.0.254" + "\n" +
                   "   NetBIOS sur Tcpip. . . . . . . . . . . : " + "Activé" + "\n" +
                   "\r");*/
            }


            if (args.Contains("/language info"))
            {

                /*
              * * 3-letter Win32 API Name: ROM
              * Installed Language Info:ro-RO
              * Current UI Language Info: fr-FR
              * Current Language Info: fr-FR
             */
                CultureInfo ci1 = CultureInfo.InstalledUICulture;
                Console.WriteLine("Installed Language Info:{0}", ci1.Name);
                ci1 = CultureInfo.CurrentUICulture;
                Console.WriteLine("Current UI Language Info: {0}", ci1.Name);
                ci1 = CultureInfo.CurrentCulture;
                Console.WriteLine("Current Language Info: {0}", ci1.Name);


              //  CultureInfo ci1 = CultureInfo.InstalledUICulture;
                Console.WriteLine("Default Language Info:");
                Console.WriteLine("* Name: {0}", ci1.Name);
                Console.WriteLine("* Display Name: {0}", ci1.DisplayName);
                Console.WriteLine("* English Name: {0}", ci1.EnglishName);
                Console.WriteLine("* 2-letter ISO Name: {0}", ci1.TwoLetterISOLanguageName);
                Console.WriteLine("* 3-letter ISO Name: {0}", ci1.ThreeLetterISOLanguageName);
                Console.WriteLine("* 3-letter Win32 API Name: {0}", ci1.ThreeLetterWindowsLanguageName);

               
               

            }


            else if (args == null)
            {
                if (defLanguage == "FR")
                {
                    Console.WriteLine(StringsFR.FR0x00002710);
                    Console.WriteLine(StringsFR.FR0x0000277E, pSuffixeDNS);
                    Console.WriteLine(StringsFR.FR0x0000296B, aIPv6, null);
                    Console.WriteLine(StringsFR.FR0x00002968, aIPv6Temp, null);
                    Console.WriteLine(StringsFR.FR0x0000296A, aIPv6Local, null);
                    Console.WriteLine(StringsFR.FR0x0000278A, aIPv4, null);
                    Console.WriteLine(StringsFR.FR0x0000278C, srMask);
                    Console.WriteLine(StringsFR.FR0x0000278D, aGTW6Default + "\n\r" + aGTW4Default);
                }
               else if (defLanguage == "EN")
                {
                    Console.WriteLine(StringsEN.EN0x00002710);
                    Console.WriteLine(StringsEN.EN0x0000277E, pSuffixeDNS);
                    Console.WriteLine(StringsEN.EN0x0000296B, aIPv6, null);
                    Console.WriteLine(StringsEN.EN0x00002968, aIPv6Temp, null);
                    Console.WriteLine(StringsEN.EN0x0000296A, aIPv6Local, null);
                    Console.WriteLine(StringsEN.EN0x0000278A, aIPv4, null);
                    Console.WriteLine(StringsEN.EN0x0000278C, srMask);
                    Console.WriteLine(StringsEN.EN0x0000278D, aGTW6Default + "\n\r" + aGTW4Default);
                }
                else
                {
                    Console.WriteLine(StringsEN.EN0x00002710);
                    Console.WriteLine(StringsEN.EN0x0000277E, pSuffixeDNS);
                    Console.WriteLine(StringsEN.EN0x0000296B, aIPv6, null);
                    Console.WriteLine(StringsEN.EN0x00002968, aIPv6Temp, null);
                    Console.WriteLine(StringsEN.EN0x0000296A, aIPv6Local, null);
                    Console.WriteLine(StringsEN.EN0x0000278A, aIPv4, null);
                    Console.WriteLine(StringsEN.EN0x0000278C, srMask);
                    Console.WriteLine(StringsEN.EN0x0000278D, aGTW6Default + "\n\r" + aGTW4Default);
                } //Default in EN

            }
        }
    }
}
