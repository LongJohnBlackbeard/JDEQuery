using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52034 - .
/// </summary>
public class F52034 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G9DOCO.
        /// </summary>
        public const string G9DOCO = "G9DOCO";

        /// <summary>
        /// G9DCTO.
        /// </summary>
        public const string G9DCTO = "G9DCTO";

        /// <summary>
        /// G9KCOO.
        /// </summary>
        public const string G9KCOO = "G9KCOO";

        /// <summary>
        /// G9LGTY.
        /// </summary>
        public const string G9LGTY = "G9LGTY";

        /// <summary>
        /// G9LGNO.
        /// </summary>
        public const string G9LGNO = "G9LGNO";

        /// <summary>
        /// G9LNID.
        /// </summary>
        public const string G9LNID = "G9LNID";

        /// <summary>
        /// G9LDTA.
        /// </summary>
        public const string G9LDTA = "G9LDTA";
    }

    /// <inheritdoc />
    public override string TableName => "F52034";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G9DOCO", "G9DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("G9DCTO", "G9DCTO", JdeDataType.String, 4, true, true),
        new JdeField("G9KCOO", "G9KCOO", JdeDataType.String, 10, true, true),
        new JdeField("G9LGTY", "G9LGTY", JdeDataType.String, 2, true, true),
        new JdeField("G9LGNO", "G9LGNO", JdeDataType.Numeric, null, true, true),
        new JdeField("G9LNID", "G9LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("G9LDTA", "G9LDTA", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52034_0", "Primary Key on G9DOCO, G9DCTO, G9KCOO, G9LGTY, G9LGNO, G9LNID", new[] { "G9DOCO", "G9DCTO", "G9KCOO", "G9LGTY", "G9LGNO", "G9LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
