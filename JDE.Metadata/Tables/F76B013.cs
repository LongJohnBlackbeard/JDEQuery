using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B013 - .
/// </summary>
public class F76B013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFBCFC.
        /// </summary>
        public const string TFBCFC = "TFBCFC";

        /// <summary>
        /// TFB76TSPIS.
        /// </summary>
        public const string TFB76TSPIS = "TFB76TSPIS";

        /// <summary>
        /// TFB76TSCOF.
        /// </summary>
        public const string TFB76TSCOF = "TFB76TSCOF";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFTDAY.
        /// </summary>
        public const string TFTDAY = "TFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFBCFC", "TFBCFC", JdeDataType.String, 6, true, true),
        new JdeField("TFB76TSPIS", "TFB76TSPIS", JdeDataType.String, 6),
        new JdeField("TFB76TSCOF", "TFB76TSCOF", JdeDataType.String, 6),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFTDAY", "TFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B013_0", "Primary Key on TFBCFC", new[] { "TFBCFC" }, isUnique: true, isPrimaryKey: true)
    };
}
