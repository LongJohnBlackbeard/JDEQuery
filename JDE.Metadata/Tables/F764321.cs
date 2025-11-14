using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F764321 - .
/// </summary>
public class F764321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFKCOO.
        /// </summary>
        public const string TFKCOO = "TFKCOO";

        /// <summary>
        /// TFDOCO.
        /// </summary>
        public const string TFDOCO = "TFDOCO";

        /// <summary>
        /// TFDCTO.
        /// </summary>
        public const string TFDCTO = "TFDCTO";

        /// <summary>
        /// TFSFXO.
        /// </summary>
        public const string TFSFXO = "TFSFXO";

        /// <summary>
        /// TFLNID.
        /// </summary>
        public const string TFLNID = "TFLNID";

        /// <summary>
        /// TFB76CI.
        /// </summary>
        public const string TFB76CI = "TFB76CI";

        /// <summary>
        /// TFB76FCI.
        /// </summary>
        public const string TFB76FCI = "TFB76FCI";

        /// <summary>
        /// TFB76TIPI.
        /// </summary>
        public const string TFB76TIPI = "TFB76TIPI";

        /// <summary>
        /// TFB76NUM.
        /// </summary>
        public const string TFB76NUM = "TFB76NUM";

        /// <summary>
        /// TFB76AA.
        /// </summary>
        public const string TFB76AA = "TFB76AA";

        /// <summary>
        /// TFB76REF.
        /// </summary>
        public const string TFB76REF = "TFB76REF";

        /// <summary>
        /// TFB76COD.
        /// </summary>
        public const string TFB76COD = "TFB76COD";

        /// <summary>
        /// TFB76DATE.
        /// </summary>
        public const string TFB76DATE = "TFB76DATE";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F764321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFKCOO", "TFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TFDOCO", "TFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCTO", "TFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TFSFXO", "TFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TFLNID", "TFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TFB76CI", "TFB76CI", JdeDataType.Numeric),
        new JdeField("TFB76FCI", "TFB76FCI", JdeDataType.String, 100),
        new JdeField("TFB76TIPI", "TFB76TIPI", JdeDataType.String, 6),
        new JdeField("TFB76NUM", "TFB76NUM", JdeDataType.Numeric),
        new JdeField("TFB76AA", "TFB76AA", JdeDataType.Numeric),
        new JdeField("TFB76REF", "TFB76REF", JdeDataType.String, 30),
        new JdeField("TFB76COD", "TFB76COD", JdeDataType.String, 4),
        new JdeField("TFB76DATE", "TFB76DATE", JdeDataType.Numeric),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F764321_0", "Primary Key on TFKCOO, TFDOCO, TFDCTO, TFSFXO, TFLNID", new[] { "TFKCOO", "TFDOCO", "TFDCTO", "TFSFXO", "TFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
