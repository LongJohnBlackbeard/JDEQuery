using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B04BC - .
/// </summary>
public class F76B04BC : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCKCO.
        /// </summary>
        public const string BCKCO = "BCKCO";

        /// <summary>
        /// BCDOC.
        /// </summary>
        public const string BCDOC = "BCDOC";

        /// <summary>
        /// BCDCT.
        /// </summary>
        public const string BCDCT = "BCDCT";

        /// <summary>
        /// BCSFX.
        /// </summary>
        public const string BCSFX = "BCSFX";

        /// <summary>
        /// BCSFXE.
        /// </summary>
        public const string BCSFXE = "BCSFXE";

        /// <summary>
        /// BCBBRCD.
        /// </summary>
        public const string BCBBRCD = "BCBBRCD";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCUPMT.
        /// </summary>
        public const string BCUPMT = "BCUPMT";

        /// <summary>
        /// BCBCE.
        /// </summary>
        public const string BCBCE = "BCBCE";
    }

    /// <inheritdoc />
    public override string TableName => "F76B04BC";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCKCO", "BCKCO", JdeDataType.String, 10, true, true),
        new JdeField("BCDOC", "BCDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("BCDCT", "BCDCT", JdeDataType.String, 4, true, true),
        new JdeField("BCSFX", "BCSFX", JdeDataType.String, 6, true, true),
        new JdeField("BCSFXE", "BCSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("BCBBRCD", "BCBBRCD", JdeDataType.String, 88),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCUPMT", "BCUPMT", JdeDataType.Numeric),
        new JdeField("BCBCE", "BCBCE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B04BC_0", "Primary Key on BCKCO, BCDOC, BCDCT, BCSFX, BCSFXE", new[] { "BCKCO", "BCDOC", "BCDCT", "BCSFX", "BCSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
