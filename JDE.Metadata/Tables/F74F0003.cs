using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74F0003 - .
/// </summary>
public class F74F0003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRK74LECO.
        /// </summary>
        public const string FRK74LECO = "FRK74LECO";

        /// <summary>
        /// FRDCT.
        /// </summary>
        public const string FRDCT = "FRDCT";

        /// <summary>
        /// FRF74GEF.
        /// </summary>
        public const string FRF74GEF = "FRF74GEF";

        /// <summary>
        /// FRK74LEDT.
        /// </summary>
        public const string FRK74LEDT = "FRK74LEDT";

        /// <summary>
        /// FRUSER.
        /// </summary>
        public const string FRUSER = "FRUSER";

        /// <summary>
        /// FRPID.
        /// </summary>
        public const string FRPID = "FRPID";

        /// <summary>
        /// FRUPMJ.
        /// </summary>
        public const string FRUPMJ = "FRUPMJ";

        /// <summary>
        /// FRUPMT.
        /// </summary>
        public const string FRUPMT = "FRUPMT";

        /// <summary>
        /// FRJOBN.
        /// </summary>
        public const string FRJOBN = "FRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74F0003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRK74LECO", "FRK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("FRDCT", "FRDCT", JdeDataType.String, 4, true, true),
        new JdeField("FRF74GEF", "FRF74GEF", JdeDataType.String, 2, true, true),
        new JdeField("FRK74LEDT", "FRK74LEDT", JdeDataType.String, 10),
        new JdeField("FRUSER", "FRUSER", JdeDataType.String, 20),
        new JdeField("FRPID", "FRPID", JdeDataType.String, 20),
        new JdeField("FRUPMJ", "FRUPMJ", JdeDataType.Numeric),
        new JdeField("FRUPMT", "FRUPMT", JdeDataType.Numeric),
        new JdeField("FRJOBN", "FRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74F0003_0", "Primary Key on FRK74LECO, FRDCT, FRF74GEF", new[] { "FRK74LECO", "FRDCT", "FRF74GEF" }, isUnique: true, isPrimaryKey: true)
    };
}
