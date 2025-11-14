using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I15A - .
/// </summary>
public class F75I15A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QCCO.
        /// </summary>
        public const string QCCO = "QCCO";

        /// <summary>
        /// QCAN8.
        /// </summary>
        public const string QCAN8 = "QCAN8";

        /// <summary>
        /// QCYTYP.
        /// </summary>
        public const string QCYTYP = "QCYTYP";

        /// <summary>
        /// QCI75DTBG.
        /// </summary>
        public const string QCI75DTBG = "QCI75DTBG";

        /// <summary>
        /// QCI75DTEN.
        /// </summary>
        public const string QCI75DTEN = "QCI75DTEN";

        /// <summary>
        /// QCI75ORST.
        /// </summary>
        public const string QCI75ORST = "QCI75ORST";

        /// <summary>
        /// QCI75CRPE.
        /// </summary>
        public const string QCI75CRPE = "QCI75CRPE";

        /// <summary>
        /// QCI75TSUR.
        /// </summary>
        public const string QCI75TSUR = "QCI75TSUR";

        /// <summary>
        /// QCPTC.
        /// </summary>
        public const string QCPTC = "QCPTC";

        /// <summary>
        /// QCGLC.
        /// </summary>
        public const string QCGLC = "QCGLC";

        /// <summary>
        /// QCYAOC.
        /// </summary>
        public const string QCYAOC = "QCYAOC";

        /// <summary>
        /// QCYDSD.
        /// </summary>
        public const string QCYDSD = "QCYDSD";

        /// <summary>
        /// QCCDT.
        /// </summary>
        public const string QCCDT = "QCCDT";

        /// <summary>
        /// QCYDFD.
        /// </summary>
        public const string QCYDFD = "QCYDFD";

        /// <summary>
        /// QCUSER.
        /// </summary>
        public const string QCUSER = "QCUSER";

        /// <summary>
        /// QCPID.
        /// </summary>
        public const string QCPID = "QCPID";

        /// <summary>
        /// QCJOBN.
        /// </summary>
        public const string QCJOBN = "QCJOBN";

        /// <summary>
        /// QCUPMJ.
        /// </summary>
        public const string QCUPMJ = "QCUPMJ";

        /// <summary>
        /// QCUPMT.
        /// </summary>
        public const string QCUPMT = "QCUPMT";

        /// <summary>
        /// QCTORG.
        /// </summary>
        public const string QCTORG = "QCTORG";

        /// <summary>
        /// QCI75CEIR.
        /// </summary>
        public const string QCI75CEIR = "QCI75CEIR";

        /// <summary>
        /// QCI75SUCE.
        /// </summary>
        public const string QCI75SUCE = "QCI75SUCE";

        /// <summary>
        /// QCI75CERA.
        /// </summary>
        public const string QCI75CERA = "QCI75CERA";

        /// <summary>
        /// QCI75EFRA.
        /// </summary>
        public const string QCI75EFRA = "QCI75EFRA";

        /// <summary>
        /// QCCHGF.
        /// </summary>
        public const string QCCHGF = "QCCHGF";

        /// <summary>
        /// QCFLAG.
        /// </summary>
        public const string QCFLAG = "QCFLAG";

        /// <summary>
        /// QCI75THAM.
        /// </summary>
        public const string QCI75THAM = "QCI75THAM";

        /// <summary>
        /// QCI75CORL.
        /// </summary>
        public const string QCI75CORL = "QCI75CORL";

        /// <summary>
        /// QCI75CORF.
        /// </summary>
        public const string QCI75CORF = "QCI75CORF";

        /// <summary>
        /// QCI75INLI.
        /// </summary>
        public const string QCI75INLI = "QCI75INLI";

        /// <summary>
        /// QCI75HECR.
        /// </summary>
        public const string QCI75HECR = "QCI75HECR";

        /// <summary>
        /// QCI75FTX1.
        /// </summary>
        public const string QCI75FTX1 = "QCI75FTX1";

        /// <summary>
        /// QCI75FTX2.
        /// </summary>
        public const string QCI75FTX2 = "QCI75FTX2";

        /// <summary>
        /// QCI75EXST.
        /// </summary>
        public const string QCI75EXST = "QCI75EXST";
    }

    /// <inheritdoc />
    public override string TableName => "F75I15A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QCCO", "QCCO", JdeDataType.String, 10, true, true),
        new JdeField("QCAN8", "QCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("QCYTYP", "QCYTYP", JdeDataType.String, 2, true, true),
        new JdeField("QCI75DTBG", "QCI75DTBG", JdeDataType.Numeric, null, true, true),
        new JdeField("QCI75DTEN", "QCI75DTEN", JdeDataType.Numeric, null, true, true),
        new JdeField("QCI75ORST", "QCI75ORST", JdeDataType.String, 6, true, true),
        new JdeField("QCI75CRPE", "QCI75CRPE", JdeDataType.Numeric),
        new JdeField("QCI75TSUR", "QCI75TSUR", JdeDataType.Numeric),
        new JdeField("QCPTC", "QCPTC", JdeDataType.String, 6),
        new JdeField("QCGLC", "QCGLC", JdeDataType.String, 8),
        new JdeField("QCYAOC", "QCYAOC", JdeDataType.String, 80),
        new JdeField("QCYDSD", "QCYDSD", JdeDataType.Numeric),
        new JdeField("QCCDT", "QCCDT", JdeDataType.Numeric),
        new JdeField("QCYDFD", "QCYDFD", JdeDataType.Numeric),
        new JdeField("QCUSER", "QCUSER", JdeDataType.String, 20),
        new JdeField("QCPID", "QCPID", JdeDataType.String, 20),
        new JdeField("QCJOBN", "QCJOBN", JdeDataType.String, 20),
        new JdeField("QCUPMJ", "QCUPMJ", JdeDataType.Numeric),
        new JdeField("QCUPMT", "QCUPMT", JdeDataType.Numeric),
        new JdeField("QCTORG", "QCTORG", JdeDataType.String, 20),
        new JdeField("QCI75CEIR", "QCI75CEIR", JdeDataType.Numeric),
        new JdeField("QCI75SUCE", "QCI75SUCE", JdeDataType.Numeric),
        new JdeField("QCI75CERA", "QCI75CERA", JdeDataType.Numeric),
        new JdeField("QCI75EFRA", "QCI75EFRA", JdeDataType.Numeric),
        new JdeField("QCCHGF", "QCCHGF", JdeDataType.String, 2),
        new JdeField("QCFLAG", "QCFLAG", JdeDataType.String, 2),
        new JdeField("QCI75THAM", "QCI75THAM", JdeDataType.String, 2),
        new JdeField("QCI75CORL", "QCI75CORL", JdeDataType.Numeric),
        new JdeField("QCI75CORF", "QCI75CORF", JdeDataType.Numeric),
        new JdeField("QCI75INLI", "QCI75INLI", JdeDataType.Numeric),
        new JdeField("QCI75HECR", "QCI75HECR", JdeDataType.Numeric),
        new JdeField("QCI75FTX1", "QCI75FTX1", JdeDataType.Numeric),
        new JdeField("QCI75FTX2", "QCI75FTX2", JdeDataType.Numeric),
        new JdeField("QCI75EXST", "QCI75EXST", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I15A_0", "Primary Key on QCCO, QCAN8, QCYTYP, QCI75DTBG, QCI75DTEN, QCI75ORST", new[] { "QCCO", "QCAN8", "QCYTYP", "QCI75DTBG", "QCI75DTEN", "QCI75ORST" }, isUnique: true, isPrimaryKey: true)
    };
}
