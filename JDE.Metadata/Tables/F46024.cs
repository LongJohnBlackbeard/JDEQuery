using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46024 - .
/// </summary>
public class F46024 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCSTY1.
        /// </summary>
        public const string LCSTY1 = "LCSTY1";

        /// <summary>
        /// LCPRP6.
        /// </summary>
        public const string LCPRP6 = "LCPRP6";

        /// <summary>
        /// LCITM.
        /// </summary>
        public const string LCITM = "LCITM";

        /// <summary>
        /// LCUOM.
        /// </summary>
        public const string LCUOM = "LCUOM";

        /// <summary>
        /// LCEQTY.
        /// </summary>
        public const string LCEQTY = "LCEQTY";

        /// <summary>
        /// LCMAXQ.
        /// </summary>
        public const string LCMAXQ = "LCMAXQ";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCTDAY.
        /// </summary>
        public const string LCTDAY = "LCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46024";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCSTY1", "LCSTY1", JdeDataType.String, 12, true, true),
        new JdeField("LCPRP6", "LCPRP6", JdeDataType.String, 12, true, true),
        new JdeField("LCITM", "LCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LCUOM", "LCUOM", JdeDataType.String, 4, true, true),
        new JdeField("LCEQTY", "LCEQTY", JdeDataType.String, 10, true, true),
        new JdeField("LCMAXQ", "LCMAXQ", JdeDataType.Numeric),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCTDAY", "LCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46024_0", "Primary Key on LCMCU, LCSTY1, LCPRP6, LCITM, LCUOM, LCEQTY", new[] { "LCMCU", "LCSTY1", "LCPRP6", "LCITM", "LCUOM", "LCEQTY" }, isUnique: true, isPrimaryKey: true)
    };
}
