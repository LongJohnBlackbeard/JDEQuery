using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3111IGS - .
/// </summary>
public class F3111IGS : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGDOCO.
        /// </summary>
        public const string IGDOCO = "IGDOCO";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGLNID.
        /// </summary>
        public const string IGLNID = "IGLNID";

        /// <summary>
        /// IGUITM.
        /// </summary>
        public const string IGUITM = "IGUITM";

        /// <summary>
        /// IGITM2.
        /// </summary>
        public const string IGITM2 = "IGITM2";

        /// <summary>
        /// IGDL01.
        /// </summary>
        public const string IGDL01 = "IGDL01";

        /// <summary>
        /// IGDL02.
        /// </summary>
        public const string IGDL02 = "IGDL02";

        /// <summary>
        /// IGUM.
        /// </summary>
        public const string IGUM = "IGUM";

        /// <summary>
        /// IGUNCS.
        /// </summary>
        public const string IGUNCS = "IGUNCS";

        /// <summary>
        /// IGVEND.
        /// </summary>
        public const string IGVEND = "IGVEND";

        /// <summary>
        /// IGLNTY.
        /// </summary>
        public const string IGLNTY = "IGLNTY";

        /// <summary>
        /// IGUORG.
        /// </summary>
        public const string IGUORG = "IGUORG";
    }

    /// <inheritdoc />
    public override string TableName => "F3111IGS";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGDOCO", "IGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20, true, true),
        new JdeField("IGLNID", "IGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("IGUITM", "IGUITM", JdeDataType.String, 52),
        new JdeField("IGITM2", "IGITM2", JdeDataType.String, 52),
        new JdeField("IGDL01", "IGDL01", JdeDataType.String, 60),
        new JdeField("IGDL02", "IGDL02", JdeDataType.String, 60),
        new JdeField("IGUM", "IGUM", JdeDataType.String, 4),
        new JdeField("IGUNCS", "IGUNCS", JdeDataType.Numeric),
        new JdeField("IGVEND", "IGVEND", JdeDataType.Numeric),
        new JdeField("IGLNTY", "IGLNTY", JdeDataType.String, 4),
        new JdeField("IGUORG", "IGUORG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3111IGS_0", "Primary Key on IGDOCO, IGUSER, IGLNID", new[] { "IGDOCO", "IGUSER", "IGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
