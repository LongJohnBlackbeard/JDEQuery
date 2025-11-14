using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1210W - .
/// </summary>
public class F1210W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FBNNBR.
        /// </summary>
        public const string FBNNBR = "FBNNBR";

        /// <summary>
        /// FBLDLN.
        /// </summary>
        public const string FBLDLN = "FBLDLN";

        /// <summary>
        /// FBLDTA.
        /// </summary>
        public const string FBLDTA = "FBLDTA";

        /// <summary>
        /// FBUSER.
        /// </summary>
        public const string FBUSER = "FBUSER";

        /// <summary>
        /// FBUPMJ.
        /// </summary>
        public const string FBUPMJ = "FBUPMJ";

        /// <summary>
        /// FBPID.
        /// </summary>
        public const string FBPID = "FBPID";

        /// <summary>
        /// FBJOBN.
        /// </summary>
        public const string FBJOBN = "FBJOBN";

        /// <summary>
        /// FBUPMT.
        /// </summary>
        public const string FBUPMT = "FBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1210W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FBNNBR", "FBNNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("FBLDLN", "FBLDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("FBLDTA", "FBLDTA", JdeDataType.String, 120),
        new JdeField("FBUSER", "FBUSER", JdeDataType.String, 20),
        new JdeField("FBUPMJ", "FBUPMJ", JdeDataType.Numeric),
        new JdeField("FBPID", "FBPID", JdeDataType.String, 20),
        new JdeField("FBJOBN", "FBJOBN", JdeDataType.String, 20),
        new JdeField("FBUPMT", "FBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1210W_0", "Primary Key on FBNNBR, FBLDLN", new[] { "FBNNBR", "FBLDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
