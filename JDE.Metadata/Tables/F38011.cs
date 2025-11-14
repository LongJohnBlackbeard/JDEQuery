using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38011 - .
/// </summary>
public class F38011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DFDMCT.
        /// </summary>
        public const string DFDMCT = "DFDMCT";

        /// <summary>
        /// DFDMCS.
        /// </summary>
        public const string DFDMCS = "DFDMCS";

        /// <summary>
        /// DFCNQY.
        /// </summary>
        public const string DFCNQY = "DFCNQY";

        /// <summary>
        /// DFDTO.
        /// </summary>
        public const string DFDTO = "DFDTO";

        /// <summary>
        /// DFDES.
        /// </summary>
        public const string DFDES = "DFDES";

        /// <summary>
        /// DFDESY.
        /// </summary>
        public const string DFDESY = "DFDESY";

        /// <summary>
        /// DFITM.
        /// </summary>
        public const string DFITM = "DFITM";

        /// <summary>
        /// DFSEQ.
        /// </summary>
        public const string DFSEQ = "DFSEQ";

        /// <summary>
        /// DFCNQT.
        /// </summary>
        public const string DFCNQT = "DFCNQT";

        /// <summary>
        /// DFAA.
        /// </summary>
        public const string DFAA = "DFAA";

        /// <summary>
        /// DFUOM.
        /// </summary>
        public const string DFUOM = "DFUOM";

        /// <summary>
        /// DFMINQ.
        /// </summary>
        public const string DFMINQ = "DFMINQ";

        /// <summary>
        /// DFMAXQ.
        /// </summary>
        public const string DFMAXQ = "DFMAXQ";

        /// <summary>
        /// DFEFTJ.
        /// </summary>
        public const string DFEFTJ = "DFEFTJ";

        /// <summary>
        /// DFEXDJ.
        /// </summary>
        public const string DFEXDJ = "DFEXDJ";

        /// <summary>
        /// DFUPRC.
        /// </summary>
        public const string DFUPRC = "DFUPRC";

        /// <summary>
        /// DFASN.
        /// </summary>
        public const string DFASN = "DFASN";

        /// <summary>
        /// DFPASN.
        /// </summary>
        public const string DFPASN = "DFPASN";

        /// <summary>
        /// DFMCU.
        /// </summary>
        public const string DFMCU = "DFMCU";

        /// <summary>
        /// DFCRCD.
        /// </summary>
        public const string DFCRCD = "DFCRCD";

        /// <summary>
        /// DFTV01.
        /// </summary>
        public const string DFTV01 = "DFTV01";

        /// <summary>
        /// DFTV02.
        /// </summary>
        public const string DFTV02 = "DFTV02";

        /// <summary>
        /// DFTV03.
        /// </summary>
        public const string DFTV03 = "DFTV03";

        /// <summary>
        /// DFQTY1.
        /// </summary>
        public const string DFQTY1 = "DFQTY1";

        /// <summary>
        /// DFTVUM.
        /// </summary>
        public const string DFTVUM = "DFTVUM";

        /// <summary>
        /// DFURCD.
        /// </summary>
        public const string DFURCD = "DFURCD";

        /// <summary>
        /// DFURDT.
        /// </summary>
        public const string DFURDT = "DFURDT";

        /// <summary>
        /// DFURAT.
        /// </summary>
        public const string DFURAT = "DFURAT";

        /// <summary>
        /// DFURAB.
        /// </summary>
        public const string DFURAB = "DFURAB";

        /// <summary>
        /// DFURRF.
        /// </summary>
        public const string DFURRF = "DFURRF";

        /// <summary>
        /// DFUSER.
        /// </summary>
        public const string DFUSER = "DFUSER";

        /// <summary>
        /// DFPID.
        /// </summary>
        public const string DFPID = "DFPID";

        /// <summary>
        /// DFJOBN.
        /// </summary>
        public const string DFJOBN = "DFJOBN";

        /// <summary>
        /// DFUPMJ.
        /// </summary>
        public const string DFUPMJ = "DFUPMJ";

        /// <summary>
        /// DFTDAY.
        /// </summary>
        public const string DFTDAY = "DFTDAY";

        /// <summary>
        /// DFRPQT.
        /// </summary>
        public const string DFRPQT = "DFRPQT";

        /// <summary>
        /// DFQEDT.
        /// </summary>
        public const string DFQEDT = "DFQEDT";

        /// <summary>
        /// DFQED3.
        /// </summary>
        public const string DFQED3 = "DFQED3";

        /// <summary>
        /// DFQED2.
        /// </summary>
        public const string DFQED2 = "DFQED2";

        /// <summary>
        /// DFPDP5.
        /// </summary>
        public const string DFPDP5 = "DFPDP5";
    }

    /// <inheritdoc />
    public override string TableName => "F38011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DFDMCT", "DFDMCT", JdeDataType.String, 24, true, true),
        new JdeField("DFDMCS", "DFDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("DFCNQY", "DFCNQY", JdeDataType.String, 2),
        new JdeField("DFDTO", "DFDTO", JdeDataType.String, 2),
        new JdeField("DFDES", "DFDES", JdeDataType.String, 24),
        new JdeField("DFDESY", "DFDESY", JdeDataType.String, 4),
        new JdeField("DFITM", "DFITM", JdeDataType.Numeric),
        new JdeField("DFSEQ", "DFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DFCNQT", "DFCNQT", JdeDataType.Numeric),
        new JdeField("DFAA", "DFAA", JdeDataType.Numeric),
        new JdeField("DFUOM", "DFUOM", JdeDataType.String, 4),
        new JdeField("DFMINQ", "DFMINQ", JdeDataType.Numeric),
        new JdeField("DFMAXQ", "DFMAXQ", JdeDataType.Numeric),
        new JdeField("DFEFTJ", "DFEFTJ", JdeDataType.Numeric),
        new JdeField("DFEXDJ", "DFEXDJ", JdeDataType.Numeric),
        new JdeField("DFUPRC", "DFUPRC", JdeDataType.Numeric),
        new JdeField("DFASN", "DFASN", JdeDataType.String, 16),
        new JdeField("DFPASN", "DFPASN", JdeDataType.String, 16),
        new JdeField("DFMCU", "DFMCU", JdeDataType.String, 24),
        new JdeField("DFCRCD", "DFCRCD", JdeDataType.String, 6),
        new JdeField("DFTV01", "DFTV01", JdeDataType.String, 2),
        new JdeField("DFTV02", "DFTV02", JdeDataType.String, 2),
        new JdeField("DFTV03", "DFTV03", JdeDataType.String, 2),
        new JdeField("DFQTY1", "DFQTY1", JdeDataType.Numeric),
        new JdeField("DFTVUM", "DFTVUM", JdeDataType.String, 4),
        new JdeField("DFURCD", "DFURCD", JdeDataType.String, 4),
        new JdeField("DFURDT", "DFURDT", JdeDataType.Numeric),
        new JdeField("DFURAT", "DFURAT", JdeDataType.Numeric),
        new JdeField("DFURAB", "DFURAB", JdeDataType.Numeric),
        new JdeField("DFURRF", "DFURRF", JdeDataType.String, 30),
        new JdeField("DFUSER", "DFUSER", JdeDataType.String, 20),
        new JdeField("DFPID", "DFPID", JdeDataType.String, 20),
        new JdeField("DFJOBN", "DFJOBN", JdeDataType.String, 20),
        new JdeField("DFUPMJ", "DFUPMJ", JdeDataType.Numeric),
        new JdeField("DFTDAY", "DFTDAY", JdeDataType.Numeric),
        new JdeField("DFRPQT", "DFRPQT", JdeDataType.Numeric),
        new JdeField("DFQEDT", "DFQEDT", JdeDataType.String, 2),
        new JdeField("DFQED3", "DFQED3", JdeDataType.String, 2),
        new JdeField("DFQED2", "DFQED2", JdeDataType.String, 2),
        new JdeField("DFPDP5", "DFPDP5", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38011_0", "Primary Key on DFDMCT, DFDMCS, DFSEQ", new[] { "DFDMCT", "DFDMCS", "DFSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
