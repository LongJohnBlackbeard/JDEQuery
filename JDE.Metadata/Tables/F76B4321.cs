using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4321 - .
/// </summary>
public class F76B4321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCBNOP.
        /// </summary>
        public const string PCBNOP = "PCBNOP";

        /// <summary>
        /// PCBSOP.
        /// </summary>
        public const string PCBSOP = "PCBSOP";

        /// <summary>
        /// PCBCFC.
        /// </summary>
        public const string PCBCFC = "PCBCFC";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCBNOP", "PCBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("PCBSOP", "PCBSOP", JdeDataType.String, 4, true, true),
        new JdeField("PCBCFC", "PCBCFC", JdeDataType.String, 6),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4321_0", "Primary Key on PCBNOP, PCBSOP", new[] { "PCBNOP", "PCBSOP" }, isUnique: true, isPrimaryKey: true)
    };
}
