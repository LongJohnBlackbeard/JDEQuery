using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B936 - .
/// </summary>
public class F76B936 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRB76SBON.
        /// </summary>
        public const string BRB76SBON = "BRB76SBON";

        /// <summary>
        /// BRB76ABON.
        /// </summary>
        public const string BRB76ABON = "BRB76ABON";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRUPMT.
        /// </summary>
        public const string BRUPMT = "BRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B936";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRB76SBON", "BRB76SBON", JdeDataType.Numeric, null, true, true),
        new JdeField("BRB76ABON", "BRB76ABON", JdeDataType.Numeric, null, true, true),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRUPMT", "BRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B936_0", "Primary Key on BRB76SBON, BRB76ABON", new[] { "BRB76SBON", "BRB76ABON" }, isUnique: true, isPrimaryKey: true)
    };
}
