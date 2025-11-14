using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700401 - .
/// </summary>
public class F700401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVKCO.
        /// </summary>
        public const string RVKCO = "RVKCO";

        /// <summary>
        /// RVDCT.
        /// </summary>
        public const string RVDCT = "RVDCT";

        /// <summary>
        /// RVDOC.
        /// </summary>
        public const string RVDOC = "RVDOC";

        /// <summary>
        /// RVSFX.
        /// </summary>
        public const string RVSFX = "RVSFX";

        /// <summary>
        /// RVSFXE.
        /// </summary>
        public const string RVSFXE = "RVSFXE";

        /// <summary>
        /// RVOKCO.
        /// </summary>
        public const string RVOKCO = "RVOKCO";

        /// <summary>
        /// RVODCT.
        /// </summary>
        public const string RVODCT = "RVODCT";

        /// <summary>
        /// RVODOC.
        /// </summary>
        public const string RVODOC = "RVODOC";

        /// <summary>
        /// RVUSER.
        /// </summary>
        public const string RVUSER = "RVUSER";

        /// <summary>
        /// RVPID.
        /// </summary>
        public const string RVPID = "RVPID";

        /// <summary>
        /// RVJOBN.
        /// </summary>
        public const string RVJOBN = "RVJOBN";

        /// <summary>
        /// RVUPMJ.
        /// </summary>
        public const string RVUPMJ = "RVUPMJ";

        /// <summary>
        /// RVUPMT.
        /// </summary>
        public const string RVUPMT = "RVUPMT";

        /// <summary>
        /// RVYFUTDT.
        /// </summary>
        public const string RVYFUTDT = "RVYFUTDT";

        /// <summary>
        /// RVFUT3.
        /// </summary>
        public const string RVFUT3 = "RVFUT3";

        /// <summary>
        /// RVFUTCH1.
        /// </summary>
        public const string RVFUTCH1 = "RVFUTCH1";

        /// <summary>
        /// RVX2.
        /// </summary>
        public const string RVX2 = "RVX2";

        /// <summary>
        /// RVFFU4.
        /// </summary>
        public const string RVFFU4 = "RVFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F700401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVKCO", "RVKCO", JdeDataType.String, 10, true, true),
        new JdeField("RVDCT", "RVDCT", JdeDataType.String, 4, true, true),
        new JdeField("RVDOC", "RVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RVSFX", "RVSFX", JdeDataType.String, 6, true, true),
        new JdeField("RVSFXE", "RVSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RVOKCO", "RVOKCO", JdeDataType.String, 10, true, true),
        new JdeField("RVODCT", "RVODCT", JdeDataType.String, 4, true, true),
        new JdeField("RVODOC", "RVODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RVUSER", "RVUSER", JdeDataType.String, 20),
        new JdeField("RVPID", "RVPID", JdeDataType.String, 20),
        new JdeField("RVJOBN", "RVJOBN", JdeDataType.String, 20),
        new JdeField("RVUPMJ", "RVUPMJ", JdeDataType.Numeric),
        new JdeField("RVUPMT", "RVUPMT", JdeDataType.Numeric),
        new JdeField("RVYFUTDT", "RVYFUTDT", JdeDataType.Numeric),
        new JdeField("RVFUT3", "RVFUT3", JdeDataType.String, 60),
        new JdeField("RVFUTCH1", "RVFUTCH1", JdeDataType.String, 2),
        new JdeField("RVX2", "RVX2", JdeDataType.String, 2),
        new JdeField("RVFFU4", "RVFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700401_0", "Primary Key on RVKCO, RVDCT, RVDOC, RVSFX, RVSFXE, RVOKCO, RVODCT, RVODOC", new[] { "RVKCO", "RVDCT", "RVDOC", "RVSFX", "RVSFXE", "RVOKCO", "RVODCT", "RVODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F700401_2", "Index on RVOKCO, RVODCT, RVODOC", new[] { "RVOKCO", "RVODCT", "RVODOC" }),
        new JdeIndex("F700401_3", "Index on RVKCO, RVDCT, RVDOC", new[] { "RVKCO", "RVDCT", "RVDOC" })
    };
}
