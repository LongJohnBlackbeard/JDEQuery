using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08097 - .
/// </summary>
public class F08097 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H#TBLN.
        /// </summary>
        public const string H_TBLN = "H#TBLN";

        /// <summary>
        /// H#LOWR.
        /// </summary>
        public const string H_LOWR = "H#LOWR";

        /// <summary>
        /// H#UPPR.
        /// </summary>
        public const string H_UPPR = "H#UPPR";

        /// <summary>
        /// H#ARES.
        /// </summary>
        public const string H_ARES = "H#ARES";

        /// <summary>
        /// H#CRES.
        /// </summary>
        public const string H_CRES = "H#CRES";

        /// <summary>
        /// H#TRES.
        /// </summary>
        public const string H_TRES = "H#TRES";

        /// <summary>
        /// H#RMK.
        /// </summary>
        public const string H_RMK = "H#RMK";
    }

    /// <inheritdoc />
    public override string TableName => "F08097";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H#TBLN", "H#TBLN", JdeDataType.Numeric, null, true, true),
        new JdeField("H#LOWR", "H#LOWR", JdeDataType.Numeric),
        new JdeField("H#UPPR", "H#UPPR", JdeDataType.Numeric, null, true, true),
        new JdeField("H#ARES", "H#ARES", JdeDataType.Numeric),
        new JdeField("H#CRES", "H#CRES", JdeDataType.String, 20),
        new JdeField("H#TRES", "H#TRES", JdeDataType.Numeric),
        new JdeField("H#RMK", "H#RMK", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08097_0", "Primary Key on H#TBLN, H#UPPR", new[] { "H#TBLN", "H#UPPR" }, isUnique: true, isPrimaryKey: true)
    };
}
