using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA08A - .
/// </summary>
public class F90CA08A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UACUAN8.
        /// </summary>
        public const string UACUAN8 = "UACUAN8";

        /// <summary>
        /// UAEMAN8.
        /// </summary>
        public const string UAEMAN8 = "UAEMAN8";

        /// <summary>
        /// UAENTDBY.
        /// </summary>
        public const string UAENTDBY = "UAENTDBY";

        /// <summary>
        /// UAMODB.
        /// </summary>
        public const string UAMODB = "UAMODB";

        /// <summary>
        /// UAEDATE.
        /// </summary>
        public const string UAEDATE = "UAEDATE";

        /// <summary>
        /// UAMDATE.
        /// </summary>
        public const string UAMDATE = "UAMDATE";

        /// <summary>
        /// UARTYPE.
        /// </summary>
        public const string UARTYPE = "UARTYPE";

        /// <summary>
        /// UAPRIFLG.
        /// </summary>
        public const string UAPRIFLG = "UAPRIFLG";

        /// <summary>
        /// UAEXVAR0.
        /// </summary>
        public const string UAEXVAR0 = "UAEXVAR0";

        /// <summary>
        /// UAEXVAR1.
        /// </summary>
        public const string UAEXVAR1 = "UAEXVAR1";

        /// <summary>
        /// UAEXVAR4.
        /// </summary>
        public const string UAEXVAR4 = "UAEXVAR4";

        /// <summary>
        /// UAEXVAR5.
        /// </summary>
        public const string UAEXVAR5 = "UAEXVAR5";

        /// <summary>
        /// UAEXVAR6.
        /// </summary>
        public const string UAEXVAR6 = "UAEXVAR6";

        /// <summary>
        /// UAEXVAR7.
        /// </summary>
        public const string UAEXVAR7 = "UAEXVAR7";

        /// <summary>
        /// UAEXVAR12.
        /// </summary>
        public const string UAEXVAR12 = "UAEXVAR12";

        /// <summary>
        /// UAEXVAR13.
        /// </summary>
        public const string UAEXVAR13 = "UAEXVAR13";

        /// <summary>
        /// UAEXNM0.
        /// </summary>
        public const string UAEXNM0 = "UAEXNM0";

        /// <summary>
        /// UAEXNM1.
        /// </summary>
        public const string UAEXNM1 = "UAEXNM1";

        /// <summary>
        /// UAEXNM2.
        /// </summary>
        public const string UAEXNM2 = "UAEXNM2";

        /// <summary>
        /// UAEXNMP0.
        /// </summary>
        public const string UAEXNMP0 = "UAEXNMP0";

        /// <summary>
        /// UAEXNMP1.
        /// </summary>
        public const string UAEXNMP1 = "UAEXNMP1";

        /// <summary>
        /// UAEXNMP2.
        /// </summary>
        public const string UAEXNMP2 = "UAEXNMP2";

        /// <summary>
        /// UAEXDT0.
        /// </summary>
        public const string UAEXDT0 = "UAEXDT0";

        /// <summary>
        /// UAEXDT1.
        /// </summary>
        public const string UAEXDT1 = "UAEXDT1";

        /// <summary>
        /// UAEXDT2.
        /// </summary>
        public const string UAEXDT2 = "UAEXDT2";

        /// <summary>
        /// UASTSUDT.
        /// </summary>
        public const string UASTSUDT = "UASTSUDT";

        /// <summary>
        /// UAACTIND.
        /// </summary>
        public const string UAACTIND = "UAACTIND";

        /// <summary>
        /// UAUSER.
        /// </summary>
        public const string UAUSER = "UAUSER";

        /// <summary>
        /// UAPID.
        /// </summary>
        public const string UAPID = "UAPID";

        /// <summary>
        /// UAVID.
        /// </summary>
        public const string UAVID = "UAVID";

        /// <summary>
        /// UAMKEY.
        /// </summary>
        public const string UAMKEY = "UAMKEY";

        /// <summary>
        /// UAUDTTM.
        /// </summary>
        public const string UAUDTTM = "UAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA08A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UACUAN8", "UACUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UAEMAN8", "UAEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UAENTDBY", "UAENTDBY", JdeDataType.Numeric),
        new JdeField("UAMODB", "UAMODB", JdeDataType.Numeric),
        new JdeField("UAEDATE", "UAEDATE", JdeDataType.Date),
        new JdeField("UAMDATE", "UAMDATE", JdeDataType.Date),
        new JdeField("UARTYPE", "UARTYPE", JdeDataType.String, 10),
        new JdeField("UAPRIFLG", "UAPRIFLG", JdeDataType.String, 2),
        new JdeField("UAEXVAR0", "UAEXVAR0", JdeDataType.String, 510),
        new JdeField("UAEXVAR1", "UAEXVAR1", JdeDataType.String, 510),
        new JdeField("UAEXVAR4", "UAEXVAR4", JdeDataType.String, 100),
        new JdeField("UAEXVAR5", "UAEXVAR5", JdeDataType.String, 100),
        new JdeField("UAEXVAR6", "UAEXVAR6", JdeDataType.String, 100),
        new JdeField("UAEXVAR7", "UAEXVAR7", JdeDataType.String, 100),
        new JdeField("UAEXVAR12", "UAEXVAR12", JdeDataType.String, 50),
        new JdeField("UAEXVAR13", "UAEXVAR13", JdeDataType.String, 50),
        new JdeField("UAEXNM0", "UAEXNM0", JdeDataType.Numeric),
        new JdeField("UAEXNM1", "UAEXNM1", JdeDataType.Numeric),
        new JdeField("UAEXNM2", "UAEXNM2", JdeDataType.Numeric),
        new JdeField("UAEXNMP0", "UAEXNMP0", JdeDataType.Numeric),
        new JdeField("UAEXNMP1", "UAEXNMP1", JdeDataType.Numeric),
        new JdeField("UAEXNMP2", "UAEXNMP2", JdeDataType.Numeric),
        new JdeField("UAEXDT0", "UAEXDT0", JdeDataType.Date),
        new JdeField("UAEXDT1", "UAEXDT1", JdeDataType.Date),
        new JdeField("UAEXDT2", "UAEXDT2", JdeDataType.Date),
        new JdeField("UASTSUDT", "UASTSUDT", JdeDataType.Date),
        new JdeField("UAACTIND", "UAACTIND", JdeDataType.String, 2),
        new JdeField("UAUSER", "UAUSER", JdeDataType.String, 20),
        new JdeField("UAPID", "UAPID", JdeDataType.String, 20),
        new JdeField("UAVID", "UAVID", JdeDataType.String, 20),
        new JdeField("UAMKEY", "UAMKEY", JdeDataType.String, 30),
        new JdeField("UAUDTTM", "UAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA08A_0", "Primary Key on UACUAN8, UAEMAN8", new[] { "UACUAN8", "UAEMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
