using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02I - .
/// </summary>
public class F90CB02I : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIOPPID.
        /// </summary>
        public const string OIOPPID = "OIOPPID";

        /// <summary>
        /// OISEQNU.
        /// </summary>
        public const string OISEQNU = "OISEQNU";

        /// <summary>
        /// OICUAN8.
        /// </summary>
        public const string OICUAN8 = "OICUAN8";

        /// <summary>
        /// OICUSAN8.
        /// </summary>
        public const string OICUSAN8 = "OICUSAN8";

        /// <summary>
        /// OIITMHID.
        /// </summary>
        public const string OIITMHID = "OIITMHID";

        /// <summary>
        /// OICATL.
        /// </summary>
        public const string OICATL = "OICATL";

        /// <summary>
        /// OIITM.
        /// </summary>
        public const string OIITM = "OIITM";

        /// <summary>
        /// OILITM.
        /// </summary>
        public const string OILITM = "OILITM";

        /// <summary>
        /// OILNID.
        /// </summary>
        public const string OILNID = "OILNID";

        /// <summary>
        /// OIITQTY.
        /// </summary>
        public const string OIITQTY = "OIITQTY";

        /// <summary>
        /// OIITUOM.
        /// </summary>
        public const string OIITUOM = "OIITUOM";

        /// <summary>
        /// OIPRUOM.
        /// </summary>
        public const string OIPRUOM = "OIPRUOM";

        /// <summary>
        /// OIACTPRC.
        /// </summary>
        public const string OIACTPRC = "OIACTPRC";

        /// <summary>
        /// OIPCE.
        /// </summary>
        public const string OIPCE = "OIPCE";

        /// <summary>
        /// OITITMPR.
        /// </summary>
        public const string OITITMPR = "OITITMPR";

        /// <summary>
        /// OIPRCRCD.
        /// </summary>
        public const string OIPRCRCD = "OIPRCRCD";

        /// <summary>
        /// OITICRCD.
        /// </summary>
        public const string OITICRCD = "OITICRCD";

        /// <summary>
        /// OIOVRBP.
        /// </summary>
        public const string OIOVRBP = "OIOVRBP";

        /// <summary>
        /// OIOPMCU.
        /// </summary>
        public const string OIOPMCU = "OIOPMCU";

        /// <summary>
        /// OIOVPRFL.
        /// </summary>
        public const string OIOVPRFL = "OIOVPRFL";

        /// <summary>
        /// OILFLNTY.
        /// </summary>
        public const string OILFLNTY = "OILFLNTY";

        /// <summary>
        /// OIMSCHGF.
        /// </summary>
        public const string OIMSCHGF = "OIMSCHGF";

        /// <summary>
        /// OIDSCRP2.
        /// </summary>
        public const string OIDSCRP2 = "OIDSCRP2";

        /// <summary>
        /// OIRDATE.
        /// </summary>
        public const string OIRDATE = "OIRDATE";

        /// <summary>
        /// OICFGFLG.
        /// </summary>
        public const string OICFGFLG = "OICFGFLG";

        /// <summary>
        /// OIMCHITM.
        /// </summary>
        public const string OIMCHITM = "OIMCHITM";

        /// <summary>
        /// OIENTDBY.
        /// </summary>
        public const string OIENTDBY = "OIENTDBY";

        /// <summary>
        /// OIEDATE.
        /// </summary>
        public const string OIEDATE = "OIEDATE";

        /// <summary>
        /// OIEXVAR0.
        /// </summary>
        public const string OIEXVAR0 = "OIEXVAR0";

        /// <summary>
        /// OIEXVAR1.
        /// </summary>
        public const string OIEXVAR1 = "OIEXVAR1";

        /// <summary>
        /// OIEXVAR4.
        /// </summary>
        public const string OIEXVAR4 = "OIEXVAR4";

        /// <summary>
        /// OIEXVAR5.
        /// </summary>
        public const string OIEXVAR5 = "OIEXVAR5";

        /// <summary>
        /// OIEXVAR6.
        /// </summary>
        public const string OIEXVAR6 = "OIEXVAR6";

        /// <summary>
        /// OIEXVAR7.
        /// </summary>
        public const string OIEXVAR7 = "OIEXVAR7";

        /// <summary>
        /// OIEXVAR12.
        /// </summary>
        public const string OIEXVAR12 = "OIEXVAR12";

        /// <summary>
        /// OIEXVAR13.
        /// </summary>
        public const string OIEXVAR13 = "OIEXVAR13";

        /// <summary>
        /// OIEXNM0.
        /// </summary>
        public const string OIEXNM0 = "OIEXNM0";

        /// <summary>
        /// OIEXNM1.
        /// </summary>
        public const string OIEXNM1 = "OIEXNM1";

        /// <summary>
        /// OIEXNM2.
        /// </summary>
        public const string OIEXNM2 = "OIEXNM2";

        /// <summary>
        /// OIEXNMP0.
        /// </summary>
        public const string OIEXNMP0 = "OIEXNMP0";

        /// <summary>
        /// OIEXNMP1.
        /// </summary>
        public const string OIEXNMP1 = "OIEXNMP1";

        /// <summary>
        /// OIEXNMP2.
        /// </summary>
        public const string OIEXNMP2 = "OIEXNMP2";

        /// <summary>
        /// OIEXDT0.
        /// </summary>
        public const string OIEXDT0 = "OIEXDT0";

        /// <summary>
        /// OIEXDT1.
        /// </summary>
        public const string OIEXDT1 = "OIEXDT1";

        /// <summary>
        /// OIEXDT2.
        /// </summary>
        public const string OIEXDT2 = "OIEXDT2";

        /// <summary>
        /// OISTSUDT.
        /// </summary>
        public const string OISTSUDT = "OISTSUDT";

        /// <summary>
        /// OIACTIND.
        /// </summary>
        public const string OIACTIND = "OIACTIND";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIVID.
        /// </summary>
        public const string OIVID = "OIVID";

        /// <summary>
        /// OIMKEY.
        /// </summary>
        public const string OIMKEY = "OIMKEY";

        /// <summary>
        /// OIUDTTM.
        /// </summary>
        public const string OIUDTTM = "OIUDTTM";

        /// <summary>
        /// OIUKID.
        /// </summary>
        public const string OIUKID = "OIUKID";

        /// <summary>
        /// OIOSTP.
        /// </summary>
        public const string OIOSTP = "OIOSTP";

        /// <summary>
        /// OICATNM.
        /// </summary>
        public const string OICATNM = "OICATNM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02I";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIOPPID", "OIOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OISEQNU", "OISEQNU", JdeDataType.Numeric),
        new JdeField("OICUAN8", "OICUAN8", JdeDataType.Numeric),
        new JdeField("OICUSAN8", "OICUSAN8", JdeDataType.Numeric),
        new JdeField("OIITMHID", "OIITMHID", JdeDataType.Numeric),
        new JdeField("OICATL", "OICATL", JdeDataType.String, 60),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIITQTY", "OIITQTY", JdeDataType.Numeric),
        new JdeField("OIITUOM", "OIITUOM", JdeDataType.String, 20),
        new JdeField("OIPRUOM", "OIPRUOM", JdeDataType.String, 20),
        new JdeField("OIACTPRC", "OIACTPRC", JdeDataType.Numeric),
        new JdeField("OIPCE", "OIPCE", JdeDataType.Numeric),
        new JdeField("OITITMPR", "OITITMPR", JdeDataType.Numeric),
        new JdeField("OIPRCRCD", "OIPRCRCD", JdeDataType.String, 6),
        new JdeField("OITICRCD", "OITICRCD", JdeDataType.String, 6),
        new JdeField("OIOVRBP", "OIOVRBP", JdeDataType.String, 2),
        new JdeField("OIOPMCU", "OIOPMCU", JdeDataType.String, 24),
        new JdeField("OIOVPRFL", "OIOVPRFL", JdeDataType.String, 2),
        new JdeField("OILFLNTY", "OILFLNTY", JdeDataType.String, 4),
        new JdeField("OIMSCHGF", "OIMSCHGF", JdeDataType.String, 2),
        new JdeField("OIDSCRP2", "OIDSCRP2", JdeDataType.String, 60),
        new JdeField("OIRDATE", "OIRDATE", JdeDataType.Date),
        new JdeField("OICFGFLG", "OICFGFLG", JdeDataType.String, 2),
        new JdeField("OIMCHITM", "OIMCHITM", JdeDataType.Numeric),
        new JdeField("OIENTDBY", "OIENTDBY", JdeDataType.Numeric),
        new JdeField("OIEDATE", "OIEDATE", JdeDataType.Date),
        new JdeField("OIEXVAR0", "OIEXVAR0", JdeDataType.String, 510),
        new JdeField("OIEXVAR1", "OIEXVAR1", JdeDataType.String, 510),
        new JdeField("OIEXVAR4", "OIEXVAR4", JdeDataType.String, 100),
        new JdeField("OIEXVAR5", "OIEXVAR5", JdeDataType.String, 100),
        new JdeField("OIEXVAR6", "OIEXVAR6", JdeDataType.String, 100),
        new JdeField("OIEXVAR7", "OIEXVAR7", JdeDataType.String, 100),
        new JdeField("OIEXVAR12", "OIEXVAR12", JdeDataType.String, 50),
        new JdeField("OIEXVAR13", "OIEXVAR13", JdeDataType.String, 50),
        new JdeField("OIEXNM0", "OIEXNM0", JdeDataType.Numeric),
        new JdeField("OIEXNM1", "OIEXNM1", JdeDataType.Numeric),
        new JdeField("OIEXNM2", "OIEXNM2", JdeDataType.Numeric),
        new JdeField("OIEXNMP0", "OIEXNMP0", JdeDataType.Numeric),
        new JdeField("OIEXNMP1", "OIEXNMP1", JdeDataType.Numeric),
        new JdeField("OIEXNMP2", "OIEXNMP2", JdeDataType.Numeric),
        new JdeField("OIEXDT0", "OIEXDT0", JdeDataType.Date),
        new JdeField("OIEXDT1", "OIEXDT1", JdeDataType.Date),
        new JdeField("OIEXDT2", "OIEXDT2", JdeDataType.Date),
        new JdeField("OISTSUDT", "OISTSUDT", JdeDataType.Date),
        new JdeField("OIACTIND", "OIACTIND", JdeDataType.String, 2),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIVID", "OIVID", JdeDataType.String, 20),
        new JdeField("OIMKEY", "OIMKEY", JdeDataType.String, 30),
        new JdeField("OIUDTTM", "OIUDTTM", JdeDataType.Date),
        new JdeField("OIUKID", "OIUKID", JdeDataType.Numeric),
        new JdeField("OIOSTP", "OIOSTP", JdeDataType.String, 6),
        new JdeField("OICATNM", "OICATNM", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02I_0", "Primary Key on OIOPPID, OILNID", new[] { "OIOPPID", "OILNID" }, isUnique: true, isPrimaryKey: true)
    };
}
