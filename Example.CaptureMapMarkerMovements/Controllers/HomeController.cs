using Example.CaptureMapMarkerMovements.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.CaptureMapMarkerMovements.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult RenderMap()
        {
            ViewBag.Polyline = string.Join("", new string[] {
        "hldhx@lnau`BCG_EaC??cFjAwDjF??uBlKMd@}@z@??aC^yk@z_@se@b[wFdE??wFfE}N",
        "fIoGxB_I\\gG}@eHoCyTmPqGaBaHOoD\\??yVrGotA|N??o[N_STiwAtEmHGeHcAkiA}^",
        "aMyBiHOkFNoI`CcVvM??gG^gF_@iJwC??eCcA]OoL}DwFyCaCgCcCwDcGwHsSoX??wI_E",
        "kUFmq@hBiOqBgTwS??iYse@gYq\\cp@ce@{vA}s@csJqaE}{@iRaqE{lBeRoIwd@_T{]_",
        "Ngn@{PmhEwaA{SeF_u@kQuyAw]wQeEgtAsZ}LiCarAkVwI}D??_}RcjEinPspDwSqCgs@",
        "sPua@_OkXaMeT_Nwk@ob@gV}TiYs[uTwXoNmT{Uyb@wNg]{Nqa@oDgNeJu_@_G}YsFw]k",
        "DuZyDmm@i_@uyIJe~@jCg|@nGiv@zUi_BfNqaAvIow@dEed@dCcf@r@qz@Egs@{Acu@mC",
        "um@yIey@gGig@cK_m@aSku@qRil@we@{mAeTej@}Tkz@cLgr@aHko@qOmcEaJw~C{w@ka",
        "i@qBchBq@kmBS{kDnBscBnFu_Dbc@_~QHeU`IuyDrC_}@bByp@fCyoA?qMbD}{AIkeAgB",
        "k_A_A{UsDke@gFej@qH{o@qGgb@qH{`@mMgm@uQus@kL{_@yOmd@ymBgwE}x@ouBwtA__",
        "DuhEgaKuWct@gp@cnBii@mlBa_@}|Asj@qrCg^eaC}L{dAaJ_aAiOyjByH{nAuYu`GsAw",
        "Xyn@ywMyOyqD{_@cfIcDe}@y@aeBJmwA`CkiAbFkhBlTgdDdPyiB`W}xDnSa}DbJyhCrX",
        "itAhT}x@bE}Z_@qW_Kwv@qKaaAiBgXvIm}A~JovAxCqW~WanB`XewBbK{_A`K}fBvAmi@",
        "xBycBeCauBoF}}@qJioAww@gjHaPopA_NurAyJku@uGmi@cDs[eRaiBkQstAsQkcByNma",
        "CsK_uBcJgbEw@gkB_@ypEqDoqSm@eZcDwjBoGw`BoMegBaU_`Ce_@_uBqb@ytBwkFqiT_",
        "fAqfEwe@mfCka@_eC_UmlB}MmaBeWkkDeHwqAoX}~DcBsZmLcxBqOwqE_DkyAuJmrJ\\o",
        "~CfIewG|YibQxBssB?es@qGciA}RorAoVajA_nAodD{[y`AgPqp@mKwr@ms@umEaW{dAm",
        "b@umAw|@ojBwzDaaJsmBwbEgdCsrFqhAihDquAi`Fux@}_Dui@_eB_u@guCuyAuiHukA_",
        "lKszAu|OmaA{wKm}@clHs_A_rEahCssKo\\sgBsSglAqk@yvDcS_wAyTwpBmPc|BwZknF",
        "oFscB_GsaDiZmyMyLgtHgQonHqT{hKaPg}Dqq@m~Hym@c`EuiBudIabB{hF{pWifx@snA",
        "w`GkFyVqf@y~BkoAi}Lel@wtc@}`@oaXi_C}pZsi@eqGsSuqJ|Lqeb@e]kgPcaAu}SkDw",
        "zGhn@gjYh\\qlNZovJieBqja@ed@siO{[ol\\kCmjMe\\isHorCmec@uLebB}EqiBaCg}",
        "@m@qwHrT_vFps@kkI`uAszIrpHuzYxx@e{Crw@kpDhN{wBtQarDy@knFgP_yCu\\wyCwy",
        "A{kHo~@omEoYmoDaEcPiuAosDagD}rO{{AsyEihCayFilLaiUqm@_bAumFo}DgqA_uByi",
        "@swC~AkzDlhA}xEvcBa}Cxk@ql@`rAo|@~bBq{@``Bye@djDww@z_C_cAtn@ye@nfC_eC",
        "|gGahH~s@w}@``Fi~FpnAooC|u@wlEaEedRlYkrPvKerBfYs}Arg@m}AtrCkzElw@gjBb",
        "h@woBhR{gCwGkgCc[wtCuOapAcFoh@uBy[yBgr@c@iq@o@wvEv@sp@`FajBfCaq@fIipA",
        "dy@ewJlUc`ExGuaBdEmbBpBssArAuqBBg}@s@g{AkB{bBif@_bYmC}r@kDgm@sPq_BuJ_",
        "s@{X_{AsK_d@eM{d@wVgx@oWcu@??aDmOkNia@wFoSmDyMyCkPiBePwAob@XcQ|@oNdCo",
        "SfFwXhEmOnLi\\lbAulB`X_d@|k@au@bc@oc@bqC}{BhwDgcD`l@ed@??bL{G|a@eTje@",
        "oS~]cLr~Bgh@|b@}Jv}EieAlv@sPluD{z@nzA_]`|KchCtd@sPvb@wSb{@ko@f`RooQ~e",
        "[upZbuIolI|gFafFzu@iq@nMmJ|OeJn^{Qjh@yQhc@uJ~j@iGdd@kAp~BkBxO{@|QsAfY",
        "gEtYiGd]}Jpd@wRhVoNzNeK`j@ce@vgK}cJnSoSzQkVvUm^rSgc@`Uql@xIq\\vIgg@~k",
        "Dyq[nIir@jNoq@xNwc@fYik@tk@su@neB}uBhqEesFjoGeyHtCoD|D}Ed|@ctAbIuOzqB",
        "_}D~NgY`\\um@v[gm@v{Cw`G`w@o{AdjAwzBh{C}`Gpp@ypAxn@}mAfz@{bBbNia@??jI",
        "ab@`CuOlC}YnAcV`@_^m@aeB}@yk@YuTuBg^uCkZiGk\\yGeY}Lu_@oOsZiTe[uWi[sl@",
        "mo@soAauAsrBgzBqgAglAyd@ig@asAcyAklA}qAwHkGi{@s~@goAmsAyDeEirB_{B}IsJ",
        "uEeFymAssAkdAmhAyTcVkFeEoKiH}l@kp@wg@sj@ku@ey@uh@kj@}EsFmG}Jk^_r@_f@m",
        "~@ym@yjA??a@cFd@kBrCgDbAUnAcBhAyAdk@et@??kF}D??OL" });

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewRequestedData()
        {
            var model = GetData().ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string uniqueId = Guid.NewGuid().ToString();
            Debug.WriteLine($"PROCESS {uniqueId}");
            string capturesPath = DoCapture(uniqueId);
            string videoPath = MakeVideo(uniqueId, capturesPath);
            Debug.WriteLine(videoPath);

            return File(videoPath, "video/mp4", "output.mp4");
        }

        private string MakeVideo(string uniqueId, string capturesPath)
        {
            string videoPath = Server.MapPath($"~/tmp/{uniqueId}.mp4");
            ProcessStartInfo info = new ProcessStartInfo(Server.MapPath("~/libs/ffmpeg.exe"))
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Arguments = $"-start_number 0 -i {capturesPath}\\capture%09d.png -c:v libx264 -r 25 -pix_fmt yuv420p {videoPath}",
            };

            try
            {
                using (Process p = Process.Start(info))
                {
                    Debug.WriteLine(p.StandardError.ReadToEnd());
                    p.WaitForExit();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return videoPath;
        }

        private string CreateTempFolder()
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempFolder);
            return tempFolder;
        }

        private string DoCapture(string uniqueId)
        {
            string capturesPath = Server.MapPath($"~/tmp/captures/{uniqueId}");
            string mapUrlPath = Url.Action(nameof(HomeController.RenderMap), nameof(HomeController).Replace("Controller", ""), new { }, Request.Url.Scheme);
            ProcessStartInfo info = new ProcessStartInfo(Server.MapPath("~/libs/phantomjs.exe"))
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Arguments = $"{Server.MapPath("~/Scripts/phantomjs-capture.js")} {capturesPath} {mapUrlPath}",
            };

            using (Process p = Process.Start(info))
            {
                string output;
                while ((output = p.StandardOutput.ReadLine()) != null)
                {
                    Debug.WriteLine(output);
                    if (output.Contains("done"))
                    {
                        break;
                    }
                    else if (output.Contains("timeout") || output.Contains("fail"))
                    {
                        throw new Exception($"Failed to capture map. {output}");
                    }
                }

                p.WaitForExit();
            }

            return capturesPath;
        }

        private IEnumerable<Waypoint> GetData()
        {
            string csvData = @"
302803252,446,Dodge,2,Car,,1/22/2019 20:24,3.713314243,TRUE,29.6571693,-90.768751,275
302803253,446,Dodge,2,Car,,1/22/2019 20:24,5.637079454,TRUE,29.6571798,-90.7687768,300
302803254,446,Dodge,2,Car,,1/22/2019 20:24,7.270042946,TRUE,29.657209,-90.7688073,323
302803301,446,Dodge,2,Car,,1/22/2019 20:24,6.397637793,TRUE,29.6574298,-90.7689393,346
302803317,446,Dodge,2,Car,,1/22/2019 20:24,6.442376519,TRUE,29.657468,-90.7689341,13
302803331,446,Dodge,2,Car,,1/22/2019 20:24,7.202934858,TRUE,29.6574955,-90.7689098,40
302803350,446,Dodge,2,Car,,1/22/2019 20:24,8.321403003,TRUE,29.6575146,-90.7688695,63
302803715,446,Dodge,2,Car,,1/22/2019 20:25,5.704187543,TRUE,29.6576248,-90.768535,86
302803718,446,Dodge,2,Car,,1/22/2019 20:25,9.37276306,TRUE,29.6576121,-90.76849,115
302803723,446,Dodge,2,Car,,1/22/2019 20:25,11.47548317,TRUE,29.6575825,-90.768454,139
302804323,446,Dodge,2,Car,,1/22/2019 20:26,49.01127414,TRUE,29.6471615,-90.7633293,162
302805089,446,Dodge,2,Car,,1/22/2019 20:28,15.90461703,TRUE,29.6355686,-90.7598375,187
302805095,446,Dodge,2,Car,,1/22/2019 20:28,17.69416606,TRUE,29.6354755,-90.7598861,214
302805100,446,Dodge,2,Car,,1/22/2019 20:28,20.6245526,TRUE,29.6354121,-90.7599716,237
302805420,446,Dodge,2,Car,,1/22/2019 20:28,24.40497494,TRUE,29.634409,-90.7615791,214
302805485,446,Dodge,2,Car,,1/22/2019 20:28,7.202934858,TRUE,29.6335896,-90.7619905,238
302805496,446,Dodge,2,Car,,1/22/2019 20:28,7.695060842,TRUE,29.6335823,-90.7620393,263
302805575,446,Dodge,2,Car,,1/22/2019 20:29,14.83088761,TRUE,29.6336338,-90.7624583,287
302805578,446,Dodge,2,Car,,1/22/2019 20:29,13.84663564,TRUE,29.6336808,-90.7625386,314
302805580,446,Dodge,2,Car,,1/22/2019 20:29,12.86238367,TRUE,29.6337396,-90.7625733,340
302805599,446,Dodge,2,Car,,1/22/2019 20:29,10.80440229,TRUE,29.6338695,-90.762589,4
302805624,446,Dodge,2,Car,,1/22/2019 20:29,3.713314243,TRUE,29.6339625,-90.7625926,340
302806779,446,Dodge,2,Car,,1/22/2019 20:31,0.044738726,TRUE,29.6341368,-90.7626758,332
302807775,446,Dodge,2,Car,,1/22/2019 20:33,0.246062992,TRUE,29.634108,-90.7626911,248
302808693,446,Dodge,2,Car,,1/22/2019 20:35,0.357909807,TRUE,29.6340273,-90.7626383,174
302809273,446,Dodge,2,Car,,1/22/2019 20:36,5.83840372,TRUE,29.6341695,-90.7626523,324
302809275,446,Dodge,2,Car,,1/22/2019 20:36,7.516105938,TRUE,29.6341783,-90.7626896,300
302809288,446,Dodge,2,Car,,1/22/2019 20:36,7.381889761,TRUE,29.6342215,-90.7627768,323
302809297,446,Dodge,2,Car,,1/22/2019 20:36,4.965998566,TRUE,29.6342516,-90.7627813,346
302809301,446,Dodge,2,Car,,1/22/2019 20:36,4.160701502,TRUE,29.634277,-90.7627731,11
302809305,446,Dodge,2,Car,,1/22/2019 20:36,6.889763777,TRUE,29.6343011,-90.7627495,40
302809315,446,Dodge,2,Car,,1/22/2019 20:36,8.947745165,TRUE,29.6343191,-90.762703,63
302809351,446,Dodge,2,Car,,1/22/2019 20:36,22.66016463,TRUE,29.6344268,-90.762128,87
302809368,446,Dodge,2,Car,,1/22/2019 20:36,14.15980672,TRUE,29.6343936,-90.7619295,110
302809462,446,Dodge,2,Car,,1/22/2019 20:36,13.98085182,TRUE,29.6343311,-90.7616925,87
302809464,446,Dodge,2,Car,,1/22/2019 20:36,19.0586972,TRUE,29.6343755,-90.7615386,63
302809480,446,Dodge,2,Car,,1/22/2019 20:37,24.89710092,TRUE,29.6345346,-90.7613516,40
302809568,446,Dodge,2,Car,,1/22/2019 20:37,25.65765926,TRUE,29.6351143,-90.7605543,63
302809676,446,Dodge,2,Car,,1/22/2019 20:37,14.7190408,TRUE,29.6356925,-90.7589766,37
302809678,446,Dodge,2,Car,,1/22/2019 20:37,15.77040085,TRUE,29.6357646,-90.7589463,11
302809682,446,Dodge,2,Car,,1/22/2019 20:37,20.31138152,TRUE,29.6358926,-90.7589613,347
302810597,446,Dodge,2,Car,,1/22/2019 20:39,36.28310664,TRUE,29.6558,-90.7663836,333
302813046,446,Dodge,2,Car,,1/22/2019 20:41,13.77952755,TRUE,29.672079,-90.7760676,309
302813048,446,Dodge,2,Car,,1/22/2019 20:41,12.66105941,TRUE,29.6721,-90.7761366,280
302813049,446,Dodge,2,Car,,1/22/2019 20:41,13.15318539,TRUE,29.6720876,-90.7762245,254
302813052,446,Dodge,2,Car,,1/22/2019 20:41,3.780422332,TRUE,29.6718553,-90.776639,213
302813054,446,Dodge,2,Car,,1/22/2019 20:41,10.11095204,TRUE,29.671811,-90.7766536,189
302813057,446,Dodge,2,Car,,1/22/2019 20:41,14.09269863,TRUE,29.67176,-90.7766423,163
302813059,446,Dodge,2,Car,,1/22/2019 20:42,9.999105222,TRUE,29.6707105,-90.7759008,186
302813062,446,Dodge,2,Car,,1/22/2019 20:42,9.931997133,TRUE,29.6706836,-90.7759166,210
302813064,446,Dodge,2,Car,,1/22/2019 20:42,9.685934141,TRUE,29.6706583,-90.7759511,234
302813067,446,Dodge,2,Car,,1/22/2019 20:42,7.560844664,TRUE,29.6705981,-90.7760236,211
302813070,446,Dodge,2,Car,,1/22/2019 20:42,6.196313527,TRUE,29.6705328,-90.7760638,235
302813074,446,Dodge,2,Car,,1/22/2019 20:42,0,FALSE,29.6705171,-90.7760988,245
302813078,446,Dodge,2,Car,,1/22/2019 20:45,0.044738726,TRUE,29.6705291,-90.7760946,245
302813080,446,Dodge,2,Car,,1/22/2019 20:45,2.035612025,TRUE,29.6704766,-90.7761256,184
302813105,446,Dodge,2,Car,,1/22/2019 20:45,2.527738009,TRUE,29.6704635,-90.7761161,356
302813128,446,Dodge,2,Car,,1/22/2019 20:45,2.281675017,TRUE,29.670498,-90.7761316,333
302813159,446,Dodge,2,Car,,1/22/2019 20:45,3.288296348,TRUE,29.6704995,-90.7761218,105
302813169,446,Dodge,2,Car,,1/22/2019 20:45,3.221188259,TRUE,29.6704998,-90.7760998,81
302813175,446,Dodge,2,Car,,1/22/2019 20:45,5.704187543,TRUE,29.6705131,-90.7760745,55
302813180,446,Dodge,2,Car,,1/22/2019 20:45,6.442376519,TRUE,29.6705433,-90.7760483,32
302813200,446,Dodge,2,Car,,1/22/2019 20:46,8.321403003,TRUE,29.6706256,-90.7759906,57
302813258,446,Dodge,2,Car,,1/22/2019 20:46,6.643700785,TRUE,29.6706611,-90.7758841,82
302813262,446,Dodge,2,Car,,1/22/2019 20:46,9.193808157,TRUE,29.6706553,-90.7758556,106
302813266,446,Dodge,2,Car,,1/22/2019 20:46,11.43074445,TRUE,29.6706351,-90.7758258,133
302813413,446,Dodge,2,Car,,1/22/2019 20:46,41.74123119,TRUE,29.6682988,-90.7743936,156
302813853,446,Dodge,2,Car,,1/22/2019 20:47,6.710808874,TRUE,29.6576821,-90.7685636,183
302813855,446,Dodge,2,Car,,1/22/2019 20:47,6.084466712,TRUE,29.6576596,-90.7685768,211
302813857,446,Dodge,2,Car,,1/22/2019 20:47,5.637079454,TRUE,29.6576421,-90.768602,235
302813913,446,Dodge,2,Car,,1/22/2019 20:47,9.618826052,TRUE,29.657477,-90.7689295,212
302813917,446,Dodge,2,Car,,1/22/2019 20:47,8.992483891,TRUE,29.6574411,-90.7689381,185
302813920,446,Dodge,2,Car,,1/22/2019 20:47,9.931997133,TRUE,29.6573866,-90.7689238,162
302813959,446,Dodge,2,Car,,1/22/2019 20:48,8.254294915,TRUE,29.6571628,-90.7687956,136
302813960,446,Dodge,2,Car,,1/22/2019 20:48,7.560844664,TRUE,29.6571501,-90.7687628,107
302813962,446,Dodge,2,Car,,1/22/2019 20:48,6.822655688,TRUE,29.6571515,-90.7687386,83
302813965,446,Dodge,2,Car,,1/22/2019 20:48,5.14495347,TRUE,29.657163,-90.7687156,58
302814349,446,Dodge,2,Car,,1/22/2019 20:49,0.044738726,FALSE,29.65717,-90.7686916,42
302840527,446,Dodge,2,Car,,1/22/2019 21:49,0,TRUE,29.6571876,-90.7686771,42
302840634,446,Dodge,2,Car,,1/22/2019 22:43,6.509484607,TRUE,29.6574703,-90.768946,7
302840635,446,Dodge,2,Car,,1/22/2019 22:43,7.76216893,TRUE,29.6575023,-90.7689263,35
302840636,446,Dodge,2,Car,,1/22/2019 22:43,9.37276306,TRUE,29.6575276,-90.7688855,59
302840668,446,Dodge,2,Car,,1/22/2019 22:44,3.91463851,TRUE,29.6576525,-90.7685608,82
302840669,446,Dodge,2,Car,,1/22/2019 22:44,8.880637076,TRUE,29.6576461,-90.7685053,106
302840670,446,Dodge,2,Car,,1/22/2019 22:44,12.10182534,TRUE,29.6576103,-90.7684455,132
302840710,446,Dodge,2,Car,,1/22/2019 22:44,12.66105941,TRUE,29.655279,-90.7668628,105
302840712,446,Dodge,2,Car,,1/22/2019 22:44,12.79527559,TRUE,29.6552843,-90.7667918,80
302840765,446,Dodge,2,Car,,1/22/2019 22:45,44.22423048,TRUE,29.65788,-90.7606701,57
302841101,446,Dodge,2,Car,,1/22/2019 22:46,49.6376163,TRUE,29.6614921,-90.7532646,81
302841102,446,Dodge,2,Car,,1/22/2019 22:46,48.76521115,TRUE,29.661441,-90.7520313,104
302841104,446,Dodge,2,Car,,1/22/2019 22:47,52.50089475,TRUE,29.652943,-90.732588,127
302841106,446,Dodge,2,Car,,1/22/2019 22:48,43.55314959,TRUE,29.6503703,-90.7285903,104
302841107,446,Dodge,2,Car,,1/22/2019 22:48,42.92680743,TRUE,29.6492101,-90.724853,127
302841131,446,Dodge,2,Car,,1/22/2019 22:50,50.0626342,TRUE,29.633318,-90.7073743,127
302841289,446,Dodge,2,Car,,1/22/2019 22:52,48.27308516,TRUE,29.626421,-90.696184,132
302841406,446,Dodge,2,Car,,1/22/2019 22:54,50.37580528,TRUE,29.6121436,-90.6745241,128
302841478,446,Dodge,2,Car,,1/22/2019 22:55,20.55744452,TRUE,29.6084621,-90.6679298,153
302841479,446,Dodge,2,Car,,1/22/2019 22:55,20.73639942,TRUE,29.60834,-90.6678973,177
302841481,446,Dodge,2,Car,,1/22/2019 22:55,22.72727272,TRUE,29.6082105,-90.6679258,200
302841645,446,Dodge,2,Car,,1/22/2019 22:57,0,TRUE,29.5954373,-90.6758441,210
302841800,446,Dodge,2,Car,,1/22/2019 22:59,0.044738726,TRUE,29.5942345,-90.6766106,208
302842066,446,Dodge,2,Car,,1/22/2019 23:01,0.044738726,TRUE,29.5933971,-90.6771068,209
302842266,446,Dodge,2,Car,,1/22/2019 23:03,10.62544738,TRUE,29.5931371,-90.6772723,208
302842486,446,Dodge,2,Car,,1/22/2019 23:05,14.78614888,TRUE,29.5926843,-90.6775233,185
302842487,446,Dodge,2,Car,,1/22/2019 23:05,15.90461703,TRUE,29.5925785,-90.6774975,161
302842492,446,Dodge,2,Car,,1/22/2019 23:05,17.20204008,TRUE,29.5925011,-90.677426,138
302842524,446,Dodge,2,Car,,1/22/2019 23:05,39.81746598,TRUE,29.591691,-90.6759623,115
302842739,446,Dodge,2,Car,,1/22/2019 23:07,48.94416605,TRUE,29.5824188,-90.6593728,138
302842979,446,Dodge,2,Car,,1/22/2019 23:09,0.044738726,TRUE,29.5660696,-90.646633,133
302843143,446,Dodge,2,Car,,1/22/2019 23:11,27.82748746,TRUE,29.5594395,-90.6342023,118
302843243,446,Dodge,2,Car,,1/22/2019 23:12,49.07838223,TRUE,29.55358,-90.6185415,95
302843434,446,Dodge,2,Car,,1/22/2019 23:14,40.06352898,TRUE,29.5533355,-90.6014605,101
302843507,446,Dodge,2,Car,,1/22/2019 23:15,43.79921258,TRUE,29.5488538,-90.588884,124
302843521,446,Dodge,2,Car,,1/22/2019 23:15,16.08357193,TRUE,29.5475003,-90.5871008,100
302843522,446,Dodge,2,Car,,1/22/2019 23:15,15.65855404,TRUE,29.5475116,-90.5869938,73
302843523,446,Dodge,2,Car,,1/22/2019 23:15,16.01646384,TRUE,29.547564,-90.586903,47
302843525,446,Dodge,2,Car,,1/22/2019 23:15,19.50608446,TRUE,29.547702,-90.5868071,23
302843619,446,Dodge,2,Car,,1/22/2019 23:17,48.34019325,TRUE,29.558593,-90.5787821,46
302843620,446,Dodge,2,Car,,1/22/2019 23:17,48.89942733,TRUE,29.5592136,-90.577643,69
302843625,446,Dodge,2,Car,,1/22/2019 23:17,49.50340012,TRUE,29.5593811,-90.5763586,92
302843631,446,Dodge,2,Car,,1/22/2019 23:17,49.07838223,TRUE,29.559084,-90.5750593,115
302843692,446,Dodge,2,Car,,1/22/2019 23:18,52.12061558,TRUE,29.5548726,-90.5628858,92
302843816,446,Dodge,2,Car,,1/22/2019 23:20,56.66159626,TRUE,29.5522426,-90.5339063,104
302843996,446,Dodge,2,Car,,1/22/2019 23:22,56.97476734,TRUE,29.5434453,-90.5045361,90
302844121,446,Dodge,2,Car,,1/22/2019 23:24,56.66159626,TRUE,29.5460583,-90.4757953,113
302844283,446,Dodge,2,Car,,1/22/2019 23:26,56.41553326,TRUE,29.53394,-90.4502896,90
302844337,446,Dodge,2,Car,,1/22/2019 23:27,56.59448817,TRUE,29.5378606,-90.4341398,67
302844428,446,Dodge,2,Car,,1/22/2019 23:28,56.66159626,TRUE,29.5444,-90.4120178,90
302844510,446,Dodge,2,Car,,1/22/2019 23:29,47.08750893,TRUE,29.5444446,-90.3986606,67
302844515,446,Dodge,2,Car,,1/22/2019 23:29,49.39155331,TRUE,29.5450293,-90.3977223,44
302844606,446,Dodge,2,Car,,1/22/2019 23:31,19.68503936,TRUE,29.5644181,-90.385121,69
302844609,446,Dodge,2,Car,,1/22/2019 23:31,20.6245526,TRUE,29.5644321,-90.3849831,92
302844620,446,Dodge,2,Car,,1/22/2019 23:31,47.71385109,TRUE,29.5632908,-90.3815456,115
302844808,446,Dodge,2,Car,,1/22/2019 23:33,56.48264135,TRUE,29.5479913,-90.3595643,138
302844869,446,Dodge,2,Car,,1/22/2019 23:34,56.52738008,TRUE,29.5372516,-90.3523285,161
302844987,446,Dodge,2,Car,,1/22/2019 23:36,56.59448817,TRUE,29.5110203,-90.3436608,165
302845136,446,Dodge,2,Car,,1/22/2019 23:38,56.66159626,TRUE,29.4852186,-90.333354,156
302845225,446,Dodge,2,Car,,1/22/2019 23:40,31.11578381,TRUE,29.4678846,-90.3244223,156
302845378,446,Dodge,2,Car,,1/22/2019 23:42,57.9590193,TRUE,29.4424816,-90.3113741,156
302845525,446,Dodge,2,Car,,1/22/2019 23:44,57.89191122,TRUE,29.4184761,-90.295076,138
302845647,446,Dodge,2,Car,,1/22/2019 23:46,48.20597708,TRUE,29.3974923,-90.2779553,149
302845706,446,Dodge,2,Car,,1/22/2019 23:47,9.618826052,TRUE,29.3910558,-90.272545,120
302845707,446,Dodge,2,Car,,1/22/2019 23:47,8.187186826,TRUE,29.3910508,-90.2725166,96
302845708,446,Dodge,2,Car,,1/22/2019 23:47,7.874015745,TRUE,29.3910575,-90.2724905,71
302845710,446,Dodge,2,Car,,1/22/2019 23:47,7.270042946,TRUE,29.3910745,-90.2724741,39
302845711,446,Dodge,2,Car,,1/22/2019 23:47,7.001610591,TRUE,29.3910961,-90.2724705,10
302845713,446,Dodge,2,Car,,1/22/2019 23:47,6.576592696,TRUE,29.3911161,-90.2724776,343
302845715,446,Dodge,2,Car,,1/22/2019 23:47,7.270042946,TRUE,29.3911385,-90.2724995,317
302845725,446,Dodge,2,Car,,1/22/2019 23:47,12.86238367,TRUE,29.391896,-90.2732606,342
302845726,446,Dodge,2,Car,,1/22/2019 23:47,11.54259126,TRUE,29.3919828,-90.2732666,5
302845731,446,Dodge,2,Car,,1/22/2019 23:47,6.509484607,TRUE,29.392124,-90.273261,340
302845735,446,Dodge,2,Car,,1/22/2019 23:47,5.704187543,TRUE,29.392186,-90.2732758,5
302845736,446,Dodge,2,Car,,1/22/2019 23:47,5.212061558,TRUE,29.3922051,-90.273264,34
302845739,446,Dodge,2,Car,,1/22/2019 23:47,2.102720114,TRUE,29.3922163,-90.273245,57
302845743,446,Dodge,2,Car,,1/22/2019 23:47,0,FALSE,29.392219,-90.2732365,66

";
            var lines = csvData.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return from l in lines
                   let items = l.Split(',')
                   select new Waypoint()
                   {
                       Lat = Convert.ToDecimal(items[9]),
                       Lng = Convert.ToDecimal(items[10]),
                       Speed = Convert.ToDecimal(items[7]),
                       Date = items[6]
                   };
        }
    }
}