using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW70 - .
/// </summary>
public class FCW70 : JdeTable
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
        /// CBMCU.
        /// </summary>
        public const string CBMCU = "CBMCU";

        /// <summary>
        /// CBAN8.
        /// </summary>
        public const string CBAN8 = "CBAN8";

        /// <summary>
        /// CBCATN.
        /// </summary>
        public const string CBCATN = "CBCATN";

        /// <summary>
        /// CBCRCD.
        /// </summary>
        public const string CBCRCD = "CBCRCD";

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
    public override string TableName => "FCW70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBC9PLN", "CBC9PLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CBMCU", "CBMCU", JdeDataType.String, 24, true, true),
        new JdeField("CBAN8", "CBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CBCATN", "CBCATN", JdeDataType.String, 16, true, true),
        new JdeField("CBCRCD", "CBCRCD", JdeDataType.String, 6, true, true),
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
        new JdeIndex("FCW70_0", "Primary Key on CBC9PLN, CBMCU, CBAN8, CBCATN, CBCRCD, CBEXDJ", new[] { "CBC9PLN", "CBMCU", "CBAN8", "CBCATN", "CBCRCD", "CBEXDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW70_2", "Unique Index on CBAN8, CBMCU, CBCATN, CBCRCD, CBEXDJ", new[] { "CBAN8", "CBMCU", "CBCATN", "CBCRCD", "CBEXDJ" }, isUnique: true)
    };
}
