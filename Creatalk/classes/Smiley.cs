﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatalk.classes
{
    public class Smiley
    {
        //you must provide smiley address of forum for the client. If its different, please change with the correct one.
        //foruma ait gülücük dosyalarının adresini isteci için vermeniz gerekiyor. Farklıysa, doğru olanı ile değiştiriniz.
        public static string sSmileyAddress = General.forum_domain + "data/smileyler/";  //hdp.

        //it may not work properly. it depends on forums smiley supports.
        //düzgün çalışmayabilir. forumların gülücük desteğine göre değişim gösterir.
        public static string GetSmiley(string sData)  //hdp.
        {
            string temp = sData;

            temp = temp.Replace(":angry:", "[img]" + sSmileyAddress + "angry.gif[/img]");
            temp = temp.Replace(":artist:", "[img]" + sSmileyAddress + "artist.gif[/img]");
            temp = temp.Replace(":bangin:", "[img]" + sSmileyAddress + "bangin.gif[/img]");
            temp = temp.Replace(":bann:", "[img]" + sSmileyAddress + "bann.gif[/img]");
            temp = temp.Replace(":biggrin:", "[img]" + sSmileyAddress + "biggrin.gif[/img]");
            temp = temp.Replace(":bigstar:", "[img]" + sSmileyAddress + "bigstar.gif[/img]");
            temp = temp.Replace(":bleh:", "[img]" + sSmileyAddress + "bleh.gif[/img]");
            temp = temp.Replace(":blink:", "[img]" + sSmileyAddress + "blink.gif[/img]");
            temp = temp.Replace(":blush:", "[img]" + sSmileyAddress + "blush.gelse if [/img]");
            temp = temp.Replace(":bottom:", "[img]" + sSmileyAddress + "bottom.gif[/img]");
            temp = temp.Replace(":box:", "[img]" + sSmileyAddress + "boxing.gif[/img]");
            temp = temp.Replace(":bira:", "[img]" + sSmileyAddress + "cheers.gif[/img]");
            temp = temp.Replace(":alkis", "[img]" + sSmileyAddress + "clap2.gif[/img]");
            temp = temp.Replace(":yuru", "[img]" + sSmileyAddress + "clapping.gif[/img]");
            temp = temp.Replace(": ?", "[img]" + sSmileyAddress + "closedeyes.gif[/img]");
            temp = temp.Replace(":close_tema:", "[img]" + sSmileyAddress + "close_tema.gif[/img]");
            temp = temp.Replace(":agla2:", "[img]" + sSmileyAddress + "crying.gif[/img]");
            temp = temp.Replace(":bilmm", "[img]" + sSmileyAddress + "dontknow.gif[/img]");
            temp = temp.Replace(":bilmm", "[img]" + sSmileyAddress + "dontknow.gif[/img]");
            temp = temp.Replace(":içelim:", "[img]" + sSmileyAddress + "drunk.gif[/img]");
            temp = temp.Replace(":dry:", "[img]" + sSmileyAddress + "dry.gif[/img]");
            temp = temp.Replace(":ehe", "[img]" + sSmileyAddress + "ehe.gif[/img]");
            temp = temp.Replace(":gun1:", "[img]" + sSmileyAddress + "gun1.gif[/img]");
            temp = temp.Replace(":haha:", "[img]" + sSmileyAddress + "haha.gif[/img]");
            temp = temp.Replace(":cool", "[img]" + sSmileyAddress + "gleam.gif[/img]");
            temp = temp.Replace(":heyo:", "[img]" + sSmileyAddress + "heyo.gif[/img]");
            temp = temp.Replace(":horse:", "[img]" + sSmileyAddress + "horse.gif[/img]");
            temp = temp.Replace(":heyo2:", "[img]" + sSmileyAddress + "kicking.gif[/img]");
            temp = temp.Replace(":op:", "[img]" + sSmileyAddress + "kiss.gif[/img]");
            temp = temp.Replace(":kop:", "[img]" + sSmileyAddress + "kop.gif[/img]");
            temp = temp.Replace(":lamer:", "[img]" + sSmileyAddress + "lamer.gif[/img]");
            temp = temp.Replace(":sos", "[img]" + sSmileyAddress + "help.gif[/img]");
            temp = temp.Replace(":lac:", "[img]" + sSmileyAddress + "lac.gif[/img]");
            temp = temp.Replace(":gul:", "[img]" + sSmileyAddress + "laugh.gif[/img]");
            temp = temp.Replace(":D", "[img]" + sSmileyAddress + "lol2.gif[/img]");
            temp = temp.Replace(":megafon:", "[img]" + sSmileyAddress + "megafon.gif[/img]");
            temp = temp.Replace(":ok2:", "[img]" + sSmileyAddress + "wink.gif[/img]");
            temp = temp.Replace(":worshippy:", "[img]" + sSmileyAddress + "worshippy.gif[/img]");
            temp = temp.Replace(";)", "[img]" + sSmileyAddress + "thumbsup.gif[/img]");
            temp = temp.Replace(":thumbup:", "[img]" + sSmileyAddress + "thumbup.gif[/img]");
            temp = temp.Replace(":seytan:", "[img]" + sSmileyAddress + "twisted.gif[/img]");
            temp = temp.Replace(":10numara:", "[img]" + sSmileyAddress + "victory.gif[/img]");
            temp = temp.Replace(":karisti:", "[img]" + sSmileyAddress + "wacko.gif[/img]");
            temp = temp.Replace(":duvar2:", "[img]" + sSmileyAddress + "wallbash.gif[/img]");
            temp = temp.Replace(":islik", "[img]" + sSmileyAddress + "whistling.gif[/img]");
            temp = temp.Replace(":kirbac:", "[img]" + sSmileyAddress + "whip.gif[/img]");
            temp = temp.Replace(":scooter:", "[img]" + sSmileyAddress + "scooter.gif[/img]");
            temp = temp.Replace(":anlas:", "[img]" + sSmileyAddress + "shake2.gif[/img]");
            temp = temp.Replace(":smartass:", "[img]" + sSmileyAddress + "smartass.gif[/img]");
            temp = temp.Replace(":sopa:", "[img]" + sSmileyAddress + "sopa19.gif[/img]");
            temp = temp.Replace(":oha:", "[img]" + sSmileyAddress + "surprise.gif[/img]");
            temp = temp.Replace(":konus:", "[img]" + sSmileyAddress + "tabletalk.gif[/img]");
            temp = temp.Replace(":kotu:", "[img]" + sSmileyAddress + "thumbdown.gif[/img]");
            temp = temp.Replace(":no:", "[img]" + sSmileyAddress + "no.gif[/img]");
            temp = temp.Replace(":nono:", "[img]" + sSmileyAddress + "nono.gif[/img]");
            temp = temp.Replace(":off:", "[img]" + sSmileyAddress + "off.gif[/img]");
            temp = temp.Replace(":pokey:", "[img]" + sSmileyAddress + "pokey.gif[/img]");
            temp = temp.Replace(":polis:", "[img]" + sSmileyAddress + "polis.gif[/img]");
            temp = temp.Replace(":(", "[img]" + sSmileyAddress + "sad.gif[/img]");
            temp = temp.Replace(":)", "[img]" + sSmileyAddress + "s1.gif[/img]");
            temp = temp.Replace(":pro:", "[img]" + sSmileyAddress + "s15.gif[/img]");
            temp = temp.Replace(":vur", "[img]" + sSmileyAddress + "s20.gif[/img]");
            temp = temp.Replace(":oke:", "[img]" + sSmileyAddress + "s8.gif[/img]");
            temp = temp.Replace(":agla", "[img]" + sSmileyAddress + "s11.gif[/img]");
            temp = temp.Replace(":oku", "[img]" + sSmileyAddress + "s9.gif[/img]");
            temp = temp.Replace(":hakem:", "[img]" + sSmileyAddress + "15818xt.gif[/img]");
            temp = temp.Replace(":oley", "[img]" + sSmileyAddress + "biggrin.gif[/img]");
            temp = temp.Replace(":sinir", "[img]" + sSmileyAddress + "eek.gif[/img]");
            temp = temp.Replace(":lol", "[img]" + sSmileyAddress + "lol.gif[/img]");
            temp = temp.Replace(":utan", "[img]" + sSmileyAddress + "redface.gif[/img]");
            temp = temp.Replace(":spr", "[img]" + sSmileyAddress + "idea.gif[/img]");
            temp = temp.Replace(":zong:", "[img]" + sSmileyAddress + "zong.gif[/img]");
            temp = temp.Replace(":aman2:", "[img]" + sSmileyAddress + "aman2.gif[/img]");
            temp = temp.Replace(":bilmem:", "[img]" + sSmileyAddress + "dontknow2.gif[/img]");
            temp = temp.Replace(":pc:", "[img]" + sSmileyAddress + "sn.gif[/img]");
            temp = temp.Replace(":dgunu:", "[img]" + sSmileyAddress + "birthday.gif[/img]");
            temp = temp.Replace(":coold:", "[img]" + sSmileyAddress + "coold.gif[/img]");
            temp = temp.Replace(":bud:", "[img]" + sSmileyAddress + "bud.gif[/img]");
            temp = temp.Replace(":birak:", "[img]" + sSmileyAddress + "birak.gif[/img]");
            temp = temp.Replace(":pro2:", "[img]" + sSmileyAddress + "pro2.gif[/img]");
            temp = temp.Replace(":sahan:", "[img]" + sSmileyAddress + "sahan.gif[/img]");
            temp = temp.Replace(":sahan2:", "[img]" + sSmileyAddress + "sia.gif[/img]");
            temp = temp.Replace(":korktum:", "[img]" + sSmileyAddress + "aaa.gif[/img]");
            temp = temp.Replace(":alsana:", "[img]" + sSmileyAddress + "alsaa.gif[/img]");
            temp = temp.Replace(":stres:", "[img]" + sSmileyAddress + "bur2.gif[/img]");
            temp = temp.Replace(":bakim:", "[img]" + sSmileyAddress + "construction.gif[/img]");
            temp = temp.Replace(":locked:", "[img]" + sSmileyAddress + "locked.gif[/img]");
            temp = temp.Replace(":naughty:", "[img]" + sSmileyAddress + "naughty.gif[/img]");
            temp = temp.Replace(":kac:", "[img]" + sSmileyAddress + "outtahere.gif[/img]");
            temp = temp.Replace(":sukur:", "[img]" + sSmileyAddress + "pray.gif[/img]");
            temp = temp.Replace(":sofer:", "[img]" + sSmileyAddress + "sofeer.gif[/img]");
            temp = temp.Replace(":huhu:", "[img]" + sSmileyAddress + "us.gif[/img]");
            temp = temp.Replace(":dance:", "[img]" + sSmileyAddress + "dance.gif[/img]");
            temp = temp.Replace(":allalla:", "[img]" + sSmileyAddress + "allalla.gif[/img]");
            temp = temp.Replace(":@", "[img]" + sSmileyAddress + "grr.gif[/img]");
            temp = temp.Replace(":nargile:", "[img]" + sSmileyAddress + "nargile.gif[/img]");
            temp = temp.Replace(":oha2:", "[img]" + sSmileyAddress + "40.gif[/img]");
            temp = temp.Replace(":pasta:", "[img]" + sSmileyAddress + "cook.gif[/img]");
            temp = temp.Replace(":cry:", "[img]" + sSmileyAddress + "cray.gif[/img]");
            temp = temp.Replace(":deal:", "[img]" + sSmileyAddress + "deal.gif[/img]");
            temp = temp.Replace(":destere:", "[img]" + sSmileyAddress + "destere.gif[/img]");
            temp = temp.Replace(":fkr:", "[img]" + sSmileyAddress + "fkr.gif[/img]");
            temp = temp.Replace(":grrr:", "[img]" + sSmileyAddress + "grrr.gif[/img]");
            temp = temp.Replace("o_O", "[img]" + sSmileyAddress + "o_o.gif[/img]");
            temp = temp.Replace(":turkiye:", "[img]" + sSmileyAddress + "turkiye.gif[/img]");
            temp = temp.Replace(":muha:", "[img]" + sSmileyAddress + "muhaha.gif[/img]");
            temp = temp.Replace(":P:", "[img]" + sSmileyAddress + "msn_p.gif[/img]");
            temp = temp.Replace(":walk:", "[img]" + sSmileyAddress + "walking.gif[/img]");
            temp = temp.Replace(":hmmm", "[img]" + sSmileyAddress + "hmmm.gif[/img]");
            temp = temp.Replace(":perde:", "[img]" + sSmileyAddress + "icon_curtain.gif[/img]");
            temp = temp.Replace(":emzik:", "[img]" + sSmileyAddress + "emzik.gif[/img]");
            temp = temp.Replace(":kahve:", "[img]" + sSmileyAddress + "coffee.gif[/img]");
            temp = temp.Replace(":zzz:", "[img]" + sSmileyAddress + "38573.png[/img]");
            temp = temp.Replace(":ohannes:", "[img]" + sSmileyAddress + "ohannes.png[/img]");
            temp = temp.Replace(":hehe:", "[img]" + sSmileyAddress + "hehe.gif[/img]");
            temp = temp.Replace(":eller:", "[img]" + sSmileyAddress + "hinzir.gif[/img]");
            temp = temp.Replace(":kro2:", "[img]" + sSmileyAddress + "kkro2.gif[/img]");
            temp = temp.Replace(":$", "[img]" + sSmileyAddress + "utan.gif[/img]");
            temp = temp.Replace(":cnfsd:", "[img]" + sSmileyAddress + "cnfsd.gif[/img]");
            temp = temp.Replace(":salincak:", "[img]" + sSmileyAddress + "salincak.gif[/img]");
            temp = temp.Replace(":sirit:", "[img]" + sSmileyAddress + "siritan.jpg[/img]");
            temp = temp.Replace(":smdance:", "[img]" + sSmileyAddress + "smiledance.gif[/img]");
            temp = temp.Replace(":mahcup:", "[img]" + sSmileyAddress + "utan22.gif[/img]");
            temp = temp.Replace(":seytan6:", "[img]" + sSmileyAddress + "seytran66.gif[/img]");
            temp = temp.Replace(":kop2:", "[img]" + sSmileyAddress + "hhhz.gif[/img]");
            temp = temp.Replace(":hih:", "[img]" + sSmileyAddress + "hih.gif[/img]");
            temp = temp.Replace(":dover:", "[img]" + sSmileyAddress + "dover.gif[/img]");
            temp = temp.Replace(":good:", "[img]" + sSmileyAddress + "idea.gif[/img]");
            temp = temp.Replace("(h)", "[img]" + sSmileyAddress + "coolh.gif[/img]");
            temp = temp.Replace(":o", "[img]" + sSmileyAddress + "sasir.gif[/img]");
            temp = temp.Replace(":züü:", "[img]" + sSmileyAddress + "20.gif[/img]");
            temp = temp.Replace(":ünlem:", "[img]" + sSmileyAddress + "excl.gif[/img]");
            temp = temp.Replace("(A)", "[img]" + sSmileyAddress + "msn_angel.gif[/img]");
            temp = temp.Replace("(U)", "[img]" + sSmileyAddress + "msn_brokenheart.gif[/img]");
            temp = temp.Replace(":(6):", "[img]" + sSmileyAddress + "msn_demon.gif[/img]");
            temp = temp.Replace(":|", "[img]" + sSmileyAddress + "msn_disappointed.gif[/img]");
            temp = temp.Replace("(L)", "[img]" + sSmileyAddress + "msn_heart.gif[/img]");
            temp = temp.Replace("8-|", "[img]" + sSmileyAddress + "msn_nerd.gif[/img]");
            temp = temp.Replace("<:o)", "[img]" + sSmileyAddress + "msn_party.gif[/img]");
            temp = temp.Replace("8-)", "[img]" + sSmileyAddress + "msn_rolleyes.gif[/img]");
            temp = temp.Replace("+o(", "[img]" + sSmileyAddress + "msn_sick.gif[/img]");
            temp = temp.Replace("|-)", "[img]" + sSmileyAddress + "msn_sleepy.gif[/img]");
            temp = temp.Replace(":d:", "[img]" + sSmileyAddress + "D.gif[/img]");
            temp = temp.Replace(":ağlarım:", "[img]" + sSmileyAddress + "s112.gif[/img]");
            temp = temp.Replace(":sarıl:", "[img]" + sSmileyAddress + "hug.gif[/img]");
            temp = temp.Replace("türkiye1:", "[img]" + sSmileyAddress + "turkiyem.gif[/img]");
            temp = temp.Replace(")):", "[img]" + sSmileyAddress + "yellow(9).gif[/img]");
            temp = temp.Replace(":!!!:", "[img]" + sSmileyAddress + "yellow(30).gif[/img]");
            temp = temp.Replace(":sır:", "[img]" + sSmileyAddress + "yellow(48).gif[/img]");
            temp = temp.Replace(":bye:", "[img]" + sSmileyAddress + "bye.gif[/img]");
            temp = temp.Replace(":nazar:", "[img]" + sSmileyAddress + "nazar.gif[/img]");
            temp = temp.Replace(":firefox:", "[img]" + sSmileyAddress + "firefoxaski.gif[/img]");
            temp = temp.Replace(":bye2:", "[img]" + sSmileyAddress + "bye2.gif[/img]");
            temp = temp.Replace(":aha:", "[img]" + sSmileyAddress + "aboo.gif[/img]");
            temp = temp.Replace(":ban:", "[img]" + sSmileyAddress + "ban.gif[/img]");
            temp = temp.Replace(":bye3:", "[img]" + sSmileyAddress + "bye4.gif[/img]");
            temp = temp.Replace(":çay:", "[img]" + sSmileyAddress + "cay.gif[/img]");
            temp = temp.Replace(":domates:", "[img]" + sSmileyAddress + "domatesat.gif[/img]");
            temp = temp.Replace(":evet:", "[img]" + sSmileyAddress + "evet.gif[/img]");
            temp = temp.Replace(":tebessüm:", "[img]" + sSmileyAddress + "gulumse.png[/img]");
            temp = temp.Replace(":kıskıs:", "[img]" + sSmileyAddress + "kiskis.gif[/img]");
            temp = temp.Replace(":oku:", "[img]" + sSmileyAddress + "kitapoku.gif[/img]");
            temp = temp.Replace(":koş:", "[img]" + sSmileyAddress + "kos2.gif[/img]");
            temp = temp.Replace("!utan!", "[img]" + sSmileyAddress + "utan3.gif[/img]");
            temp = temp.Replace(":utandım:", "[img]" + sSmileyAddress + "utan4.gif[/img]");
            temp = temp.Replace(":trip:", "[img]" + sSmileyAddress + "yaritrip.gif[/img]");
            temp = temp.Replace(":dansöz:", "[img]" + sSmileyAddress + "dansoz.gif[/img]");
            temp = temp.Replace(":hoba:", "[img]" + sSmileyAddress + "horay.gif[/img]");
            temp = temp.Replace("sopa:", "[img]" + sSmileyAddress + "sopa.gif[/img]");
            temp = temp.Replace(":halay1:", "[img]" + sSmileyAddress + "halay1.gif[/img]");
            temp = temp.Replace(":halay2:", "[img]" + sSmileyAddress + "kro_mendil.gif[/img]");
            temp = temp.Replace(":emoamca:", "[img]" + sSmileyAddress + "emodayi.gif[/img]");
            temp = temp.Replace(":halay3:", "[img]" + sSmileyAddress + "halay_mendil.gif[/img]");
            temp = temp.Replace(":zuhaha:", "[img]" + sSmileyAddress + "zuhaha.gif[/img]");
            temp = temp.Replace(":yavrum:", "[img]" + sSmileyAddress + "12.gif[/img]");
            temp = temp.Replace(":bira2:", "[img]" + sSmileyAddress + "bira.gif[/img]");
            temp = temp.Replace(":cigara:", "[img]" + sSmileyAddress + "cigaragif.gif[/img]");
            temp = temp.Replace(":dayak:", "[img]" + sSmileyAddress + "dayak.gif[/img]");
            temp = temp.Replace(":dondum:", "[img]" + sSmileyAddress + "dondum.gif[/img]");
            temp = temp.Replace(":teslimol:", "[img]" + sSmileyAddress + "teslimol.gif[/img]");
            temp = temp.Replace(":hayalet:", "[img]" + sSmileyAddress + "hayalet.gif[/img]");
            temp = temp.Replace(":bablik:", "[img]" + sSmileyAddress + "fishie.gif[/img]");
            temp = temp.Replace(":rock:", "[img]" + sSmileyAddress + "rock.gif[/img]");
            temp = temp.Replace(":havai:", "[img]" + sSmileyAddress + "havai.gif[/img]");
            temp = temp.Replace(":duello:", "[img]" + sSmileyAddress + "duello.gif[/img]");
            temp = temp.Replace(":gunes:", "[img]" + sSmileyAddress + "gunes.gif[/img]");
            temp = temp.Replace(":catcat:", "[img]" + sSmileyAddress + "MsnSlap.gif[/img]");
            temp = temp.Replace(":disko:", "[img]" + sSmileyAddress + "party0023.gif[/img]");
            temp = temp.Replace(":yagmur:", "[img]" + sSmileyAddress + "raincloud.gif[/img]");
            temp = temp.Replace(":tşk:", "[img]" + sSmileyAddress + "xpost_thanks.gif[/img]");
            temp = temp.Replace("somuru:", "[img]" + sSmileyAddress + "ssshn.gif[/img]");
            temp = temp.Replace("<3", "[img]" + sSmileyAddress + "heart.gif[/img]");
            temp = temp.Replace(":rica:", "[img]" + sSmileyAddress + "xpost_rica.gif[/img]");
            temp = temp.Replace(":apple:", "[img]" + sSmileyAddress + "apple.gif[/img]");
            temp = temp.Replace(":tl:", "[img]" + sSmileyAddress + "turklirasi.png[/img]");
            temp = temp.Replace(":locked2:", "[img]" + sSmileyAddress + "locked2.gif[/img]");
            temp = temp.Replace(":’(", "[img]" + sSmileyAddress + "s11.gif[/img]");
            temp = temp.Replace(":p", "[img]" + sSmileyAddress + "tongue.gif[/img]");
            temp = temp.Replace(":S", "[img]" + sSmileyAddress + "abzurt.gif[/img]");
            temp = temp.Replace(":ah", "[img]" + sSmileyAddress + "doh.gif[/img]");

            return temp;
        }
    }
}