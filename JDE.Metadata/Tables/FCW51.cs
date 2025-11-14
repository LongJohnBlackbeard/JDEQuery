using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW51 - .
/// </summary>
public class FCW51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUKIT.
        /// </summary>
        public const string BUKIT = "BUKIT";

        /// <summary>
        /// BUMMCU.
        /// </summary>
        public const string BUMMCU = "BUMMCU";

        /// <summary>
        /// BUTBM.
        /// </summary>
        public const string BUTBM = "BUTBM";

        /// <summary>
        /// BUBQTY.
        /// </summary>
        public const string BUBQTY = "BUBQTY";

        /// <summary>
        /// BUITM.
        /// </summary>
        public const string BUITM = "BUITM";

        /// <summary>
        /// BUC9LVNO.
        /// </summary>
        public const string BUC9LVNO = "BUC9LVNO";

        /// <summary>
        /// BUC9LVCO.
        /// </summary>
        public const string BUC9LVCO = "BUC9LVCO";

        /// <summary>
        /// BUCPNT.
        /// </summary>
        public const string BUCPNT = "BUCPNT";

        /// <summary>
        /// BUSBNT.
        /// </summary>
        public const string BUSBNT = "BUSBNT";

        /// <summary>
        /// BUCOBY.
        /// </summary>
        public const string BUCOBY = "BUCOBY";

        /// <summary>
        /// BUC9LVC0.
        /// </summary>
        public const string BUC9LVC0 = "BUC9LVC0";

        /// <summary>
        /// BUQNTY.
        /// </summary>
        public const string BUQNTY = "BUQNTY";

        /// <summary>
        /// BUCPNB.
        /// </summary>
        public const string BUCPNB = "BUCPNB";

        /// <summary>
        /// BUQTY.
        /// </summary>
        public const string BUQTY = "BUQTY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUKIT", "BUKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BUMMCU", "BUMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BUTBM", "BUTBM", JdeDataType.String, 6, true, true),
        new JdeField("BUBQTY", "BUBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BUITM", "BUITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BUC9LVNO", "BUC9LVNO", JdeDataType.Numeric, null, true, true),
        new JdeField("BUC9LVCO", "BUC9LVCO", JdeDataType.String, 50, true, true),
        new JdeField("BUCPNT", "BUCPNT", JdeDataType.Numeric),
        new JdeField("BUSBNT", "BUSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("BUCOBY", "BUCOBY", JdeDataType.String, 2, true, true),
        new JdeField("BUC9LVC0", "BUC9LVC0", JdeDataType.String, 50, true, true),
        new JdeField("BUQNTY", "BUQNTY", JdeDataType.Numeric),
        new JdeField("BUCPNB", "BUCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("BUQTY", "BUQTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW51_0", "Primary Key on BUKIT, BUMMCU, BUTBM, BUBQTY, BUITM, BUC9LVNO, BUC9LVCO, BUCPNB, BUSBNT, BUCOBY, BUC9LVC0", new[] { "BUKIT", "BUMMCU", "BUTBM", "BUBQTY", "BUITM", "BUC9LVNO", "BUC9LVCO", "BUCPNB", "BUSBNT", "BUCOBY", "BUC9LVC0" }, isUnique: true, isPrimaryKey: true)
    };
}
