using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41061 - .
/// </summary>
public class F41061 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBMCU.
        /// </summary>
        public const string CBMCU = "CBMCU";

        /// <summary>
        /// CBAN8.
        /// </summary>
        public const string CBAN8 = "CBAN8";

        /// <summary>
        /// CBITM.
        /// </summary>
        public const string CBITM = "CBITM";

        /// <summary>
        /// CBLITM.
        /// </summary>
        public const string CBLITM = "CBLITM";

        /// <summary>
        /// CBAITM.
        /// </summary>
        public const string CBAITM = "CBAITM";

        /// <summary>
        /// CBCATN.
        /// </summary>
        public const string CBCATN = "CBCATN";

        /// <summary>
        /// CBDMCT.
        /// </summary>
        public const string CBDMCT = "CBDMCT";

        /// <summary>
        /// CBDMCS.
        /// </summary>
        public const string CBDMCS = "CBDMCS";

        /// <summary>
        /// CBKCOO.
        /// </summary>
        public const string CBKCOO = "CBKCOO";

        /// <summary>
        /// CBDOCO.
        /// </summary>
        public const string CBDOCO = "CBDOCO";

        /// <summary>
        /// CBDCTO.
        /// </summary>
        public const string CBDCTO = "CBDCTO";

        /// <summary>
        /// CBLNID.
        /// </summary>
        public const string CBLNID = "CBLNID";

        /// <summary>
        /// CBCRCD.
        /// </summary>
        public const string CBCRCD = "CBCRCD";

        /// <summary>
        /// CBUOM.
        /// </summary>
        public const string CBUOM = "CBUOM";

        /// <summary>
        /// CBPRRC.
        /// </summary>
        public const string CBPRRC = "CBPRRC";

        /// <summary>
        /// CBUORG.
        /// </summary>
        public const string CBUORG = "CBUORG";

        /// <summary>
        /// CBEFTJ.
        /// </summary>
        public const string CBEFTJ = "CBEFTJ";

        /// <summary>
        /// CBEXDJ.
        /// </summary>
        public const string CBEXDJ = "CBEXDJ";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBJOBN.
        /// </summary>
        public const string CBJOBN = "CBJOBN";

        /// <summary>
        /// CBUPMJ.
        /// </summary>
        public const string CBUPMJ = "CBUPMJ";

        /// <summary>
        /// CBTDAY.
        /// </summary>
        public const string CBTDAY = "CBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41061";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBMCU", "CBMCU", JdeDataType.String, 24, true, true),
        new JdeField("CBAN8", "CBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CBITM", "CBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CBLITM", "CBLITM", JdeDataType.String, 50),
        new JdeField("CBAITM", "CBAITM", JdeDataType.String, 50),
        new JdeField("CBCATN", "CBCATN", JdeDataType.String, 16, true, true),
        new JdeField("CBDMCT", "CBDMCT", JdeDataType.String, 24),
        new JdeField("CBDMCS", "CBDMCS", JdeDataType.Numeric),
        new JdeField("CBKCOO", "CBKCOO", JdeDataType.String, 10),
        new JdeField("CBDOCO", "CBDOCO", JdeDataType.Numeric),
        new JdeField("CBDCTO", "CBDCTO", JdeDataType.String, 4),
        new JdeField("CBLNID", "CBLNID", JdeDataType.Numeric),
        new JdeField("CBCRCD", "CBCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CBUOM", "CBUOM", JdeDataType.String, 4, true, true),
        new JdeField("CBPRRC", "CBPRRC", JdeDataType.Numeric),
        new JdeField("CBUORG", "CBUORG", JdeDataType.Numeric, null, true, true),
        new JdeField("CBEFTJ", "CBEFTJ", JdeDataType.Numeric),
        new JdeField("CBEXDJ", "CBEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBTDAY", "CBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41061_0", "Primary Key on CBMCU, CBAN8, CBITM, CBCATN, CBCRCD, CBUOM, CBUORG, CBEXDJ", new[] { "CBMCU", "CBAN8", "CBITM", "CBCATN", "CBCRCD", "CBUOM", "CBUORG", "CBEXDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41061_4", "Index on CBITM, CBCATN, CBAN8, CBCRCD, CBUOM, CBEXDJ, CBUORG", new[] { "CBITM", "CBCATN", "CBAN8", "CBCRCD", "CBUOM", "CBEXDJ", "CBUORG" }),
        new JdeIndex("F41061_5", "Index on CBAN8, CBITM, CBCRCD, CBUOM, CBCATN", new[] { "CBAN8", "CBITM", "CBCRCD", "CBUOM", "CBCATN" }),
        new JdeIndex("F41061_6", "Index on CBMCU, CBAN8, CBITM, CBCRCD, CBUOM, CBCATN", new[] { "CBMCU", "CBAN8", "CBITM", "CBCRCD", "CBUOM", "CBCATN" }),
        new JdeIndex("F41061_7", "Index on CBAN8, CBCATN", new[] { "CBAN8", "CBCATN" })
    };
}
