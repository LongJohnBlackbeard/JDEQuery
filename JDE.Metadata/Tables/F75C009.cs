using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C009 - .
/// </summary>
public class F75C009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BICO.
        /// </summary>
        public const string BICO = "BICO";

        /// <summary>
        /// BIC75SPRT.
        /// </summary>
        public const string BIC75SPRT = "BIC75SPRT";

        /// <summary>
        /// BIC75COAR.
        /// </summary>
        public const string BIC75COAR = "BIC75COAR";

        /// <summary>
        /// BIC75CFIR.
        /// </summary>
        public const string BIC75CFIR = "BIC75CFIR";

        /// <summary>
        /// BIC75JNHF.
        /// </summary>
        public const string BIC75JNHF = "BIC75JNHF";

        /// <summary>
        /// BIC75JHFR.
        /// </summary>
        public const string BIC75JHFR = "BIC75JHFR";

        /// <summary>
        /// BIC75JNLF.
        /// </summary>
        public const string BIC75JNLF = "BIC75JNLF";

        /// <summary>
        /// BIC75JLFR.
        /// </summary>
        public const string BIC75JLFR = "BIC75JLFR";

        /// <summary>
        /// BIFUTMATH1.
        /// </summary>
        public const string BIFUTMATH1 = "BIFUTMATH1";

        /// <summary>
        /// BIFUTSTR1.
        /// </summary>
        public const string BIFUTSTR1 = "BIFUTSTR1";

        /// <summary>
        /// BIFUTDATE1.
        /// </summary>
        public const string BIFUTDATE1 = "BIFUTDATE1";

        /// <summary>
        /// BIFUTUO1.
        /// </summary>
        public const string BIFUTUO1 = "BIFUTUO1";

        /// <summary>
        /// BIUSER.
        /// </summary>
        public const string BIUSER = "BIUSER";

        /// <summary>
        /// BIPID.
        /// </summary>
        public const string BIPID = "BIPID";

        /// <summary>
        /// BIJOBN.
        /// </summary>
        public const string BIJOBN = "BIJOBN";

        /// <summary>
        /// BIUPMJ.
        /// </summary>
        public const string BIUPMJ = "BIUPMJ";

        /// <summary>
        /// BIUPMT.
        /// </summary>
        public const string BIUPMT = "BIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BICO", "BICO", JdeDataType.String, 10, true, true),
        new JdeField("BIC75SPRT", "BIC75SPRT", JdeDataType.String, 2),
        new JdeField("BIC75COAR", "BIC75COAR", JdeDataType.String, 400),
        new JdeField("BIC75CFIR", "BIC75CFIR", JdeDataType.String, 400),
        new JdeField("BIC75JNHF", "BIC75JNHF", JdeDataType.String, 1000),
        new JdeField("BIC75JHFR", "BIC75JHFR", JdeDataType.String, 1000),
        new JdeField("BIC75JNLF", "BIC75JNLF", JdeDataType.String, 1000),
        new JdeField("BIC75JLFR", "BIC75JLFR", JdeDataType.String, 1000),
        new JdeField("BIFUTMATH1", "BIFUTMATH1", JdeDataType.Numeric),
        new JdeField("BIFUTSTR1", "BIFUTSTR1", JdeDataType.String, 100),
        new JdeField("BIFUTDATE1", "BIFUTDATE1", JdeDataType.Numeric),
        new JdeField("BIFUTUO1", "BIFUTUO1", JdeDataType.String, 2),
        new JdeField("BIUSER", "BIUSER", JdeDataType.String, 20),
        new JdeField("BIPID", "BIPID", JdeDataType.String, 20),
        new JdeField("BIJOBN", "BIJOBN", JdeDataType.String, 20),
        new JdeField("BIUPMJ", "BIUPMJ", JdeDataType.Numeric),
        new JdeField("BIUPMT", "BIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C009_0", "Primary Key on BICO", new[] { "BICO" }, isUnique: true, isPrimaryKey: true)
    };
}
