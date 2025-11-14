using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA121 - .
/// </summary>
public class F90CA121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGCIG.
        /// </summary>
        public const string IGCIG = "IGCIG";

        /// <summary>
        /// IGBLGID.
        /// </summary>
        public const string IGBLGID = "IGBLGID";

        /// <summary>
        /// IGCFGSID.
        /// </summary>
        public const string IGCFGSID = "IGCFGSID";

        /// <summary>
        /// IGCIGNAME.
        /// </summary>
        public const string IGCIGNAME = "IGCIGNAME";

        /// <summary>
        /// IGACTIND.
        /// </summary>
        public const string IGACTIND = "IGACTIND";

        /// <summary>
        /// IGUDTTM.
        /// </summary>
        public const string IGUDTTM = "IGUDTTM";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGENTDBY.
        /// </summary>
        public const string IGENTDBY = "IGENTDBY";

        /// <summary>
        /// IGEDATE.
        /// </summary>
        public const string IGEDATE = "IGEDATE";

        /// <summary>
        /// IGSTSUDT.
        /// </summary>
        public const string IGSTSUDT = "IGSTSUDT";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGVID.
        /// </summary>
        public const string IGVID = "IGVID";

        /// <summary>
        /// IGMKEY.
        /// </summary>
        public const string IGMKEY = "IGMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGCIG", "IGCIG", JdeDataType.Numeric, null, true, true),
        new JdeField("IGBLGID", "IGBLGID", JdeDataType.Numeric),
        new JdeField("IGCFGSID", "IGCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("IGCIGNAME", "IGCIGNAME", JdeDataType.String, 100),
        new JdeField("IGACTIND", "IGACTIND", JdeDataType.String, 2),
        new JdeField("IGUDTTM", "IGUDTTM", JdeDataType.Date),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGENTDBY", "IGENTDBY", JdeDataType.Numeric),
        new JdeField("IGEDATE", "IGEDATE", JdeDataType.Date),
        new JdeField("IGSTSUDT", "IGSTSUDT", JdeDataType.Date),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGVID", "IGVID", JdeDataType.String, 20),
        new JdeField("IGMKEY", "IGMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA121_0", "Primary Key on IGCFGSID, IGCIG", new[] { "IGCFGSID", "IGCIG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA121_2", "Index on IGBLGID", new[] { "IGBLGID" })
    };
}
