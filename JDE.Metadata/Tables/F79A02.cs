using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A02 - .
/// </summary>
public class F79A02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSAN8.
        /// </summary>
        public const string GSAN8 = "GSAN8";

        /// <summary>
        /// GSMCU.
        /// </summary>
        public const string GSMCU = "GSMCU";

        /// <summary>
        /// GSBEFD.
        /// </summary>
        public const string GSBEFD = "GSBEFD";

        /// <summary>
        /// GSEEFD.
        /// </summary>
        public const string GSEEFD = "GSEEFD";

        /// <summary>
        /// GS79AGHGST.
        /// </summary>
        public const string GS79AGHGST = "GS79AGHGST";

        /// <summary>
        /// GS79AGESID.
        /// </summary>
        public const string GS79AGESID = "GS79AGESID";

        /// <summary>
        /// GS79AEMSC.
        /// </summary>
        public const string GS79AEMSC = "GS79AEMSC";

        /// <summary>
        /// GS79AGIT.
        /// </summary>
        public const string GS79AGIT = "GS79AGIT";

        /// <summary>
        /// GSURCD.
        /// </summary>
        public const string GSURCD = "GSURCD";

        /// <summary>
        /// GSURDT.
        /// </summary>
        public const string GSURDT = "GSURDT";

        /// <summary>
        /// GSURAT.
        /// </summary>
        public const string GSURAT = "GSURAT";

        /// <summary>
        /// GSURAB.
        /// </summary>
        public const string GSURAB = "GSURAB";

        /// <summary>
        /// GSURRF.
        /// </summary>
        public const string GSURRF = "GSURRF";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSAN8", "GSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("GSMCU", "GSMCU", JdeDataType.String, 24, true, true),
        new JdeField("GSBEFD", "GSBEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("GSEEFD", "GSEEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("GS79AGHGST", "GS79AGHGST", JdeDataType.String, 4),
        new JdeField("GS79AGESID", "GS79AGESID", JdeDataType.Numeric),
        new JdeField("GS79AEMSC", "GS79AEMSC", JdeDataType.String, 20),
        new JdeField("GS79AGIT", "GS79AGIT", JdeDataType.String, 2),
        new JdeField("GSURCD", "GSURCD", JdeDataType.String, 4),
        new JdeField("GSURDT", "GSURDT", JdeDataType.Numeric),
        new JdeField("GSURAT", "GSURAT", JdeDataType.Numeric),
        new JdeField("GSURAB", "GSURAB", JdeDataType.Numeric),
        new JdeField("GSURRF", "GSURRF", JdeDataType.String, 30),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A02_0", "Primary Key on GSAN8, GSMCU, GSBEFD, GSEEFD", new[] { "GSAN8", "GSMCU", "GSBEFD", "GSEEFD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A02_2", "Index on GSMCU, GSBEFD", new[] { "GSMCU", "GSBEFD" })
    };
}
