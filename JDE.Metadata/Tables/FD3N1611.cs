using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N1611 - .
/// </summary>
public class FD3N1611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDCNID.
        /// </summary>
        public const string PDCNID = "PDCNID";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDLOTN.
        /// </summary>
        public const string PDLOTN = "PDLOTN";

        /// <summary>
        /// PDPQOH.
        /// </summary>
        public const string PDPQOH = "PDPQOH";

        /// <summary>
        /// PDUM.
        /// </summary>
        public const string PDUM = "PDUM";

        /// <summary>
        /// PDDOCO.
        /// </summary>
        public const string PDDOCO = "PDDOCO";

        /// <summary>
        /// PDDCTO.
        /// </summary>
        public const string PDDCTO = "PDDCTO";

        /// <summary>
        /// PDLNID.
        /// </summary>
        public const string PDLNID = "PDLNID";

        /// <summary>
        /// PDPTUT01.
        /// </summary>
        public const string PDPTUT01 = "PDPTUT01";

        /// <summary>
        /// PDPTUT02.
        /// </summary>
        public const string PDPTUT02 = "PDPTUT02";

        /// <summary>
        /// PDPTUT03.
        /// </summary>
        public const string PDPTUT03 = "PDPTUT03";

        /// <summary>
        /// PDPTUT04.
        /// </summary>
        public const string PDPTUT04 = "PDPTUT04";

        /// <summary>
        /// PDPTUPUSER.
        /// </summary>
        public const string PDPTUPUSER = "PDPTUPUSER";

        /// <summary>
        /// PDPTUPDTTM.
        /// </summary>
        public const string PDPTUPDTTM = "PDPTUPDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N1611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDCNID", "PDCNID", JdeDataType.String, 40, true, true),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PDLOTN", "PDLOTN", JdeDataType.String, 60, true, true),
        new JdeField("PDPQOH", "PDPQOH", JdeDataType.Numeric),
        new JdeField("PDUM", "PDUM", JdeDataType.String, 4),
        new JdeField("PDDOCO", "PDDOCO", JdeDataType.Numeric),
        new JdeField("PDDCTO", "PDDCTO", JdeDataType.String, 4),
        new JdeField("PDLNID", "PDLNID", JdeDataType.Numeric),
        new JdeField("PDPTUT01", "PDPTUT01", JdeDataType.String, 100),
        new JdeField("PDPTUT02", "PDPTUT02", JdeDataType.String, 100),
        new JdeField("PDPTUT03", "PDPTUT03", JdeDataType.String, 100),
        new JdeField("PDPTUT04", "PDPTUT04", JdeDataType.String, 100),
        new JdeField("PDPTUPUSER", "PDPTUPUSER", JdeDataType.String, 32),
        new JdeField("PDPTUPDTTM", "PDPTUPDTTM", JdeDataType.String, 28)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N1611_0", "Primary Key on PDCNID, PDITM, PDLOTN", new[] { "PDCNID", "PDITM", "PDLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
