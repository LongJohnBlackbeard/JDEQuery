using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B927 - .
/// </summary>
public class F76B927 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAB76AID.
        /// </summary>
        public const string RAB76AID = "RAB76AID";

        /// <summary>
        /// RAB76AID2.
        /// </summary>
        public const string RAB76AID2 = "RAB76AID2";

        /// <summary>
        /// RAB76CODG.
        /// </summary>
        public const string RAB76CODG = "RAB76CODG";

        /// <summary>
        /// RAB76NAT.
        /// </summary>
        public const string RAB76NAT = "RAB76NAT";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B927";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAB76AID", "RAB76AID", JdeDataType.String, 16, true, true),
        new JdeField("RAB76AID2", "RAB76AID2", JdeDataType.String, 16, true, true),
        new JdeField("RAB76CODG", "RAB76CODG", JdeDataType.String, 12),
        new JdeField("RAB76NAT", "RAB76NAT", JdeDataType.String, 4),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B927_0", "Primary Key on RAB76AID, RAB76AID2", new[] { "RAB76AID", "RAB76AID2" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B927_2", "Index on RAB76AID, RAB76CODG", new[] { "RAB76AID", "RAB76CODG" })
    };
}
