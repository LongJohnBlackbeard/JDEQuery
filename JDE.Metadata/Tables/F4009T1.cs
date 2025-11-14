using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4009T1 - .
/// </summary>
public class F4009T1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTSY.
        /// </summary>
        public const string CTSY = "CTSY";

        /// <summary>
        /// CTTPSC.
        /// </summary>
        public const string CTTPSC = "CTTPSC";

        /// <summary>
        /// CTCTXP.
        /// </summary>
        public const string CTCTXP = "CTCTXP";

        /// <summary>
        /// CTDFUC1.
        /// </summary>
        public const string CTDFUC1 = "CTDFUC1";

        /// <summary>
        /// CTDFUC2.
        /// </summary>
        public const string CTDFUC2 = "CTDFUC2";

        /// <summary>
        /// CTDFUC3.
        /// </summary>
        public const string CTDFUC3 = "CTDFUC3";

        /// <summary>
        /// CTDFUS1.
        /// </summary>
        public const string CTDFUS1 = "CTDFUS1";

        /// <summary>
        /// CTDFUS2.
        /// </summary>
        public const string CTDFUS2 = "CTDFUS2";

        /// <summary>
        /// CTDFUS3.
        /// </summary>
        public const string CTDFUS3 = "CTDFUS3";

        /// <summary>
        /// CTDFUDJ.
        /// </summary>
        public const string CTDFUDJ = "CTDFUDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4009T1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTSY", "CTSY", JdeDataType.String, 8, true, true),
        new JdeField("CTTPSC", "CTTPSC", JdeDataType.String, 2),
        new JdeField("CTCTXP", "CTCTXP", JdeDataType.String, 2),
        new JdeField("CTDFUC1", "CTDFUC1", JdeDataType.String, 2),
        new JdeField("CTDFUC2", "CTDFUC2", JdeDataType.String, 2),
        new JdeField("CTDFUC3", "CTDFUC3", JdeDataType.String, 2),
        new JdeField("CTDFUS1", "CTDFUS1", JdeDataType.String, 20),
        new JdeField("CTDFUS2", "CTDFUS2", JdeDataType.String, 20),
        new JdeField("CTDFUS3", "CTDFUS3", JdeDataType.String, 20),
        new JdeField("CTDFUDJ", "CTDFUDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4009T1_0", "Primary Key on CTSY", new[] { "CTSY" }, isUnique: true, isPrimaryKey: true)
    };
}
