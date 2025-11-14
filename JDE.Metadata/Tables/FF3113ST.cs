using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF3113ST - .
/// </summary>
public class FF3113ST : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRUKID.
        /// </summary>
        public const string LRUKID = "LRUKID";

        /// <summary>
        /// LRLEANUNIT.
        /// </summary>
        public const string LRLEANUNIT = "LRLEANUNIT";

        /// <summary>
        /// LRLEANAMT.
        /// </summary>
        public const string LRLEANAMT = "LRLEANAMT";

        /// <summary>
        /// LRHRSWRK.
        /// </summary>
        public const string LRHRSWRK = "LRHRSWRK";

        /// <summary>
        /// LRAMTGPAY.
        /// </summary>
        public const string LRAMTGPAY = "LRAMTGPAY";
    }

    /// <inheritdoc />
    public override string TableName => "FF3113ST";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRUKID", "LRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LRLEANUNIT", "LRLEANUNIT", JdeDataType.Numeric),
        new JdeField("LRLEANAMT", "LRLEANAMT", JdeDataType.Numeric),
        new JdeField("LRHRSWRK", "LRHRSWRK", JdeDataType.Numeric),
        new JdeField("LRAMTGPAY", "LRAMTGPAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF3113ST_0", "Primary Key on LRUKID", new[] { "LRUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
