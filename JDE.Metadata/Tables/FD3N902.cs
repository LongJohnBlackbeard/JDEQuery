using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N902 - .
/// </summary>
public class FD3N902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LEDVDT.
        /// </summary>
        public const string LEDVDT = "LEDVDT";

        /// <summary>
        /// LEFMAT.
        /// </summary>
        public const string LEFMAT = "LEFMAT";

        /// <summary>
        /// LEPFN0.
        /// </summary>
        public const string LEPFN0 = "LEPFN0";

        /// <summary>
        /// LEUFD1.
        /// </summary>
        public const string LEUFD1 = "LEUFD1";

        /// <summary>
        /// LEBLCT.
        /// </summary>
        public const string LEBLCT = "LEBLCT";

        /// <summary>
        /// LETNID.
        /// </summary>
        public const string LETNID = "LETNID";

        /// <summary>
        /// LEDVNM.
        /// </summary>
        public const string LEDVNM = "LEDVNM";

        /// <summary>
        /// LEMMCU.
        /// </summary>
        public const string LEMMCU = "LEMMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LEDVDT", "LEDVDT", JdeDataType.String, 28, true, true),
        new JdeField("LEFMAT", "LEFMAT", JdeDataType.String, 20),
        new JdeField("LEPFN0", "LEPFN0", JdeDataType.Numeric),
        new JdeField("LEUFD1", "LEUFD1", JdeDataType.String, 500),
        new JdeField("LEBLCT", "LEBLCT", JdeDataType.Numeric),
        new JdeField("LETNID", "LETNID", JdeDataType.String, 6, true, true),
        new JdeField("LEDVNM", "LEDVNM", JdeDataType.String, 20, true, true),
        new JdeField("LEMMCU", "LEMMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N902_0", "Primary Key on LEDVDT, LETNID, LEDVNM", new[] { "LEDVDT", "LETNID", "LEDVNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N902_2", "Index on LEDVDT, LEDVNM", new[] { "LEDVDT", "LEDVNM" })
    };
}
