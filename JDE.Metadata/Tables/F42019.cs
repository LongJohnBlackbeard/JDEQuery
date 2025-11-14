using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42019 - .
/// </summary>
public class F42019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHKCOO.
        /// </summary>
        public const string SHKCOO = "SHKCOO";

        /// <summary>
        /// SHDOCO.
        /// </summary>
        public const string SHDOCO = "SHDOCO";

        /// <summary>
        /// SHDCTO.
        /// </summary>
        public const string SHDCTO = "SHDCTO";

        /// <summary>
        /// SHSFXO.
        /// </summary>
        public const string SHSFXO = "SHSFXO";

        /// <summary>
        /// SHMCU.
        /// </summary>
        public const string SHMCU = "SHMCU";

        /// <summary>
        /// SHCO.
        /// </summary>
        public const string SHCO = "SHCO";

        /// <summary>
        /// SHOKCO.
        /// </summary>
        public const string SHOKCO = "SHOKCO";

        /// <summary>
        /// SHOORN.
        /// </summary>
        public const string SHOORN = "SHOORN";

        /// <summary>
        /// SHOCTO.
        /// </summary>
        public const string SHOCTO = "SHOCTO";

        /// <summary>
        /// SHRKCO.
        /// </summary>
        public const string SHRKCO = "SHRKCO";

        /// <summary>
        /// SHRORN.
        /// </summary>
        public const string SHRORN = "SHRORN";

        /// <summary>
        /// SHRCTO.
        /// </summary>
        public const string SHRCTO = "SHRCTO";

        /// <summary>
        /// SHAN8.
        /// </summary>
        public const string SHAN8 = "SHAN8";

        /// <summary>
        /// SHSHAN.
        /// </summary>
        public const string SHSHAN = "SHSHAN";

        /// <summary>
        /// SHPA8.
        /// </summary>
        public const string SHPA8 = "SHPA8";

        /// <summary>
        /// SHDRQJ.
        /// </summary>
        public const string SHDRQJ = "SHDRQJ";

        /// <summary>
        /// SHTRDJ.
        /// </summary>
        public const string SHTRDJ = "SHTRDJ";

        /// <summary>
        /// SHPDDJ.
        /// </summary>
        public const string SHPDDJ = "SHPDDJ";

        /// <summary>
        /// SHOPDJ.
        /// </summary>
        public const string SHOPDJ = "SHOPDJ";

        /// <summary>
        /// SHADDJ.
        /// </summary>
        public const string SHADDJ = "SHADDJ";

        /// <summary>
        /// SHCNDJ.
        /// </summary>
        public const string SHCNDJ = "SHCNDJ";

        /// <summary>
        /// SHPEFJ.
        /// </summary>
        public const string SHPEFJ = "SHPEFJ";

        /// <summary>
        /// SHPPDJ.
        /// </summary>
        public const string SHPPDJ = "SHPPDJ";

        /// <summary>
        /// SHVR01.
        /// </summary>
        public const string SHVR01 = "SHVR01";

        /// <summary>
        /// SHVR02.
        /// </summary>
        public const string SHVR02 = "SHVR02";

        /// <summary>
        /// SHDEL1.
        /// </summary>
        public const string SHDEL1 = "SHDEL1";

        /// <summary>
        /// SHDEL2.
        /// </summary>
        public const string SHDEL2 = "SHDEL2";

        /// <summary>
        /// SHINMG.
        /// </summary>
        public const string SHINMG = "SHINMG";

        /// <summary>
        /// SHPTC.
        /// </summary>
        public const string SHPTC = "SHPTC";

        /// <summary>
        /// SHRYIN.
        /// </summary>
        public const string SHRYIN = "SHRYIN";

        /// <summary>
        /// SHASN.
        /// </summary>
        public const string SHASN = "SHASN";

        /// <summary>
        /// SHPRGP.
        /// </summary>
        public const string SHPRGP = "SHPRGP";

        /// <summary>
        /// SHTRDC.
        /// </summary>
        public const string SHTRDC = "SHTRDC";

        /// <summary>
        /// SHPCRT.
        /// </summary>
        public const string SHPCRT = "SHPCRT";

        /// <summary>
        /// SHTXA1.
        /// </summary>
        public const string SHTXA1 = "SHTXA1";

        /// <summary>
        /// SHEXR1.
        /// </summary>
        public const string SHEXR1 = "SHEXR1";

        /// <summary>
        /// SHTXCT.
        /// </summary>
        public const string SHTXCT = "SHTXCT";

        /// <summary>
        /// SHATXT.
        /// </summary>
        public const string SHATXT = "SHATXT";

        /// <summary>
        /// SHPRIO.
        /// </summary>
        public const string SHPRIO = "SHPRIO";

        /// <summary>
        /// SHBACK.
        /// </summary>
        public const string SHBACK = "SHBACK";

        /// <summary>
        /// SHSBAL.
        /// </summary>
        public const string SHSBAL = "SHSBAL";

        /// <summary>
        /// SHHOLD.
        /// </summary>
        public const string SHHOLD = "SHHOLD";

        /// <summary>
        /// SHPLST.
        /// </summary>
        public const string SHPLST = "SHPLST";

        /// <summary>
        /// SHINVC.
        /// </summary>
        public const string SHINVC = "SHINVC";

        /// <summary>
        /// SHNTR.
        /// </summary>
        public const string SHNTR = "SHNTR";

        /// <summary>
        /// SHANBY.
        /// </summary>
        public const string SHANBY = "SHANBY";

        /// <summary>
        /// SHCARS.
        /// </summary>
        public const string SHCARS = "SHCARS";

        /// <summary>
        /// SHMOT.
        /// </summary>
        public const string SHMOT = "SHMOT";

        /// <summary>
        /// SHCOT.
        /// </summary>
        public const string SHCOT = "SHCOT";

        /// <summary>
        /// SHROUT.
        /// </summary>
        public const string SHROUT = "SHROUT";

        /// <summary>
        /// SHSTOP.
        /// </summary>
        public const string SHSTOP = "SHSTOP";

        /// <summary>
        /// SHZON.
        /// </summary>
        public const string SHZON = "SHZON";

        /// <summary>
        /// SHCNID.
        /// </summary>
        public const string SHCNID = "SHCNID";

        /// <summary>
        /// SHFRTH.
        /// </summary>
        public const string SHFRTH = "SHFRTH";

        /// <summary>
        /// SHAFT.
        /// </summary>
        public const string SHAFT = "SHAFT";

        /// <summary>
        /// SHFUF1.
        /// </summary>
        public const string SHFUF1 = "SHFUF1";

        /// <summary>
        /// SHFRTC.
        /// </summary>
        public const string SHFRTC = "SHFRTC";

        /// <summary>
        /// SHMORD.
        /// </summary>
        public const string SHMORD = "SHMORD";

        /// <summary>
        /// SHRCD.
        /// </summary>
        public const string SHRCD = "SHRCD";

        /// <summary>
        /// SHFUF2.
        /// </summary>
        public const string SHFUF2 = "SHFUF2";

        /// <summary>
        /// SHOTOT.
        /// </summary>
        public const string SHOTOT = "SHOTOT";

        /// <summary>
        /// SHTOTC.
        /// </summary>
        public const string SHTOTC = "SHTOTC";

        /// <summary>
        /// SHWUMD.
        /// </summary>
        public const string SHWUMD = "SHWUMD";

        /// <summary>
        /// SHVUMD.
        /// </summary>
        public const string SHVUMD = "SHVUMD";

        /// <summary>
        /// SHAUTN.
        /// </summary>
        public const string SHAUTN = "SHAUTN";

        /// <summary>
        /// SHCACT.
        /// </summary>
        public const string SHCACT = "SHCACT";

        /// <summary>
        /// SHCEXP.
        /// </summary>
        public const string SHCEXP = "SHCEXP";

        /// <summary>
        /// SHSBLI.
        /// </summary>
        public const string SHSBLI = "SHSBLI";

        /// <summary>
        /// SHCRMD.
        /// </summary>
        public const string SHCRMD = "SHCRMD";

        /// <summary>
        /// SHCRRM.
        /// </summary>
        public const string SHCRRM = "SHCRRM";

        /// <summary>
        /// SHCRCD.
        /// </summary>
        public const string SHCRCD = "SHCRCD";

        /// <summary>
        /// SHCRR.
        /// </summary>
        public const string SHCRR = "SHCRR";

        /// <summary>
        /// SHLNGP.
        /// </summary>
        public const string SHLNGP = "SHLNGP";

        /// <summary>
        /// SHFAP.
        /// </summary>
        public const string SHFAP = "SHFAP";

        /// <summary>
        /// SHFCST.
        /// </summary>
        public const string SHFCST = "SHFCST";

        /// <summary>
        /// SHORBY.
        /// </summary>
        public const string SHORBY = "SHORBY";

        /// <summary>
        /// SHTKBY.
        /// </summary>
        public const string SHTKBY = "SHTKBY";

        /// <summary>
        /// SHURCD.
        /// </summary>
        public const string SHURCD = "SHURCD";

        /// <summary>
        /// SHURDT.
        /// </summary>
        public const string SHURDT = "SHURDT";

        /// <summary>
        /// SHURAT.
        /// </summary>
        public const string SHURAT = "SHURAT";

        /// <summary>
        /// SHURAB.
        /// </summary>
        public const string SHURAB = "SHURAB";

        /// <summary>
        /// SHURRF.
        /// </summary>
        public const string SHURRF = "SHURRF";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHTDAY.
        /// </summary>
        public const string SHTDAY = "SHTDAY";

        /// <summary>
        /// SHIR01.
        /// </summary>
        public const string SHIR01 = "SHIR01";

        /// <summary>
        /// SHIR02.
        /// </summary>
        public const string SHIR02 = "SHIR02";

        /// <summary>
        /// SHIR03.
        /// </summary>
        public const string SHIR03 = "SHIR03";

        /// <summary>
        /// SHIR04.
        /// </summary>
        public const string SHIR04 = "SHIR04";

        /// <summary>
        /// SHIR05.
        /// </summary>
        public const string SHIR05 = "SHIR05";

        /// <summary>
        /// SHVR03.
        /// </summary>
        public const string SHVR03 = "SHVR03";

        /// <summary>
        /// SHSOOR.
        /// </summary>
        public const string SHSOOR = "SHSOOR";

        /// <summary>
        /// SHPMDT.
        /// </summary>
        public const string SHPMDT = "SHPMDT";

        /// <summary>
        /// SHRSDT.
        /// </summary>
        public const string SHRSDT = "SHRSDT";

        /// <summary>
        /// SHRQSJ.
        /// </summary>
        public const string SHRQSJ = "SHRQSJ";

        /// <summary>
        /// SHPSTM.
        /// </summary>
        public const string SHPSTM = "SHPSTM";

        /// <summary>
        /// SHPDTT.
        /// </summary>
        public const string SHPDTT = "SHPDTT";

        /// <summary>
        /// SHOPTT.
        /// </summary>
        public const string SHOPTT = "SHOPTT";

        /// <summary>
        /// SHDRQT.
        /// </summary>
        public const string SHDRQT = "SHDRQT";

        /// <summary>
        /// SHADTM.
        /// </summary>
        public const string SHADTM = "SHADTM";

        /// <summary>
        /// SHADLJ.
        /// </summary>
        public const string SHADLJ = "SHADLJ";

        /// <summary>
        /// SHPBAN.
        /// </summary>
        public const string SHPBAN = "SHPBAN";

        /// <summary>
        /// SHITAN.
        /// </summary>
        public const string SHITAN = "SHITAN";

        /// <summary>
        /// SHFTAN.
        /// </summary>
        public const string SHFTAN = "SHFTAN";

        /// <summary>
        /// SHDVAN.
        /// </summary>
        public const string SHDVAN = "SHDVAN";

        /// <summary>
        /// SHDOC1.
        /// </summary>
        public const string SHDOC1 = "SHDOC1";

        /// <summary>
        /// SHDCT4.
        /// </summary>
        public const string SHDCT4 = "SHDCT4";

        /// <summary>
        /// SHCORD.
        /// </summary>
        public const string SHCORD = "SHCORD";

        /// <summary>
        /// SHBSC.
        /// </summary>
        public const string SHBSC = "SHBSC";

        /// <summary>
        /// SHBCRC.
        /// </summary>
        public const string SHBCRC = "SHBCRC";

        /// <summary>
        /// SHAUFT.
        /// </summary>
        public const string SHAUFT = "SHAUFT";

        /// <summary>
        /// SHAUFI.
        /// </summary>
        public const string SHAUFI = "SHAUFI";

        /// <summary>
        /// SHOPBO.
        /// </summary>
        public const string SHOPBO = "SHOPBO";

        /// <summary>
        /// SHOPTC.
        /// </summary>
        public const string SHOPTC = "SHOPTC";

        /// <summary>
        /// SHOPLD.
        /// </summary>
        public const string SHOPLD = "SHOPLD";

        /// <summary>
        /// SHOPBK.
        /// </summary>
        public const string SHOPBK = "SHOPBK";

        /// <summary>
        /// SHOPSB.
        /// </summary>
        public const string SHOPSB = "SHOPSB";

        /// <summary>
        /// SHOPPS.
        /// </summary>
        public const string SHOPPS = "SHOPPS";

        /// <summary>
        /// SHOPPL.
        /// </summary>
        public const string SHOPPL = "SHOPPL";

        /// <summary>
        /// SHOPMS.
        /// </summary>
        public const string SHOPMS = "SHOPMS";

        /// <summary>
        /// SHOPSS.
        /// </summary>
        public const string SHOPSS = "SHOPSS";

        /// <summary>
        /// SHOPBA.
        /// </summary>
        public const string SHOPBA = "SHOPBA";

        /// <summary>
        /// SHOPLL.
        /// </summary>
        public const string SHOPLL = "SHOPLL";

        /// <summary>
        /// SHPRAN8.
        /// </summary>
        public const string SHPRAN8 = "SHPRAN8";

        /// <summary>
        /// SHOPPID.
        /// </summary>
        public const string SHOPPID = "SHOPPID";

        /// <summary>
        /// SHSDATTN.
        /// </summary>
        public const string SHSDATTN = "SHSDATTN";

        /// <summary>
        /// SHSPATTN.
        /// </summary>
        public const string SHSPATTN = "SHSPATTN";

        /// <summary>
        /// SHOTIND.
        /// </summary>
        public const string SHOTIND = "SHOTIND";

        /// <summary>
        /// SHPRCIDLN.
        /// </summary>
        public const string SHPRCIDLN = "SHPRCIDLN";

        /// <summary>
        /// SHCCIDLN.
        /// </summary>
        public const string SHCCIDLN = "SHCCIDLN";

        /// <summary>
        /// SHSHCCIDLN.
        /// </summary>
        public const string SHSHCCIDLN = "SHSHCCIDLN";
    }

    /// <inheritdoc />
    public override string TableName => "F42019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHKCOO", "SHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SHDOCO", "SHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SHDCTO", "SHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SHSFXO", "SHSFXO", JdeDataType.String, 6),
        new JdeField("SHMCU", "SHMCU", JdeDataType.String, 24),
        new JdeField("SHCO", "SHCO", JdeDataType.String, 10),
        new JdeField("SHOKCO", "SHOKCO", JdeDataType.String, 10),
        new JdeField("SHOORN", "SHOORN", JdeDataType.String, 16),
        new JdeField("SHOCTO", "SHOCTO", JdeDataType.String, 4),
        new JdeField("SHRKCO", "SHRKCO", JdeDataType.String, 10),
        new JdeField("SHRORN", "SHRORN", JdeDataType.String, 16),
        new JdeField("SHRCTO", "SHRCTO", JdeDataType.String, 4),
        new JdeField("SHAN8", "SHAN8", JdeDataType.Numeric),
        new JdeField("SHSHAN", "SHSHAN", JdeDataType.Numeric),
        new JdeField("SHPA8", "SHPA8", JdeDataType.Numeric),
        new JdeField("SHDRQJ", "SHDRQJ", JdeDataType.Numeric),
        new JdeField("SHTRDJ", "SHTRDJ", JdeDataType.Numeric),
        new JdeField("SHPDDJ", "SHPDDJ", JdeDataType.Numeric),
        new JdeField("SHOPDJ", "SHOPDJ", JdeDataType.Numeric),
        new JdeField("SHADDJ", "SHADDJ", JdeDataType.Numeric),
        new JdeField("SHCNDJ", "SHCNDJ", JdeDataType.Numeric),
        new JdeField("SHPEFJ", "SHPEFJ", JdeDataType.Numeric),
        new JdeField("SHPPDJ", "SHPPDJ", JdeDataType.Numeric),
        new JdeField("SHVR01", "SHVR01", JdeDataType.String, 50),
        new JdeField("SHVR02", "SHVR02", JdeDataType.String, 50),
        new JdeField("SHDEL1", "SHDEL1", JdeDataType.String, 60),
        new JdeField("SHDEL2", "SHDEL2", JdeDataType.String, 60),
        new JdeField("SHINMG", "SHINMG", JdeDataType.String, 20),
        new JdeField("SHPTC", "SHPTC", JdeDataType.String, 6),
        new JdeField("SHRYIN", "SHRYIN", JdeDataType.String, 2),
        new JdeField("SHASN", "SHASN", JdeDataType.String, 16),
        new JdeField("SHPRGP", "SHPRGP", JdeDataType.String, 16),
        new JdeField("SHTRDC", "SHTRDC", JdeDataType.Numeric),
        new JdeField("SHPCRT", "SHPCRT", JdeDataType.Numeric),
        new JdeField("SHTXA1", "SHTXA1", JdeDataType.String, 20),
        new JdeField("SHEXR1", "SHEXR1", JdeDataType.String, 4),
        new JdeField("SHTXCT", "SHTXCT", JdeDataType.String, 40),
        new JdeField("SHATXT", "SHATXT", JdeDataType.String, 2),
        new JdeField("SHPRIO", "SHPRIO", JdeDataType.String, 2),
        new JdeField("SHBACK", "SHBACK", JdeDataType.String, 2),
        new JdeField("SHSBAL", "SHSBAL", JdeDataType.String, 2),
        new JdeField("SHHOLD", "SHHOLD", JdeDataType.String, 4),
        new JdeField("SHPLST", "SHPLST", JdeDataType.String, 2),
        new JdeField("SHINVC", "SHINVC", JdeDataType.Numeric),
        new JdeField("SHNTR", "SHNTR", JdeDataType.String, 4),
        new JdeField("SHANBY", "SHANBY", JdeDataType.Numeric),
        new JdeField("SHCARS", "SHCARS", JdeDataType.Numeric),
        new JdeField("SHMOT", "SHMOT", JdeDataType.String, 6),
        new JdeField("SHCOT", "SHCOT", JdeDataType.String, 6),
        new JdeField("SHROUT", "SHROUT", JdeDataType.String, 6),
        new JdeField("SHSTOP", "SHSTOP", JdeDataType.String, 6),
        new JdeField("SHZON", "SHZON", JdeDataType.String, 6),
        new JdeField("SHCNID", "SHCNID", JdeDataType.String, 40),
        new JdeField("SHFRTH", "SHFRTH", JdeDataType.String, 6),
        new JdeField("SHAFT", "SHAFT", JdeDataType.String, 2),
        new JdeField("SHFUF1", "SHFUF1", JdeDataType.String, 2),
        new JdeField("SHFRTC", "SHFRTC", JdeDataType.String, 2),
        new JdeField("SHMORD", "SHMORD", JdeDataType.String, 2),
        new JdeField("SHRCD", "SHRCD", JdeDataType.String, 6),
        new JdeField("SHFUF2", "SHFUF2", JdeDataType.String, 2),
        new JdeField("SHOTOT", "SHOTOT", JdeDataType.Numeric),
        new JdeField("SHTOTC", "SHTOTC", JdeDataType.Numeric),
        new JdeField("SHWUMD", "SHWUMD", JdeDataType.String, 4),
        new JdeField("SHVUMD", "SHVUMD", JdeDataType.String, 4),
        new JdeField("SHAUTN", "SHAUTN", JdeDataType.String, 20),
        new JdeField("SHCACT", "SHCACT", JdeDataType.String, 50),
        new JdeField("SHCEXP", "SHCEXP", JdeDataType.Numeric),
        new JdeField("SHSBLI", "SHSBLI", JdeDataType.String, 2),
        new JdeField("SHCRMD", "SHCRMD", JdeDataType.String, 2),
        new JdeField("SHCRRM", "SHCRRM", JdeDataType.String, 2),
        new JdeField("SHCRCD", "SHCRCD", JdeDataType.String, 6),
        new JdeField("SHCRR", "SHCRR", JdeDataType.Numeric),
        new JdeField("SHLNGP", "SHLNGP", JdeDataType.String, 4),
        new JdeField("SHFAP", "SHFAP", JdeDataType.Numeric),
        new JdeField("SHFCST", "SHFCST", JdeDataType.Numeric),
        new JdeField("SHORBY", "SHORBY", JdeDataType.String, 20),
        new JdeField("SHTKBY", "SHTKBY", JdeDataType.String, 20),
        new JdeField("SHURCD", "SHURCD", JdeDataType.String, 4),
        new JdeField("SHURDT", "SHURDT", JdeDataType.Numeric),
        new JdeField("SHURAT", "SHURAT", JdeDataType.Numeric),
        new JdeField("SHURAB", "SHURAB", JdeDataType.Numeric),
        new JdeField("SHURRF", "SHURRF", JdeDataType.String, 30),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHTDAY", "SHTDAY", JdeDataType.Numeric),
        new JdeField("SHIR01", "SHIR01", JdeDataType.String, 60),
        new JdeField("SHIR02", "SHIR02", JdeDataType.String, 60),
        new JdeField("SHIR03", "SHIR03", JdeDataType.String, 60),
        new JdeField("SHIR04", "SHIR04", JdeDataType.String, 60),
        new JdeField("SHIR05", "SHIR05", JdeDataType.String, 60),
        new JdeField("SHVR03", "SHVR03", JdeDataType.String, 50),
        new JdeField("SHSOOR", "SHSOOR", JdeDataType.Numeric),
        new JdeField("SHPMDT", "SHPMDT", JdeDataType.Numeric),
        new JdeField("SHRSDT", "SHRSDT", JdeDataType.Numeric),
        new JdeField("SHRQSJ", "SHRQSJ", JdeDataType.Numeric),
        new JdeField("SHPSTM", "SHPSTM", JdeDataType.Numeric),
        new JdeField("SHPDTT", "SHPDTT", JdeDataType.Numeric),
        new JdeField("SHOPTT", "SHOPTT", JdeDataType.Numeric),
        new JdeField("SHDRQT", "SHDRQT", JdeDataType.Numeric),
        new JdeField("SHADTM", "SHADTM", JdeDataType.Numeric),
        new JdeField("SHADLJ", "SHADLJ", JdeDataType.Numeric),
        new JdeField("SHPBAN", "SHPBAN", JdeDataType.Numeric),
        new JdeField("SHITAN", "SHITAN", JdeDataType.Numeric),
        new JdeField("SHFTAN", "SHFTAN", JdeDataType.Numeric),
        new JdeField("SHDVAN", "SHDVAN", JdeDataType.Numeric),
        new JdeField("SHDOC1", "SHDOC1", JdeDataType.Numeric),
        new JdeField("SHDCT4", "SHDCT4", JdeDataType.String, 4),
        new JdeField("SHCORD", "SHCORD", JdeDataType.Numeric),
        new JdeField("SHBSC", "SHBSC", JdeDataType.String, 20),
        new JdeField("SHBCRC", "SHBCRC", JdeDataType.String, 6),
        new JdeField("SHAUFT", "SHAUFT", JdeDataType.String, 2),
        new JdeField("SHAUFI", "SHAUFI", JdeDataType.String, 2),
        new JdeField("SHOPBO", "SHOPBO", JdeDataType.String, 60),
        new JdeField("SHOPTC", "SHOPTC", JdeDataType.Numeric),
        new JdeField("SHOPLD", "SHOPLD", JdeDataType.Numeric),
        new JdeField("SHOPBK", "SHOPBK", JdeDataType.Numeric),
        new JdeField("SHOPSB", "SHOPSB", JdeDataType.Numeric),
        new JdeField("SHOPPS", "SHOPPS", JdeDataType.String, 60),
        new JdeField("SHOPPL", "SHOPPL", JdeDataType.String, 2),
        new JdeField("SHOPMS", "SHOPMS", JdeDataType.String, 2),
        new JdeField("SHOPSS", "SHOPSS", JdeDataType.String, 2),
        new JdeField("SHOPBA", "SHOPBA", JdeDataType.String, 2),
        new JdeField("SHOPLL", "SHOPLL", JdeDataType.String, 2),
        new JdeField("SHPRAN8", "SHPRAN8", JdeDataType.Numeric),
        new JdeField("SHOPPID", "SHOPPID", JdeDataType.Numeric),
        new JdeField("SHSDATTN", "SHSDATTN", JdeDataType.String, 100),
        new JdeField("SHSPATTN", "SHSPATTN", JdeDataType.String, 100),
        new JdeField("SHOTIND", "SHOTIND", JdeDataType.String, 2),
        new JdeField("SHPRCIDLN", "SHPRCIDLN", JdeDataType.Numeric),
        new JdeField("SHCCIDLN", "SHCCIDLN", JdeDataType.Numeric),
        new JdeField("SHSHCCIDLN", "SHSHCCIDLN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42019_0", "Primary Key on SHDOCO, SHDCTO, SHKCOO", new[] { "SHDOCO", "SHDCTO", "SHKCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42019_2", "Index on SHVR01, SHAN8", new[] { "SHVR01", "SHAN8" }),
        new JdeIndex("F42019_3", "Index on SHDCTO", new[] { "SHDCTO" }),
        new JdeIndex("F42019_4", "Index on SHAN8, SYS_NC00134$, SYS_NC00135$", new[] { "SHAN8", "SYS_NC00134$", "SYS_NC00135$" })
    };
}
