using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00098 - .
/// </summary>
public class F00098 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDSY.
        /// </summary>
        public const string EDSY = "EDSY";

        /// <summary>
        /// EDORNN.
        /// </summary>
        public const string EDORNN = "EDORNN";

        /// <summary>
        /// EDKCO.
        /// </summary>
        public const string EDKCO = "EDKCO";

        /// <summary>
        /// EDDCT.
        /// </summary>
        public const string EDDCT = "EDDCT";

        /// <summary>
        /// EDCTRY.
        /// </summary>
        public const string EDCTRY = "EDCTRY";

        /// <summary>
        /// EDFY.
        /// </summary>
        public const string EDFY = "EDFY";

        /// <summary>
        /// EDOBNM.
        /// </summary>
        public const string EDOBNM = "EDOBNM";

        /// <summary>
        /// EDENAB.
        /// </summary>
        public const string EDENAB = "EDENAB";

        /// <summary>
        /// EDWLVL.
        /// </summary>
        public const string EDWLVL = "EDWLVL";
    }

    /// <inheritdoc />
    public override string TableName => "F00098";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDSY", "EDSY", JdeDataType.String, 8, true, true),
        new JdeField("EDORNN", "EDORNN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDKCO", "EDKCO", JdeDataType.String, 10, true, true),
        new JdeField("EDDCT", "EDDCT", JdeDataType.String, 4, true, true),
        new JdeField("EDCTRY", "EDCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("EDFY", "EDFY", JdeDataType.Numeric, null, true, true),
        new JdeField("EDOBNM", "EDOBNM", JdeDataType.String, 20, true, true),
        new JdeField("EDENAB", "EDENAB", JdeDataType.String, 2),
        new JdeField("EDWLVL", "EDWLVL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00098_0", "Primary Key on EDSY, EDORNN, EDKCO, EDDCT, EDCTRY, EDFY, EDOBNM", new[] { "EDSY", "EDORNN", "EDKCO", "EDDCT", "EDCTRY", "EDFY", "EDOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
