using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X001 - .
/// </summary>
public class F42X001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XA42XFETR.
        /// </summary>
        public const string XA42XFETR = "XA42XFETR";

        /// <summary>
        /// XADCT.
        /// </summary>
        public const string XADCT = "XADCT";

        /// <summary>
        /// XAUSER.
        /// </summary>
        public const string XAUSER = "XAUSER";

        /// <summary>
        /// XAPID.
        /// </summary>
        public const string XAPID = "XAPID";

        /// <summary>
        /// XAJOBN.
        /// </summary>
        public const string XAJOBN = "XAJOBN";

        /// <summary>
        /// XAUPMJ.
        /// </summary>
        public const string XAUPMJ = "XAUPMJ";

        /// <summary>
        /// XAMKEY.
        /// </summary>
        public const string XAMKEY = "XAMKEY";

        /// <summary>
        /// XAUPMT.
        /// </summary>
        public const string XAUPMT = "XAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42X001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XA42XFETR", "XA42XFETR", JdeDataType.String, 4, true, true),
        new JdeField("XADCT", "XADCT", JdeDataType.String, 4, true, true),
        new JdeField("XAUSER", "XAUSER", JdeDataType.String, 20),
        new JdeField("XAPID", "XAPID", JdeDataType.String, 20),
        new JdeField("XAJOBN", "XAJOBN", JdeDataType.String, 20),
        new JdeField("XAUPMJ", "XAUPMJ", JdeDataType.Numeric),
        new JdeField("XAMKEY", "XAMKEY", JdeDataType.String, 30),
        new JdeField("XAUPMT", "XAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X001_0", "Primary Key on XA42XFETR, XADCT", new[] { "XA42XFETR", "XADCT" }, isUnique: true, isPrimaryKey: true)
    };
}
