using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H020 - .
/// </summary>
public class F76H020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NOTXA1.
        /// </summary>
        public const string NOTXA1 = "NOTXA1";

        /// <summary>
        /// NOITM.
        /// </summary>
        public const string NOITM = "NOITM";

        /// <summary>
        /// NOEFDJ.
        /// </summary>
        public const string NOEFDJ = "NOEFDJ";

        /// <summary>
        /// NOH76TXBN.
        /// </summary>
        public const string NOH76TXBN = "NOH76TXBN";

        /// <summary>
        /// NOH76TXCC.
        /// </summary>
        public const string NOH76TXCC = "NOH76TXCC";

        /// <summary>
        /// NOH76TXVC.
        /// </summary>
        public const string NOH76TXVC = "NOH76TXVC";

        /// <summary>
        /// NOH76ITXB.
        /// </summary>
        public const string NOH76ITXB = "NOH76ITXB";

        /// <summary>
        /// NOTORG.
        /// </summary>
        public const string NOTORG = "NOTORG";

        /// <summary>
        /// NOUSER.
        /// </summary>
        public const string NOUSER = "NOUSER";

        /// <summary>
        /// NOPID.
        /// </summary>
        public const string NOPID = "NOPID";

        /// <summary>
        /// NOJOBN.
        /// </summary>
        public const string NOJOBN = "NOJOBN";

        /// <summary>
        /// NOUPMJ.
        /// </summary>
        public const string NOUPMJ = "NOUPMJ";

        /// <summary>
        /// NOUPMT.
        /// </summary>
        public const string NOUPMT = "NOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NOTXA1", "NOTXA1", JdeDataType.String, 20, true, true),
        new JdeField("NOITM", "NOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("NOEFDJ", "NOEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("NOH76TXBN", "NOH76TXBN", JdeDataType.Numeric, null, true, true),
        new JdeField("NOH76TXCC", "NOH76TXCC", JdeDataType.Numeric),
        new JdeField("NOH76TXVC", "NOH76TXVC", JdeDataType.Numeric),
        new JdeField("NOH76ITXB", "NOH76ITXB", JdeDataType.Numeric),
        new JdeField("NOTORG", "NOTORG", JdeDataType.String, 20),
        new JdeField("NOUSER", "NOUSER", JdeDataType.String, 20),
        new JdeField("NOPID", "NOPID", JdeDataType.String, 20),
        new JdeField("NOJOBN", "NOJOBN", JdeDataType.String, 20),
        new JdeField("NOUPMJ", "NOUPMJ", JdeDataType.Numeric),
        new JdeField("NOUPMT", "NOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H020_0", "Primary Key on NOTXA1, NOITM, NOEFDJ, NOH76TXBN", new[] { "NOTXA1", "NOITM", "NOEFDJ", "NOH76TXBN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H020_2", "Index on NOTXA1, NOITM, NOH76TXBN", new[] { "NOTXA1", "NOITM", "NOH76TXBN" })
    };
}
