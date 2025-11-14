using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B400F - .
/// </summary>
public class F76B400F : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNUKID.
        /// </summary>
        public const string TNUKID = "TNUKID";

        /// <summary>
        /// TNDGJ.
        /// </summary>
        public const string TNDGJ = "TNDGJ";

        /// <summary>
        /// TNBRNO.
        /// </summary>
        public const string TNBRNO = "TNBRNO";

        /// <summary>
        /// TNDESC.
        /// </summary>
        public const string TNDESC = "TNDESC";

        /// <summary>
        /// TNRDOR.
        /// </summary>
        public const string TNRDOR = "TNRDOR";

        /// <summary>
        /// TNC1FU.
        /// </summary>
        public const string TNC1FU = "TNC1FU";

        /// <summary>
        /// TNC2FU.
        /// </summary>
        public const string TNC2FU = "TNC2FU";

        /// <summary>
        /// TND1FU.
        /// </summary>
        public const string TND1FU = "TND1FU";

        /// <summary>
        /// TND2FU.
        /// </summary>
        public const string TND2FU = "TND2FU";

        /// <summary>
        /// TNN1FU.
        /// </summary>
        public const string TNN1FU = "TNN1FU";

        /// <summary>
        /// TNN2FU.
        /// </summary>
        public const string TNN2FU = "TNN2FU";

        /// <summary>
        /// TNN3FU.
        /// </summary>
        public const string TNN3FU = "TNN3FU";

        /// <summary>
        /// TNN4FU.
        /// </summary>
        public const string TNN4FU = "TNN4FU";

        /// <summary>
        /// TNN5FU.
        /// </summary>
        public const string TNN5FU = "TNN5FU";

        /// <summary>
        /// TNN6FU.
        /// </summary>
        public const string TNN6FU = "TNN6FU";

        /// <summary>
        /// TNN7FU.
        /// </summary>
        public const string TNN7FU = "TNN7FU";

        /// <summary>
        /// TNS1FU.
        /// </summary>
        public const string TNS1FU = "TNS1FU";

        /// <summary>
        /// TNS2FU.
        /// </summary>
        public const string TNS2FU = "TNS2FU";

        /// <summary>
        /// TNS3FU.
        /// </summary>
        public const string TNS3FU = "TNS3FU";

        /// <summary>
        /// TNS4FU.
        /// </summary>
        public const string TNS4FU = "TNS4FU";

        /// <summary>
        /// TNGENLNG.
        /// </summary>
        public const string TNGENLNG = "TNGENLNG";

        /// <summary>
        /// TNTORG.
        /// </summary>
        public const string TNTORG = "TNTORG";

        /// <summary>
        /// TNUSER.
        /// </summary>
        public const string TNUSER = "TNUSER";

        /// <summary>
        /// TNPID.
        /// </summary>
        public const string TNPID = "TNPID";

        /// <summary>
        /// TNJOBN.
        /// </summary>
        public const string TNJOBN = "TNJOBN";

        /// <summary>
        /// TNUPMJ.
        /// </summary>
        public const string TNUPMJ = "TNUPMJ";

        /// <summary>
        /// TNUPMT.
        /// </summary>
        public const string TNUPMT = "TNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B400F";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNUKID", "TNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TNDGJ", "TNDGJ", JdeDataType.Numeric),
        new JdeField("TNBRNO", "TNBRNO", JdeDataType.String, 12),
        new JdeField("TNDESC", "TNDESC", JdeDataType.String, 60),
        new JdeField("TNRDOR", "TNRDOR", JdeDataType.String, 2),
        new JdeField("TNC1FU", "TNC1FU", JdeDataType.String, 2),
        new JdeField("TNC2FU", "TNC2FU", JdeDataType.String, 2),
        new JdeField("TND1FU", "TND1FU", JdeDataType.Numeric),
        new JdeField("TND2FU", "TND2FU", JdeDataType.Numeric),
        new JdeField("TNN1FU", "TNN1FU", JdeDataType.Numeric),
        new JdeField("TNN2FU", "TNN2FU", JdeDataType.Numeric),
        new JdeField("TNN3FU", "TNN3FU", JdeDataType.Numeric),
        new JdeField("TNN4FU", "TNN4FU", JdeDataType.Numeric),
        new JdeField("TNN5FU", "TNN5FU", JdeDataType.Numeric),
        new JdeField("TNN6FU", "TNN6FU", JdeDataType.Numeric),
        new JdeField("TNN7FU", "TNN7FU", JdeDataType.Numeric),
        new JdeField("TNS1FU", "TNS1FU", JdeDataType.String, 60),
        new JdeField("TNS2FU", "TNS2FU", JdeDataType.String, 60),
        new JdeField("TNS3FU", "TNS3FU", JdeDataType.String, 6),
        new JdeField("TNS4FU", "TNS4FU", JdeDataType.String, 6),
        new JdeField("TNGENLNG", "TNGENLNG", JdeDataType.Numeric),
        new JdeField("TNTORG", "TNTORG", JdeDataType.String, 20),
        new JdeField("TNUSER", "TNUSER", JdeDataType.String, 20),
        new JdeField("TNPID", "TNPID", JdeDataType.String, 20),
        new JdeField("TNJOBN", "TNJOBN", JdeDataType.String, 20),
        new JdeField("TNUPMJ", "TNUPMJ", JdeDataType.Numeric),
        new JdeField("TNUPMT", "TNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B400F_0", "Primary Key on TNUKID", new[] { "TNUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B400F_2", "Unique Index on TNBRNO", new[] { "TNBRNO" }, isUnique: true)
    };
}
