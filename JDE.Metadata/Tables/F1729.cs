using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1729 - .
/// </summary>
public class F1729 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPSERP.
        /// </summary>
        public const string SPSERP = "SPSERP";

        /// <summary>
        /// SPDL01.
        /// </summary>
        public const string SPDL01 = "SPDL01";

        /// <summary>
        /// SPTYPS.
        /// </summary>
        public const string SPTYPS = "SPTYPS";

        /// <summary>
        /// SPCOVT.
        /// </summary>
        public const string SPCOVT = "SPCOVT";

        /// <summary>
        /// SPGLPT.
        /// </summary>
        public const string SPGLPT = "SPGLPT";

        /// <summary>
        /// SPRSTM.
        /// </summary>
        public const string SPRSTM = "SPRSTM";

        /// <summary>
        /// SPCRTU.
        /// </summary>
        public const string SPCRTU = "SPCRTU";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPUPMT.
        /// </summary>
        public const string SPUPMT = "SPUPMT";

        /// <summary>
        /// SPCOVGR.
        /// </summary>
        public const string SPCOVGR = "SPCOVGR";
    }

    /// <inheritdoc />
    public override string TableName => "F1729";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPSERP", "SPSERP", JdeDataType.String, 16, true, true),
        new JdeField("SPDL01", "SPDL01", JdeDataType.String, 60),
        new JdeField("SPTYPS", "SPTYPS", JdeDataType.String, 2, true, true),
        new JdeField("SPCOVT", "SPCOVT", JdeDataType.String, 20, true, true),
        new JdeField("SPGLPT", "SPGLPT", JdeDataType.String, 8),
        new JdeField("SPRSTM", "SPRSTM", JdeDataType.Numeric),
        new JdeField("SPCRTU", "SPCRTU", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPUPMT", "SPUPMT", JdeDataType.Numeric),
        new JdeField("SPCOVGR", "SPCOVGR", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1729_0", "Primary Key on SPSERP, SPTYPS, SPCOVT", new[] { "SPSERP", "SPTYPS", "SPCOVT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1729_3", "Index on SPSERP", new[] { "SPSERP" })
    };
}
