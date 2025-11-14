using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05119 - .
/// </summary>
public class F05119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLSCLE.
        /// </summary>
        public const string CLSCLE = "CLSCLE";

        /// <summary>
        /// CLSCLL.
        /// </summary>
        public const string CLSCLL = "CLSCLL";

        /// <summary>
        /// CLSCLH.
        /// </summary>
        public const string CLSCLH = "CLSCLH";

        /// <summary>
        /// CLDL01.
        /// </summary>
        public const string CLDL01 = "CLDL01";

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
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLUPMT.
        /// </summary>
        public const string CLUPMT = "CLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLSCLE", "CLSCLE", JdeDataType.String, 20, true, true),
        new JdeField("CLSCLL", "CLSCLL", JdeDataType.Numeric, null, true, true),
        new JdeField("CLSCLH", "CLSCLH", JdeDataType.Numeric, null, true, true),
        new JdeField("CLDL01", "CLDL01", JdeDataType.String, 60),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLJOBN", "CLJOBN", JdeDataType.String, 20),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLUPMT", "CLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05119_0", "Primary Key on CLSCLE, CLSCLL, CLSCLH", new[] { "CLSCLE", "CLSCLL", "CLSCLH" }, isUnique: true, isPrimaryKey: true)
    };
}
