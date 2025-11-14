using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8001 - .
/// </summary>
public class F76A8001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V2CDAA.
        /// </summary>
        public const string V2CDAA = "V2CDAA";

        /// <summary>
        /// V2DIVJ.
        /// </summary>
        public const string V2DIVJ = "V2DIVJ";

        /// <summary>
        /// V2AGRP.
        /// </summary>
        public const string V2AGRP = "V2AGRP";

        /// <summary>
        /// V2ACEM.
        /// </summary>
        public const string V2ACEM = "V2ACEM";

        /// <summary>
        /// V2AINW.
        /// </summary>
        public const string V2AINW = "V2AINW";

        /// <summary>
        /// V2AG.
        /// </summary>
        public const string V2AG = "V2AG";

        /// <summary>
        /// V2ATXC.
        /// </summary>
        public const string V2ATXC = "V2ATXC";

        /// <summary>
        /// V2ALGC.
        /// </summary>
        public const string V2ALGC = "V2ALGC";

        /// <summary>
        /// V2BICC.
        /// </summary>
        public const string V2BICC = "V2BICC";

        /// <summary>
        /// V2BBCS.
        /// </summary>
        public const string V2BBCS = "V2BBCS";

        /// <summary>
        /// V2DSVJ.
        /// </summary>
        public const string V2DSVJ = "V2DSVJ";

        /// <summary>
        /// V2AC01.
        /// </summary>
        public const string V2AC01 = "V2AC01";

        /// <summary>
        /// V2PAAP.
        /// </summary>
        public const string V2PAAP = "V2PAAP";

        /// <summary>
        /// V2APR1.
        /// </summary>
        public const string V2APR1 = "V2APR1";

        /// <summary>
        /// V2ABD.
        /// </summary>
        public const string V2ABD = "V2ABD";

        /// <summary>
        /// V2ADCT.
        /// </summary>
        public const string V2ADCT = "V2ADCT";

        /// <summary>
        /// V2TAX.
        /// </summary>
        public const string V2TAX = "V2TAX";

        /// <summary>
        /// V2BCGC.
        /// </summary>
        public const string V2BCGC = "V2BCGC";

        /// <summary>
        /// V2ALPH.
        /// </summary>
        public const string V2ALPH = "V2ALPH";

        /// <summary>
        /// V2APTO.
        /// </summary>
        public const string V2APTO = "V2APTO";

        /// <summary>
        /// V2ACUI.
        /// </summary>
        public const string V2ACUI = "V2ACUI";

        /// <summary>
        /// V2ACUM.
        /// </summary>
        public const string V2ACUM = "V2ACUM";

        /// <summary>
        /// V2AN8.
        /// </summary>
        public const string V2AN8 = "V2AN8";

        /// <summary>
        /// V2BCGT.
        /// </summary>
        public const string V2BCGT = "V2BCGT";

        /// <summary>
        /// V2CO.
        /// </summary>
        public const string V2CO = "V2CO";

        /// <summary>
        /// V2URCD.
        /// </summary>
        public const string V2URCD = "V2URCD";

        /// <summary>
        /// V2URDT.
        /// </summary>
        public const string V2URDT = "V2URDT";

        /// <summary>
        /// V2URAT.
        /// </summary>
        public const string V2URAT = "V2URAT";

        /// <summary>
        /// V2URAB.
        /// </summary>
        public const string V2URAB = "V2URAB";

        /// <summary>
        /// V2URRF.
        /// </summary>
        public const string V2URRF = "V2URRF";

        /// <summary>
        /// V2ACEM1.
        /// </summary>
        public const string V2ACEM1 = "V2ACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V2CDAA", "V2CDAA", JdeDataType.String, 4),
        new JdeField("V2DIVJ", "V2DIVJ", JdeDataType.Numeric),
        new JdeField("V2AGRP", "V2AGRP", JdeDataType.String, 2),
        new JdeField("V2ACEM", "V2ACEM", JdeDataType.String, 8),
        new JdeField("V2AINW", "V2AINW", JdeDataType.String, 16),
        new JdeField("V2AG", "V2AG", JdeDataType.Numeric),
        new JdeField("V2ATXC", "V2ATXC", JdeDataType.String, 20, true, true),
        new JdeField("V2ALGC", "V2ALGC", JdeDataType.String, 6),
        new JdeField("V2BICC", "V2BICC", JdeDataType.String, 2, true, true),
        new JdeField("V2BBCS", "V2BBCS", JdeDataType.Numeric),
        new JdeField("V2DSVJ", "V2DSVJ", JdeDataType.Numeric),
        new JdeField("V2AC01", "V2AC01", JdeDataType.String, 6),
        new JdeField("V2PAAP", "V2PAAP", JdeDataType.Numeric),
        new JdeField("V2APR1", "V2APR1", JdeDataType.Numeric),
        new JdeField("V2ABD", "V2ABD", JdeDataType.Numeric),
        new JdeField("V2ADCT", "V2ADCT", JdeDataType.String, 6),
        new JdeField("V2TAX", "V2TAX", JdeDataType.String, 40),
        new JdeField("V2BCGC", "V2BCGC", JdeDataType.String, 30),
        new JdeField("V2ALPH", "V2ALPH", JdeDataType.String, 80),
        new JdeField("V2APTO", "V2APTO", JdeDataType.String, 2),
        new JdeField("V2ACUI", "V2ACUI", JdeDataType.Numeric),
        new JdeField("V2ACUM", "V2ACUM", JdeDataType.Numeric),
        new JdeField("V2AN8", "V2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("V2BCGT", "V2BCGT", JdeDataType.String, 30, true, true),
        new JdeField("V2CO", "V2CO", JdeDataType.String, 10, true, true),
        new JdeField("V2URCD", "V2URCD", JdeDataType.String, 4),
        new JdeField("V2URDT", "V2URDT", JdeDataType.Numeric),
        new JdeField("V2URAT", "V2URAT", JdeDataType.Numeric),
        new JdeField("V2URAB", "V2URAB", JdeDataType.Numeric),
        new JdeField("V2URRF", "V2URRF", JdeDataType.String, 30),
        new JdeField("V2ACEM1", "V2ACEM1", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8001_0", "Primary Key on V2BICC, V2CO, V2AN8, V2BCGT, V2ATXC", new[] { "V2BICC", "V2CO", "V2AN8", "V2BCGT", "V2ATXC" }, isUnique: true, isPrimaryKey: true)
    };
}
