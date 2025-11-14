using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48710 - .
/// </summary>
public class F48710 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTUKID.
        /// </summary>
        public const string WTUKID = "WTUKID";

        /// <summary>
        /// WTTMPNA.
        /// </summary>
        public const string WTTMPNA = "WTTMPNA";

        /// <summary>
        /// WTTMPDSC.
        /// </summary>
        public const string WTTMPDSC = "WTTMPDSC";

        /// <summary>
        /// WTHIDEPLN.
        /// </summary>
        public const string WTHIDEPLN = "WTHIDEPLN";

        /// <summary>
        /// WTHIDEORD.
        /// </summary>
        public const string WTHIDEORD = "WTHIDEORD";

        /// <summary>
        /// WTHIDECAT.
        /// </summary>
        public const string WTHIDECAT = "WTHIDECAT";

        /// <summary>
        /// WTHIDECLS.
        /// </summary>
        public const string WTHIDECLS = "WTHIDECLS";

        /// <summary>
        /// WTHIDEACC.
        /// </summary>
        public const string WTHIDEACC = "WTHIDEACC";

        /// <summary>
        /// WTSRST.
        /// </summary>
        public const string WTSRST = "WTSRST";

        /// <summary>
        /// WTDISST.
        /// </summary>
        public const string WTDISST = "WTDISST";

        /// <summary>
        /// WTSTCM.
        /// </summary>
        public const string WTSTCM = "WTSTCM";

        /// <summary>
        /// WTDISSTCOM.
        /// </summary>
        public const string WTDISSTCOM = "WTDISSTCOM";

        /// <summary>
        /// WTPC.
        /// </summary>
        public const string WTPC = "WTPC";

        /// <summary>
        /// WTDISPC.
        /// </summary>
        public const string WTDISPC = "WTDISPC";

        /// <summary>
        /// WTDPL.
        /// </summary>
        public const string WTDPL = "WTDPL";

        /// <summary>
        /// WTDISRFD.
        /// </summary>
        public const string WTDISRFD = "WTDISRFD";

        /// <summary>
        /// WTSTRT.
        /// </summary>
        public const string WTSTRT = "WTSTRT";

        /// <summary>
        /// WTDISPSD.
        /// </summary>
        public const string WTDISPSD = "WTDISPSD";

        /// <summary>
        /// WTDRQJ.
        /// </summary>
        public const string WTDRQJ = "WTDRQJ";

        /// <summary>
        /// WTDISPFD.
        /// </summary>
        public const string WTDISPFD = "WTDISPFD";

        /// <summary>
        /// WTSTRX.
        /// </summary>
        public const string WTSTRX = "WTSTRX";

        /// <summary>
        /// WTDISAFD.
        /// </summary>
        public const string WTDISAFD = "WTDISAFD";

        /// <summary>
        /// WTANSA.
        /// </summary>
        public const string WTANSA = "WTANSA";

        /// <summary>
        /// WTDISMGR.
        /// </summary>
        public const string WTDISMGR = "WTDISMGR";

        /// <summary>
        /// WTMCULT.
        /// </summary>
        public const string WTMCULT = "WTMCULT";

        /// <summary>
        /// WTDISLC.
        /// </summary>
        public const string WTDISLC = "WTDISLC";

        /// <summary>
        /// WTANP.
        /// </summary>
        public const string WTANP = "WTANP";

        /// <summary>
        /// WTDISATO.
        /// </summary>
        public const string WTDISATO = "WTDISATO";

        /// <summary>
        /// WTANT.
        /// </summary>
        public const string WTANT = "WTANT";

        /// <summary>
        /// WTDISINS.
        /// </summary>
        public const string WTDISINS = "WTDISINS";

        /// <summary>
        /// WTANO.
        /// </summary>
        public const string WTANO = "WTANO";

        /// <summary>
        /// WTDISORG.
        /// </summary>
        public const string WTDISORG = "WTDISORG";

        /// <summary>
        /// WTANPA.
        /// </summary>
        public const string WTANPA = "WTANPA";

        /// <summary>
        /// WTDISSUP.
        /// </summary>
        public const string WTDISSUP = "WTDISSUP";

        /// <summary>
        /// WTDCTO.
        /// </summary>
        public const string WTDCTO = "WTDCTO";

        /// <summary>
        /// WTDISOTY.
        /// </summary>
        public const string WTDISOTY = "WTDISOTY";

        /// <summary>
        /// WTTYPS.
        /// </summary>
        public const string WTTYPS = "WTTYPS";

        /// <summary>
        /// WTDISWOTY.
        /// </summary>
        public const string WTDISWOTY = "WTDISWOTY";

        /// <summary>
        /// WTAN8.
        /// </summary>
        public const string WTAN8 = "WTAN8";

        /// <summary>
        /// WTDISCUS.
        /// </summary>
        public const string WTDISCUS = "WTDISCUS";

        /// <summary>
        /// WTSAID.
        /// </summary>
        public const string WTSAID = "WTSAID";

        /// <summary>
        /// WTDISSNO.
        /// </summary>
        public const string WTDISSNO = "WTDISSNO";

        /// <summary>
        /// WTDL01.
        /// </summary>
        public const string WTDL01 = "WTDL01";

        /// <summary>
        /// WTDISDL01.
        /// </summary>
        public const string WTDISDL01 = "WTDISDL01";

        /// <summary>
        /// WTWR01.
        /// </summary>
        public const string WTWR01 = "WTWR01";

        /// <summary>
        /// WTDISCC1.
        /// </summary>
        public const string WTDISCC1 = "WTDISCC1";

        /// <summary>
        /// WTWR02.
        /// </summary>
        public const string WTWR02 = "WTWR02";

        /// <summary>
        /// WTDISCC2.
        /// </summary>
        public const string WTDISCC2 = "WTDISCC2";

        /// <summary>
        /// WTWR03.
        /// </summary>
        public const string WTWR03 = "WTWR03";

        /// <summary>
        /// WTDISCC3.
        /// </summary>
        public const string WTDISCC3 = "WTDISCC3";

        /// <summary>
        /// WTWR04.
        /// </summary>
        public const string WTWR04 = "WTWR04";

        /// <summary>
        /// WTDISCC4.
        /// </summary>
        public const string WTDISCC4 = "WTDISCC4";

        /// <summary>
        /// WTWR05.
        /// </summary>
        public const string WTWR05 = "WTWR05";

        /// <summary>
        /// WTDISCC5.
        /// </summary>
        public const string WTDISCC5 = "WTDISCC5";

        /// <summary>
        /// WTWR06.
        /// </summary>
        public const string WTWR06 = "WTWR06";

        /// <summary>
        /// WTDISCC6.
        /// </summary>
        public const string WTDISCC6 = "WTDISCC6";

        /// <summary>
        /// WTWR07.
        /// </summary>
        public const string WTWR07 = "WTWR07";

        /// <summary>
        /// WTDISCC7.
        /// </summary>
        public const string WTDISCC7 = "WTDISCC7";

        /// <summary>
        /// WTWR08.
        /// </summary>
        public const string WTWR08 = "WTWR08";

        /// <summary>
        /// WTDISCC8.
        /// </summary>
        public const string WTDISCC8 = "WTDISCC8";

        /// <summary>
        /// WTWR09.
        /// </summary>
        public const string WTWR09 = "WTWR09";

        /// <summary>
        /// WTDISCC9.
        /// </summary>
        public const string WTDISCC9 = "WTDISCC9";

        /// <summary>
        /// WTWR10.
        /// </summary>
        public const string WTWR10 = "WTWR10";

        /// <summary>
        /// WTDISCC10.
        /// </summary>
        public const string WTDISCC10 = "WTDISCC10";

        /// <summary>
        /// WTWR11.
        /// </summary>
        public const string WTWR11 = "WTWR11";

        /// <summary>
        /// WTDISCC11.
        /// </summary>
        public const string WTDISCC11 = "WTDISCC11";

        /// <summary>
        /// WTWR12.
        /// </summary>
        public const string WTWR12 = "WTWR12";

        /// <summary>
        /// WTDISCC12.
        /// </summary>
        public const string WTDISCC12 = "WTDISCC12";

        /// <summary>
        /// WTWR13.
        /// </summary>
        public const string WTWR13 = "WTWR13";

        /// <summary>
        /// WTDISCC13.
        /// </summary>
        public const string WTDISCC13 = "WTDISCC13";

        /// <summary>
        /// WTWR14.
        /// </summary>
        public const string WTWR14 = "WTWR14";

        /// <summary>
        /// WTDISCC14.
        /// </summary>
        public const string WTDISCC14 = "WTDISCC14";

        /// <summary>
        /// WTWR15.
        /// </summary>
        public const string WTWR15 = "WTWR15";

        /// <summary>
        /// WTDISCC15.
        /// </summary>
        public const string WTDISCC15 = "WTDISCC15";

        /// <summary>
        /// WTWR16.
        /// </summary>
        public const string WTWR16 = "WTWR16";

        /// <summary>
        /// WTDISCC16.
        /// </summary>
        public const string WTDISCC16 = "WTDISCC16";

        /// <summary>
        /// WTWR17.
        /// </summary>
        public const string WTWR17 = "WTWR17";

        /// <summary>
        /// WTDISCC17.
        /// </summary>
        public const string WTDISCC17 = "WTDISCC17";

        /// <summary>
        /// WTWR18.
        /// </summary>
        public const string WTWR18 = "WTWR18";

        /// <summary>
        /// WTDISCC18.
        /// </summary>
        public const string WTDISCC18 = "WTDISCC18";

        /// <summary>
        /// WTWR19.
        /// </summary>
        public const string WTWR19 = "WTWR19";

        /// <summary>
        /// WTDISCC19.
        /// </summary>
        public const string WTDISCC19 = "WTDISCC19";

        /// <summary>
        /// WTWR20.
        /// </summary>
        public const string WTWR20 = "WTWR20";

        /// <summary>
        /// WTDISCC20.
        /// </summary>
        public const string WTDISCC20 = "WTDISCC20";

        /// <summary>
        /// WTPRTS.
        /// </summary>
        public const string WTPRTS = "WTPRTS";

        /// <summary>
        /// WTDISPRI.
        /// </summary>
        public const string WTDISPRI = "WTDISPRI";

        /// <summary>
        /// WTREGION.
        /// </summary>
        public const string WTREGION = "WTREGION";

        /// <summary>
        /// WTDISGR.
        /// </summary>
        public const string WTDISGR = "WTDISGR";

        /// <summary>
        /// WTSPRT.
        /// </summary>
        public const string WTSPRT = "WTSPRT";

        /// <summary>
        /// WTDISWOMSG.
        /// </summary>
        public const string WTDISWOMSG = "WTDISWOMSG";

        /// <summary>
        /// WTPARS.
        /// </summary>
        public const string WTPARS = "WTPARS";

        /// <summary>
        /// WTDISPARWO.
        /// </summary>
        public const string WTDISPARWO = "WTDISPARWO";

        /// <summary>
        /// WTSHNO.
        /// </summary>
        public const string WTSHNO = "WTSHNO";

        /// <summary>
        /// WTDISSHNO.
        /// </summary>
        public const string WTDISSHNO = "WTDISSHNO";

        /// <summary>
        /// WTVR01.
        /// </summary>
        public const string WTVR01 = "WTVR01";

        /// <summary>
        /// WTDISVR01.
        /// </summary>
        public const string WTDISVR01 = "WTDISVR01";

        /// <summary>
        /// WTTBM.
        /// </summary>
        public const string WTTBM = "WTTBM";

        /// <summary>
        /// WTDISTBM.
        /// </summary>
        public const string WTDISTBM = "WTDISTBM";

        /// <summary>
        /// WTTRT.
        /// </summary>
        public const string WTTRT = "WTTRT";

        /// <summary>
        /// WTDISTRT.
        /// </summary>
        public const string WTDISTRT = "WTDISTRT";

        /// <summary>
        /// WTUNCD.
        /// </summary>
        public const string WTUNCD = "WTUNCD";

        /// <summary>
        /// WTDISUNCD.
        /// </summary>
        public const string WTDISUNCD = "WTDISUNCD";

        /// <summary>
        /// WTMCU.
        /// </summary>
        public const string WTMCU = "WTMCU";

        /// <summary>
        /// WTDISBU.
        /// </summary>
        public const string WTDISBU = "WTDISBU";

        /// <summary>
        /// WTSUB.
        /// </summary>
        public const string WTSUB = "WTSUB";

        /// <summary>
        /// WTDISSUB.
        /// </summary>
        public const string WTDISSUB = "WTDISSUB";

        /// <summary>
        /// WTSBLI.
        /// </summary>
        public const string WTSBLI = "WTSBLI";

        /// <summary>
        /// WTDISSIC.
        /// </summary>
        public const string WTDISSIC = "WTDISSIC";

        /// <summary>
        /// WTGLCCV.
        /// </summary>
        public const string WTGLCCV = "WTGLCCV";

        /// <summary>
        /// WTDISGLC.
        /// </summary>
        public const string WTDISGLC = "WTDISGLC";

        /// <summary>
        /// WTGLCNC.
        /// </summary>
        public const string WTGLCNC = "WTGLCNC";

        /// <summary>
        /// WTDISNCGLC.
        /// </summary>
        public const string WTDISNCGLC = "WTDISNCGLC";

        /// <summary>
        /// WTMMCU.
        /// </summary>
        public const string WTMMCU = "WTMMCU";

        /// <summary>
        /// WTDISBRA.
        /// </summary>
        public const string WTDISBRA = "WTDISBRA";

        /// <summary>
        /// WTHIDEPEP.
        /// </summary>
        public const string WTHIDEPEP = "WTHIDEPEP";

        /// <summary>
        /// WTPID.
        /// </summary>
        public const string WTPID = "WTPID";

        /// <summary>
        /// WTUSER.
        /// </summary>
        public const string WTUSER = "WTUSER";

        /// <summary>
        /// WTMKEY.
        /// </summary>
        public const string WTMKEY = "WTMKEY";

        /// <summary>
        /// WTUPMJ.
        /// </summary>
        public const string WTUPMJ = "WTUPMJ";

        /// <summary>
        /// WTUPMT.
        /// </summary>
        public const string WTUPMT = "WTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48710";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTUKID", "WTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WTTMPNA", "WTTMPNA", JdeDataType.String, 40),
        new JdeField("WTTMPDSC", "WTTMPDSC", JdeDataType.String, 120),
        new JdeField("WTHIDEPLN", "WTHIDEPLN", JdeDataType.String, 2),
        new JdeField("WTHIDEORD", "WTHIDEORD", JdeDataType.String, 2),
        new JdeField("WTHIDECAT", "WTHIDECAT", JdeDataType.String, 2),
        new JdeField("WTHIDECLS", "WTHIDECLS", JdeDataType.String, 2),
        new JdeField("WTHIDEACC", "WTHIDEACC", JdeDataType.String, 2),
        new JdeField("WTSRST", "WTSRST", JdeDataType.String, 4),
        new JdeField("WTDISST", "WTDISST", JdeDataType.String, 2),
        new JdeField("WTSTCM", "WTSTCM", JdeDataType.String, 60),
        new JdeField("WTDISSTCOM", "WTDISSTCOM", JdeDataType.String, 2),
        new JdeField("WTPC", "WTPC", JdeDataType.Numeric),
        new JdeField("WTDISPC", "WTDISPC", JdeDataType.String, 2),
        new JdeField("WTDPL", "WTDPL", JdeDataType.Numeric),
        new JdeField("WTDISRFD", "WTDISRFD", JdeDataType.String, 2),
        new JdeField("WTSTRT", "WTSTRT", JdeDataType.Numeric),
        new JdeField("WTDISPSD", "WTDISPSD", JdeDataType.String, 2),
        new JdeField("WTDRQJ", "WTDRQJ", JdeDataType.Numeric),
        new JdeField("WTDISPFD", "WTDISPFD", JdeDataType.String, 2),
        new JdeField("WTSTRX", "WTSTRX", JdeDataType.Numeric),
        new JdeField("WTDISAFD", "WTDISAFD", JdeDataType.String, 2),
        new JdeField("WTANSA", "WTANSA", JdeDataType.Numeric),
        new JdeField("WTDISMGR", "WTDISMGR", JdeDataType.String, 2),
        new JdeField("WTMCULT", "WTMCULT", JdeDataType.String, 24),
        new JdeField("WTDISLC", "WTDISLC", JdeDataType.String, 2),
        new JdeField("WTANP", "WTANP", JdeDataType.Numeric),
        new JdeField("WTDISATO", "WTDISATO", JdeDataType.String, 2),
        new JdeField("WTANT", "WTANT", JdeDataType.Numeric),
        new JdeField("WTDISINS", "WTDISINS", JdeDataType.String, 2),
        new JdeField("WTANO", "WTANO", JdeDataType.Numeric),
        new JdeField("WTDISORG", "WTDISORG", JdeDataType.String, 2),
        new JdeField("WTANPA", "WTANPA", JdeDataType.Numeric),
        new JdeField("WTDISSUP", "WTDISSUP", JdeDataType.String, 2),
        new JdeField("WTDCTO", "WTDCTO", JdeDataType.String, 4),
        new JdeField("WTDISOTY", "WTDISOTY", JdeDataType.String, 2),
        new JdeField("WTTYPS", "WTTYPS", JdeDataType.String, 2),
        new JdeField("WTDISWOTY", "WTDISWOTY", JdeDataType.String, 2),
        new JdeField("WTAN8", "WTAN8", JdeDataType.Numeric),
        new JdeField("WTDISCUS", "WTDISCUS", JdeDataType.String, 2),
        new JdeField("WTSAID", "WTSAID", JdeDataType.Numeric),
        new JdeField("WTDISSNO", "WTDISSNO", JdeDataType.String, 2),
        new JdeField("WTDL01", "WTDL01", JdeDataType.String, 60),
        new JdeField("WTDISDL01", "WTDISDL01", JdeDataType.String, 2),
        new JdeField("WTWR01", "WTWR01", JdeDataType.String, 8),
        new JdeField("WTDISCC1", "WTDISCC1", JdeDataType.String, 2),
        new JdeField("WTWR02", "WTWR02", JdeDataType.String, 6),
        new JdeField("WTDISCC2", "WTDISCC2", JdeDataType.String, 2),
        new JdeField("WTWR03", "WTWR03", JdeDataType.String, 6),
        new JdeField("WTDISCC3", "WTDISCC3", JdeDataType.String, 2),
        new JdeField("WTWR04", "WTWR04", JdeDataType.String, 6),
        new JdeField("WTDISCC4", "WTDISCC4", JdeDataType.String, 2),
        new JdeField("WTWR05", "WTWR05", JdeDataType.String, 6),
        new JdeField("WTDISCC5", "WTDISCC5", JdeDataType.String, 2),
        new JdeField("WTWR06", "WTWR06", JdeDataType.String, 6),
        new JdeField("WTDISCC6", "WTDISCC6", JdeDataType.String, 2),
        new JdeField("WTWR07", "WTWR07", JdeDataType.String, 6),
        new JdeField("WTDISCC7", "WTDISCC7", JdeDataType.String, 2),
        new JdeField("WTWR08", "WTWR08", JdeDataType.String, 6),
        new JdeField("WTDISCC8", "WTDISCC8", JdeDataType.String, 2),
        new JdeField("WTWR09", "WTWR09", JdeDataType.String, 6),
        new JdeField("WTDISCC9", "WTDISCC9", JdeDataType.String, 2),
        new JdeField("WTWR10", "WTWR10", JdeDataType.String, 6),
        new JdeField("WTDISCC10", "WTDISCC10", JdeDataType.String, 2),
        new JdeField("WTWR11", "WTWR11", JdeDataType.String, 6),
        new JdeField("WTDISCC11", "WTDISCC11", JdeDataType.String, 2),
        new JdeField("WTWR12", "WTWR12", JdeDataType.String, 6),
        new JdeField("WTDISCC12", "WTDISCC12", JdeDataType.String, 2),
        new JdeField("WTWR13", "WTWR13", JdeDataType.String, 6),
        new JdeField("WTDISCC13", "WTDISCC13", JdeDataType.String, 2),
        new JdeField("WTWR14", "WTWR14", JdeDataType.String, 6),
        new JdeField("WTDISCC14", "WTDISCC14", JdeDataType.String, 2),
        new JdeField("WTWR15", "WTWR15", JdeDataType.String, 6),
        new JdeField("WTDISCC15", "WTDISCC15", JdeDataType.String, 2),
        new JdeField("WTWR16", "WTWR16", JdeDataType.String, 6),
        new JdeField("WTDISCC16", "WTDISCC16", JdeDataType.String, 2),
        new JdeField("WTWR17", "WTWR17", JdeDataType.String, 6),
        new JdeField("WTDISCC17", "WTDISCC17", JdeDataType.String, 2),
        new JdeField("WTWR18", "WTWR18", JdeDataType.String, 6),
        new JdeField("WTDISCC18", "WTDISCC18", JdeDataType.String, 2),
        new JdeField("WTWR19", "WTWR19", JdeDataType.String, 6),
        new JdeField("WTDISCC19", "WTDISCC19", JdeDataType.String, 2),
        new JdeField("WTWR20", "WTWR20", JdeDataType.String, 6),
        new JdeField("WTDISCC20", "WTDISCC20", JdeDataType.String, 2),
        new JdeField("WTPRTS", "WTPRTS", JdeDataType.String, 2),
        new JdeField("WTDISPRI", "WTDISPRI", JdeDataType.String, 2),
        new JdeField("WTREGION", "WTREGION", JdeDataType.String, 6),
        new JdeField("WTDISGR", "WTDISGR", JdeDataType.String, 2),
        new JdeField("WTSPRT", "WTSPRT", JdeDataType.String, 2),
        new JdeField("WTDISWOMSG", "WTDISWOMSG", JdeDataType.String, 2),
        new JdeField("WTPARS", "WTPARS", JdeDataType.String, 16),
        new JdeField("WTDISPARWO", "WTDISPARWO", JdeDataType.String, 2),
        new JdeField("WTSHNO", "WTSHNO", JdeDataType.String, 20),
        new JdeField("WTDISSHNO", "WTDISSHNO", JdeDataType.String, 2),
        new JdeField("WTVR01", "WTVR01", JdeDataType.String, 50),
        new JdeField("WTDISVR01", "WTDISVR01", JdeDataType.String, 2),
        new JdeField("WTTBM", "WTTBM", JdeDataType.String, 6),
        new JdeField("WTDISTBM", "WTDISTBM", JdeDataType.String, 2),
        new JdeField("WTTRT", "WTTRT", JdeDataType.String, 6),
        new JdeField("WTDISTRT", "WTDISTRT", JdeDataType.String, 2),
        new JdeField("WTUNCD", "WTUNCD", JdeDataType.String, 2),
        new JdeField("WTDISUNCD", "WTDISUNCD", JdeDataType.String, 2),
        new JdeField("WTMCU", "WTMCU", JdeDataType.String, 24),
        new JdeField("WTDISBU", "WTDISBU", JdeDataType.String, 2),
        new JdeField("WTSUB", "WTSUB", JdeDataType.String, 16),
        new JdeField("WTDISSUB", "WTDISSUB", JdeDataType.String, 2),
        new JdeField("WTSBLI", "WTSBLI", JdeDataType.String, 2),
        new JdeField("WTDISSIC", "WTDISSIC", JdeDataType.String, 2),
        new JdeField("WTGLCCV", "WTGLCCV", JdeDataType.String, 8),
        new JdeField("WTDISGLC", "WTDISGLC", JdeDataType.String, 2),
        new JdeField("WTGLCNC", "WTGLCNC", JdeDataType.String, 8),
        new JdeField("WTDISNCGLC", "WTDISNCGLC", JdeDataType.String, 2),
        new JdeField("WTMMCU", "WTMMCU", JdeDataType.String, 24),
        new JdeField("WTDISBRA", "WTDISBRA", JdeDataType.String, 2),
        new JdeField("WTHIDEPEP", "WTHIDEPEP", JdeDataType.String, 2),
        new JdeField("WTPID", "WTPID", JdeDataType.String, 20),
        new JdeField("WTUSER", "WTUSER", JdeDataType.String, 20),
        new JdeField("WTMKEY", "WTMKEY", JdeDataType.String, 30),
        new JdeField("WTUPMJ", "WTUPMJ", JdeDataType.Numeric),
        new JdeField("WTUPMT", "WTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48710_0", "Primary Key on WTUKID", new[] { "WTUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48710_2", "Index on WTTMPNA", new[] { "WTTMPNA" })
    };
}
