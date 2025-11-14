using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44445Z - .
/// </summary>
public class F44445Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWCO.
        /// </summary>
        public const string SWCO = "SWCO";

        /// <summary>
        /// SWHDC.
        /// </summary>
        public const string SWHDC = "SWHDC";

        /// <summary>
        /// SWDOCM.
        /// </summary>
        public const string SWDOCM = "SWDOCM";

        /// <summary>
        /// SWADDI.
        /// </summary>
        public const string SWADDI = "SWADDI";

        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWDMT.
        /// </summary>
        public const string SWDMT = "SWDMT";

        /// <summary>
        /// SWCTAD.
        /// </summary>
        public const string SWCTAD = "SWCTAD";

        /// <summary>
        /// SWAUD.
        /// </summary>
        public const string SWAUD = "SWAUD";
    }

    /// <inheritdoc />
    public override string TableName => "F44445Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWCO", "SWCO", JdeDataType.String, 10, true, true),
        new JdeField("SWHDC", "SWHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDOCM", "SWDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("SWADDI", "SWADDI", JdeDataType.String, 20),
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24),
        new JdeField("SWDMT", "SWDMT", JdeDataType.Numeric),
        new JdeField("SWCTAD", "SWCTAD", JdeDataType.Numeric),
        new JdeField("SWAUD", "SWAUD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44445Z_0", "Primary Key on SWCO, SWHDC, SWDOCM", new[] { "SWCO", "SWHDC", "SWDOCM" }, isUnique: true, isPrimaryKey: true)
    };
}
