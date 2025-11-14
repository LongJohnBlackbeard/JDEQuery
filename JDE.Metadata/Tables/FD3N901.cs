using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N901 - .
/// </summary>
public class FD3N901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPDVDT.
        /// </summary>
        public const string LPDVDT = "LPDVDT";

        /// <summary>
        /// LPFMAT.
        /// </summary>
        public const string LPFMAT = "LPFMAT";

        /// <summary>
        /// LPPFN0.
        /// </summary>
        public const string LPPFN0 = "LPPFN0";

        /// <summary>
        /// LPUFD1.
        /// </summary>
        public const string LPUFD1 = "LPUFD1";

        /// <summary>
        /// LPBLCT.
        /// </summary>
        public const string LPBLCT = "LPBLCT";

        /// <summary>
        /// LPTNID.
        /// </summary>
        public const string LPTNID = "LPTNID";

        /// <summary>
        /// LPDVNM.
        /// </summary>
        public const string LPDVNM = "LPDVNM";

        /// <summary>
        /// LPMMCU.
        /// </summary>
        public const string LPMMCU = "LPMMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPDVDT", "LPDVDT", JdeDataType.String, 28, true, true),
        new JdeField("LPFMAT", "LPFMAT", JdeDataType.String, 20),
        new JdeField("LPPFN0", "LPPFN0", JdeDataType.Numeric),
        new JdeField("LPUFD1", "LPUFD1", JdeDataType.String, 500),
        new JdeField("LPBLCT", "LPBLCT", JdeDataType.Numeric),
        new JdeField("LPTNID", "LPTNID", JdeDataType.String, 6, true, true),
        new JdeField("LPDVNM", "LPDVNM", JdeDataType.String, 20, true, true),
        new JdeField("LPMMCU", "LPMMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N901_0", "Primary Key on LPDVDT, LPTNID, LPDVNM", new[] { "LPDVDT", "LPTNID", "LPDVNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N901_2", "Index on LPDVDT, LPDVNM", new[] { "LPDVDT", "LPDVNM" })
    };
}
