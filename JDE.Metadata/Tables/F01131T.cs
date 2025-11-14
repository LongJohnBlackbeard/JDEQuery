using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01131T - .
/// </summary>
public class F01131T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZCSERK.
        /// </summary>
        public const string ZCSERK = "ZCSERK";

        /// <summary>
        /// ZCFMNM.
        /// </summary>
        public const string ZCFMNM = "ZCFMNM";

        /// <summary>
        /// ZCMSGDS1.
        /// </summary>
        public const string ZCMSGDS1 = "ZCMSGDS1";

        /// <summary>
        /// ZCMSGDS2.
        /// </summary>
        public const string ZCMSGDS2 = "ZCMSGDS2";

        /// <summary>
        /// ZCMSGST1.
        /// </summary>
        public const string ZCMSGST1 = "ZCMSGST1";

        /// <summary>
        /// ZCMSGST2.
        /// </summary>
        public const string ZCMSGST2 = "ZCMSGST2";

        /// <summary>
        /// ZCMSGC1.
        /// </summary>
        public const string ZCMSGC1 = "ZCMSGC1";

        /// <summary>
        /// ZCMSGC2.
        /// </summary>
        public const string ZCMSGC2 = "ZCMSGC2";

        /// <summary>
        /// ZCUPMJ.
        /// </summary>
        public const string ZCUPMJ = "ZCUPMJ";

        /// <summary>
        /// ZCPID.
        /// </summary>
        public const string ZCPID = "ZCPID";

        /// <summary>
        /// ZCUSER.
        /// </summary>
        public const string ZCUSER = "ZCUSER";

        /// <summary>
        /// ZCTDAY.
        /// </summary>
        public const string ZCTDAY = "ZCTDAY";

        /// <summary>
        /// ZCJOBN.
        /// </summary>
        public const string ZCJOBN = "ZCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F01131T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZCSERK", "ZCSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCFMNM", "ZCFMNM", JdeDataType.String, 20),
        new JdeField("ZCMSGDS1", "ZCMSGDS1", JdeDataType.String, 60),
        new JdeField("ZCMSGDS2", "ZCMSGDS2", JdeDataType.String, 60),
        new JdeField("ZCMSGST1", "ZCMSGST1", JdeDataType.String, 6),
        new JdeField("ZCMSGST2", "ZCMSGST2", JdeDataType.String, 6),
        new JdeField("ZCMSGC1", "ZCMSGC1", JdeDataType.String, 2),
        new JdeField("ZCMSGC2", "ZCMSGC2", JdeDataType.String, 2),
        new JdeField("ZCUPMJ", "ZCUPMJ", JdeDataType.Numeric),
        new JdeField("ZCPID", "ZCPID", JdeDataType.String, 20),
        new JdeField("ZCUSER", "ZCUSER", JdeDataType.String, 20),
        new JdeField("ZCTDAY", "ZCTDAY", JdeDataType.Numeric),
        new JdeField("ZCJOBN", "ZCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01131T_0", "Primary Key on ZCSERK", new[] { "ZCSERK" }, isUnique: true, isPrimaryKey: true)
    };
}
