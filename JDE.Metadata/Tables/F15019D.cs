using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15019D - .
/// </summary>
public class F15019D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NLBLFC.
        /// </summary>
        public const string NLBLFC = "NLBLFC";

        /// <summary>
        /// NLLNGP.
        /// </summary>
        public const string NLLNGP = "NLLNGP";

        /// <summary>
        /// NLDL01.
        /// </summary>
        public const string NLDL01 = "NLDL01";

        /// <summary>
        /// NLUSER.
        /// </summary>
        public const string NLUSER = "NLUSER";

        /// <summary>
        /// NLPID.
        /// </summary>
        public const string NLPID = "NLPID";

        /// <summary>
        /// NLUPMJ.
        /// </summary>
        public const string NLUPMJ = "NLUPMJ";

        /// <summary>
        /// NLUPMT.
        /// </summary>
        public const string NLUPMT = "NLUPMT";

        /// <summary>
        /// NLJOBN.
        /// </summary>
        public const string NLJOBN = "NLJOBN";

        /// <summary>
        /// NLTORG.
        /// </summary>
        public const string NLTORG = "NLTORG";

        /// <summary>
        /// NLENTJ.
        /// </summary>
        public const string NLENTJ = "NLENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15019D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NLBLFC", "NLBLFC", JdeDataType.String, 2, true, true),
        new JdeField("NLLNGP", "NLLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NLDL01", "NLDL01", JdeDataType.String, 60),
        new JdeField("NLUSER", "NLUSER", JdeDataType.String, 20),
        new JdeField("NLPID", "NLPID", JdeDataType.String, 20),
        new JdeField("NLUPMJ", "NLUPMJ", JdeDataType.Numeric),
        new JdeField("NLUPMT", "NLUPMT", JdeDataType.Numeric),
        new JdeField("NLJOBN", "NLJOBN", JdeDataType.String, 20),
        new JdeField("NLTORG", "NLTORG", JdeDataType.String, 20),
        new JdeField("NLENTJ", "NLENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15019D_0", "Primary Key on NLBLFC, NLLNGP", new[] { "NLBLFC", "NLLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
