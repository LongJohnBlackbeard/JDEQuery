using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4100 - .
/// </summary>
public class F76B4100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSEV01.
        /// </summary>
        public const string PSEV01 = "PSEV01";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";

        /// <summary>
        /// PSUPMT.
        /// </summary>
        public const string PSUPMT = "PSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20, true, true),
        new JdeField("PSEV01", "PSEV01", JdeDataType.String, 2),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric),
        new JdeField("PSUPMT", "PSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4100_0", "Primary Key on PSPID", new[] { "PSPID" }, isUnique: true, isPrimaryKey: true)
    };
}
