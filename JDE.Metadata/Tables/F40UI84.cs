using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI84 - .
/// </summary>
public class F40UI84 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XRKCOO.
        /// </summary>
        public const string XRKCOO = "XRKCOO";

        /// <summary>
        /// XRDOCO.
        /// </summary>
        public const string XRDOCO = "XRDOCO";

        /// <summary>
        /// XRDCTO.
        /// </summary>
        public const string XRDCTO = "XRDCTO";

        /// <summary>
        /// XRLNID.
        /// </summary>
        public const string XRLNID = "XRLNID";

        /// <summary>
        /// XRJOBS.
        /// </summary>
        public const string XRJOBS = "XRJOBS";

        /// <summary>
        /// XRCTID.
        /// </summary>
        public const string XRCTID = "XRCTID";

        /// <summary>
        /// XRATID.
        /// </summary>
        public const string XRATID = "XRATID";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI84";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XRKCOO", "XRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("XRDOCO", "XRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("XRDCTO", "XRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("XRLNID", "XRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("XRJOBS", "XRJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("XRCTID", "XRCTID", JdeDataType.String, 30, true, true),
        new JdeField("XRATID", "XRATID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI84_0", "Primary Key on XRKCOO, XRDOCO, XRDCTO, XRLNID, XRJOBS, XRCTID", new[] { "XRKCOO", "XRDOCO", "XRDCTO", "XRLNID", "XRJOBS", "XRCTID" }, isUnique: true, isPrimaryKey: true)
    };
}
