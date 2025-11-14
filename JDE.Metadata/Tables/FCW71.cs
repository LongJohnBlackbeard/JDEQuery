using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW71 - .
/// </summary>
public class FCW71 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBC9PLN.
        /// </summary>
        public const string CBC9PLN = "CBC9PLN";

        /// <summary>
        /// CBC9LVL0.
        /// </summary>
        public const string CBC9LVL0 = "CBC9LVL0";

        /// <summary>
        /// CBC9LVL1.
        /// </summary>
        public const string CBC9LVL1 = "CBC9LVL1";

        /// <summary>
        /// CBC9LVL2.
        /// </summary>
        public const string CBC9LVL2 = "CBC9LVL2";

        /// <summary>
        /// CBC9LVL3.
        /// </summary>
        public const string CBC9LVL3 = "CBC9LVL3";

        /// <summary>
        /// CBC9LVL4.
        /// </summary>
        public const string CBC9LVL4 = "CBC9LVL4";

        /// <summary>
        /// CBC9LVL5.
        /// </summary>
        public const string CBC9LVL5 = "CBC9LVL5";

        /// <summary>
        /// CBC9LVL6.
        /// </summary>
        public const string CBC9LVL6 = "CBC9LVL6";

        /// <summary>
        /// CBC9LVL7.
        /// </summary>
        public const string CBC9LVL7 = "CBC9LVL7";

        /// <summary>
        /// CBC9LVL8.
        /// </summary>
        public const string CBC9LVL8 = "CBC9LVL8";

        /// <summary>
        /// CBC9LVL9.
        /// </summary>
        public const string CBC9LVL9 = "CBC9LVL9";

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
        /// CBC9STS.
        /// </summary>
        public const string CBC9STS = "CBC9STS";

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
    public override string TableName => "FCW71";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBC9PLN", "CBC9PLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CBC9LVL0", "CBC9LVL0", JdeDataType.String, 50),
        new JdeField("CBC9LVL1", "CBC9LVL1", JdeDataType.String, 12),
        new JdeField("CBC9LVL2", "CBC9LVL2", JdeDataType.String, 12),
        new JdeField("CBC9LVL3", "CBC9LVL3", JdeDataType.String, 12),
        new JdeField("CBC9LVL4", "CBC9LVL4", JdeDataType.String, 12),
        new JdeField("CBC9LVL5", "CBC9LVL5", JdeDataType.String, 12),
        new JdeField("CBC9LVL6", "CBC9LVL6", JdeDataType.String, 12),
        new JdeField("CBC9LVL7", "CBC9LVL7", JdeDataType.String, 12),
        new JdeField("CBC9LVL8", "CBC9LVL8", JdeDataType.String, 12),
        new JdeField("CBC9LVL9", "CBC9LVL9", JdeDataType.String, 12),
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
        new JdeField("CBC9STS", "CBC9STS", JdeDataType.String, 2),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBTDAY", "CBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW71_0", "Primary Key on CBC9PLN, CBMCU, CBCATN, CBAN8, CBITM, CBCRCD, CBUORG, CBUOM, CBEXDJ", new[] { "CBC9PLN", "CBMCU", "CBCATN", "CBAN8", "CBITM", "CBCRCD", "CBUORG", "CBUOM", "CBEXDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW71_2", "Index on CBC9PLN", new[] { "CBC9PLN" })
    };
}
