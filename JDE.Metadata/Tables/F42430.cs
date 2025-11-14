using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42430 - .
/// </summary>
public class F42430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSSHAN.
        /// </summary>
        public const string CSSHAN = "CSSHAN";

        /// <summary>
        /// CSEFTJ.
        /// </summary>
        public const string CSEFTJ = "CSEFTJ";

        /// <summary>
        /// CSEXDJ.
        /// </summary>
        public const string CSEXDJ = "CSEXDJ";

        /// <summary>
        /// CSDVAN.
        /// </summary>
        public const string CSDVAN = "CSDVAN";

        /// <summary>
        /// CSITAN.
        /// </summary>
        public const string CSITAN = "CSITAN";

        /// <summary>
        /// CSPBAN.
        /// </summary>
        public const string CSPBAN = "CSPBAN";

        /// <summary>
        /// CSFTAN.
        /// </summary>
        public const string CSFTAN = "CSFTAN";

        /// <summary>
        /// CSAUFT.
        /// </summary>
        public const string CSAUFT = "CSAUFT";

        /// <summary>
        /// CSAUFI.
        /// </summary>
        public const string CSAUFI = "CSAUFI";
    }

    /// <inheritdoc />
    public override string TableName => "F42430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSSHAN", "CSSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("CSEFTJ", "CSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CSEXDJ", "CSEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CSDVAN", "CSDVAN", JdeDataType.Numeric),
        new JdeField("CSITAN", "CSITAN", JdeDataType.Numeric),
        new JdeField("CSPBAN", "CSPBAN", JdeDataType.Numeric),
        new JdeField("CSFTAN", "CSFTAN", JdeDataType.Numeric),
        new JdeField("CSAUFT", "CSAUFT", JdeDataType.String, 2),
        new JdeField("CSAUFI", "CSAUFI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42430_0", "Primary Key on CSAN8, CSSHAN, CSEFTJ, CSEXDJ", new[] { "CSAN8", "CSSHAN", "CSEFTJ", "CSEXDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
