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

            return View();
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
            ProcessStartInfo info = new ProcessStartInfo(Server.MapPath("~/libs/phantomjs.exe"))
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Arguments = $"{Server.MapPath("~/Scripts/phantomjs-capture.js")} {capturesPath}",
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