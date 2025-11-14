using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8003 - .
/// </summary>
public class F76A8003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V4CDAA.
        /// </summary>
        public const string V4CDAA = "V4CDAA";

        /// <summary>
        /// V4DIVJ.
        /// </summary>
        public const string V4DIVJ = "V4DIVJ";

        /// <summary>
        /// V4AGRP.
        /// </summary>
        public const string V4AGRP = "V4AGRP";

        /// <summary>
        /// V4ACEM1.
        /// </summary>
        public const string V4ACEM1 = "V4ACEM1";

        /// <summary>
        /// V4AINW.
        /// </summary>
        public const string V4AINW = "V4AINW";

        /// <summary>
        /// V4AG.
        /// </summary>
        public const string V4AG = "V4AG";

        /// <summary>
        /// V4ATXC.
        /// </summary>
        public const string V4ATXC = "V4ATXC";

        /// <summary>
        /// V4ALGC.
        /// </summary>
        public const string V4ALGC = "V4ALGC";

        /// <summary>
        /// V4BICC.
        /// </summary>
        public const string V4BICC = "V4BICC";

        /// <summary>
        /// V4BBCS.
        /// </summary>
        public const string V4BBCS = "V4BBCS";

        /// <summary>
        /// V4DSVJ.
        /// </summary>
        public const string V4DSVJ = "V4DSVJ";

        /// <summary>
        /// V4AC01.
        /// </summary>
        public const string V4AC01 = "V4AC01";

        /// <summary>
        /// V4PAAP.
        /// </summary>
        public const string V4PAAP = "V4PAAP";

        /// <summary>
        /// V4APR1.
        /// </summary>
        public const string V4APR1 = "V4APR1";

        /// <summary>
        /// V4ABD.
        /// </summary>
        public const string V4ABD = "V4ABD";

        /// <summary>
        /// V4ADCT.
        /// </summary>
        public const string V4ADCT = "V4ADCT";

        /// <summary>
        /// V4TAX.
        /// </summary>
        public const string V4TAX = "V4TAX";

        /// <summary>
        /// V4BCGC.
        /// </summary>
        public const string V4BCGC = "V4BCGC";

        /// <summary>
        /// V4ALPH.
        /// </summary>
        public const string V4ALPH = "V4ALPH";

        /// <summary>
        /// V4APTO.
        /// </summary>
        public const string V4APTO = "V4APTO";

        /// <summary>
        /// V4ACUI.
        /// </summary>
        public const string V4ACUI = "V4ACUI";

        /// <summary>
        /// V4ACUM.
        /// </summary>
        public const string V4ACUM = "V4ACUM";

        /// <summary>
        /// V4AN8.
        /// </summary>
        public const string V4AN8 = "V4AN8";

        /// <summary>
        /// V4BCGT.
        /// </summary>
        public const string V4BCGT = "V4BCGT";

        /// <summary>
        /// V4CO.
        /// </summary>
        public const string V4CO = "V4CO";

        /// <summary>
        /// V4A76FRMV.
        /// </summary>
        public const string V4A76FRMV = "V4A76FRMV";

        /// <summary>
        /// V4A76TC.
        /// </summary>
        public const string V4A76TC = "V4A76TC";

        /// <summary>
        /// V4A76NW.
        /// </summary>
        public const string V4A76NW = "V4A76NW";

        /// <summary>
        /// V4A76NWR.
        /// </summary>
        public const string V4A76NWR = "V4A76NWR";

        /// <summary>
        /// V4A76CDNR.
        /// </summary>
        public const string V4A76CDNR = "V4A76CDNR";

        /// <summary>
        /// V4DTDO.
        /// </summary>
        public const string V4DTDO = "V4DTDO";

        /// <summary>
        /// V4A76DOCN.
        /// </summary>
        public const string V4A76DOCN = "V4A76DOCN";

        /// <summary>
        /// V4ADOT.
        /// </summary>
        public const string V4ADOT = "V4ADOT";

        /// <summary>
        /// V4JVTDA.
        /// </summary>
        public const string V4JVTDA = "V4JVTDA";

        /// <summary>
        /// V4XFLG.
        /// </summary>
        public const string V4XFLG = "V4XFLG";

        /// <summary>
        /// V4ACAI.
        /// </summary>
        public const string V4ACAI = "V4ACAI";

        /// <summary>
        /// V4A76WOCN.
        /// </summary>
        public const string V4A76WOCN = "V4A76WOCN";

        /// <summary>
        /// V4A76WOCA.
        /// </summary>
        public const string V4A76WOCA = "V4A76WOCA";

        /// <summary>
        /// V4A76WOCD.
        /// </summary>
        public const string V4A76WOCD = "V4A76WOCD";

        /// <summary>
        /// V4URCD.
        /// </summary>
        public const string V4URCD = "V4URCD";

        /// <summary>
        /// V4URDT.
        /// </summary>
        public const string V4URDT = "V4URDT";

        /// <summary>
        /// V4URAT.
        /// </summary>
        public const string V4URAT = "V4URAT";

        /// <summary>
        /// V4URAB.
        /// </summary>
        public const string V4URAB = "V4URAB";

        /// <summary>
        /// V4URRF.
        /// </summary>
        public const string V4URRF = "V4URRF";

        /// <summary>
        /// V4FNUMB12.
        /// </summary>
        public const string V4FNUMB12 = "V4FNUMB12";

        /// <summary>
        /// V4FNUMB13.
        /// </summary>
        public const string V4FNUMB13 = "V4FNUMB13";

        /// <summary>
        /// V4FNUMB14.
        /// </summary>
        public const string V4FNUMB14 = "V4FNUMB14";

        /// <summary>
        /// V4FSTRN12.
        /// </summary>
        public const string V4FSTRN12 = "V4FSTRN12";

        /// <summary>
        /// V4FSTRN13.
        /// </summary>
        public const string V4FSTRN13 = "V4FSTRN13";

        /// <summary>
        /// V4FSTRN14.
        /// </summary>
        public const string V4FSTRN14 = "V4FSTRN14";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V4CDAA", "V4CDAA", JdeDataType.String, 4),
        new JdeField("V4DIVJ", "V4DIVJ", JdeDataType.Numeric),
        new JdeField("V4AGRP", "V4AGRP", JdeDataType.String, 2),
        new JdeField("V4ACEM1", "V4ACEM1", JdeDataType.String, 30),
        new JdeField("V4AINW", "V4AINW", JdeDataType.String, 16),
        new JdeField("V4AG", "V4AG", JdeDataType.Numeric),
        new JdeField("V4ATXC", "V4ATXC", JdeDataType.String, 20, true, true),
        new JdeField("V4ALGC", "V4ALGC", JdeDataType.String, 6),
        new JdeField("V4BICC", "V4BICC", JdeDataType.String, 2, true, true),
        new JdeField("V4BBCS", "V4BBCS", JdeDataType.Numeric),
        new JdeField("V4DSVJ", "V4DSVJ", JdeDataType.Numeric),
        new JdeField("V4AC01", "V4AC01", JdeDataType.String, 6),
        new JdeField("V4PAAP", "V4PAAP", JdeDataType.Numeric),
        new JdeField("V4APR1", "V4APR1", JdeDataType.Numeric),
        new JdeField("V4ABD", "V4ABD", JdeDataType.Numeric),
        new JdeField("V4ADCT", "V4ADCT", JdeDataType.String, 6),
        new JdeField("V4TAX", "V4TAX", JdeDataType.String, 40),
        new JdeField("V4BCGC", "V4BCGC", JdeDataType.String, 30),
        new JdeField("V4ALPH", "V4ALPH", JdeDataType.String, 80),
        new JdeField("V4APTO", "V4APTO", JdeDataType.String, 2),
        new JdeField("V4ACUI", "V4ACUI", JdeDataType.Numeric),
        new JdeField("V4ACUM", "V4ACUM", JdeDataType.Numeric),
        new JdeField("V4AN8", "V4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("V4BCGT", "V4BCGT", JdeDataType.String, 30, true, true),
        new JdeField("V4CO", "V4CO", JdeDataType.String, 10, true, true),
        new JdeField("V4A76FRMV", "V4A76FRMV", JdeDataType.String, 8),
        new JdeField("V4A76TC", "V4A76TC", JdeDataType.Numeric),
        new JdeField("V4A76NW", "V4A76NW", JdeDataType.String, 2),
        new JdeField("V4A76NWR", "V4A76NWR", JdeDataType.String, 60),
        new JdeField("V4A76CDNR", "V4A76CDNR", JdeDataType.String, 60),
        new JdeField("V4DTDO", "V4DTDO", JdeDataType.Numeric),
        new JdeField("V4A76DOCN", "V4A76DOCN", JdeDataType.String, 32),
        new JdeField("V4ADOT", "V4ADOT", JdeDataType.Numeric),
        new JdeField("V4JVTDA", "V4JVTDA", JdeDataType.Numeric),
        new JdeField("V4XFLG", "V4XFLG", JdeDataType.String, 2),
        new JdeField("V4ACAI", "V4ACAI", JdeDataType.String, 28),
        new JdeField("V4A76WOCN", "V4A76WOCN", JdeDataType.String, 50),
        new JdeField("V4A76WOCA", "V4A76WOCA", JdeDataType.Numeric),
        new JdeField("V4A76WOCD", "V4A76WOCD", JdeDataType.Numeric),
        new JdeField("V4URCD", "V4URCD", JdeDataType.String, 4),
        new JdeField("V4URDT", "V4URDT", JdeDataType.Numeric),
        new JdeField("V4URAT", "V4URAT", JdeDataType.Numeric),
        new JdeField("V4URAB", "V4URAB", JdeDataType.Numeric),
        new JdeField("V4URRF", "V4URRF", JdeDataType.String, 30),
        new JdeField("V4FNUMB12", "V4FNUMB12", JdeDataType.Numeric),
        new JdeField("V4FNUMB13", "V4FNUMB13", JdeDataType.Numeric),
        new JdeField("V4FNUMB14", "V4FNUMB14", JdeDataType.Numeric),
        new JdeField("V4FSTRN12", "V4FSTRN12", JdeDataType.String, 50),
        new JdeField("V4FSTRN13", "V4FSTRN13", JdeDataType.String, 50),
        new JdeField("V4FSTRN14", "V4FSTRN14", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8003_0", "Primary Key on V4BICC, V4CO, V4AN8, V4ATXC, V4BCGT", new[] { "V4BICC", "V4CO", "V4AN8", "V4ATXC", "V4BCGT" }, isUnique: true, isPrimaryKey: true)
    };
}
