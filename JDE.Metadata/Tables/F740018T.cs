using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740018T - .
/// </summary>
public class F740018T : JdeTable
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
        /// TFDCTO.
        /// </summary>
        public const string TFDCTO = "TFDCTO";

        /// <summary>
        /// TFDOCO.
        /// </summary>
        public const string TFDOCO = "TFDOCO";

        /// <summary>
        /// TFSFXO.
        /// </summary>
        public const string TFSFXO = "TFSFXO";

        /// <summary>
        /// TFLNID.
        /// </summary>
        public const string TFLNID = "TFLNID";

        /// <summary>
        /// TFPROCFL.
        /// </summary>
        public const string TFPROCFL = "TFPROCFL";

        /// <summary>
        /// TFURC1.
        /// </summary>
        public const string TFURC1 = "TFURC1";

        /// <summary>
        /// TFURDT.
        /// </summary>
        public const string TFURDT = "TFURDT";

        /// <summary>
        /// TFURAB.
        /// </summary>
        public const string TFURAB = "TFURAB";

        /// <summary>
        /// TFURAT.
        /// </summary>
        public const string TFURAT = "TFURAT";

        /// <summary>
        /// TFURRF.
        /// </summary>
        public const string TFURRF = "TFURRF";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

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
    public override string TableName => "F740018T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFKCOO", "TFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TFDCTO", "TFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TFDOCO", "TFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TFSFXO", "TFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TFLNID", "TFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TFPROCFL", "TFPROCFL", JdeDataType.String, 2),
        new JdeField("TFURC1", "TFURC1", JdeDataType.String, 6),
        new JdeField("TFURDT", "TFURDT", JdeDataType.Numeric),
        new JdeField("TFURAB", "TFURAB", JdeDataType.Numeric),
        new JdeField("TFURAT", "TFURAT", JdeDataType.Numeric),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740018T_0", "Primary Key on TFKCOO, TFDCTO, TFDOCO, TFSFXO, TFLNID", new[] { "TFKCOO", "TFDCTO", "TFDOCO", "TFSFXO", "TFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
