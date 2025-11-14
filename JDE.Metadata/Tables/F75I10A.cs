using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I10A - .
/// </summary>
public class F75I10A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAYTYP.
        /// </summary>
        public const string QAYTYP = "QAYTYP";

        /// <summary>
        /// QATAXC.
        /// </summary>
        public const string QATAXC = "QATAXC";

        /// <summary>
        /// QAI75DTBG.
        /// </summary>
        public const string QAI75DTBG = "QAI75DTBG";

        /// <summary>
        /// QAI75DTEN.
        /// </summary>
        public const string QAI75DTEN = "QAI75DTEN";

        /// <summary>
        /// QAI75ORST.
        /// </summary>
        public const string QAI75ORST = "QAI75ORST";

        /// <summary>
        /// QAYGRP.
        /// </summary>
        public const string QAYGRP = "QAYGRP";

        /// <summary>
        /// QAI75TDSR.
        /// </summary>
        public const string QAI75TDSR = "QAI75TDSR";

        /// <summary>
        /// QAYERT.
        /// </summary>
        public const string QAYERT = "QAYERT";

        /// <summary>
        /// QAI75TSUR.
        /// </summary>
        public const string QAI75TSUR = "QAI75TSUR";

        /// <summary>
        /// QAPTC.
        /// </summary>
        public const string QAPTC = "QAPTC";

        /// <summary>
        /// QAGLC.
        /// </summary>
        public const string QAGLC = "QAGLC";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QATORG.
        /// </summary>
        public const string QATORG = "QATORG";

        /// <summary>
        /// QACDT.
        /// </summary>
        public const string QACDT = "QACDT";

        /// <summary>
        /// QAI75CEIR.
        /// </summary>
        public const string QAI75CEIR = "QAI75CEIR";

        /// <summary>
        /// QAI75SUCE.
        /// </summary>
        public const string QAI75SUCE = "QAI75SUCE";

        /// <summary>
        /// QAI75CERA.
        /// </summary>
        public const string QAI75CERA = "QAI75CERA";

        /// <summary>
        /// QAI75EFRA.
        /// </summary>
        public const string QAI75EFRA = "QAI75EFRA";

        /// <summary>
        /// QAJOBN.
        /// </summary>
        public const string QAJOBN = "QAJOBN";

        /// <summary>
        /// QAUPMJ.
        /// </summary>
        public const string QAUPMJ = "QAUPMJ";

        /// <summary>
        /// QAUPMT.
        /// </summary>
        public const string QAUPMT = "QAUPMT";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAI75THAM.
        /// </summary>
        public const string QAI75THAM = "QAI75THAM";

        /// <summary>
        /// QAI75INLI.
        /// </summary>
        public const string QAI75INLI = "QAI75INLI";

        /// <summary>
        /// QAI75HECR.
        /// </summary>
        public const string QAI75HECR = "QAI75HECR";

        /// <summary>
        /// QAI75FTX1.
        /// </summary>
        public const string QAI75FTX1 = "QAI75FTX1";

        /// <summary>
        /// QAI75FTX2.
        /// </summary>
        public const string QAI75FTX2 = "QAI75FTX2";

        /// <summary>
        /// QAI75TDSF.
        /// </summary>
        public const string QAI75TDSF = "QAI75TDSF";

        /// <summary>
        /// QAI75EXST.
        /// </summary>
        public const string QAI75EXST = "QAI75EXST";
    }

    /// <inheritdoc />
    public override string TableName => "F75I10A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAYTYP", "QAYTYP", JdeDataType.String, 2, true, true),
        new JdeField("QATAXC", "QATAXC", JdeDataType.String, 2, true, true),
        new JdeField("QAI75DTBG", "QAI75DTBG", JdeDataType.Numeric, null, true, true),
        new JdeField("QAI75DTEN", "QAI75DTEN", JdeDataType.Numeric, null, true, true),
        new JdeField("QAI75ORST", "QAI75ORST", JdeDataType.String, 6, true, true),
        new JdeField("QAYGRP", "QAYGRP", JdeDataType.String, 2),
        new JdeField("QAI75TDSR", "QAI75TDSR", JdeDataType.Numeric),
        new JdeField("QAYERT", "QAYERT", JdeDataType.Numeric),
        new JdeField("QAI75TSUR", "QAI75TSUR", JdeDataType.Numeric),
        new JdeField("QAPTC", "QAPTC", JdeDataType.String, 6),
        new JdeField("QAGLC", "QAGLC", JdeDataType.String, 8),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QATORG", "QATORG", JdeDataType.String, 20),
        new JdeField("QACDT", "QACDT", JdeDataType.Numeric),
        new JdeField("QAI75CEIR", "QAI75CEIR", JdeDataType.Numeric),
        new JdeField("QAI75SUCE", "QAI75SUCE", JdeDataType.Numeric),
        new JdeField("QAI75CERA", "QAI75CERA", JdeDataType.Numeric),
        new JdeField("QAI75EFRA", "QAI75EFRA", JdeDataType.Numeric),
        new JdeField("QAJOBN", "QAJOBN", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QAUPMT", "QAUPMT", JdeDataType.Numeric),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAI75THAM", "QAI75THAM", JdeDataType.String, 2),
        new JdeField("QAI75INLI", "QAI75INLI", JdeDataType.Numeric),
        new JdeField("QAI75HECR", "QAI75HECR", JdeDataType.Numeric),
        new JdeField("QAI75FTX1", "QAI75FTX1", JdeDataType.Numeric),
        new JdeField("QAI75FTX2", "QAI75FTX2", JdeDataType.Numeric),
        new JdeField("QAI75TDSF", "QAI75TDSF", JdeDataType.String, 2),
        new JdeField("QAI75EXST", "QAI75EXST", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I10A_0", "Primary Key on QAYTYP, QATAXC, QAI75DTBG, QAI75DTEN, QAI75ORST", new[] { "QAYTYP", "QATAXC", "QAI75DTBG", "QAI75DTEN", "QAI75ORST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I10A_2", "Index on QAYTYP, QATAXC, QAI75ORST", new[] { "QAYTYP", "QATAXC", "QAI75ORST" })
    };
}
