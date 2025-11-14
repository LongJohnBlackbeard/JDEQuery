using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B007 - .
/// </summary>
public class F76B007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNFCO.
        /// </summary>
        public const string NNFCO = "NNFCO";

        /// <summary>
        /// NNB76TNF.
        /// </summary>
        public const string NNB76TNF = "NNB76TNF";

        /// <summary>
        /// NNB76LSER.
        /// </summary>
        public const string NNB76LSER = "NNB76LSER";

        /// <summary>
        /// NNB76LNN.
        /// </summary>
        public const string NNB76LNN = "NNB76LNN";

        /// <summary>
        /// NNUSER.
        /// </summary>
        public const string NNUSER = "NNUSER";

        /// <summary>
        /// NNPID.
        /// </summary>
        public const string NNPID = "NNPID";

        /// <summary>
        /// NNJOBN.
        /// </summary>
        public const string NNJOBN = "NNJOBN";

        /// <summary>
        /// NNUPMJ.
        /// </summary>
        public const string NNUPMJ = "NNUPMJ";

        /// <summary>
        /// NNUPMT.
        /// </summary>
        public const string NNUPMT = "NNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNFCO", "NNFCO", JdeDataType.String, 10, true, true),
        new JdeField("NNB76TNF", "NNB76TNF", JdeDataType.String, 20, true, true),
        new JdeField("NNB76LSER", "NNB76LSER", JdeDataType.String, 20, true, true),
        new JdeField("NNB76LNN", "NNB76LNN", JdeDataType.Numeric),
        new JdeField("NNUSER", "NNUSER", JdeDataType.String, 20),
        new JdeField("NNPID", "NNPID", JdeDataType.String, 20),
        new JdeField("NNJOBN", "NNJOBN", JdeDataType.String, 20),
        new JdeField("NNUPMJ", "NNUPMJ", JdeDataType.Numeric),
        new JdeField("NNUPMT", "NNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B007_0", "Primary Key on NNFCO, NNB76TNF, NNB76LSER", new[] { "NNFCO", "NNB76TNF", "NNB76LSER" }, isUnique: true, isPrimaryKey: true)
    };
}
