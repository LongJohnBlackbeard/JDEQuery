using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0087 - .
/// </summary>
public class F0087 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EUENVN.
        /// </summary>
        public const string EUENVN = "EUENVN";

        /// <summary>
        /// EUEDCO.
        /// </summary>
        public const string EUEDCO = "EUEDCO";

        /// <summary>
        /// EUBCO.
        /// </summary>
        public const string EUBCO = "EUBCO";

        /// <summary>
        /// EUEFT.
        /// </summary>
        public const string EUEFT = "EUEFT";

        /// <summary>
        /// EUCRR.
        /// </summary>
        public const string EUCRR = "EUCRR";

        /// <summary>
        /// EUCRCM.
        /// </summary>
        public const string EUCRCM = "EUCRCM";

        /// <summary>
        /// EUCRDC.
        /// </summary>
        public const string EUCRDC = "EUCRDC";
    }

    /// <inheritdoc />
    public override string TableName => "F0087";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EUENVN", "EUENVN", JdeDataType.String, 20, true, true),
        new JdeField("EUEDCO", "EUEDCO", JdeDataType.String, 10, true, true),
        new JdeField("EUBCO", "EUBCO", JdeDataType.String, 10, true, true),
        new JdeField("EUEFT", "EUEFT", JdeDataType.Numeric),
        new JdeField("EUCRR", "EUCRR", JdeDataType.Numeric),
        new JdeField("EUCRCM", "EUCRCM", JdeDataType.String, 2),
        new JdeField("EUCRDC", "EUCRDC", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0087_0", "Primary Key on EUENVN, EUEDCO, EUBCO, EUCRDC", new[] { "EUENVN", "EUEDCO", "EUBCO", "EUCRDC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0087_2", "Index on EUENVN, EUEDCO, EUBCO", new[] { "EUENVN", "EUEDCO", "EUBCO" })
    };
}
