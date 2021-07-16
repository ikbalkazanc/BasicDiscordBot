using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ConsoleApp7
{
    public static class Variables
    {
        public static CacheKeys CacheKey = new CacheKeys();
        public static BotMessages BotMessage = new BotMessages();

        public static ulong[] TargetIds =
        {
            729166821302861905, //sakat
            1, //kürt
        };

        public static string DefaultGuild = "genel";

        public static Dictionary<List<string>, List<string>> Responses = Response.CreateResponses();
        public static List<string> BadWords = BadWord.CreateBadWords();
    }

    public class CacheKeys
    {
        public string IdentityRequestKey = "identity-requested-list";
    }

    public class BotMessages
    {
        //identity request messages
        public string[] IdentityRequestMessages =
        {
            "<@{0}> Hop kardeşim nereye kimlik göster.",
            "<@{0}> Hoob kmlikler çıkra göstree",
            "<@{0}> Kimliğinizi alabilirmiyim",
            "<@{0}> Dostum kimliğini verirmisin?",
            "<@{0}> Kardeşim kimliğini alabilirmiyim?",
            "<@{0}> Bir bakarmısın dostum? Kimliğini alabilirmiyiz?",
            "<@{0}> Yat yere YAT YAT!! Kimlikleri çıkra çıkra!",
        };

        public string[] IdentityRequestMessagesForSakat =
        {
            "<@{0}> sakat request",
        };

        public string[] IdentityRequestMessagesForKurd =
        {
            "<@{0}>  kürt"
        };

        //did i request your idendtity messages

        public string[] DidIRequestYourIdentity =
        {
            "<@{0}> Ben sana sordum mu amk malı.",
            "<@{0}> Tatava yapma uza.",
            "<@{0}> Kel başa şimşir tarak bu ayakları artık bırak.",
            "<@{0}> Groovy kadar beyin yok sende.",
            "<@{0}> Meşgul etme kardeşm devletin fedaisini."
        };

        public string[] DidIRequestYourIdentityForSakat =
        {
            "<@{0}> sakat did"
        };

        public string[] DidIRequestYourIdentityForKurd =
        {
            "<@{0}> kürd idd"
        };

        //okay u can go away messages
        public string[] OkayYouCanGoAway =
        {
            "<@{0}> Tmam hadi uza",
            "<@{0}> Tamm dostum gidebilirsin",
            "<@{0}> Eve git gezme bu saatte burda kardeşim",
            "<@{0}> tm kardeşm",
            "<@{0}> Kayserinin neresinden",
            "<@{0}> devam et.",
            "<@{0}> Şidi ben bnu merkze göderiyorum orda incliyolar",
        };

        public string[] OkayYouCanGoAwayForSakat =
        {
            "<@{0}> sakat go awy",
        };

        public string[] OkayYouCanGoAwayForKurd =
        {
            "<@{0}> kürt go awy",
        };

        //Others

        public string[] BadWordResponse =
        {
            "<@{0}> Sikerim belanı he yavşak",
            "<@{0}> oi! oi! oi!",
            "<@{0}> {1} ne mk??",
            "<@{0}> Ağzını topla",
            "<@{0}> Hop!",
            "<@{0}> Ağzını topla puşt",
            "<@{0}> skmcem belanı şimdi",
            "<@{0}> savcılığa verildiniz gg"
        };

        public string[] ReuqestWarning =
        {
            "<@{0}> versene it",
            "<@{0}> Aloooo!!!",
            "<@{0}> Bu sana son uyarım ver şunu",
            "<@{0}> skcm ama versene aq",
            "<@{0}> geçmiş olsun kardeşim silivri yolu gözüktü",
            "<@{0}> işim var dostum verirmisin artık",
            "<@{0}> can sıktın artık ver şunu",
            "<@{0}> ikorlütistan dan banlanmak istemiyosan kimlik at",
            "<@{0}> Ooo Hadi kardeşim",
        };
    }

    public static class Response
    {
        public static Dictionary<List<string>, List<string>> CreateResponses()
        {
            var list = new Dictionary<List<string>, List<string>>();

            list.Add(new List<string>() { "selam", "selamlar", "selamunaleyküm", "selamunaleykm", " sa ", " slm " },
                new List<string>() { "Aleykümselam", "Aleykümselam yiğenim", "Aslm", "Ooo kimler gelmiş" });

            list.Add(new List<string>() { "merhaba", "günaydın", "mısın", "misin" },
                new List<string>() { "İbne misin sen?", "Top", "ibne" });

            list.Add(new List<string>() { " bb ", "görüşürüz", "grşrz", "bay bay" },
                new List<string>() { "Hadi Allaha emanet kardeşim", "Görüşürüz", "BB", "Demagoji yapma sg", "Hadi görüşürüz" });

            list.Add(new List<string>() { "napıyosun", "nabıyon", "naber", "nasılsın", "nabiyon" },
                new List<string>() { "seni" });

            list.Add(new List<string>() { "yaraa", "yraa", "yara" },
                new List<string>() { "YARRAAA!!" });

            //list.Add(new List<string>() { "girdi1", "girdi2"}, new List<string>() { "çıktı1", "çıktı2" });

            return list;
        }
    }

    public static class BadWord
    {
        public static List<string> CreateBadWords()
        {
            List<string> files = new List<string>();
            files = JsonSerializer.Deserialize<List<string>>("[\"abaza\",\"skm\",\" it \",\" sg \",\"amk\",\" aw \",\"abazan\",\" ag \",\"a\u011fz\u0131na s\u0131\u00e7ay\u0131m\",\"ahmak\",\" am \",\"amar\u0131m\",\"ambiti\",\"am biti\",\"amc\u0131\u011f\u0131\",\"amc\u0131\u011f\u0131n\",\"amc\u0131\u011f\u0131n\u0131\",\"amc\u0131\u011f\u0131n\u0131z\u0131\",\"amc\u0131k\",\"amc\u0131k ho\u015faf\u0131\",\"amc\u0131klama\",\"amc\u0131kland\u0131\",\"amcik\",\"amck\",\"amckl\",\"amcklama\",\"amcklaryla\",\"amckta\",\"amcktan\",\"amcuk\",\"am\u0131k\",\"am\u0131na\",\"am\u0131nako\",\"am\u0131na koy\",\"am\u0131na koyar\u0131m\",\"am\u0131na koyay\u0131m\",\"am\u0131nakoyim\",\"am\u0131na koyyim\",\"am\u0131na s\",\"am\u0131na sikem\",\"am\u0131na sokam\",\"am\u0131n feryad\u0131\",\"am\u0131n\u0131\",\"am\u0131n\u0131 s\",\"am\u0131n oglu\",\"am\u0131no\u011flu\",\"am\u0131n o\u011flu\",\"am\u0131s\u0131na\",\"am\u0131s\u0131n\u0131\",\"amina\",\"amina g\",\"amina k\",\"aminako\",\"aminakoyarim\",\"amina koyarim\",\"amina koyay\u0131m\",\"amina koyayim\",\"aminakoyim\",\"aminda\",\"amindan\",\"amindayken\",\"amini\",\"aminiyarraaniskiim\",\"aminoglu\",\"amin oglu\",\"amiyum\",\"amk\",\"amkafa\",\"amk \u00e7ocu\u011fu\",\"amlarnzn\",\"aml\u0131\",\"amm\",\"ammak\",\"ammna\",\"amn\",\"amna\",\"amnda\",\"amndaki\",\"amngtn\",\"amnn\",\"amona\",\"amq\",\"ams\u0131z\",\"amsiz\",\"amsz\",\"amteri\",\"amugaa\",\"amu\u011fa\",\"amuna\",\"ana\",\"anaaann\",\"anal\",\"analarn\",\"anam\",\"anamla\",\"anan\",\"anana\",\"anandan\",\"anan\u0131\",\"anan\u0131\",\"anan\u0131n\",\"anan\u0131n am\",\"anan\u0131n am\u0131\",\"anan\u0131n d\u00f6l\u00fc\",\"anan\u0131nki\",\"anan\u0131sikerim\",\"anan\u0131 sikerim\",\"anan\u0131sikeyim\",\"anan\u0131 sikeyim\",\"anan\u0131z\u0131n\",\"anan\u0131z\u0131n am\",\"anani\",\"ananin\",\"ananisikerim\",\"anani sikerim\",\"ananisikeyim\",\"anani sikeyim\",\"anann\",\"ananz\",\"anas\",\"anas\u0131n\u0131\",\"anas\u0131n\u0131n am\",\"anas\u0131 orospu\",\"anasi\",\"anasinin\",\"anay\",\"anayin\",\"angut\",\"anneni\",\"annenin\",\"annesiz\",\"anuna\",\"aptal\",\"aq\",\"a.q\",\"a.q.\",\"aq.\",\"ass\",\"atkafas\u0131\",\"atm\u0131k\",\"att\u0131rd\u0131\u011f\u0131m\",\"attrrm\",\"auzlu\",\"avrat\",\"ayklarmalrmsikerim\",\"azd\u0131m\",\"azd\u0131r\",\"azd\u0131r\u0131c\u0131\",\"babaannesi ka\u015far\",\"baban\u0131\",\"baban\u0131n\",\"babani\",\"babas\u0131 pezevenk\",\"baca\u011f\u0131na s\u0131\u00e7ay\u0131m\",\"bac\u0131na\",\"bac\u0131n\u0131\",\"bac\u0131n\u0131n\",\"bacini\",\"bacn\",\"bacndan\",\"bacy\",\"bastard\",\"basur\",\"beyinsiz\",\"b\u0131z\u0131r\",\"bitch\",\"biting\",\"bok\",\"boka\",\"bokbok\",\"bok\u00e7a\",\"bokhu\",\"bokkkumu\",\"boklar\",\"boktan\",\"boku\",\"bokubokuna\",\"bokum\",\"bombok\",\"boner\",\"bosalmak\",\"bo\u015falmak\",\"cenabet\",\"cibiliyetsiz\",\"cibilliyetini\",\"cibilliyetsiz\",\"cif\",\"cikar\",\"cim\",\"\u00e7\u00fck\",\"dalaks\u0131z\",\"dallama\",\"daltassak\",\"dalyarak\",\"dalyarrak\",\"dangalak\",\"dassagi\",\"diktim\",\"dildo\",\"dingil\",\"dingilini\",\"dinsiz\",\"dkerim\",\"domal\",\"domalan\",\"domald\u0131\",\"domald\u0131n\",\"domal\u0131k\",\"domal\u0131yor\",\"domalmak\",\"domalm\u0131\u015f\",\"domals\u0131n\",\"domalt\",\"domaltarak\",\"domalt\u0131p\",\"domalt\u0131r\",\"domalt\u0131r\u0131m\",\"domaltip\",\"domaltmak\",\"d\u00f6l\u00fc\",\"d\u00f6nek\",\"d\u00fcd\u00fck\",\"eben\",\"ebeni\",\"ebenin\",\"ebeninki\",\"ebleh\",\"ecdad\u0131n\u0131\",\"ecdadini\",\"embesil\",\"emi\",\"fahise\",\"fahi\u015fe\",\"feri\u015ftah\",\"ferre\",\"fuck\",\"fucker\",\"fuckin\",\"fucking\",\"gavad\",\"gavat\",\"geber\",\"geberik\",\"gebermek\",\"gebermi\u015f\",\"gebertir\",\"ger\u0131zekal\u0131\",\"gerizekal\u0131\",\"gerizekali\",\"gerzek\",\"giberim\",\"giberler\",\"gibis\",\"gibi\u015f\",\"gibmek\",\"gibtiler\",\"goddamn\",\"godo\u015f\",\"godumun\",\"gotelek\",\"gotlalesi\",\"gotlu\",\"gotten\",\"gotundeki\",\"gotunden\",\"gotune\",\"gotunu\",\"gotveren\",\"goyiim\",\"goyum\",\"goyuyim\",\"goyyim\",\"g\u00f6t\",\"g\u00f6t deli\u011fi\",\"g\u00f6telek\",\"g\u00f6t herif\",\"g\u00f6tlalesi\",\"g\u00f6tlek\",\"g\u00f6to\u011flan\u0131\",\"g\u00f6t o\u011flan\u0131\",\"g\u00f6to\u015f\",\"g\u00f6tten\",\"g\u00f6t\u00fc\",\"g\u00f6t\u00fcn\",\"g\u00f6t\u00fcne\",\"g\u00f6t\u00fcnekoyim\",\"g\u00f6t\u00fcne koyim\",\"g\u00f6t\u00fcn\u00fc\",\"g\u00f6tveren\",\"g\u00f6t veren\",\"g\u00f6t verir\",\"gtelek\",\"gtn\",\"gtnde\",\"gtnden\",\"gtne\",\"gtten\",\"gtveren\",\"hasiktir\",\"hassikome\",\"hassiktir\",\"has siktir\",\"hassittir\",\"haysiyetsiz\",\"hayvan herif\",\"ho\u015faf\u0131\",\"h\u00f6d\u00fck\",\"hsktr\",\"huur\",\"\u0131bnel\u0131k\",\"ibina\",\"ibine\",\"ibinenin\",\"ibne\",\"ibnedir\",\"ibneleri\",\"ibnelik\",\"ibnelri\",\"ibneni\",\"ibnenin\",\"ibnerator\",\"ibnesi\",\"idiot\",\"idiyot\",\"imansz\",\"ipne\",\"iserim\",\"i\u015ferim\",\"ito\u011flu it\",\"kafam girsin\",\"kafas\u0131z\",\"kafasiz\",\"kahpe\",\"kahpenin\",\"kahpenin feryad\u0131\",\"kaka\",\"kaltak\",\"kanc\u0131k\",\"kancik\",\"kappe\",\"karhane\",\"ka\u015far\",\"kavat\",\"kavatn\",\"kaypak\",\"kayyum\",\"kerane\",\"kerhane\",\"kerhanelerde\",\"kevase\",\"keva\u015fe\",\"kevvase\",\"koca g\u00f6t\",\"kodu\u011fmun\",\"kodu\u011fmunun\",\"kodumun\",\"kodumunun\",\"koduumun\",\"koyarm\",\"koyay\u0131m\",\"koyiim\",\"koyiiym\",\"koyim\",\"koyum\",\"koyyim\",\"krar\",\"kukudaym\",\"laciye boyad\u0131m\",\"lavuk\",\"libo\u015f\",\"madafaka\",\"mal\",\"malafat\",\"malak\",\"manyak\",\"mcik\",\"meme\",\"memelerini\",\"mezveleli\",\"minaamc\u0131k\",\"mincikliyim\",\"mna\",\"monakkoluyum\",\"motherfucker\",\"mudik\",\"oc\",\"ocuu\",\"ocuun\",\"O\u00c7\",\"o\u00e7\",\"o. \u00e7ocu\u011fu\",\"o\u011flan\",\"o\u011flanc\u0131\",\"o\u011flu it\",\"orosbucocuu\",\"orospu\",\"orospucocugu\",\"orospu cocugu\",\"orospu \u00e7oc\",\"orospu\u00e7ocu\u011fu\",\"orospu \u00e7ocu\u011fu\",\"orospu \u00e7ocu\u011fudur\",\"orospu \u00e7ocuklar\u0131\",\"orospudur\",\"orospular\",\"orospunun\",\"orospunun evlad\u0131\",\"orospuydu\",\"orospuyuz\",\"orostoban\",\"orostopol\",\"orrospu\",\"oruspu\",\"oruspu\u00e7ocu\u011fu\",\"oruspu \u00e7ocu\u011fu\",\"osbir\",\"ossurduum\",\"ossurmak\",\"ossuruk\",\"osur\",\"osurduu\",\"osuruk\",\"osururum\",\"otuzbir\",\"\u00f6k\u00fcz\",\"\u00f6\u015fex\",\"patlak zar\",\"penis\",\"pezevek\",\"pezeven\",\"pezeveng\",\"pezevengi\",\"pezevengin evlad\u0131\",\"pezevenk\",\"pezo\",\"pic\",\"pici\",\"picler\",\"pi\u00e7\",\"pi\u00e7in o\u011flu\",\"pi\u00e7 kurusu\",\"pi\u00e7ler\",\"pipi\",\"pipi\u015f\",\"pisliktir\",\"porno\",\"pussy\",\"pu\u015ft\",\"pu\u015fttur\",\"rahminde\",\"revizyonist\",\"s1kerim\",\"s1kerm\",\"s1krm\",\"sakso\",\"saksofon\",\"salaak\",\"salak\",\"saxo\",\"sekis\",\"serefsiz\",\"sevgi koyar\u0131m\",\"sevi\u015felim\",\"sexs\",\"s\u0131\u00e7ar\u0131m\",\"s\u0131\u00e7t\u0131\u011f\u0131m\",\"s\u0131ecem\",\"sicarsin\",\"sie\",\"sik\",\"sikdi\",\"sikdi\u011fim\",\"sike\",\"sikecem\",\"sikem\",\"siken\",\"sikenin\",\"siker\",\"sikerim\",\"sikerler\",\"sikersin\",\"sikertir\",\"sikertmek\",\"sikesen\",\"sikesicenin\",\"sikey\",\"sikeydim\",\"sikeyim\",\"sikeym\",\"siki\",\"sikicem\",\"sikici\",\"sikien\",\"sikienler\",\"sikiiim\",\"sikiiimmm\",\"sikiim\",\"sikiir\",\"sikiirken\",\"sikik\",\"sikil\",\"sikildiini\",\"sikilesice\",\"sikilmi\",\"sikilmie\",\"sikilmis\",\"sikilmi\u015f\",\"sikilsin\",\"sikim\",\"sikimde\",\"sikimden\",\"sikime\",\"sikimi\",\"sikimiin\",\"sikimin\",\"sikimle\",\"sikimsonik\",\"sikimtrak\",\"sikin\",\"sikinde\",\"sikinden\",\"sikine\",\"sikini\",\"sikip\",\"sikis\",\"sikisek\",\"sikisen\",\"sikish\",\"sikismis\",\"siki\u015f\",\"siki\u015fen\",\"siki\u015fme\",\"sikitiin\",\"sikiyim\",\"sikiym\",\"sikiyorum\",\"sikkim\",\"sikko\",\"sikleri\",\"sikleriii\",\"sikli\",\"sikm\",\"sikmek\",\"sikmem\",\"sikmiler\",\"sikmisligim\",\"siksem\",\"sikseydin\",\"sikseyidin\",\"siksin\",\"siksinbaya\",\"siksinler\",\"siksiz\",\"siksok\",\"siksz\",\"sikt\",\"sikti\",\"siktigimin\",\"siktigiminin\",\"sikti\u011fim\",\"sikti\u011fimin\",\"sikti\u011fiminin\",\"siktii\",\"siktiim\",\"siktiimin\",\"siktiiminin\",\"siktiler\",\"siktim\",\"siktim\",\"siktimin\",\"siktiminin\",\"siktir\",\"siktir et\",\"siktirgit\",\"siktir git\",\"siktirir\",\"siktiririm\",\"siktiriyor\",\"siktir lan\",\"siktirolgit\",\"siktir ol git\",\"sittimin\",\"sittir\",\"skcem\",\"skecem\",\"skem\",\"sker\",\"skerim\",\"skerm\",\"skeyim\",\"skiim\",\"skik\",\"skim\",\"skime\",\"skmek\",\"sksin\",\"sksn\",\"sksz\",\"sktiimin\",\"sktrr\",\"skyim\",\"slaleni\",\"sokam\",\"sokar\u0131m\",\"sokarim\",\"sokarm\",\"sokarmkoduumun\",\"sokay\u0131m\",\"sokaym\",\"sokiim\",\"soktu\u011fumunun\",\"sokuk\",\"sokum\",\"soku\u015f\",\"sokuyum\",\"soxum\",\"sulaleni\",\"s\u00fclaleni\",\"s\u00fclalenizi\",\"s\u00fcrt\u00fck\",\"\u015ferefsiz\",\"\u015f\u0131ll\u0131k\",\"taaklarn\",\"taaklarna\",\"tarrakimin\",\"tasak\",\"tassak\",\"ta\u015fak\",\"ta\u015f\u015fak\",\"tipini s.k\",\"tipinizi s.keyim\",\"tiyniyat\",\"toplarm\",\"topsun\",\"toto\u015f\",\"vajina\",\"vajinan\u0131\",\"veled\",\"veledizina\",\"veled i zina\",\"verdiimin\",\"weled\",\"weledizina\",\"whore\",\"xikeyim\",\"yaaraaa\",\"yalama\",\"yalar\u0131m\",\"yalarun\",\"yaraaam\",\"yarak\",\"yaraks\u0131z\",\"yaraktr\",\"yaram\",\"yaraminbasi\",\"yaramn\",\"yararmorospunun\",\"yarra\",\"yarraaaa\",\"yarraak\",\"yarraam\",\"yarraam\u0131\",\"yarragi\",\"yarragimi\",\"yarragina\",\"yarragindan\",\"yarragm\",\"yarra\u011f\",\"yarra\u011f\u0131m\",\"yarra\u011f\u0131m\u0131\",\"yarraimin\",\"yarrak\",\"yarram\",\"yarramin\",\"yarraminba\u015f\u0131\",\"yarramn\",\"yarran\",\"yarrana\",\"yarrrak\",\"yavak\",\"yav\u015f\",\"yav\u015fak\",\"yav\u015fakt\u0131r\",\"yavu\u015fak\",\"y\u0131l\u0131\u015f\u0131k\",\"yilisik\",\"yogurtlayam\",\"yo\u011furtlayam\",\"yrrak\",\"z\u0131kk\u0131m\u0131m\",\"zibidi\",\"zigsin\",\"zikeyim\",\"zikiiim\",\"zikiim\",\"zikik\",\"zikim\",\"ziksiiin\",\"ziksiin\",\"zulliyetini\",\"zviyetini\"]");
            return files;
        }
    }
}