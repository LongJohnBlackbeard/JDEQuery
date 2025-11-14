using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA050 - .
/// </summary>
public class F90CA050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPRAN8.
        /// </summary>
        public const string PPPRAN8 = "PPPRAN8";

        /// <summary>
        /// PPPTY.
        /// </summary>
        public const string PPPTY = "PPPTY";

        /// <summary>
        /// PPNUMEMP.
        /// </summary>
        public const string PPNUMEMP = "PPNUMEMP";

        /// <summary>
        /// PPANNREV.
        /// </summary>
        public const string PPANNREV = "PPANNREV";

        /// <summary>
        /// PPARCRCD.
        /// </summary>
        public const string PPARCRCD = "PPARCRCD";

        /// <summary>
        /// PPENTDBY.
        /// </summary>
        public const string PPENTDBY = "PPENTDBY";

        /// <summary>
        /// PPMODB.
        /// </summary>
        public const string PPMODB = "PPMODB";

        /// <summary>
        /// PPEDATE.
        /// </summary>
        public const string PPEDATE = "PPEDATE";

        /// <summary>
        /// PPMDATE.
        /// </summary>
        public const string PPMDATE = "PPMDATE";

        /// <summary>
        /// PPEXVAR0.
        /// </summary>
        public const string PPEXVAR0 = "PPEXVAR0";

        /// <summary>
        /// PPEXVAR1.
        /// </summary>
        public const string PPEXVAR1 = "PPEXVAR1";

        /// <summary>
        /// PPEXVAR2.
        /// </summary>
        public const string PPEXVAR2 = "PPEXVAR2";

        /// <summary>
        /// PPEXVAR3.
        /// </summary>
        public const string PPEXVAR3 = "PPEXVAR3";

        /// <summary>
        /// PPEXVAR4.
        /// </summary>
        public const string PPEXVAR4 = "PPEXVAR4";

        /// <summary>
        /// PPEXVAR5.
        /// </summary>
        public const string PPEXVAR5 = "PPEXVAR5";

        /// <summary>
        /// PPEXVAR6.
        /// </summary>
        public const string PPEXVAR6 = "PPEXVAR6";

        /// <summary>
        /// PPEXVAR7.
        /// </summary>
        public const string PPEXVAR7 = "PPEXVAR7";

        /// <summary>
        /// PPEXVAR8.
        /// </summary>
        public const string PPEXVAR8 = "PPEXVAR8";

        /// <summary>
        /// PPEXVAR9.
        /// </summary>
        public const string PPEXVAR9 = "PPEXVAR9";

        /// <summary>
        /// PPEXVAR10.
        /// </summary>
        public const string PPEXVAR10 = "PPEXVAR10";

        /// <summary>
        /// PPEXVAR11.
        /// </summary>
        public const string PPEXVAR11 = "PPEXVAR11";

        /// <summary>
        /// PPEXVAR12.
        /// </summary>
        public const string PPEXVAR12 = "PPEXVAR12";

        /// <summary>
        /// PPEXVAR13.
        /// </summary>
        public const string PPEXVAR13 = "PPEXVAR13";

        /// <summary>
        /// PPEXVAR14.
        /// </summary>
        public const string PPEXVAR14 = "PPEXVAR14";

        /// <summary>
        /// PPEXNM0.
        /// </summary>
        public const string PPEXNM0 = "PPEXNM0";

        /// <summary>
        /// PPEXNM1.
        /// </summary>
        public const string PPEXNM1 = "PPEXNM1";

        /// <summary>
        /// PPEXNM2.
        /// </summary>
        public const string PPEXNM2 = "PPEXNM2";

        /// <summary>
        /// PPEXNM3.
        /// </summary>
        public const string PPEXNM3 = "PPEXNM3";

        /// <summary>
        /// PPEXNM4.
        /// </summary>
        public const string PPEXNM4 = "PPEXNM4";

        /// <summary>
        /// PPEXNMP0.
        /// </summary>
        public const string PPEXNMP0 = "PPEXNMP0";

        /// <summary>
        /// PPEXNMP1.
        /// </summary>
        public const string PPEXNMP1 = "PPEXNMP1";

        /// <summary>
        /// PPEXNMP2.
        /// </summary>
        public const string PPEXNMP2 = "PPEXNMP2";

        /// <summary>
        /// PPEXNMP3.
        /// </summary>
        public const string PPEXNMP3 = "PPEXNMP3";

        /// <summary>
        /// PPEXNMP4.
        /// </summary>
        public const string PPEXNMP4 = "PPEXNMP4";

        /// <summary>
        /// PPEXDT0.
        /// </summary>
        public const string PPEXDT0 = "PPEXDT0";

        /// <summary>
        /// PPEXDT1.
        /// </summary>
        public const string PPEXDT1 = "PPEXDT1";

        /// <summary>
        /// PPEXDT2.
        /// </summary>
        public const string PPEXDT2 = "PPEXDT2";

        /// <summary>
        /// PPEXDT3.
        /// </summary>
        public const string PPEXDT3 = "PPEXDT3";

        /// <summary>
        /// PPEXDT4.
        /// </summary>
        public const string PPEXDT4 = "PPEXDT4";

        /// <summary>
        /// PPSTSUDT.
        /// </summary>
        public const string PPSTSUDT = "PPSTSUDT";

        /// <summary>
        /// PPACTIND.
        /// </summary>
        public const string PPACTIND = "PPACTIND";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPVID.
        /// </summary>
        public const string PPVID = "PPVID";

        /// <summary>
        /// PPMKEY.
        /// </summary>
        public const string PPMKEY = "PPMKEY";

        /// <summary>
        /// PPUDTTM.
        /// </summary>
        public const string PPUDTTM = "PPUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPRAN8", "PPPRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PPPTY", "PPPTY", JdeDataType.String, 10),
        new JdeField("PPNUMEMP", "PPNUMEMP", JdeDataType.Numeric),
        new JdeField("PPANNREV", "PPANNREV", JdeDataType.Numeric),
        new JdeField("PPARCRCD", "PPARCRCD", JdeDataType.String, 6),
        new JdeField("PPENTDBY", "PPENTDBY", JdeDataType.Numeric),
        new JdeField("PPMODB", "PPMODB", JdeDataType.Numeric),
        new JdeField("PPEDATE", "PPEDATE", JdeDataType.Date),
        new JdeField("PPMDATE", "PPMDATE", JdeDataType.Date),
        new JdeField("PPEXVAR0", "PPEXVAR0", JdeDataType.String, 510),
        new JdeField("PPEXVAR1", "PPEXVAR1", JdeDataType.String, 510),
        new JdeField("PPEXVAR2", "PPEXVAR2", JdeDataType.String, 510),
        new JdeField("PPEXVAR3", "PPEXVAR3", JdeDataType.String, 510),
        new JdeField("PPEXVAR4", "PPEXVAR4", JdeDataType.String, 100),
        new JdeField("PPEXVAR5", "PPEXVAR5", JdeDataType.String, 100),
        new JdeField("PPEXVAR6", "PPEXVAR6", JdeDataType.String, 100),
        new JdeField("PPEXVAR7", "PPEXVAR7", JdeDataType.String, 100),
        new JdeField("PPEXVAR8", "PPEXVAR8", JdeDataType.String, 100),
        new JdeField("PPEXVAR9", "PPEXVAR9", JdeDataType.String, 100),
        new JdeField("PPEXVAR10", "PPEXVAR10", JdeDataType.String, 100),
        new JdeField("PPEXVAR11", "PPEXVAR11", JdeDataType.String, 100),
        new JdeField("PPEXVAR12", "PPEXVAR12", JdeDataType.String, 50),
        new JdeField("PPEXVAR13", "PPEXVAR13", JdeDataType.String, 50),
        new JdeField("PPEXVAR14", "PPEXVAR14", JdeDataType.String, 50),
        new JdeField("PPEXNM0", "PPEXNM0", JdeDataType.Numeric),
        new JdeField("PPEXNM1", "PPEXNM1", JdeDataType.Numeric),
        new JdeField("PPEXNM2", "PPEXNM2", JdeDataType.Numeric),
        new JdeField("PPEXNM3", "PPEXNM3", JdeDataType.Numeric),
        new JdeField("PPEXNM4", "PPEXNM4", JdeDataType.Numeric),
        new JdeField("PPEXNMP0", "PPEXNMP0", JdeDataType.Numeric),
        new JdeField("PPEXNMP1", "PPEXNMP1", JdeDataType.Numeric),
        new JdeField("PPEXNMP2", "PPEXNMP2", JdeDataType.Numeric),
        new JdeField("PPEXNMP3", "PPEXNMP3", JdeDataType.Numeric),
        new JdeField("PPEXNMP4", "PPEXNMP4", JdeDataType.Numeric),
        new JdeField("PPEXDT0", "PPEXDT0", JdeDataType.Date),
        new JdeField("PPEXDT1", "PPEXDT1", JdeDataType.Date),
        new JdeField("PPEXDT2", "PPEXDT2", JdeDataType.Date),
        new JdeField("PPEXDT3", "PPEXDT3", JdeDataType.Date),
        new JdeField("PPEXDT4", "PPEXDT4", JdeDataType.Date),
        new JdeField("PPSTSUDT", "PPSTSUDT", JdeDataType.Date),
        new JdeField("PPACTIND", "PPACTIND", JdeDataType.String, 2),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPVID", "PPVID", JdeDataType.String, 20),
        new JdeField("PPMKEY", "PPMKEY", JdeDataType.String, 30),
        new JdeField("PPUDTTM", "PPUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA050_0", "Primary Key on PPPRAN8", new[] { "PPPRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
