using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B1201 - .
/// </summary>
public class F76B1201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FAB76EPCF.
        /// </summary>
        public const string FAB76EPCF = "FAB76EPCF";

        /// <summary>
        /// FAB76CBC.
        /// </summary>
        public const string FAB76CBC = "FAB76CBC";

        /// <summary>
        /// FAB76ASID.
        /// </summary>
        public const string FAB76ASID = "FAB76ASID";

        /// <summary>
        /// FAB76AOI.
        /// </summary>
        public const string FAB76AOI = "FAB76AOI";

        /// <summary>
        /// FAB76AUI.
        /// </summary>
        public const string FAB76AUI = "FAB76AUI";

        /// <summary>
        /// FAB76NOP.
        /// </summary>
        public const string FAB76NOP = "FAB76NOP";

        /// <summary>
        /// FAB76OPQ.
        /// </summary>
        public const string FAB76OPQ = "FAB76OPQ";

        /// <summary>
        /// FAUSER.
        /// </summary>
        public const string FAUSER = "FAUSER";

        /// <summary>
        /// FAPID.
        /// </summary>
        public const string FAPID = "FAPID";

        /// <summary>
        /// FAJOBN.
        /// </summary>
        public const string FAJOBN = "FAJOBN";

        /// <summary>
        /// FAUPMJ.
        /// </summary>
        public const string FAUPMJ = "FAUPMJ";

        /// <summary>
        /// FAUPMT.
        /// </summary>
        public const string FAUPMT = "FAUPMT";

        /// <summary>
        /// FAB76URAB.
        /// </summary>
        public const string FAB76URAB = "FAB76URAB";

        /// <summary>
        /// FAB76URAT.
        /// </summary>
        public const string FAB76URAT = "FAB76URAT";

        /// <summary>
        /// FAB76URRF.
        /// </summary>
        public const string FAB76URRF = "FAB76URRF";

        /// <summary>
        /// FAB76URDT.
        /// </summary>
        public const string FAB76URDT = "FAB76URDT";

        /// <summary>
        /// FAB76URCD.
        /// </summary>
        public const string FAB76URCD = "FAB76URCD";
    }

    /// <inheritdoc />
    public override string TableName => "F76B1201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FAB76EPCF", "FAB76EPCF", JdeDataType.String, 2),
        new JdeField("FAB76CBC", "FAB76CBC", JdeDataType.String, 4),
        new JdeField("FAB76ASID", "FAB76ASID", JdeDataType.String, 4),
        new JdeField("FAB76AOI", "FAB76AOI", JdeDataType.Numeric),
        new JdeField("FAB76AUI", "FAB76AUI", JdeDataType.Numeric),
        new JdeField("FAB76NOP", "FAB76NOP", JdeDataType.Numeric),
        new JdeField("FAB76OPQ", "FAB76OPQ", JdeDataType.Numeric),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FAJOBN", "FAJOBN", JdeDataType.String, 20),
        new JdeField("FAUPMJ", "FAUPMJ", JdeDataType.Numeric),
        new JdeField("FAUPMT", "FAUPMT", JdeDataType.Numeric),
        new JdeField("FAB76URAB", "FAB76URAB", JdeDataType.Numeric),
        new JdeField("FAB76URAT", "FAB76URAT", JdeDataType.Numeric),
        new JdeField("FAB76URRF", "FAB76URRF", JdeDataType.String, 30),
        new JdeField("FAB76URDT", "FAB76URDT", JdeDataType.Numeric),
        new JdeField("FAB76URCD", "FAB76URCD", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B1201_0", "Primary Key on FANUMB", new[] { "FANUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
