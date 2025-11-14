using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08511 - .
/// </summary>
public class F08511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HJAN8.
        /// </summary>
        public const string HJAN8 = "HJAN8";

        /// <summary>
        /// HJPLAN.
        /// </summary>
        public const string HJPLAN = "HJPLAN";

        /// <summary>
        /// HJYRA.
        /// </summary>
        public const string HJYRA = "HJYRA";

        /// <summary>
        /// HJEFT.
        /// </summary>
        public const string HJEFT = "HJEFT";

        /// <summary>
        /// HJEFTE.
        /// </summary>
        public const string HJEFTE = "HJEFTE";

        /// <summary>
        /// HJPSTA.
        /// </summary>
        public const string HJPSTA = "HJPSTA";

        /// <summary>
        /// HJHRV.
        /// </summary>
        public const string HJHRV = "HJHRV";

        /// <summary>
        /// HJHRBN.
        /// </summary>
        public const string HJHRBN = "HJHRBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HJAN8", "HJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HJPLAN", "HJPLAN", JdeDataType.String, 16, true, true),
        new JdeField("HJYRA", "HJYRA", JdeDataType.Numeric, null, true, true),
        new JdeField("HJEFT", "HJEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("HJEFTE", "HJEFTE", JdeDataType.Numeric),
        new JdeField("HJPSTA", "HJPSTA", JdeDataType.String, 6),
        new JdeField("HJHRV", "HJHRV", JdeDataType.Numeric),
        new JdeField("HJHRBN", "HJHRBN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08511_0", "Primary Key on HJAN8, HJPLAN, HJYRA, HJEFT", new[] { "HJAN8", "HJPLAN", "HJYRA", "HJEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
