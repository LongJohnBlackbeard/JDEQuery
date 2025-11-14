using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1755UR - .
/// </summary>
public class F1755UR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CADOCO.
        /// </summary>
        public const string CADOCO = "CADOCO";

        /// <summary>
        /// CAEXVAR0.
        /// </summary>
        public const string CAEXVAR0 = "CAEXVAR0";

        /// <summary>
        /// CAEXVAR1.
        /// </summary>
        public const string CAEXVAR1 = "CAEXVAR1";

        /// <summary>
        /// CAEXVAR2.
        /// </summary>
        public const string CAEXVAR2 = "CAEXVAR2";

        /// <summary>
        /// CAEXVAR3.
        /// </summary>
        public const string CAEXVAR3 = "CAEXVAR3";

        /// <summary>
        /// CAEXVAR4.
        /// </summary>
        public const string CAEXVAR4 = "CAEXVAR4";

        /// <summary>
        /// CAEXVAR5.
        /// </summary>
        public const string CAEXVAR5 = "CAEXVAR5";

        /// <summary>
        /// CAEXVAR6.
        /// </summary>
        public const string CAEXVAR6 = "CAEXVAR6";

        /// <summary>
        /// CAEXVAR7.
        /// </summary>
        public const string CAEXVAR7 = "CAEXVAR7";

        /// <summary>
        /// CAEXVAR8.
        /// </summary>
        public const string CAEXVAR8 = "CAEXVAR8";

        /// <summary>
        /// CAEXVAR9.
        /// </summary>
        public const string CAEXVAR9 = "CAEXVAR9";

        /// <summary>
        /// CAEXVAR10.
        /// </summary>
        public const string CAEXVAR10 = "CAEXVAR10";

        /// <summary>
        /// CAEXVAR11.
        /// </summary>
        public const string CAEXVAR11 = "CAEXVAR11";

        /// <summary>
        /// CAEXVAR12.
        /// </summary>
        public const string CAEXVAR12 = "CAEXVAR12";

        /// <summary>
        /// CAEXVAR13.
        /// </summary>
        public const string CAEXVAR13 = "CAEXVAR13";

        /// <summary>
        /// CAEXVAR14.
        /// </summary>
        public const string CAEXVAR14 = "CAEXVAR14";

        /// <summary>
        /// CAEXNM0.
        /// </summary>
        public const string CAEXNM0 = "CAEXNM0";

        /// <summary>
        /// CAEXNM1.
        /// </summary>
        public const string CAEXNM1 = "CAEXNM1";

        /// <summary>
        /// CAEXNM2.
        /// </summary>
        public const string CAEXNM2 = "CAEXNM2";

        /// <summary>
        /// CAEXNM3.
        /// </summary>
        public const string CAEXNM3 = "CAEXNM3";

        /// <summary>
        /// CAEXNM4.
        /// </summary>
        public const string CAEXNM4 = "CAEXNM4";

        /// <summary>
        /// CAEXNMP0.
        /// </summary>
        public const string CAEXNMP0 = "CAEXNMP0";

        /// <summary>
        /// CAEXNMP1.
        /// </summary>
        public const string CAEXNMP1 = "CAEXNMP1";

        /// <summary>
        /// CAEXNMP2.
        /// </summary>
        public const string CAEXNMP2 = "CAEXNMP2";

        /// <summary>
        /// CAEXNMP3.
        /// </summary>
        public const string CAEXNMP3 = "CAEXNMP3";

        /// <summary>
        /// CAEXNMP4.
        /// </summary>
        public const string CAEXNMP4 = "CAEXNMP4";

        /// <summary>
        /// CAEXDT0.
        /// </summary>
        public const string CAEXDT0 = "CAEXDT0";

        /// <summary>
        /// CAEXDT1.
        /// </summary>
        public const string CAEXDT1 = "CAEXDT1";

        /// <summary>
        /// CAEXDT2.
        /// </summary>
        public const string CAEXDT2 = "CAEXDT2";

        /// <summary>
        /// CAEXDT3.
        /// </summary>
        public const string CAEXDT3 = "CAEXDT3";

        /// <summary>
        /// CAEXDT4.
        /// </summary>
        public const string CAEXDT4 = "CAEXDT4";

        /// <summary>
        /// CACRTU.
        /// </summary>
        public const string CACRTU = "CACRTU";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAUDTTM.
        /// </summary>
        public const string CAUDTTM = "CAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F1755UR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CADOCO", "CADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CAEXVAR0", "CAEXVAR0", JdeDataType.String, 510),
        new JdeField("CAEXVAR1", "CAEXVAR1", JdeDataType.String, 510),
        new JdeField("CAEXVAR2", "CAEXVAR2", JdeDataType.String, 510),
        new JdeField("CAEXVAR3", "CAEXVAR3", JdeDataType.String, 510),
        new JdeField("CAEXVAR4", "CAEXVAR4", JdeDataType.String, 100),
        new JdeField("CAEXVAR5", "CAEXVAR5", JdeDataType.String, 100),
        new JdeField("CAEXVAR6", "CAEXVAR6", JdeDataType.String, 100),
        new JdeField("CAEXVAR7", "CAEXVAR7", JdeDataType.String, 100),
        new JdeField("CAEXVAR8", "CAEXVAR8", JdeDataType.String, 100),
        new JdeField("CAEXVAR9", "CAEXVAR9", JdeDataType.String, 100),
        new JdeField("CAEXVAR10", "CAEXVAR10", JdeDataType.String, 100),
        new JdeField("CAEXVAR11", "CAEXVAR11", JdeDataType.String, 100),
        new JdeField("CAEXVAR12", "CAEXVAR12", JdeDataType.String, 50),
        new JdeField("CAEXVAR13", "CAEXVAR13", JdeDataType.String, 50),
        new JdeField("CAEXVAR14", "CAEXVAR14", JdeDataType.String, 50),
        new JdeField("CAEXNM0", "CAEXNM0", JdeDataType.Numeric),
        new JdeField("CAEXNM1", "CAEXNM1", JdeDataType.Numeric),
        new JdeField("CAEXNM2", "CAEXNM2", JdeDataType.Numeric),
        new JdeField("CAEXNM3", "CAEXNM3", JdeDataType.Numeric),
        new JdeField("CAEXNM4", "CAEXNM4", JdeDataType.Numeric),
        new JdeField("CAEXNMP0", "CAEXNMP0", JdeDataType.Numeric),
        new JdeField("CAEXNMP1", "CAEXNMP1", JdeDataType.Numeric),
        new JdeField("CAEXNMP2", "CAEXNMP2", JdeDataType.Numeric),
        new JdeField("CAEXNMP3", "CAEXNMP3", JdeDataType.Numeric),
        new JdeField("CAEXNMP4", "CAEXNMP4", JdeDataType.Numeric),
        new JdeField("CAEXDT0", "CAEXDT0", JdeDataType.Date),
        new JdeField("CAEXDT1", "CAEXDT1", JdeDataType.Date),
        new JdeField("CAEXDT2", "CAEXDT2", JdeDataType.Date),
        new JdeField("CAEXDT3", "CAEXDT3", JdeDataType.Date),
        new JdeField("CAEXDT4", "CAEXDT4", JdeDataType.Date),
        new JdeField("CACRTU", "CACRTU", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAUDTTM", "CAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1755UR_0", "Primary Key on CADOCO", new[] { "CADOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
