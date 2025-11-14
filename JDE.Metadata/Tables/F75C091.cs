using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C091 - .
/// </summary>
public class F75C091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLAID.
        /// </summary>
        public const string CLAID = "CLAID";

        /// <summary>
        /// CLC75NAC.
        /// </summary>
        public const string CLC75NAC = "CLC75NAC";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLUPMT.
        /// </summary>
        public const string CLUPMT = "CLUPMT";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLJOBN.
        /// </summary>
        public const string CLJOBN = "CLJOBN";

        /// <summary>
        /// CLCDAA.
        /// </summary>
        public const string CLCDAA = "CLCDAA";

        /// <summary>
        /// CLCDBB.
        /// </summary>
        public const string CLCDBB = "CLCDBB";

        /// <summary>
        /// CLCDCC.
        /// </summary>
        public const string CLCDCC = "CLCDCC";
    }

    /// <inheritdoc />
    public override string TableName => "F75C091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLAID", "CLAID", JdeDataType.String, 16, true, true),
        new JdeField("CLC75NAC", "CLC75NAC", JdeDataType.String, 60),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLUPMT", "CLUPMT", JdeDataType.Numeric),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLJOBN", "CLJOBN", JdeDataType.String, 20),
        new JdeField("CLCDAA", "CLCDAA", JdeDataType.String, 4),
        new JdeField("CLCDBB", "CLCDBB", JdeDataType.String, 4),
        new JdeField("CLCDCC", "CLCDCC", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C091_0", "Primary Key on CLAID", new[] { "CLAID" }, isUnique: true, isPrimaryKey: true)
    };
}
