using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI31 - .
/// </summary>
public class F76HUI31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRCTID.
        /// </summary>
        public const string DRCTID = "DRCTID";

        /// <summary>
        /// DRJOBS.
        /// </summary>
        public const string DRJOBS = "DRJOBS";

        /// <summary>
        /// DRKCO.
        /// </summary>
        public const string DRKCO = "DRKCO";

        /// <summary>
        /// DRDCT.
        /// </summary>
        public const string DRDCT = "DRDCT";

        /// <summary>
        /// DRDOC.
        /// </summary>
        public const string DRDOC = "DRDOC";

        /// <summary>
        /// DROKCO.
        /// </summary>
        public const string DROKCO = "DROKCO";

        /// <summary>
        /// DRODCT.
        /// </summary>
        public const string DRODCT = "DRODCT";

        /// <summary>
        /// DRODOC.
        /// </summary>
        public const string DRODOC = "DRODOC";

        /// <summary>
        /// DRACTI.
        /// </summary>
        public const string DRACTI = "DRACTI";
    }

    /// <inheritdoc />
    public override string TableName => "F76HUI31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRCTID", "DRCTID", JdeDataType.String, 30, true, true),
        new JdeField("DRJOBS", "DRJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DRKCO", "DRKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRDCT", "DRDCT", JdeDataType.String, 4, true, true),
        new JdeField("DRDOC", "DRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DROKCO", "DROKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRODCT", "DRODCT", JdeDataType.String, 4, true, true),
        new JdeField("DRODOC", "DRODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DRACTI", "DRACTI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI31_0", "Primary Key on DRCTID, DRJOBS, DRKCO, DRDCT, DRDOC, DROKCO, DRODCT, DRODOC", new[] { "DRCTID", "DRJOBS", "DRKCO", "DRDCT", "DRDOC", "DROKCO", "DRODCT", "DRODOC" }, isUnique: true, isPrimaryKey: true)
    };
}
