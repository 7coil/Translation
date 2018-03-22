using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Finnish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Botti tarvitsee oikeuden \" Embed Links \"",
                AdminOnly = "Et ole palvelimen yll�pidossa",
                PlayerNotFound = "Pelaajaa {0} ei l�ydetty",
                ApiError = "API Virhe",
                EnterIP = "Sy�t� IP-osoite",
                InvalidIP = "Virheellinen IP-osoite",
                Cooldown = "Olet j��hyll� 1min!",
                EnableQuery = "Minecraft serverill� ei ole enable-query asetettu server.properties",
                ListNoServers = "This community has no servers listed",
                UnknownArg = "Tuntematon Argumentti do",
                TextLimit = "Teksti ei voi olla pidempi kuin 22 kirjaimia/numeroita",
                RequireAttachFiles = "Botti vaatii attach files Oikeuden",
                UnknownWiki = "Tuntematon wiki kohta"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Botin info ja status",
                Quiz = "Minecraft Kysely",
                Color = "Minecraft v�rikoodit",
                NameHistory = "nimihistoria",
                UserProfile = "Discord k�ytt�j� profiili",
                Ping = "Pinggaa minecraft serveri",
                Version = "Minecraft version tiedot",
                Rcon = "Hallitse Serverisi konsolia et��t�",
                Achievement = "Saa palkinto",
                Playing = "Pelaamassa minecraftia",
                List = "Palvelimeen lis�tyt minecraft serverit",
                Admin = "Palvelimen admin komennot",
                Invite = "Lis�� botti palvelimellesi"
            },

            Main = new TMain
            {
                HelpFooter = "Tuolla on salaisiakin komentoja ;)",
                MultiMC = "MultiMC antaa sinun hallita ja k�ynnist�� monia versioita helposti forge/mods Asennukseen",
                PleaseWait = "Odota kun pinggaan",
                ServerAdminUse = "Server admin should use",
                StoleSkin = "Varasta skin",
                NameOnlyOne = "Pelaajalle {0} on vain 1 nimi historiassa",
                PlayingMinecraft = "Pelaajia pelaamassa minecraftia",
                Hi = "Hei",
                BotDesc = "Jos sinulla on jotain ongelmia, ehdoituksia tai kieli k��nn�ksi� ota yheteytt� minuun",
                First = "eka"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hei, l�ysit salaisen komennon :D",
                Herobrine = "Aina katsomassa sinua...",
                Notch = "Minecraftin teki Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Palikat",
                Unknown = "Tuntematon",
                Player = "Pelaaja",
                Players = "Pelaajat",
                Attack = "Hy�kk�ys",
                Easy = "Helppo",
                Hard = "Vaikea",
                Health = "El�m�",
                Height = "Korkeus",
                Width = "Leveys"
            },

            Profile = new TProfile
            {
                Badges = "Kunniamerkit",
                BadgeInfo = "Kunniamerkkien tiedot",
                InvalidUserID = "Virheellinen k�ytt�j�n id",
                UnknownUser = "Pelaajaa ei l�ydetty",
                NotInServer = "Et ole serverill�!",
                SetMCName = " asettaa Minecraft k�ytt�j�n"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Luo rooli vahvistetuille j�senille",
                AutoPost = "Julkaise automaattisesti palvelimen tilastoja",
                AddServer = "Lis�� serveri yhteis�n listalle",
                RemoveServer = "Poista serveri yhteis�n listalta",              
				SetPrefix = "Muuta botin prefixi�",
                ResetPrefix = "Poista muutettu prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Haluatko k��nt�� bottia jollekin kielelle? Ota yheteytt�",
                ChangeLang = "Vaihda kieli joksikin",
                UseList = "Tee mc/list ett� n��t listan minecraft servereist� jotka on palvelimelle lis�tty",
                AddServer = "Sy�t� Merkki, ip ja nimi",
                AddServerAdded = "Lis�tty serveri {0} Palvelimen listalle",
                AddServerAlready = "Serveri on lis�tty jo listaan!",
                DelServerEnter = "Poista serveri",
                DelServerNone = "This server is not on the list",
                DelServerDeleted = "Serveri {0} poistettu palvelimen listalta",
                PrefixReset = "Palvelimen prefixin palautus mc/",
                LanguageSet = "Palvelimen kieli muutettu"
            }
        };
    }
}
