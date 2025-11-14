using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B50 - .
/// </summary>
public class F03B50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REARL.
        /// </summary>
        public const string REARL = "REARL";

        /// <summary>
        /// REARS.
        /// </summary>
        public const string REARS = "REARS";

        /// <summary>
        /// REDL01.
        /// </summary>
        public const string REDL01 = "REDL01";

        /// <summary>
        /// REALGO.
        /// </summary>
        public const string REALGO = "REALGO";

        /// <summary>
        /// REVERS.
        /// </summary>
        public const string REVERS = "REVERS";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REUPMJ.
        /// </summary>
        public const string REUPMJ = "REUPMJ";

        /// <summary>
        /// REUPMT.
        /// </summary>
        public const string REUPMT = "REUPMT";

        /// <summary>
        /// REJOBN.
        /// </summary>
        public const string REJOBN = "REJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REARL", "REARL", JdeDataType.String, 20, true, true),
        new JdeField("REARS", "REARS", JdeDataType.Numeric, null, true, true),
        new JdeField("REDL01", "REDL01", JdeDataType.String, 60),
        new JdeField("REALGO", "REALGO", JdeDataType.String, 20),
        new JdeField("REVERS", "REVERS", JdeDataType.String, 20),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REUPMJ", "REUPMJ", JdeDataType.Numeric),
        new JdeField("REUPMT", "REUPMT", JdeDataType.Numeric),
        new JdeField("REJOBN", "REJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B50_0", "Primary Key on REARL, REARS", new[] { "REARL", "REARS" }, isUnique: true, isPrimaryKey: true)
    };
}
