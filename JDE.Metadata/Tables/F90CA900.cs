using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA900 - .
/// </summary>
public class F90CA900 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AEAEAN8.
        /// </summary>
        public const string AEAEAN8 = "AEAEAN8";

        /// <summary>
        /// AEAELNID.
        /// </summary>
        public const string AEAELNID = "AEAELNID";

        /// <summary>
        /// AEAEXEFD.
        /// </summary>
        public const string AEAEXEFD = "AEAEXEFD";

        /// <summary>
        /// AEENTDBY.
        /// </summary>
        public const string AEENTDBY = "AEENTDBY";

        /// <summary>
        /// AEMODB.
        /// </summary>
        public const string AEMODB = "AEMODB";

        /// <summary>
        /// AEEDATE.
        /// </summary>
        public const string AEEDATE = "AEEDATE";

        /// <summary>
        /// AEMDATE.
        /// </summary>
        public const string AEMDATE = "AEMDATE";

        /// <summary>
        /// AEEXVAR0.
        /// </summary>
        public const string AEEXVAR0 = "AEEXVAR0";

        /// <summary>
        /// AEEXVAR1.
        /// </summary>
        public const string AEEXVAR1 = "AEEXVAR1";

        /// <summary>
        /// AEEXVAR4.
        /// </summary>
        public const string AEEXVAR4 = "AEEXVAR4";

        /// <summary>
        /// AEEXVAR5.
        /// </summary>
        public const string AEEXVAR5 = "AEEXVAR5";

        /// <summary>
        /// AEEXVAR6.
        /// </summary>
        public const string AEEXVAR6 = "AEEXVAR6";

        /// <summary>
        /// AEEXVAR7.
        /// </summary>
        public const string AEEXVAR7 = "AEEXVAR7";

        /// <summary>
        /// AEEXVAR12.
        /// </summary>
        public const string AEEXVAR12 = "AEEXVAR12";

        /// <summary>
        /// AEEXVAR13.
        /// </summary>
        public const string AEEXVAR13 = "AEEXVAR13";

        /// <summary>
        /// AEEXNM0.
        /// </summary>
        public const string AEEXNM0 = "AEEXNM0";

        /// <summary>
        /// AEEXNM1.
        /// </summary>
        public const string AEEXNM1 = "AEEXNM1";

        /// <summary>
        /// AEEXNM2.
        /// </summary>
        public const string AEEXNM2 = "AEEXNM2";

        /// <summary>
        /// AEEXNMP0.
        /// </summary>
        public const string AEEXNMP0 = "AEEXNMP0";

        /// <summary>
        /// AEEXNMP1.
        /// </summary>
        public const string AEEXNMP1 = "AEEXNMP1";

        /// <summary>
        /// AEEXNMP2.
        /// </summary>
        public const string AEEXNMP2 = "AEEXNMP2";

        /// <summary>
        /// AEEXDT0.
        /// </summary>
        public const string AEEXDT0 = "AEEXDT0";

        /// <summary>
        /// AEEXDT1.
        /// </summary>
        public const string AEEXDT1 = "AEEXDT1";

        /// <summary>
        /// AEEXDT2.
        /// </summary>
        public const string AEEXDT2 = "AEEXDT2";

        /// <summary>
        /// AESTSUDT.
        /// </summary>
        public const string AESTSUDT = "AESTSUDT";

        /// <summary>
        /// AEACTIND.
        /// </summary>
        public const string AEACTIND = "AEACTIND";

        /// <summary>
        /// AEUSER.
        /// </summary>
        public const string AEUSER = "AEUSER";

        /// <summary>
        /// AEPID.
        /// </summary>
        public const string AEPID = "AEPID";

        /// <summary>
        /// AEVID.
        /// </summary>
        public const string AEVID = "AEVID";

        /// <summary>
        /// AEMKEY.
        /// </summary>
        public const string AEMKEY = "AEMKEY";

        /// <summary>
        /// AEUDTTM.
        /// </summary>
        public const string AEUDTTM = "AEUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA900";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AEAEAN8", "AEAEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AEAELNID", "AEAELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AEAEXEFD", "AEAEXEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("AEENTDBY", "AEENTDBY", JdeDataType.Numeric),
        new JdeField("AEMODB", "AEMODB", JdeDataType.Numeric),
        new JdeField("AEEDATE", "AEEDATE", JdeDataType.Date),
        new JdeField("AEMDATE", "AEMDATE", JdeDataType.Date),
        new JdeField("AEEXVAR0", "AEEXVAR0", JdeDataType.String, 510),
        new JdeField("AEEXVAR1", "AEEXVAR1", JdeDataType.String, 510),
        new JdeField("AEEXVAR4", "AEEXVAR4", JdeDataType.String, 100),
        new JdeField("AEEXVAR5", "AEEXVAR5", JdeDataType.String, 100),
        new JdeField("AEEXVAR6", "AEEXVAR6", JdeDataType.String, 100),
        new JdeField("AEEXVAR7", "AEEXVAR7", JdeDataType.String, 100),
        new JdeField("AEEXVAR12", "AEEXVAR12", JdeDataType.String, 50),
        new JdeField("AEEXVAR13", "AEEXVAR13", JdeDataType.String, 50),
        new JdeField("AEEXNM0", "AEEXNM0", JdeDataType.Numeric),
        new JdeField("AEEXNM1", "AEEXNM1", JdeDataType.Numeric),
        new JdeField("AEEXNM2", "AEEXNM2", JdeDataType.Numeric),
        new JdeField("AEEXNMP0", "AEEXNMP0", JdeDataType.Numeric),
        new JdeField("AEEXNMP1", "AEEXNMP1", JdeDataType.Numeric),
        new JdeField("AEEXNMP2", "AEEXNMP2", JdeDataType.Numeric),
        new JdeField("AEEXDT0", "AEEXDT0", JdeDataType.Date),
        new JdeField("AEEXDT1", "AEEXDT1", JdeDataType.Date),
        new JdeField("AEEXDT2", "AEEXDT2", JdeDataType.Date),
        new JdeField("AESTSUDT", "AESTSUDT", JdeDataType.Date),
        new JdeField("AEACTIND", "AEACTIND", JdeDataType.String, 2),
        new JdeField("AEUSER", "AEUSER", JdeDataType.String, 20),
        new JdeField("AEPID", "AEPID", JdeDataType.String, 20),
        new JdeField("AEVID", "AEVID", JdeDataType.String, 20),
        new JdeField("AEMKEY", "AEMKEY", JdeDataType.String, 30),
        new JdeField("AEUDTTM", "AEUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA900_0", "Primary Key on AEAEAN8, AEAELNID, AEAEXEFD", new[] { "AEAEAN8", "AEAELNID", "AEAEXEFD" }, isUnique: true, isPrimaryKey: true)
    };
}
